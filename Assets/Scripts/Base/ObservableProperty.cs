using System;
using UnityEngine;

public class ObservableProperty<T> : IObservableProperty<T>
{
    [SerializeField]
    private T field;

    private event Action<T> onValueChanged;

    public void AddObserver(Action<T> observer)
    {
        if (onValueChanged == null)
        {
            onValueChanged = delegate (T o) { };
        }

        if (onValueChanged != null)
        {
            onValueChanged += observer;
        }
    }

    public ObservableProperty(T field)
    {
        this.field = field;
    }

    public T Field
    {
        get
        {
            return field;
        }
        set
        {
            this.field = value;

            if (onValueChanged != null)
            {
                onValueChanged(value);
            }
        }
    }

    public T GetValue()
    {
        return Field;
    }

    public void SetValue(T t)
    {
        Field = t;
    }
}