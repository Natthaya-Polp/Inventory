using UnityEngine;

public abstract class ItemGeneratorBase<T> : MonoBehaviour
{
    [SerializeField] protected Transform itemsContainer;
    [SerializeField] protected GameObject itemPrefab;
    [SerializeField] protected T database;

    public abstract void GenerateUI();
}
