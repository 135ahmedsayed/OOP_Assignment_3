namespace OOP_Assignment_03;

#region With Part(1)
#region Q2
public class Rectangle
{
    private int width;
    private int height;

    //●	A parameterless constructor that sets the width and height to 0.
    public Rectangle()
    {
        width = 0;
        height = 0;
    }
    //●	A constructor that accepts width and height as integers.
    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }
    //●	A constructor that accepts a single integer and sets both width and height to that value.
    public Rectangle(int value)
    {
        width = value;
        height = value;
    }
    public string Rectangle1nfo
    {
        get
        {
            return $"Width: {width}, Height: {height}";
        }
    }
}
#endregion

#region Q3
public class Complex
{
    public int real;
    public int imag;
    public Complex()
    {
        real = 0;
        imag = 0;
    }
    public Complex(int real, int imag)
    {
        this.real = real;
        this.imag = imag;
    }
    public override string ToString()
    {
        return $"complex number = {real} + {imag}i ";
    }
    // Overloading the + operator to add two complex numbers
    public static Complex operator +(Complex left, Complex right)
    {
        return new Complex(left.real + right.real, left.imag + right.imag);
    }
    // Overloading the - operator to subtract two complex numbers
    public static Complex operator -(Complex left, Complex right)
    {
        return new Complex(left.real - right.real, left.imag - right.imag);
    }
}
#endregion

#region Q4
public class Employee
{
    public virtual void work()
    {
        Console.WriteLine("Employee is working");
    }
}
public class Manager : Employee
{
    public override void work()
    {
        base.work(); // Calls the work method of the Employee class
        Console.WriteLine("Manager is managing");
    }
}

#endregion
#endregion

