using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFCReader : MonoBehaviour, IPurchase
{
    public void Pay()
    {
        print("Paid by NFC");
    }

}
