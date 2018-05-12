using System;
using UnityEngine;

public abstract class ModelAbstraction : MonoBehaviour, IModel
{
    protected string id;

    public string Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }
}