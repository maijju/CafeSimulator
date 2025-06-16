using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardReader : MonoBehaviour, IPurchase
{
    public void Pay()
    {
        print("Paid by Card");
    }
}
