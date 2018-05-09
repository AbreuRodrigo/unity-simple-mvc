using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CanEditMultipleObjects]
public class Player : MonoBehaviour
{
    public IntProperty Life;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Life -= 10;
        }
    }
}