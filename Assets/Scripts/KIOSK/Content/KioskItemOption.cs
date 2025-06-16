using System;
using UnityEngine;
using UnityEngine.UI;

public class KioskItemOption : MonoBehaviour
{
    public Button hot;
    public Button ice;
    public Button hall;
    public Button takeout;
    KioskCartManager kioskCartManager;

    bool isSeletedTemp = false;
    bool isSeletedPlace = false;

    SOItem item;

    public void Start()
    {
        kioskCartManager = GetComponentInParent<KioskCartManager>();
        hot.onClick.AddListener(Temperature);
        ice.onClick.AddListener(Temperature);
        hall.onClick.AddListener(Place);
        takeout.onClick.AddListener(Place);
    }

    public void Setup(SOItem deliveredItem)
    {
        item = deliveredItem;
        if (item == null)
        {
            print("item is null");
            return;
        }

        hot.gameObject.SetActive(true);
        ice.gameObject.SetActive(true);
        hall.gameObject.SetActive(true);
        takeout.gameObject.SetActive(true);

        if (item.temperature == ETemperatureOption.HotOnly)
        {
            ice.gameObject.SetActive(false);
        }
        else if (item.temperature == ETemperatureOption.IceOnly)
        {
            hot.gameObject.SetActive(false);
        }
        else if (item.temperature == ETemperatureOption.None)
        {
            ice.gameObject.SetActive(false);
            hot.gameObject.SetActive(false);
        }

    }

    public void Temperature()
    {
        isSeletedTemp = true;
        print("Temperature is seleted!");

        if (item != null && isSeletedTemp && isSeletedPlace)
        {
            kioskCartManager.AddItemToCart(item);
            gameObject.SetActive(false);
            isSeletedTemp = false;
            isSeletedPlace = false;
        }
            
    }

    public void Place()
    {
        isSeletedPlace = true;
        print("Place is seleted!");

        if (item != null)
        {
            if ((isSeletedTemp && isSeletedPlace) || (isSeletedPlace && !ice.gameObject.activeSelf && !hot.gameObject.activeSelf))
            {
                kioskCartManager.AddItemToCart(item);
                gameObject.SetActive(false);
                isSeletedTemp = false;
                isSeletedPlace = false;    
            }
            
        }       
    }
}