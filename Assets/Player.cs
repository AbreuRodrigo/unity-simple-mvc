using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour, IModel
{
    public StringProperty playerName;
    public ByteProperty data;
    public ShortProperty shortVal;
    public BoolProperty dead;
    public IntProperty life;
    public FloatProperty range;
    public DoubleProperty precision;
    public LongProperty money;

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