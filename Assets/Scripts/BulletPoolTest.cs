﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletPoolTest : MonoBehaviour {

	public static BulletPoolTest Current;
	public GameObject ObjectForPool;
	public int pooledAmount = 20;
	public bool Growth = true;

	List<GameObject> ObjectsForPool;


	void Awake()
	{
		Current = this;
	}

	void Start()
	{
		ObjectsForPool = new List<GameObject> ();
		for (int i = 0; i < pooledAmount; i++) 
		{
			GameObject obj = (GameObject)Instantiate (ObjectForPool);
			obj.SetActive (false);
			ObjectsForPool.Add(obj);
		}
	}

	public GameObject GetPooledObject()
	{
		for (int i = 0; i < ObjectsForPool.Count; i++)
		{
			if (!ObjectsForPool [i].activeInHierarchy)
			{
				return ObjectsForPool[i];
			}
		}
		if (Growth) 
		{
			GameObject obj = (GameObject)Instantiate (ObjectForPool);
			ObjectsForPool.Add(obj);
			return obj;
		}
		return null;
	}
}
