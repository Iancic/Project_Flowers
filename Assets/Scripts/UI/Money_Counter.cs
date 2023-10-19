using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money_Counter : MonoBehaviour
{
    public TMP_Text text;

    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        text.SetText("$ " + Master_Tool.Instance.money.ToString());
    }
}
