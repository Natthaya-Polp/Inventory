using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetGenerator : ItemGeneratorBase<PetDatabase>
{
    public override void GenerateUI()
    {
        itemsContainer.DetachChildren();

        for (int i = 0; i < database.PetsCount; i++)
        {
            Pet pet = database.GetPet(i);
            ItemList uiItem = Instantiate(itemPrefab, itemsContainer).GetComponent<ItemList>();

            uiItem.SetItemIcon(pet.image);
            uiItem.SetItemPrice(pet.price);
        }
    }
}
