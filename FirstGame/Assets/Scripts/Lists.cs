using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lists : MonoBehaviour {

	public Incredibles Incredibles;
	public Text AddMember;
	
	void OnMouseDown()
	{
		Incredibles.FamilyList.Add(AddMember.text);
	}
}
