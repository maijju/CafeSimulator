using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering.Universal;
using System.Collections.Generic;

public class PosAddItem : MonoBehaviour
{
    public TextMeshProUGUI nameInput;
    public TextMeshProUGUI priceInput;
    public TMP_Dropdown temperatureDropdown;
    public TMP_Dropdown categoryDropdown;

    public Button confirmBtn;
    public Button cancelBtn;

    SOItem item;

    void Start()
    {
        confirmBtn.onClick.AddListener(CreateItem);
        cancelBtn.onClick.AddListener(Exit);
    }

    void OnEnable()
    {
        Setup();
    }

    void Setup()
    {
        nameInput.text = "";
        priceInput.text = "";
        categoryDropdown.ClearOptions();
        List<string> categoryNames = new List<string>();
        foreach (SOCategory category in CafeManager.Instance.categories)
        {
            categoryNames.Add(category.categoryName);
        }
        categoryDropdown.AddOptions(categoryNames);
    }

    

    public void CreateItem()
    {
        string realPrice = "";
        //print(nameInput.text);
        foreach (var c in priceInput.text)
        {
            if (char.IsDigit(c))
                realPrice += c;
        }

        item = ScriptableObject.CreateInstance<SOItem>();
        item.name = nameInput.text;
        item.itemName = nameInput.text;
        item.price = int.Parse(realPrice);
        item.temperature = (ETemperatureOption)temperatureDropdown.value;

        string selectedCategoryName = categoryDropdown.options[categoryDropdown.value].text;

        foreach (SOCategory category in CafeManager.Instance.categories)
        {
            if (selectedCategoryName == category.categoryName)
            {
                item.category = category;
                break;
            }
        }

        if (item != null)
        {
            CafeManager.Instance.AddItem(item);
        }
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }



}