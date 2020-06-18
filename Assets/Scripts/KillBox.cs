using UnityEngine;
using System.Collections;

public class KillBox : MonoBehaviour 
{

	void OnTriggerExit(Collider other) 
	{
		Destroy(other.gameObject.transform.parent.gameObject);
	}
}

