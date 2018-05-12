using System;

[Serializable]
public class CharProperty : ObservableProperty<char>
{
    public CharProperty(char field) : base(field) { }

    //OPERATORS

    public static CharProperty operator +(CharProperty obj1, CharProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, CharProperty obj2)
    {
        obj1.Field -= obj2.Field;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, CharProperty obj2)
    {
        obj1.Field *= obj2.Field;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, CharProperty obj2)
    {
        obj1.Field /= obj2.Field;
        return obj1;
    }

    public static CharProperty operator +(CharProperty obj1, int v)
    {
        obj1.Field += (char)v;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, int v)
    {
        obj1.Field -= (char)v;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, int v)
    {
        obj1.Field *= (char)v;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, int v)
    {
        obj1.Field /= (char)v;
        return obj1;
    }

    public static CharProperty operator +(CharProperty obj1, float v)
    {
        obj1.Field += (char)v;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, float v)
    {
        obj1.Field -= (char)v;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, float v)
    {
        obj1.Field *= (char)v;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, float v)
    {
        obj1.Field /= (char)v;
        return obj1;
    }

    public static CharProperty operator +(CharProperty obj1, double v)
    {
        obj1.Field += (char)v;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, double v)
    {
        obj1.Field -= (char)v;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, double v)
    {
        obj1.Field *= (char)v;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, double v)
    {
        obj1.Field /= (char)v;
        return obj1;
    }

    public static CharProperty operator +(CharProperty obj1, long v)
    {
        obj1.Field += (char)v;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, long v)
    {
        obj1.Field -= (char)v;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, long v)
    {
        obj1.Field *= (char)v;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, long v)
    {
        obj1.Field /= (char)v;
        return obj1;
    }

    public static CharProperty operator +(CharProperty obj1, short v)
    {
        obj1.Field += (char)v;
        return obj1;
    }

    public static CharProperty operator -(CharProperty obj1, short v)
    {
        obj1.Field -= (char)v;
        return obj1;
    }

    public static CharProperty operator *(CharProperty obj1, short v)
    {
        obj1.Field *= (char)v;
        return obj1;
    }

    public static CharProperty operator /(CharProperty obj1, short v)
    {
        obj1.Field /= (char)v;
        return obj1;
    }

    public static CharProperty operator ++(CharProperty o)
    {
        o.Field++;
        return o;
    }

    public static CharProperty operator --(CharProperty o)
    {
        o.Field--;
        return o;
    }

    public static bool operator !=(CharProperty o1, CharProperty o2)
    {
        return o1.Field != o2.Field;
    }

    public static bool operator ==(CharProperty o1, CharProperty o2)
    {
        return o1.Field == o2.Field;
    }

    public static bool operator !=(CharProperty o1, int v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(CharProperty o1, int v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(CharProperty o1, float v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(CharProperty o1, float v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(CharProperty o1, double v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(CharProperty o1, double v)
    {
        return o1.Field == v;
    }
    
    public static bool operator !=(CharProperty o1, long v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(CharProperty o1, long v)
    {
        return o1.Field == v;
    }

    public static bool operator !=(CharProperty o1, short v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(CharProperty o1, short v)
    {
        return o1.Field == v;
    }

    public static bool operator >(CharProperty o1, CharProperty o2)
    {
        return o1.Field > o2.Field;
    }

    public static bool operator <(CharProperty o1, CharProperty o2)
    {
        return o1.Field < o2.Field;
    }

    public static bool operator >(CharProperty o1, int v)
    {
        return o1.Field > v;
    }

    public static bool operator <(CharProperty o1, int v)
    {
        return o1.Field < v;
    }

    public static bool operator >(CharProperty o1, float v)
    {
        return o1.Field > v;
    }

    public static bool operator <(CharProperty o1, float v)
    {
        return o1.Field < v;
    }

    public static bool operator >(CharProperty o1, short v)
    {
        return o1.Field > v;
    }

    public static bool operator <(CharProperty o1, short v)
    {
        return o1.Field < v;
    }

    public static bool operator >(CharProperty o1, long v)
    {
        return o1.Field > v;
    }

    public static bool operator <(CharProperty o1, long v)
    {
        return o1.Field < v;
    }

    public static bool operator >(CharProperty o1, double v)
    {
        return o1.Field > v;
    }

    public static bool operator <(CharProperty o1, double v)
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