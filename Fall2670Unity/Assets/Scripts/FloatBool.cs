using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

[CreateAssetMenu(fileName = "FloatBool")]

public class FloatBool : FloatInput
{

	public override float Value
	{
		get
		{
			if (Input.GetButton("InputType"))
			{
				return value;
			}
			else
			{
				return 0;
			}
		}
	}
	

}
	
