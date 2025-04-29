using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelection : MonoBehaviour
{
    public Item selectedItem;
    public List<Item> itemCart;

    public void ItemDetail()
    {

    }

    public void AddToCart()
    {
        itemCart.Add(selectedItem);
    }
}
