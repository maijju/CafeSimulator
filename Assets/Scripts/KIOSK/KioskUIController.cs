using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KioskUIController : MonoBehaviour
{
    private KioskCategoryManager categoryTabManager;
    void Awake()
    {
        categoryTabManager = GetComponentInChildren<KioskCategoryManager>();
        
    }
    void Start()
    {
        print("Start");
        categoryTabManager.Setup();
    }
}
