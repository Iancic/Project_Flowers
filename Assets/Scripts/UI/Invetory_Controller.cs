using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class Invetory_Controller : MonoBehaviour
{
    public GameObject seed_tab;

    public TMP_Text text_seeds_A, text_seeds_B, text_seeds_C;

    void Start()
    {
        seed_tab.SetActive(false);
    }

    private void Update()
    {
        text_seeds_A.SetText("A Seeds: " + Master_Tool.Instance.seedsA.ToString());
        text_seeds_B.SetText("B Seeds: " + Master_Tool.Instance.seedsB.ToString());
        text_seeds_C.SetText("C Seeds: " + Master_Tool.Instance.seedsC.ToString());
    }

    public void OpenMenu()
    {
        if (seed_tab.active)
            seed_tab.SetActive(false);
        else
            seed_tab.SetActive(true);
    }

    public void SeedA()
    {
        Master_Tool.Instance.selected_seed = Master_Tool.Instance.plantA;
    }

    public void SeedB()
    {
        Master_Tool.Instance.selected_seed = Master_Tool.Instance.plantB;
    }

    public void SeedC()
    {
        Master_Tool.Instance.selected_seed = Master_Tool.Instance.plantC;
    }
}
