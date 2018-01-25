using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

	public string Name;
	public int FoodCount;

	// Use this for initialization
	void Start () {
		print("Hello Dave.");
		print("One ring to rule them all");
		print("yer a wizard, harry");
		print("join me, and together we can rule the galaxy as father and son");
			}
	void OnMouseDown() {
		print(Name);
		print(FoodCount);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
