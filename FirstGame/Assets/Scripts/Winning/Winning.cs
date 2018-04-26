using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour {

	public int Health = 1;

	public void OnTriggerEnter(Collider other)
	{
		if (Health == 1)
		{
			print ("YOU WIN");
		}
		else
		{
			print ("Go Heal!");
		}
	}
}
