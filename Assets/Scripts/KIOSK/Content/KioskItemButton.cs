using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KioskItemButton : MonoBehaviour
{
    public TextMeshProUGUI categoryText;

    public void Setup(SOItem data, System.Action<SOItem> onClick, Image thumbnail)
    {
        name = data.itemName;
        categoryText.text = data.itemName;
        if (thumbnail != null) GetComponent<Image>().sprite = thumbnail.sprite;
        GetComponent<Image>().color = new Color(255f, 255f, 255f);
        GetComponentInChildren<TextMeshProUGUI>().color = new Color(255f, 255f, 255f);
        GetComponent<Button>().onClick.AddListener(() => onClick?.Invoke(data));
    }
}