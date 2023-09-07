using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    public Button selectionButton1;
    public Button buyButton;

    private bool hasSelected = false;

    private void Start()
    {
        // Add onClick listeners to your selection buttons
        selectionButton1.onClick.AddListener(SelectOption1);
        buyButton.onClick.AddListener(Buy);
    }

    private void SelectOption1()
    {
        hasSelected = true;
        // Enable the BuyButton since the player has made a selection
        buyButton.interactable = true;
        Debug.Log("Item has choose");
    }

    private void Buy()
    {
        if (hasSelected)
        {
            // Add your buy logic here
            Debug.Log("Item purchased!");
        }
        else
        {
            // Display a message or handle the case where the player hasn't made a selection
            Debug.Log("Please make a selection before buying.");
        }
    }
}
