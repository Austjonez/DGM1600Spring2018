using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCont : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private Move PrevMove;

	private void OnTriggerEnter(Collider obj)
	{
		PrevMove = obj.GetComponent<MoveCharacter>().Move;

		obj.GetComponent<MoveCharacter>().Move = PowerUpTransfer.Transfer();
	}
}
