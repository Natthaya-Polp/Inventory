using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ItemDatabase", menuName = "Shopping/Item database")]
public class ItemDatabase : ScriptableObject
{
    public Item[] items;

    public int ItemsCount
    {
        get{return items.Length;}
    }

    public Item GetItem (int index)
	{
		return items [index];
	}

}
