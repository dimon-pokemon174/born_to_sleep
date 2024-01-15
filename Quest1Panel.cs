using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest1Panel : MonoBehaviour
{
    public bool questIsHere = false;
    public float x;
    public float y;
    public float z;
    void Update()
    {
        if (questIsHere)
        {
            transform.localPosition = new Vector3(x, y, z);
        }
        else
        {
            transform.localPosition = new Vector3(-1000, y, z);
        }
    }
}
