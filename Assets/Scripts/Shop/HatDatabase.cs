using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "HatDatabase", menuName = "Shopping/Hat database")]
public class HatDatabase : ScriptableObject
{
    public Hat[] hats;

    public int HatsCount
    {
        get{return hats.Length;}
    }

    public Hat GetHat (int index)
	{
		return hats [index];
	}

}
