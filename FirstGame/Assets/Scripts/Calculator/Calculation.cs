using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject {

	public float anum;
	public float bnum;

	public abstract float Calculate (string a, string b);

	
}
