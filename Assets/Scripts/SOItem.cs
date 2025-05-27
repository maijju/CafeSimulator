using UnityEngine;

public enum ETemperatureOption
{
    HotOnly,
    IceOnly,
    Both,
    None
}

[CreateAssetMenu(menuName = "Kiosk/DrinkItem")]
public class SOItem : ScriptableObject
{
    public string itemName;
    public int price;
    public ETemperatureOption temperature;
    public SOCategory category; 
}
