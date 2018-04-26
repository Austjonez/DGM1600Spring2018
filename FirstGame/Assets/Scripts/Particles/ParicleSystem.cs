using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParicleSystem : MonoBehaviour {

	public ParticleSystem particleSystem;
	public int Health = 1;

	private void OnTriggerEnter(Collider other){
		while (Health == 1)
		{
			//ParticleSystem.Emit(100);
			print ("Go to EXIT");
		}
		
	}
}
