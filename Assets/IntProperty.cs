using System;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ObservableProperty<T>
{
    [SerializeField]
    private T field;

    private event Action<T> onValueChanged;

    public void AddObserver(Action<T> observer)
    {
        if(onValueChanged == null)
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
}

[Serializable]
public class IntProperty : ObservableProperty<int>
{
    public IntProperty(int field) : base(field) { }

    //OPERATORS

    public static IntProperty operator +(IntProperty obj1, IntProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, IntProperty obj2)
    {
        obj1.Field -= obj2.Field;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, IntProperty obj2)
    {
        obj1.Field *= obj2.Field;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, IntProperty obj2)
    {
        obj1.Field /= obj2.Field;
        return obj1;
    }

    public static IntProperty operator +(IntProperty obj1, int v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, int v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, int v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, int v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static IntProperty operator ++(IntProperty o)
    {
        o.Field++;
        return o;
    }

    public static IntProperty operator --(IntProperty o)
    {
        o.Field--;
        return o;
    }

    public override string ToString()
    {
        return Field.ToString();
    }
}