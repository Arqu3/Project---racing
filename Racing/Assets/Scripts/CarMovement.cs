using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    public float currentSpeed = 60.0f;
    public float baseSpeed = 60.0f;
    float turnSpeed = 5.0f;
    float hoverForce = 65.0f;
    float hoverHeight = 3.5f;
    float powerInput;
    float turnInput;
    float totalVelocity;
    Rigidbody myRigidbody;

	void Start() 
    {
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	void Update() 
    {
        powerInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");
	}

    void FixedUpdate()
    {
        if (currentSpeed > baseSpeed)
            currentSpeed -= 10;

        if (Input.GetKeyDown(KeyCode.Space))
            currentSpeed += 20;
        //RaycastHit hit;
        //Ray ray = new Ray(transform.position, -transform.up);

        //if (Physics.Raycast(ray, out hit, hoverHeight))
        //{
        //    float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
        //    Vector3 appliedForce = Vector3.up * proportionalHeight * hoverForce;
        //    myRigidbody.AddForce(appliedForce, ForceMode.Acceleration);
        //}

        myRigidbody.AddRelativeForce(0.0f, 0.0f, powerInput * currentSpeed);
        totalVelocity = Mathf.Abs(myRigidbody.velocity.x) + Mathf.Abs(myRigidbody.velocity.z);
        transform.Rotate(Vector3.up, turnInput * Mathf.Abs(turnSpeed - totalVelocity * 0.07f));
        Debug.Log(totalVelocity);
    }
}
