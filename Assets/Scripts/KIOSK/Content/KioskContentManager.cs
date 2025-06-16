using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KioskContentManager : MonoBehaviour
{
    public Transform contentPanel;
    public Transform itemOptionPanel;
    public GameObject itemPrefab;
    public Sprite[] thumbnailSprite;
    private Image thumbnail;

    KioskItemOption kioskItemOption;
    

    void Start()
    {
        kioskItemOption = itemOptionPanel.GetComponent<KioskItemOption>();
        thumbnail = GetComponent<Image>();
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

            thumbnail.sprite = thumbnailSprite[0];
            if (categoryName == "Coffee")
            {
                thumbnail.sprite = thumbnailSprite[1];
            }
            else if (categoryName == "Juice")
            {
                thumbnail.sprite = thumbnailSprite[2];
            }
            else if (categoryName == "Tea")
            {
                thumbnail.sprite = thumbnailSprite[3];
            }
            else if (categoryName == "Dessert")
            {
                thumbnail.sprite = thumbnailSprite[4];
            }

            button.GetComponent<KioskItemButton>().Setup(item, OnItemClicked, thumbnail);
        }
    }

    void OnItemClicked(SOItem item)
    {
        //Debug.Log("Selected Item: " + item.itemName);
        itemOptionPanel.gameObject.SetActive(true);
        kioskItemOption.Setup(item);
        //kioskCartManager.AddItemToCart(item);
    }
}
