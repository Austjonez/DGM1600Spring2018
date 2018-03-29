using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	public Move Move;
	private CharacterController controller;


	private void Start()
	{
		controller = GetComponent<CharacterController>();
	}

    void Update() {
       Move.Movement(controller, transform);
    }
}
