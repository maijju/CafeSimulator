using UnityEngine;
using System.Collections.Generic;

public class CafeManager : MonoBehaviour
{
    public static CafeManager Instance { get; private set; }
    public Transform kioskPanel;
    public Transform posPanel;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public List<SOCategory> categories;
    public List<SOItem> items;
    public int totalSales = 0;

    public void AddItem(SOItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(SOItem item)
    {
        items.Remove(item);
    }

    public void AddCategory(SOCategory category)
    {
        categories.Add(category);
        kioskPanel.GetComponent<KioskCategoryManager>().Setup();
    }

    public void RemoveCategory(SOCategory category)
    {
        categories.Remove(category);
    }
    
}
