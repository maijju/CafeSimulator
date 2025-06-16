using UnityEngine;

public enum ETemperature
{
    Hot,
    Ice
}

public class SOCartItem : ScriptableObject
{
    public string itemName;
    public int price;
    public ETemperature temperature;
}
