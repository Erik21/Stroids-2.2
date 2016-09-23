using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

	public float speedLeft;
	public float speedRight;
	public Rigidbody2D rb2D;

	public float ThrustForce;
	//public float angularVelocity;

	void Start() 
	{
		rb2D = GetComponent<Rigidbody2D>();
	}



	
	void FixedUpdate()
	{

		if (Input.GetKey(KeyCode.A))
		{
			// Rotade Left
			// Rigidbody2D.angularVelocity = 100.0f;
			rb2D.MoveRotation(rb2D.rotation + speedLeft * Time.fixedDeltaTime);
		}

		else if (Input.GetKey(KeyCode.D))
		{
			// Rotade Right
			// Rigidbody2D.angularVelocity = -100.0f;
			rb2D.MoveRotation(rb2D.rotation + speedRight * Time.fixedDeltaTime);
		}

		if (Input.GetKey(KeyCode.W))
		{
			// Engage the engines .
			//Vector2 forceVector = transform.up * ThrustForce;
			//Rigidbody2D.AddForce(forceVector);
			rb2D.AddForce(transform.up * ThrustForce);
		}


	}
}
