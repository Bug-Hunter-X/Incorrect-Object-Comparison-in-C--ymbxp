using System;

public class MyClass : IEquatable<MyClass>
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(10);
        MyClass obj2 = new MyClass(10);

        // Correct comparison using Equals()
        if (obj1.Equals(obj2))
        {
            Console.WriteLine("Objects are equal");
        }
        else
        {
            Console.WriteLine("Objects are not equal");
        }
    }

    public bool Equals(MyClass other)
    {
        if (other is null) return false;
        return this.MyProperty == other.MyProperty;
    }
    public override bool Equals(object obj)
    {
        return Equals(obj as MyClass);
    }
    public override int GetHashCode()
    {
        return MyProperty.GetHashCode();
    }
}