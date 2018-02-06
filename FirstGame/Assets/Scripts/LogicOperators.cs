using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour {

	public int DarthVader;
	public int Obiwan;
	public string LukeEnters;
	void Start () {
		if (DarthVader > Obiwan && LukeEnters == "True")
		{
			print("luke screams 'no!'");
		}
		if (DarthVader < Obiwan && LukeEnters != "True")
		{
			print("I have the high ground!");
		}
		if (DarthVader < Obiwan && LukeEnters == "True")
		{
			print("wait, what?");
		}
		if (DarthVader > Obiwan && LukeEnters != "True")
		{
			print("Now I am the master!");
		}
	}

}
