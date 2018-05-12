using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.A))
        {
            life -= 10;
        }
    }
}