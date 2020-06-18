using UnityEngine;
using System.Collections;

public class EnemyShots : MonoBehaviour {

	public GameObject Shot;
	public Transform BulletSpawn;
	public float fireRate;
	private float nextFire;
	
	void Update () 
	{
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(Shot, BulletSpawn.position, BulletSpawn.rotation);
		}
}
}