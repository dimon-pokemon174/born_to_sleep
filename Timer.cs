using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public Text timerText;
    public int Hour;
    public int timerStop;
    public bool quest = true; 

    bool timerRunning = true;
    // Start is called before the first frame update
    void Start()
    {
        timerText.text = Hour.ToString() + ':' + '0' + timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning && quest)
        {
            timeStart += Time.deltaTime;
            if (Mathf.Round(timeStart) == 60)
            {
                timeStart = 0;
                Hour += 1;
            }
            if (Mathf.Round(timeStart) < 10)
            {
                timerText.text = Hour.ToString() + ':' + '0' + Mathf.Round(timeStart).ToString();
            }
            else
            {
                timerText.text = Hour.ToString() + ':' + Mathf.Round(timeStart).ToString();
            }
        }
        if (Hour == timerStop)
        {
            timerRunning = false;
        }
    }
}
