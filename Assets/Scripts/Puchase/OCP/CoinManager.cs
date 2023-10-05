using UnityEngine;
using UnityEngine.UI;

public abstract class CoinManager : MonoBehaviour
{
    [SerializeField] protected float startingCoins;
    [SerializeField] protected float price;
    protected float currentCoins;
    [SerializeField] protected Text coinsText;

    protected virtual void Start()
    {
        currentCoins = startingCoins;
        UpdateCoinsDisplay();
    }

    public abstract void UpdateCoinsDisplay();

    public abstract void OnButtonClick();


}
