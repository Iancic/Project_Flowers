using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Shop_Controller : MonoBehaviour
{
    public GameObject shop_tab;

    void Start()
    {
        shop_tab.SetActive(false);
    }

    public void OpenMenu()
    {
        if (shop_tab.active)
            shop_tab.SetActive(false);
        else
            shop_tab.SetActive(true);
    }

    public void Buy_SeedA()
    {
        Master_Tool.Instance.seedsA += 1;
        Master_Tool.Instance.money -= 100;
    }

    public void Buy_SeedB()
    {
        Master_Tool.Instance.seedsB += 1;
        Master_Tool.Instance.money -= 100;
    }

    public void Buy_SeedC()
    {
        Master_Tool.Instance.seedsC += 1;
        Master_Tool.Instance.money -= 100;
    }
}
