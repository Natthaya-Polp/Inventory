using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    public void OpenShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
