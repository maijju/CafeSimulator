using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : ScriptableObject
{
    public List<SOItem> itemLists;
    
    public void AddItemToList(SOItem item)
    {
        itemLists.Add(item);
    }
}
