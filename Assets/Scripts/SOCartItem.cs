using UnityEngine;

public enum ETemperature
{
    Hot,
    Ice
}

public class SOCartItem : ScriptableObject
{
    public string itemName;
    public string price;
    public ETemperature temperature;
}
