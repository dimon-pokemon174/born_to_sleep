
using UnityEngine;
using UnityEngine.UI;

public class Quest1 : MonoBehaviour
{
    public Timer timer;
    public Image image;

    public bool questIsHere = false;
    private float time = 0;

    private int hourOfStart = 10;
    private int minOfStart = 10;
    private int hourOfEnd = 10;
    private int minOfMiddle = 20;
    private int minOfEnd = 26;
    void Update()
    {
        int hour = timer.Hour;
        float minute = timer.timeStart;

        if (hour == hourOfStart && Mathf.Round(minute) == minOfStart)
        {
            transform.localPosition = new Vector3(-70, -47, 0);
        }

        if (hour == hourOfEnd && Mathf.Round(minute) >= minOfMiddle && Mathf.Round(minute) <= minOfEnd)
        {
            time += Time.deltaTime;
            int t = (int)Mathf.Round(time);
            if (t % 2 == 0)
            {
                image.color = new Color(0f, 0f, 0f, 255f);
            }
            else
            {
                image.color = new Color(255f, 255f, 255f, 255f);
            }
        }

        if ((hour == hourOfEnd && Mathf.Round(minute) >= minOfEnd) || questIsHere)
        {
            transform.position = new Vector3(0, 600, 0);
        }
    }
}
