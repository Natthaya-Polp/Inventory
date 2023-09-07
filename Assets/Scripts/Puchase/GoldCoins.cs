using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCoins : MonoBehaviour
{
    [SerializeField] private float startingCoins;
    [SerializeField] private float price;
    public float currentCoins{get; private set;}
    [SerializeField] private Text coinsText;

    private void Start(){
        currentCoins = startingCoins;
        UpdateCoinsDisplay();

    }
    public void LoseCoins(float _buy){
        currentCoins = Mathf.Clamp(currentCoins - _buy, 0, startingCoins);
        UpdateCoinsDisplay();

        if(currentCoins <= 0){
            Debug.Log("Out of money");
        }
    }
    public void OnButtonClick(){
        LoseCoins(price);
    }
    public void UpdateCoinsDisplay(){
        coinsText.text = " " + currentCoins.ToString();
    }
}
