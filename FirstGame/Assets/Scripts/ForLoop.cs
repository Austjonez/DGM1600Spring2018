using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	public string[] Keys;

	void Start () {
			// this is meh
		for (int i = 0; i < Keys.Length; i++)	{
			if (Keys[i] == "Add Ammo"){
			print(Keys[i]);
			}
		}
			//this is better
		//foreach (var names in Keys)
		//{
		//	print(Keys);
		//}
	}
}
