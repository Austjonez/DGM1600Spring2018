using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesList : MonoBehaviour {
public int EnemyNum;

	public string[] Enemies;

	private void Start() {
		foreach (string names in Enemies)
		{
			print("Enemies");
		}
	}	
	private void OnTriggerEnter(Collider other){
		switch (EnemyNum)
		{
			case 0:
			print ("Jack Got you");
			break;
			case 1:
			print ("Dave Got you");
			break;
			case 2:
			print ("Wait... reall? Bill got you??");
			break;
			
			default:
			print ("some thug got you");
			break;
		}
	}
}
