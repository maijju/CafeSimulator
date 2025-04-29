using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : ScriptableObject
{
    public List<Item> itemLists;
    
    public void AddItemToList(Item item)
    {
        itemLists.Add(item);
    }
}
