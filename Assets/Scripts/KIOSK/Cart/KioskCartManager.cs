using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Kinnly;
using UnityEngine.UI;

public class KioskCartManager : MonoBehaviour
{
    public List<SOItem> cart;
    public GameObject cartPrefab;
    public Transform cartPanel;
    public TextMeshProUGUI totalPrice;
    public Button purchaseBtn;

    void Start()
    {
        purchaseBtn.onClick.AddListener(Purchase);
    }
    public void AddItemToCart(SOItem item)
    {
        if (cart.Count > 10)
        {
            Debug.Log("카트에는 10개의 아이템 까지 담을 수 있습니다.");
            return;
        }

        cart.Add(item);
        Setup();
    }

    public void ClearCart()
    {
        foreach (Transform child in cartPanel)
        {
            Destroy(child.gameObject);
        }
    }

    public void Setup()
    {
        int total = 0;
        ClearCart();
        foreach (var item in cart)
        {
            total += item.price;
            var button = Instantiate(cartPrefab, cartPanel);
            button.GetComponent<KioskCartButton>().Setup(item, OnCartClicked);
        }
        totalPrice.text = total.ToString();
    }

    void OnCartClicked(SOItem item)
    {
        Debug.Log("Selected cart item: " + item.itemName);
        cart.Remove(item);
        Setup();
    }

    public void Purchase()
    {
        CafeManager.Instance.totalSales += int.Parse(totalPrice.text);
        totalPrice.text = "0";
        ClearCart();
    }
}
