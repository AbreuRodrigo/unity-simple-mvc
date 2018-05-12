using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour, IModel
{
    [Header("Setup")]
    public int initialLife;

    [Header("Properties")]
    public StringProperty playerName;
    public BoolProperty dead;
    public IntProperty life;

    private void Start()
    {
        if(life != null)
        {
            life.SetValue(initialLife);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && !dead)
        {
            life -= 10;

            if(life <= 0)
            {
                dead.SetValue(true);
            }
        }
    }
}