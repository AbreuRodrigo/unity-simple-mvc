using System;

[Serializable]
public class ShortProperty : ObservableProperty<short>
{
    public ShortProperty(short field) : base(field) { }

    //OPERATORS

    public static ShortProperty operator +(ShortProperty obj1, ShortProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, ShortProperty obj2)
    {
        obj1.Field -= obj2.Field;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, ShortProperty obj2)
    {
        obj1.Field *= obj2.Field;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, ShortProperty obj2)
    {
        obj1.Field /= obj2.Field;
        return obj1;
    }

    public static ShortProperty operator +(ShortProperty obj1, short v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, short v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, short v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, short v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static ShortProperty operator +(ShortProperty obj1, long v)
    {
        obj1.Field += (short)v;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, long v)
    {
        obj1.Field -= (short)v;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, long v)
    {
        obj1.Field *= (short)v;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, long v)
    {
        obj1.Field /= (short)v;
        return obj1;
    }

    public static ShortProperty operator +(ShortProperty obj1, int v)
    {
        obj1.Field += (short)v;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, int v)
    {
        obj1.Field -= (short)v;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, int v)
    {
        obj1.Field *= (short)v;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, int v)
    {
        obj1.Field /= (short)v;
        return obj1;
    }

    public static ShortProperty operator +(ShortProperty obj1, float v)
    {
        obj1.Field += (short)v;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, float v)
    {
        obj1.Field -= (short)v;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, float v)
    {
        obj1.Field *= (short)v;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, float v)
    {
        obj1.Field /= (short)v;
        return obj1;
    }

    public static ShortProperty operator +(ShortProperty obj1, double v)
    {
        obj1.Field += (short)v;
        return obj1;
    }

    public static ShortProperty operator -(ShortProperty obj1, double v)
    {
        obj1.Field -= (short)v;
        return obj1;
    }

    public static ShortProperty operator *(ShortProperty obj1, double v)
    {
        obj1.Field *= (short)v;
        return obj1;
    }

    public static ShortProperty operator /(ShortProperty obj1, double v)
    {
        obj1.Field /= (short)v;
        return obj1;
    }

    public static ShortProperty operator ++(ShortProperty o)
    {
        o.Field++;
        return o;
    }

    public static ShortProperty operator --(ShortProperty o)
    {
        o.Field--;
        return o;
    }

    public static bool operator !=(ShortProperty o1, ShortProperty o2)
    {
        return !o1.Equals(o2);
    }

    public static bool operator ==(ShortProperty o1, ShortProperty o2)
    {
        return o1.Equals(o2);
    }

    public static bool operator !=(ShortProperty o1, short v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ShortProperty o1, short v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(ShortProperty o1, int v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ShortProperty o1, int v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(ShortProperty o1, float v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ShortProperty o1, float v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(ShortProperty o1, double v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ShortProperty o1, double v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(ShortProperty o1, long v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ShortProperty o1, long v)
    {
        return o1.Field == v;
    }

    public static bool operator >(ShortProperty o1, ShortProperty o2)
    {
        return o1.Field > o2.Field;
    }

    public static bool operator <(ShortProperty o1, ShortProperty o2)
    {
        return o1.Field < o2.Field;
    }

    public static bool operator >(ShortProperty o1, int v)
    {
        return o1.Field > v;
    }

    public static bool operator <(ShortProperty o1, int v)
    {
        return o1.Field < v;
    }

    public static bool operator >(ShortProperty o1, float v)
    {
        return o1.Field > v;
    }

    public static bool operator <(ShortProperty o1, float v)
    {
        return o1.Field < v;
    }

    public static bool operator >(ShortProperty o1, short v)
    {
        return o1.Field > v;
    }

    public static bool operator <(ShortProperty o1, short v)
    {
        return o1.Field < v;
    }

    public static bool operator >(ShortProperty o1, long v)
    {
        return o1.Field > v;
    }

    public static bool operator <(ShortProperty o1, long v)
    {
        return o1.Field < v;
    }

    public static bool operator >(ShortProperty o1, double v)
    {
        return o1.Field > v;
    }

    public static bool operator <(ShortProperty o1, double v)
    {
        return o1.Field < v;
    }

    #region >= <=
    public static bool operator <=(ShortProperty o1, int v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(ShortProperty o1, int v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(ShortProperty o1, float v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(ShortProperty o1, float v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(ShortProperty o1, double v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(ShortProperty o1, double v)
    {
        return o1.Field >= v;
    }

    public static bool operator >=(ShortProperty o1, short v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(ShortProperty o1, short v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(ShortProperty o1, long v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(ShortProperty o1, long v)
    {
        return o1.Field <= v;
    }

    #endregion >= <=

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj != null && obj.GetType() == typeof(short))
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