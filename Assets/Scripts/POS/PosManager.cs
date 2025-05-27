using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PosManager : MonoBehaviour
{
    public Button addItem;
    public Button addCategory;
    public Button viewSales;

    public Transform addItemPanel;
    public Transform addCategoryPanel;
    public Transform viewSalesPanel;

    void Start()
    {
        addItem.onClick.AddListener(ShowAddItem);
        addCategory.onClick.AddListener(ShowAddCategory);
        viewSales.onClick.AddListener(ShowViewSales);

        addItemPanel.gameObject.SetActive(false);
        addCategoryPanel.gameObject.SetActive(false);
        viewSalesPanel.gameObject.SetActive(false);
    }

    void ShowAddItem()
    {
        if (CafeManager.Instance == null) return;
        addItemPanel.gameObject.SetActive(true);
    }
    void ShowAddCategory()
    {
        if (CafeManager.Instance == null) return;
        addCategoryPanel.gameObject.SetActive(true);
    }
    void ShowViewSales()
    {
        if (CafeManager.Instance == null) return;
        viewSalesPanel.gameObject.SetActive(true);
    }
}