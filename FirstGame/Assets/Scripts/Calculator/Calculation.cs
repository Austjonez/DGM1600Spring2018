using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Calculation : ScriptableObject {

	protected float anum;
	protected float bnum;

	public string Calculate (string a, string b)
	{
		anum = float.Parse(a);
		anum = float.Parse(b);

		return FinishCalculation();
	}

	public abstract string FinishCalculation();

	
}
