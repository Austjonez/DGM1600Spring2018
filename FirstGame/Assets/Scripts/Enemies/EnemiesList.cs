using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesList : MonoBehaviour {

	public string[] Enemies;

	private void Start() {
		foreach (string names in Enemies)
		{
			print("Enemies");
		}
	}
}
