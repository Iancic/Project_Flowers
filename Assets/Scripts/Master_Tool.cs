using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master_Tool : MonoBehaviour
{
    public static Master_Tool Instance { get; private set; }

    public GameObject plantA, plantB, plantC;
    public GameObject selected_seed;
    public GameObject hole;
    public int seedsA = 5, seedsB = 5, seedsC = 5;
    public int money = 500;

    public int selected_Tool = 1;
    // 1 = Glove, 2 = Shovel, 3 = Water 

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    //Singleton Workflow

    void Start()
    {
        selected_seed = plantA;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            switch (selected_Tool)
            {
                case 3:
                    Water();
                    break;
                case 2:
                    Shovel();
                    break;
                case 1:
                    Glove();
                    break;
            }
        }
    }

    public void Glove()
    {
        if ((selected_seed == plantA && seedsA > 0) || (selected_seed == plantB && seedsB > 0) || (selected_seed == plantC && seedsC > 0))
        {
            money += 200;
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;

            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(selected_seed, new Vector3(objectPos.x, objectPos.y + 1f, objectPos.z), Quaternion.identity);

        if (selected_seed == plantA)
            seedsA -= 1;
        else if (selected_seed == plantB)
            seedsB -= 1;
        else if (selected_seed == plantC)
            seedsC -= 1;
        }
    }

    public void Water()
    {
        Debug.Log("I splash water");
    }

    public void Shovel()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;

        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Instantiate(hole, new Vector3(objectPos.x, objectPos.y + 1f, objectPos.z), Quaternion.identity);
    }
}
