using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class DOTween : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;
    [SerializeField] public GameObject shopPanel;
    [SerializeField] public GameObject openShopPanel;

    //public List<GameObject> items = new List<GameObject>();

    public void PanelFadeIn()
    {
        rectTransform.transform.localPosition = new Vector3(-49f, - 1000f, 0f);
        rectTransform.DOAnchorPos(new Vector2(-49f, 0f), fadeTime, false).SetEase(Ease.InOutQuint);
        shopPanel.SetActive(true);
        
        // StartCoroutine("ItemsAnimation");
    }

    public void PanelFadeOut()
    {
        rectTransform.transform.localPosition = new Vector3(-49f, -1f, 0f);
        rectTransform.DOAnchorPos(new Vector2(-49f, -1000f), fadeTime, false).SetEase(Ease.InOutQuint);
        StartCoroutine("ShopButtonBack");
    }

    // IEnumerator ItemsAnimation()
    // {
    //     foreach (var item in items)
    //     {
    //         item.transform.localScale = Vector3.zero;
    //     }

    //     foreach (var item in items)
    //     {
    //         item.transform.DOScale(1f, fadeTime).SetEase(Ease.OutBounce);
    //         yield return new WaitForSeconds(0.25f);
    //     }
    // }

    IEnumerator ShopButtonBack()
    {
        yield return new WaitForSeconds(1f);
        openShopPanel.SetActive(true);
        shopPanel.SetActive(false);
    }

}
