using System;

[Serializable]
public class DoubleProperty : ObservableProperty<double>
{
    public DoubleProperty(double field) : base(field) { }

    //OPERATORS

    public static DoubleProperty operator +(DoubleProperty obj1, DoubleProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, DoubleProperty obj2)
    {
        obj1.Field -= obj2.Field;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, DoubleProperty obj2)
    {
        obj1.Field *= obj2.Field;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, DoubleProperty obj2)
    {
        obj1.Field /= obj2.Field;
        return obj1;
    }

    public static DoubleProperty operator ++(DoubleProperty o)
    {
        o.Field++;
        return o;
    }

    public static DoubleProperty operator --(DoubleProperty o)
    {
        o.Field--;
        return o;
    }

    public static bool operator !=(DoubleProperty o1, DoubleProperty o2)
    {
        return o1.Field != o2.Field;
    }

    public static bool operator ==(DoubleProperty o1, DoubleProperty o2)
    {
        return o1.Field == o2.Field;
    }
        
    public static DoubleProperty operator +(DoubleProperty obj1, double v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, double v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, double v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, double v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static DoubleProperty operator +(DoubleProperty obj1, int v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, int v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, int v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, int v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static DoubleProperty operator +(DoubleProperty obj1, short v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, short v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, short v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, short v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static DoubleProperty operator +(DoubleProperty obj1, float v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, float v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, float v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, float v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static DoubleProperty operator +(DoubleProperty obj1, long v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static DoubleProperty operator -(DoubleProperty obj1, long v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static DoubleProperty operator *(DoubleProperty obj1, long v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static DoubleProperty operator /(DoubleProperty obj1, long v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static bool operator !=(DoubleProperty o1, double v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(DoubleProperty o1, double v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(DoubleProperty o1, int v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(DoubleProperty o1, int v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(DoubleProperty o1, float v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(DoubleProperty o1, float v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(DoubleProperty o1, short v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(DoubleProperty o1, short v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(DoubleProperty o1, long v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(DoubleProperty o1, long v)
    {
        return o1.Field == v;
    }
    
    #region >= <=
    public static bool operator <=(DoubleProperty o1, int v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(DoubleProperty o1, int v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(DoubleProperty o1, float v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(DoubleProperty o1, float v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(DoubleProperty o1, double v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(DoubleProperty o1, double v)
    {
        return o1.Field >= v;
    }

    public static bool operator >=(DoubleProperty o1, short v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(DoubleProperty o1, short v)
    {
        return o1.Field <= v;
    }

    public static bool operator >=(DoubleProperty o1, long v)
    {
        return o1.Field >= v;
    }

    public static bool operator <=(DoubleProperty o1, long v)
    {
        return o1.Field <= v;
    }

    #endregion >= <=

    public static bool operator >(DoubleProperty o1, DoubleProperty o2)
    {
        return o1.Field > o2.Field;
    }

    public static bool operator <(DoubleProperty o1, DoubleProperty o2)
    {
        return o1.Field < o2.Field;
    }

    public static bool operator >(DoubleProperty o1, int v)
    {
        return o1.Field > v;
    }

    public static bool operator <(DoubleProperty o1, int v)
    {
        return o1.Field < v;
    }

    public static bool operator >(DoubleProperty o1, float v)
    {
        return o1.Field > v;
    }

    public static bool operator <(DoubleProperty o1, float v)
    {
        return o1.Field < v;
    }

    public static bool operator >(DoubleProperty o1, short v)
    {
        return o1.Field > v;
    }

    public static bool operator <(DoubleProperty o1, short v)
    {
        return o1.Field < v;
    }

    public static bool operator >(DoubleProperty o1, long v)
    {
        return o1.Field > v;
    }

    public static bool operator <(DoubleProperty o1, long v)
    {
        return o1.Field < v;
    }

    public static bool operator >(DoubleProperty o1, double v)
    {
        return o1.Field > v;
    }

    public static bool operator <(DoubleProperty o1, double v)
    {
        return o1.Field < v;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj.GetType() == typeof(int))
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