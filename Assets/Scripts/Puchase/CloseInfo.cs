using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInfo : MonoBehaviour
{
    public GameObject itemInfoPanel;

    public void OnButtonClick(){
        itemInfoPanel.SetActive(false);
    }
}
