using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemUIPrefab;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject itemUIObject = Instantiate(itemUIPrefab, transform);
        }
    }
}

