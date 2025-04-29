using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPurchase : MonoBehaviour
{
    private CardReader cardReader;
    private NFCReader nfcReader;
    private QRReader qrReader;
    private ItemSelection itemSelection;
    public int totalPrice = 0;

    void Start()
    {
        cardReader = GetComponent<CardReader>();
        nfcReader = GetComponent<NFCReader>();
        qrReader = GetComponent<QRReader>();
        itemSelection = GetComponent<ItemSelection>();
    }
    public void ConfirmPurchase(int selection)
    {
        switch(selection)
        {
            case 1:
            cardReader.Pay(totalPrice);
            break;

            case 2:
            nfcReader.Pay(totalPrice);
            break;

            case 3:
            qrReader.Pay(totalPrice);
            break;
        }
    }
    public void CalcTotalPrice()
    {
        foreach (Item item in itemSelection.itemCart)
        {
            totalPrice += item.GetPrice();
        }
    }
}
