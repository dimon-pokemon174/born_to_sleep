using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        DateTime now = DateTime.Now;
        timeText.text = now.ToString("HH:mm:ss");
    }
}

