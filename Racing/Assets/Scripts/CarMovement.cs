using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    float speed = 60.0f;
    float turnSpeed = 5.0f;
    float hoverForce = 65.0f;
    float hoverHeight = 3.5f;
    float powerInput;
    float turnInput;
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
        //RaycastHit hit;
        //Ray ray = new Ray(transform.position, -transform.up);

        //if (Physics.Raycast(ray, out hit, hoverHeight))
        //{
        //    float proportionalHeight = (hoverHeight - hit.distance) / hoverHeight;
        //    Vector3 appliedForce = Vector3.up * proportionalHeight * hoverForce;
        //    myRigidbody.AddForce(appliedForce, ForceMode.Acceleration);
        //}

        myRigidbody.AddRelativeForce(0.0f, 0.0f, powerInput * speed);
        transform.Rotate(Vector3.up, turnInput * turnSpeed);
    }
}
