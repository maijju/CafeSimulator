using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KioskUIManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform contentPanel; // Panel_Content
    public List<Item> coffeeItems;
    public List<Item> teaItems;
    public List<Item> dessertItems;

    public void OnClickCategory(string category)
    {
        ClearContent();
        List<Item> selectedItems = GetItemsByCategory(category);
        foreach (var item in selectedItems)
        {
            GameObject itemGO = Instantiate(itemPrefab, contentPanel);
        }
    }

    void ClearContent()
    {
        foreach (Transform child in contentPanel)
        {
            Destroy(child.gameObject);
        }
    }

    List<Item> GetItemsByCategory(string category)
    {
        switch (category)
        {
            case "Coffee": return coffeeItems;
            case "Tea": return teaItems;
            case "Dessert": return dessertItems;
            default: return new List<Item>();
        }
    }
}
