using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

    public float currentSpeed = 60.0f;
    public float baseSpeed = 60.0f;
    float turnSpeed = 5.0f;
    float powerInput;
    float turnInput;
    float totalVelocity;
    float velocityY;
    Rigidbody myRigidbody;

    bool isJumping;

	void Start() 
    {
        isJumping = false;
        myRigidbody = GetComponent<Rigidbody>();
	}
	
	void Update() 
    {
        velocityY = Mathf.Abs(myRigidbody.velocity.y);

        if (velocityY >= 1.5f)
            isJumping = true;
        else
            isJumping = false;

        if (!isJumping)
        {
            powerInput = Input.GetAxis("Vertical");
            turnInput = Input.GetAxis("Horizontal");
        }
        Debug.Log(velocityY);
	}

    void FixedUpdate()
    {
        if (currentSpeed > baseSpeed)
            currentSpeed -= 10 * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
            currentSpeed += 20;

        myRigidbody.AddRelativeForce(0.0f, 0.0f, powerInput * currentSpeed);
        totalVelocity = Mathf.Abs(myRigidbody.velocity.x) + Mathf.Abs(myRigidbody.velocity.z);
        transform.Rotate(Vector3.up, turnInput * Mathf.Abs(turnSpeed - totalVelocity * 0.075f));
        //Debug.Log(totalVelocity);
    }
}
