using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCont : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	private Move PrevMove;

	private void OnTriggerEnter(Collider obj)
	{
		PrevMove = obj.GetComponent<MoveCharacter>().Player.Move;

		obj.GetComponent<MoveCharacter>().Player.Move = PowerUpTransfer.Transfer();
	}
}
