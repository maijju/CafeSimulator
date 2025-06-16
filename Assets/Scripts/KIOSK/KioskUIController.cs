using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KioskUIController : MonoBehaviour
{
    private KioskCategoryManager kioskCategoryManager;
    private KioskContentManager kioskContentManager;
    private KioskCartManager kioskCartManager;
    void Awake()
    {
        kioskCategoryManager = GetComponentInChildren<KioskCategoryManager>();
        kioskContentManager = GetComponentInChildren<KioskContentManager>();
        kioskCartManager = GetComponentInChildren<KioskCartManager>();
        
    }
    void Start()
    {
        print("Start");
        kioskCategoryManager.Setup();
    }
}
