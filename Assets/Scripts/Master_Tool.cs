using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master_Tool : MonoBehaviour
{
    public GameObject plantA, plantB, plantC;
    public GameObject selected_seed;
    public static int seeds = 5;
    public static int money = 500;

    void Start()
    {
        selected_seed = plantA;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if ( seeds > 0) 
            {
            seeds -= 1;
            money += 200;
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(selected_seed, new Vector3 (objectPos.x, objectPos.y + 1f, objectPos.z), Quaternion.identity);
            }
        }
    }

    public void BuyMore()
    {
        seeds += 1;
        money -= 100;
    }

    public void SeedA()
    {
        selected_seed = plantA;
    }

    public void SeedB()
    {
        selected_seed = plantB;
    }

    public void SeedC()
    {
        selected_seed = plantC;
    }
}
