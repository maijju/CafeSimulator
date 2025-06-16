using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering.Universal;
using System.Collections.Generic;

public class PosViewSales : MonoBehaviour
{
    public TextMeshProUGUI result;
    public Button confirmBtn;

    void Start()
    {
        confirmBtn.onClick.AddListener(Exit);
    }

    void OnEnable()
    {
        Setup();
    }

    void Setup()
    {
        result.text = CafeManager.Instance.totalSales.ToString();
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }

}