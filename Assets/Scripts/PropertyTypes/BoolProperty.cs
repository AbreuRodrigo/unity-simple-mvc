using System;

[Serializable]
public class BoolProperty : ObservableProperty<bool>
{
    public BoolProperty(bool field) : base(field) { }

    //OPERATORS

    public static bool operator !(BoolProperty o1)
    {
        return !o1.Field;
    }

    public static bool operator true(BoolProperty t)
    {
        return t.Field;
    }

    public static bool operator false(BoolProperty t)
    {
        return t.Field;
    }

    public static bool operator !=(BoolProperty o1, BoolProperty o2)
    {
        return !o1.Equals(o2);
    }

    public static bool operator ==(BoolProperty o1, BoolProperty o2)
    {
        return o1.Equals(o2);
    }

    public static bool operator !=(BoolProperty o1, bool v)
    {
        return o1.Field != v;
    }

    public static bool operator ==(BoolProperty o1, bool v)
    {
        return o1.Field == v;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj != null && obj.GetType() == typeof(bool))
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