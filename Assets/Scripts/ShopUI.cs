using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    // [Header ("Layout Settings")]
	// [SerializeField] float itemSpacing = .5f;
	// float itemHeight;

    [Header ("UI elements")]
	//[SerializeField] Image selectedItemIcon;
	[SerializeField] Transform ShopItemsContainer;
	[SerializeField] GameObject itemPrefab;
	
	[SerializeField] ItemDatabase itemDB;
    
    [Header ("Shop Events")]
	[SerializeField] GameObject shopUI;

    void Start()
    {
        GenerateShopItemsUI();
    }

    public void GenerateShopItemsUI()
    {
        //itemHeight = ShopItemsContainer.GetChild (0).GetComponent <RectTransform> ().sizeDelta.y;
		Destroy (ShopItemsContainer.GetChild (0).gameObject);
		ShopItemsContainer.DetachChildren ();

		for (int i = 0; i < itemDB.ItemsCount; i++)
        {
			Item items = itemDB.GetItem (i);
			ItemList uiItem = Instantiate (itemPrefab, ShopItemsContainer).GetComponent <ItemList> ();

            //uiItem.SetItemPosition (Vector2.down * i * (itemHeight + itemSpacing));

			//Add information to the UI (one item)
			uiItem.SetItemIcon (items.image);
			uiItem.SetItemPrice (items.price);
        }
    }

    // void OnItemSelected (int index)
	// {
	// 	SelectItemUI (index);
	// }

    // void SelectItemUI (int itemIndex)
	// {
	// 	previousSelectedItemIndex = newSelectedItemIndex;
	// 	newSelectedItemIndex = itemIndex;

	// 	ItemList prevUiItem = GetItemUI (previousSelectedItemIndex);
	// 	ItemList newUiItem = GetItemUI (newSelectedItemIndex);

	// 	prevUiItem.DeselectItem ();
	// 	newUiItem.SelectItem ();
	// }

    ItemList GetItemUI (int index)
	{
		return ShopItemsContainer.GetChild (index).GetComponent <ItemList> ();
	}

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Game");
    }
}
