using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "PetDatabase", menuName = "Shopping/Pet database")]
public class PetDatabase : ScriptableObject
{
    public Pet[] pets;

    public int PetsCount
    {
        get{return pets.Length;}
    }

    public Pet GetPet (int index)
	{
		return pets [index];
	}

}