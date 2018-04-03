using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatConstant : InputBase {

	public float FloatValue;

	public override float SetFloat()
	{
		return FloatValue;
	}

}
