using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPurchase : MonoBehaviour
{
    public Button card;
    public Button NFC;
    public Button QR;

    private CardReader cardReader;
    private NFCReader nfcReader;
    private QRReader qrReader;
    private ItemSelection itemSelection;
    int totalPrice = 0;

    KioskCartManager kioskCartManager;

    void Start()
    {
        card.onClick.AddListener(() => ConfirmPurchase(1));
        NFC.onClick.AddListener(() => ConfirmPurchase(1));
        QR.onClick.AddListener(() => ConfirmPurchase(1));

        cardReader = GetComponent<CardReader>();
        nfcReader = GetComponent<NFCReader>();
        qrReader = GetComponent<QRReader>();
        itemSelection = GetComponent<ItemSelection>();
        kioskCartManager = GetComponentInParent<KioskCartManager>();
    }

    public void Setup(int total)
    {
        totalPrice = total;
    }
    public void ConfirmPurchase(int selection)
    {
        switch (selection)
        {
            case 1:
                cardReader.Pay();
                break;

            case 2:
                nfcReader.Pay();
                break;

            case 3:
                qrReader.Pay();
                break;
        }
        CafeManager.Instance.totalSales += totalPrice;
        kioskCartManager.SuccessPay();
        gameObject.SetActive(false);
    }
}

