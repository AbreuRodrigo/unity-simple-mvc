using System;

[Serializable]
public class BoolProperty : ObservableProperty<bool>
{
    public BoolProperty(bool field) : base(field) { }

    //OPERATORS

    public static bool operator !=(BoolProperty obj1, BoolProperty obj2)
    {
        return obj1.Field != obj2.Field;
    }

    public static bool operator ==(BoolProperty obj1, BoolProperty obj2)
    {
        return obj1.Field == obj2.Field;
    }

    public static bool operator !=(BoolProperty obj1, bool v)
    {
        return obj1.Field != v;
    }

    public static bool operator ==(BoolProperty obj1, bool v)
    {
        return obj1.Field == v;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj.GetType() == typeof(bool))
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