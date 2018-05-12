using System;

[Serializable]
public class StringProperty : ObservableProperty<string>
{
    public StringProperty(string field) : base(field) { }

    //OPERATORS

    public static StringProperty operator +(StringProperty obj1, StringProperty obj2)
    {
        obj1.Field += obj2.Field;
        return obj1;
    }
    
    public static StringProperty operator +(StringProperty obj1, string v)
    {
        obj1.Field += v;
        return obj1;
    }

    public override string ToString()
    {
        return Field.ToString();
    }

    public override bool Equals(object obj)
    {
        if (obj.GetType() == typeof(string))
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