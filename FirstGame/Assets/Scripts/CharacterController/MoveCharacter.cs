using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	public Player Player;
	private CharacterController controller;


	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

    void Update() {
       Player.Move.Movement(controller, transform);
    }
}
