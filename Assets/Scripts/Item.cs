using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "ScriptableObjects/CafeItem")]
public class Item : ScriptableObject
{
    [SerializeField] string itemName;
    [SerializeField] string category;
    [SerializeField] Sprite previewImage;
    [SerializeField] int price;

    public int GetPrice()
    {
        return price;
    }
}
