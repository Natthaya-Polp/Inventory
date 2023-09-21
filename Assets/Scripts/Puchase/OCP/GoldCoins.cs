using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCoins : CoinManager
{
    protected override void Start()
    {
        base.Start();
    }

    public override void UpdateCoinsDisplay()
    {
        coinsText.text = " " + currentCoins.ToString();
    }

    public override void OnButtonClick()
    {
        LoseCoins(price);
    }

    public void LoseCoins(float _buy)
    {
        currentCoins = Mathf.Clamp(currentCoins - _buy, 0, startingCoins);
        UpdateCoinsDisplay();

        if (currentCoins <= 0)
        {
            Debug.Log("Out of money");
        }
    }
}
