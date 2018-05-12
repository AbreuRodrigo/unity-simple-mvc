using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour, IView
{
    public Text life;

    public void OnClose()
    {
        //Do Nothing
    }

    public void OnOpen()
    {
        //Do Nothing
    }

    public void UpdateLife(int lifeVal)
    {
        if(life != null)
        {
            life.text = "Life: " + lifeVal;
        }
    }
}