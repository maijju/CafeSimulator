using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KioskContentManager : MonoBehaviour
{
    public Transform contentPanel;
    public GameObject itemPrefab;
    

    KioskCartManager kioskCartManager;

    void Start()
    {
        kioskCartManager = GetComponent<KioskCartManager>();
    }

    public void ClearContent()
    {
        foreach (Transform child in contentPanel)
        {
            Destroy(child.gameObject);
        }
    }

    public void Setup(string categoryName)
    {
        ClearContent();
        foreach (var item in CafeManager.Instance.items)
        {
            print(item.name);
            if (item.category.categoryName != categoryName) continue;
            var button = Instantiate(itemPrefab, contentPanel);
            button.GetComponent<KioskItemButton>().Setup(item, OnItemClicked);
        }
    }

    void OnItemClicked(SOItem item)
    {
        Debug.Log("Selected Item: " + item.itemName);
        kioskCartManager.AddItemToCart(item);
    }
}
