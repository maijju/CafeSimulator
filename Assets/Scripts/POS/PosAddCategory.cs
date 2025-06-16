using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering.Universal;
using System.Collections.Generic;

public class PosAddCategory : MonoBehaviour
{
    public TextMeshProUGUI nameInput;

    public Button confirmBtn;
    public Button cancelBtn;

    void Start()
    {
        confirmBtn.onClick.AddListener(CreateCategory);
        cancelBtn.onClick.AddListener(Exit);
    }

    void OnEnable()
    {
        Setup();
    }

    void Setup()
    {
        nameInput.text = "";
    }



    public void CreateCategory()
    {
        SOCategory category = new SOCategory();
        category.categoryName = nameInput.text;

        if (category != null)
        {
            CafeManager.Instance.AddCategory(category);
        }
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }

}