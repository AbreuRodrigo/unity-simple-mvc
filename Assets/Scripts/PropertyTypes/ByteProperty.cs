using System;

[Serializable]
public class ByteProperty : ObservableProperty<byte>
{
    public ByteProperty(byte field) : base(field) { }

    //OPERATORS

    public static ByteProperty operator +(ByteProperty obj1, ByteProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }

    public static ByteProperty operator -(ByteProperty obj1, ByteProperty obj2)
    {
        obj1.Field -= obj2.Field;
        return obj1;
    }

    public static ByteProperty operator *(ByteProperty obj1, ByteProperty obj2)
    {
        obj1.Field *= obj2.Field;
        return obj1;
    }

    public static ByteProperty operator /(ByteProperty obj1, ByteProperty obj2)
    {
        obj1.Field /= obj2.Field;
        return obj1;
    }

    public static ByteProperty operator +(ByteProperty obj1, byte v)
    {
        obj1.Field += v;
        return obj1;
    }

    public static ByteProperty operator -(ByteProperty obj1, byte v)
    {
        obj1.Field -= v;
        return obj1;
    }

    public static ByteProperty operator *(ByteProperty obj1, byte v)
    {
        obj1.Field *= v;
        return obj1;
    }

    public static ByteProperty operator /(ByteProperty obj1, byte v)
    {
        obj1.Field /= v;
        return obj1;
    }

    public static ByteProperty operator ++(ByteProperty o)
    {
        o.Field++;
        return o;
    }

    public static ByteProperty operator --(ByteProperty o)
    {
        o.Field--;
        return o;
    }

    public static bool operator !=(ByteProperty o1, ByteProperty o2)
    {
        return !o1.Equals(o2);
    }

    public static bool operator ==(ByteProperty o1, ByteProperty o2)
    {
        return o1.Equals(o2);
    }

    public static bool operator !=(ByteProperty o1, byte v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(ByteProperty o1, byte v)
    {
        return o1.Field == v;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj != null && obj.GetType() == typeof(int))
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