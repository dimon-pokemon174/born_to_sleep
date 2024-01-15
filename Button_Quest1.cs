using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Quest1 : MonoBehaviour
{
    public Timer timer;
    public Quest1 quest;
    public Quest1Panel panel;
    public Quest1Panel ramka1;
    public Quest1Panel ramka2;
    public void Click1()
    {
        timer.quest = false;
        quest.questIsHere = true;
        panel.questIsHere = true;
        ramka1.questIsHere = true;
        ramka2.questIsHere = true;
    }

    public void ClickFalse()
    {
        timer.quest = true;
        panel.questIsHere = false;
        ramka1.questIsHere = false;
        ramka2.questIsHere = false;
    }
}
