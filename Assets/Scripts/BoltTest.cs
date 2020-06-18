using UnityEngine;
using System.Collections;

public class BoltTest : MonoBehaviour 
{
	public float speed;
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}	
