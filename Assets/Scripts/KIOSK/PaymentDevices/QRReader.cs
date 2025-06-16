using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QRReader : MonoBehaviour, IPurchase
{
    public void Pay()
    {
        print("Paid by QR");
    }

}
