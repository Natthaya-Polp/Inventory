using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesGenerator : ItemGeneratorBase<ClothesDatabase>
{
    public override void GenerateUI()
    {
        itemsContainer.DetachChildren();

        for (int i = 0; i < database.ClothesCount; i++)
        {
            Clothes clothes = database.GetClothes(i);
            ItemList uiItem = Instantiate(itemPrefab, itemsContainer).GetComponent<ItemList>();

            uiItem.SetItemIcon(clothes.image);
            uiItem.SetItemPrice(clothes.price);
        }
    }
}
