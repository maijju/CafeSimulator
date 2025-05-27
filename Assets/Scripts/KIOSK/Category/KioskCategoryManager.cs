using System.Collections.Generic;
using UnityEngine;

public class KioskCategoryManager : MonoBehaviour
{
    public Transform contentPanel; // Scroll View > Viewport > Content
    public GameObject categoryPrefab;
    

    private KioskContentManager contentManager;

    void Start()
    {
        contentManager = GetComponent<KioskContentManager>();
    }

    public void Setup()
    {
        foreach (var category in CafeManager.Instance.categories)
        {
            var button = Instantiate(categoryPrefab, contentPanel);
            button.GetComponent<KioskCategoryButton>().Setup(category, OnCategoryClicked);
        }
    }

    

    void OnCategoryClicked(string categoryName)
    {
        Debug.Log("Selected category: " + categoryName);
        contentManager.Setup(categoryName);
    }
}
