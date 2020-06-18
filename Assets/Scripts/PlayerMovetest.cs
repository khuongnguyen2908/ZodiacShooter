using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerMovetest : MonoBehaviour 
{
	public float speed;

	public Boundary boundary;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		var movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		var rigidbody = GetComponent<Rigidbody> ();
		rigidbody.velocity = movement * speed;

		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax),
				0.0f,
				Mathf.Clamp (rigidbody.position.z,boundary.zMin, boundary.zMax)
			);
	}
}