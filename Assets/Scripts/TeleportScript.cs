/*
using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

			public float MinX;
			public float MaxX;
			public float MinY;
			public float MaxY;


	void FixedUpdate() 
	{
		float x = transform.position.x;
		float y = transform.position.y;

		if (x < MinX) x = MaxX;
		else if (x > MaxX) x = MinX;

		if (y < MinY) y = MaxY;
		else if (y > MaxY) y = MinY;

		transform.position.x = x;
		transform.position.y = y;
//		transform.position.x = new Vector3(x, y, transform.position.z);
//		transform.position.x = new Vector2(transform.position.x, transform.position.y);

	}
}
*/