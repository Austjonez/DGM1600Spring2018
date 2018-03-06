using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {

	// Use this for initialization
	//void Start () {
		//does work
		//returns nothing

		//	MyInt = AddHealth();
	//}

	//public int MyInt = 50 + 50;

	//public int AddHealth()
	//{
	//	return 50 + 50;
	//}

	public int Health;

	public int AddHealth(int value)
	{
		print("Hello There");
		//move character
		//play an animation
		return Health += value;
	}

	private void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("Bob"));
	}

	public List<string> Players;

	public List<string> NewPlayers ()
	{
		return new List<string>();
	}

	public string NewPlayer(string name)
	{
		return name;
	}

}