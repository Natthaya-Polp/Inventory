using UnityEngine;

public class HatGenerator : ItemGeneratorBase<HatDatabase>
{
    public override void GenerateUI()
    {
        itemsContainer.DetachChildren();

        for (int i = 0; i < database.HatsCount; i++)
        {
            Hat hat = database.GetHat(i);
            ItemList uiItem = Instantiate(itemPrefab, itemsContainer).GetComponent<ItemList>();

            uiItem.SetItemIcon(hat.image);
            uiItem.SetItemPrice(hat.price);
        }
    }
}


