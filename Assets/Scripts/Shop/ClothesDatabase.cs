using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ClothesDatabase", menuName = "Shopping/Clothes database")]
public class ClothesDatabase : ScriptableObject
{
    public Clothes[] clothes;

    public int ClothesCount
    {
        get{return clothes.Length;}
    }

    public Clothes GetClothes (int index)
	{
		return clothes [index];
	}

}
