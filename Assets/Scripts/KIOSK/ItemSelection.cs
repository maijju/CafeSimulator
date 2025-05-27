using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelection : MonoBehaviour
{
    public SOItem selectedItem;
    public List<SOItem> itemCart;

    public void ItemDetail()
    {

    }

    public void AddToCart()
    {
        itemCart.Add(selectedItem);
    }
}
