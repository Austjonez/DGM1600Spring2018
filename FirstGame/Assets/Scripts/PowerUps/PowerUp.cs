using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel;

	public Move MovePatternTransfer;
	public Move Transfer()
	{
		return MovePatternTransfer;
	}
	
}