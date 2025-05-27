using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KioskCategoryButton : MonoBehaviour
{
    public TextMeshProUGUI categoryText;

    public void Setup(SOCategory data, System.Action<string> onClick)
    {
        name = data.categoryName;
        categoryText.text = data.categoryName;
        GetComponent<Button>().onClick.AddListener(() => onClick?.Invoke(data.categoryName));
    }
}