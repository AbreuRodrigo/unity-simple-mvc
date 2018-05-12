using System;
using UnityEngine;

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
    
    public static IntProperty operator +(IntProperty obj1, float v)
    {
        obj1.Field += (int) v;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, float v)
    {
        obj1.Field -= (int) v;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, float v)
    {
        obj1.Field *= (int) v;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, float v)
    {
        obj1.Field /= (int) v;
        return obj1;
    }
    
    public static IntProperty operator +(IntProperty obj1, double v)
    {
        obj1.Field += (int)v;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, double v)
    {
        obj1.Field -= (int)v;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, double v)
    {
        obj1.Field *= (int)v;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, double v)
    {
        obj1.Field /= (int)v;
        return obj1;
    }

    public static IntProperty operator +(IntProperty obj1, long v)
    {
        obj1.Field += (int) v;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, long v)
    {
        obj1.Field -= (int) v;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, long v)
    {
        obj1.Field *= (int) v;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, long v)
    {
        obj1.Field /= (int) v;
        return obj1;
    }

    public static IntProperty operator +(IntProperty obj1, short v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static IntProperty operator -(IntProperty obj1, short v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static IntProperty operator *(IntProperty obj1, short v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static IntProperty operator /(IntProperty obj1, short v)
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
    
    public static bool operator !=(IntProperty o1, IntProperty o2)
    {
        return !o1.Equals(o2);
    }

    public static bool operator ==(IntProperty o1, IntProperty o2)
    {
        return o1.Equals(o2);
    }

    public static bool operator !=(IntProperty o1, int v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(IntProperty o1, int v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(IntProperty o1, float v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(IntProperty o1, float v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(IntProperty o1, double v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(IntProperty o1, double v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(IntProperty o1, long v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(IntProperty o1, long v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(IntProperty o1, short v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(IntProperty o1, short v)
    {
        return o1.Field == v;
    }

    #region >= <=
    public static bool operator <=(IntProperty o1, int v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(IntProperty o1, int v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(IntProperty o1, float v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(IntProperty o1, float v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(IntProperty o1, double v)
    {
        return o1.Field <= v;
    }
    
    public static bool operator >=(IntProperty o1, double v)
    {
        return o1.Field >= v;
    }

    public static bool operator >=(IntProperty o1, short v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(IntProperty o1, short v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(IntProperty o1, long v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(IntProperty o1, long v)
    {
        return o1.Field <= v;
    }

    #endregion >= <=

    public static bool operator >(IntProperty o1, IntProperty o2)
    {
        return o1.Field > o2.Field;
    }

    public static bool operator <(IntProperty o1, IntProperty o2)
    {
        return o1.Field < o2.Field;
    }

    public static bool operator >(IntProperty o1, int v)
    {
        return o1.Field > v;
    }

    public static bool operator <(IntProperty o1, int v)
    {
        return o1.Field < v;
    }

    public static bool operator >(IntProperty o1, float v)
    {
        return o1.Field > v;
    }

    public static bool operator <(IntProperty o1, float v)
    {
        return o1.Field < v;
    }

    public static bool operator >(IntProperty o1, short v)
    {
        return o1.Field > v;
    }

    public static bool operator <(IntProperty o1, short v)
    {
        return o1.Field < v;
    }

    public static bool operator >(IntProperty o1, long v)
    {
        return o1.Field > v;
    }

    public static bool operator <(IntProperty o1, long v)
    {
        return o1.Field < v;
    }

    public static bool operator >(IntProperty o1, double v)
    {
        return o1.Field > v;
    }

    public static bool operator <(IntProperty o1, double v)
    {
        return o1.Field < v;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj != null && obj != null && obj.GetType() == typeof(int))
        {
            return Field.Equals(obj);
        }

        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}