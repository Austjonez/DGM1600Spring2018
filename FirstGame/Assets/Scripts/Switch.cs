using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;
	
	void Start () {
		switch (UserName)
		{
			case "Password":
				print ("Password is correct");
				break;

			case "LevelUp":
				print ("you defeated");
				break;
				
			default:
				print ("Why don't you just tell me which movie you want to see?");
				break;
		}
	}
}
