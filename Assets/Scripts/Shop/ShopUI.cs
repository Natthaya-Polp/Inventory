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
	[SerializeField] Transform HatItemsContainer;
	[SerializeField] GameObject hatPrefab;

	[SerializeField] Transform ClothesItemsContainer;
	[SerializeField] GameObject clothesPrefab;

	[SerializeField] Transform PetItemsContainer;
	[SerializeField] GameObject petPrefab;
	
	[SerializeField] HatDatabase hatDB;
	[SerializeField] ClothesDatabase clothesDB;
	[SerializeField] PetDatabase petDB;
    
    [Header ("Shop Events")]
	[SerializeField] GameObject shopUI;

    void Start()
    {
        GenerateHatUI();
		GenerateClothesUI();
		GeneratePetUI();
    }

    public void GenerateHatUI()
    {
		HatItemsContainer.DetachChildren ();

		for (int i = 0; i < hatDB.HatsCount; i++)
        {
			Hat hats = hatDB.GetHat (i);
			ItemList uiItem = Instantiate (hatPrefab, HatItemsContainer).GetComponent <ItemList> ();

			uiItem.SetItemIcon (hats.image);
			uiItem.SetItemPrice (hats.price);
        }
    }

	public void GenerateClothesUI()
    {
		ClothesItemsContainer.DetachChildren ();

		for (int i = 0; i < clothesDB.ClothesCount; i++)
        {
			Clothes clothes = clothesDB.GetClothes (i);
			ItemList uiItem = Instantiate (clothesPrefab, ClothesItemsContainer).GetComponent <ItemList> ();

			uiItem.SetItemIcon (clothes.image);
			uiItem.SetItemPrice (clothes.price);
        }
    }

	public void GeneratePetUI()
    {
		PetItemsContainer.DetachChildren ();

		for (int i = 0; i < petDB.PetsCount; i++)
        {
			Pet pets = petDB.GetPet (i);
			ItemList uiItem = Instantiate (petPrefab, PetItemsContainer).GetComponent <ItemList> ();

			uiItem.SetItemIcon (pets.image);
			uiItem.SetItemPrice (pets.price);
        }
    }

    // ItemList GetItemUI (int index)
	// {
	// 	return ShopItemsContainer.GetChild (index).GetComponent <ItemList> ();
	// }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Game");
    }
}
