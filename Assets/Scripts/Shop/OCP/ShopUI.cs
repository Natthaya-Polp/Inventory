using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopUI : MonoBehaviour
{
    [SerializeField] private GameObject shopUI;

    [SerializeField] private HatGenerator hatGenerator;
    [SerializeField] private ClothesGenerator clothesGenerator;
    [SerializeField] private PetGenerator petGenerator;

    private void Start()
    {
        GenerateHatUI();
        GenerateClothesUI();
        GeneratePetUI();
    }

    public void GenerateHatUI()
    {
        hatGenerator.GenerateUI();
    }

    public void GenerateClothesUI()
    {
        clothesGenerator.GenerateUI();
    }

    public void GeneratePetUI()
    {
        petGenerator.GenerateUI();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Game");
    }
}
