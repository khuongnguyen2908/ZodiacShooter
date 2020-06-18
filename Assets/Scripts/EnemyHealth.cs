﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 100;                         
	public int currentHealth;                                  
	public Slider healthSlider;                           


	void Awake ()
	{
		currentHealth = startingHealth;
	}

	public void TakeDamage (int amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if(currentHealth <= 0)
		{
			Destroy (gameObject);
		}
	}
}