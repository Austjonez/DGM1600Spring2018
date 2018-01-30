using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
	public bool Rabid = false;

	void Start()
	{
		print("there are two dogs, one of them is rabid");
	}

	void OnMouseDown()
	{
		if (Rabid == true)
		{
			print("The dog bites you");
		}
	}
}
