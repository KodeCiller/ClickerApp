using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text ClicksTotalText;

    float TotalClicks;

    bool hasUpgrade, hasUpgrade2, hasUpgrade3;
    public int autoClicksPerSecond;
    public int minimumClicksToUnlockUpgrade, minimumClicksToUnlockUpgrade2, minimumClicksToUnlockUpgrade3; 

    public void AddClicks()
    {
        TotalClicks++;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

    public void AutoClickUpgrade()
    {
        if(!hasUpgrade && TotalClicks >= minimumClicksToUnlockUpgrade)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade;
            hasUpgrade = true;
        }
    }

    public void AutoClickUpgrade2()
    {
        if(!hasUpgrade2 && TotalClicks >= minimumClicksToUnlockUpgrade2)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade2;
            hasUpgrade2 = true;
        }
    }
    public void AutoClickUpgrade3()
    {    
        if(!hasUpgrade3 && TotalClicks >= minimumClicksToUnlockUpgrade3)
        {
            TotalClicks -= minimumClicksToUnlockUpgrade3;
            hasUpgrade3 = true;
        }
    }
    private void Update()
    {
        if(hasUpgrade)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime;

            ClicksTotalText.text = TotalClicks.ToString("0");
        }

        if(hasUpgrade2)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 4;

            ClicksTotalText.text = TotalClicks.ToString("0");
        }

        if(hasUpgrade3)
        {
            TotalClicks += autoClicksPerSecond * Time.deltaTime * 8;

            ClicksTotalText.text = TotalClicks.ToString("0");
        }
    }
    
}
    