using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Seeds_Counter : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text.SetText("Seeds: " + Master_Tool.seeds.ToString());
    }
}
