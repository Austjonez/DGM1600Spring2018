﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public float PowerLevel = 1;
	public Image HealthBar;
	public PowerUp PowerUpTransfer;


	void OnTriggerEnter(Collider obj)
	{
		HealthBar.fillAmount = PowerLevel;
	
		if (HealthBar.fillAmount == 0)
		{
			obj.GetComponent<MoveCharacter>().Player.Move = PowerUpTransfer.MovePatternTransfer;
		}
		
	}
}
