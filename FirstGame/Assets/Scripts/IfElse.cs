using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {
	public bool Key;
	void Start () {
		if (Key)
		{
			print("I have the key.");
		}
		else{
			print("You shall not pass!");
		}
	}
}
