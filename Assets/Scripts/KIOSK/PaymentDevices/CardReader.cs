using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardReader : MonoBehaviour, IPurchase
{
    int paymentResultCode;
    private bool activateState = false;

    public int Pay(int price)
    {
        return paymentResultCode;
    }

    public void Activate()
    {
        activateState = true;
    }

    public void Deactivate()
    {
        activateState = false;
    }
}
