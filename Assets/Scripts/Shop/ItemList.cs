using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ItemList : MonoBehaviour
{
    [SerializeField] Image itemIcon;
    [SerializeField] TMP_Text itemPrice;

    [SerializeField] Button itemButton;
	[SerializeField] Outline itemOutline;

    public void SetItemPosition (Vector2 pos)
	{
		GetComponent <RectTransform> ().anchoredPosition += pos;
	}

	public void SetItemIcon (Sprite sprite)
	{
		itemIcon.sprite = sprite;
	}

	public void SetItemPrice (int price)
	{
		itemPrice.text = price.ToString ();
	}

    public void OnItemSelect (int itemIndex, UnityAction<int> action)
	{
		itemButton.interactable = true;

		itemButton.onClick.RemoveAllListeners ();
		itemButton.onClick.AddListener (() => action.Invoke (itemIndex));
	}

	public void SelectItem ()
	{
		itemOutline.enabled = true;
		itemButton.interactable = false;
	}

	public void DeselectItem ()
	{
		itemOutline.enabled = false;
		itemButton.interactable = true;
	}
}
