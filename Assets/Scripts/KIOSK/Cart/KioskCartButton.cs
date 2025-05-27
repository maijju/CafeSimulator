using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KioskCartButton : MonoBehaviour
{
    public TextMeshProUGUI categoryText;

    public void Setup(SOItem data, System.Action<SOItem> onClick)
    {
        name = data.itemName;
        categoryText.text = data.itemName;
        GetComponent<Button>().onClick.AddListener(() => onClick?.Invoke(data));
    }
}   