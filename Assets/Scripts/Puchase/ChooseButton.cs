using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseButton : MonoBehaviour
{
    public GameObject itemInfoPanel;

    public void OnButtonClick(){
        itemInfoPanel.SetActive(true);
    }
}
