using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private Move 

	private void OnTriggerEnter(Collider obj)
	{
		PrevMove = obj.GetComponent<MoveCharacter>().Move;

		obj.GetComponent<MoveCharacter>().Move = PowerUpTransfer.Transfer();
		
		gameObject.SetActive(false);
	}

	void RestoreMove(Move OldMove)
	{
		
	}
}
