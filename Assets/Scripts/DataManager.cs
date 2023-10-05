using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;

public struct Data
{
    public string HatInfo;
    public string ClothesInfo;
    public string PetInfo;
}
public class DataManager : MonoBehaviour
{
    [SerializeField] Text uiHatText;
    [SerializeField] Text uiClothText;
    [SerializeField] Text uiPetText;
    [SerializeField] GameObject loadingUi;
    

    string jsonURL = "https://drive.google.com/uc?export=download&id=1lJZljq14Vi3hV00YvQ1V5QdE2N_biAZa";

    void Start()
    {
       StartCoroutine( GetData (jsonURL));
    }
    IEnumerator GetData(string url)
    {
        loadingUi.SetActive(true);

        UnityWebRequest request = UnityWebRequest.Get(url);

        yield return request.Send();

        if (request.isError)
        {

        }
        else
        {
            Data data = JsonUtility.FromJson<Data>(request.downloadHandler.text);

            uiHatText.text = data.HatInfo;
            uiClothText.text = data.ClothesInfo;
            uiPetText.text = data.PetInfo;

            loadingUi.SetActive(false);
            
        }

        request.Dispose();
    }

   
}
