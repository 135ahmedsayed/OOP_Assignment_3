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

#region Q5
public class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Message from BaseClass");
    }
}
public class DerivedClass1 : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Message from BaseClass");
    }
}
public class DerivedClass2 : BaseClass
{
    public new void Display()
    {
        Console.WriteLine("Message from BaseClass");
    }
}
#endregion
#endregion

#region With Part(2)
public class Duration
{
    //Function Convert from Seconds to Hours,Minutes,Seconds
    internal static void ConvertTimebySeconds(Duration d, int S)
    {
        d.hours = S / 3600;
        S %= 3600;
        d.minutes = S / 60;
        d.seconds = S % 60;
    }
    public int hours;
    public int minutes;
    public int seconds;
    // Default constructor that initializes the duration to 0 hours, 0 minutes, and 0 seconds.
    public Duration()
    {
        hours = 0;
        minutes = 0;
        seconds = 0;
    }
    public Duration(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }
    // Override ToString method 
    public override string ToString()
    {
        return $"Hours: {hours} , Minutes : {minutes} , Seconds : {seconds} ";
    }
    // Override Equals method
    public override bool Equals(Object obj)
    {
        Duration duration = (Duration)obj;
        if (duration == null)
            return false;
        return this.hours == duration.hours && this.minutes == duration.minutes && this.seconds == duration.seconds;
    }
    // Override GetHashCode method
    public override int GetHashCode()
    {
        return (hours, minutes, seconds).GetHashCode();
    }
    // Calculates Hours , Minutes and Seconds by Seconds
    public Duration(int Seconds)
    {
        hours = Seconds / 3600;
        Seconds %= 3600;
        minutes = Seconds / 60;
        seconds = Seconds % 60;
    }
    // Override the addition operator to add two Duration objects
    public static Duration operator +(Duration left, Duration right)
    {
        return new Duration(left.hours + right.hours, left.minutes + right.minutes, left.seconds + right.seconds);
    }
    public static Duration operator +(Duration left, int Seconds)
    {
        Duration right = new Duration();
        ConvertTimebySeconds(right, Seconds);
        return new Duration(left.hours + right.hours, left.minutes + right.minutes, left.seconds + right.seconds);
    }
    public static Duration operator +(int Seconds, Duration right)
    {
        Duration left = new Duration();
        ConvertTimebySeconds(left, Seconds);
        return new Duration(left.hours + right.hours, left.minutes + right.minutes, left.seconds + right.seconds);
    }
    public static Duration operator ++(Duration right)
    {
        return new Duration(right.hours, right.minutes + 1, right.seconds);
    }
    public static Duration operator --(Duration right)
    {
        return new Duration(right.hours, right.minutes - 1, right.seconds);
    }
    public static Duration operator -(Duration left, Duration right)
    {
        return new Duration(left.hours - right.hours, left.minutes - right.minutes, left.seconds - right.seconds);
    }
    public static bool operator >(Duration left, Duration right)
    {
        if (left.hours < right.hours)
            return false;
        else if (left.hours == right.hours && left.minutes < right.minutes)
            return false;
        else if (left.hours == right.hours && left.minutes == right.minutes && left.seconds < right.seconds)
            return false;
        else if (left.hours == right.hours && left.minutes == right.minutes && left.seconds == right.seconds)
            return false;
        return true;

    }
    public static bool operator <(Duration left, Duration right)
    {
        if (left.hours > right.hours)
            return false;
        else if (left.hours == right.hours && left.minutes > right.minutes)
            return false;
        else if (left.hours == right.hours && left.minutes == right.minutes && left.seconds > right.seconds)
            return false;
        return true;
    }
    public static implicit operator bool(Duration D)
    {
        return (D.hours >= 0) && (D.minutes >= 0) && (D.seconds >= 0);
    }
    public static explicit operator DateTime(Duration D)
    {

        return DateTime.MinValue
         .AddHours(D.hours)
         .AddMinutes(D.minutes)
         .AddSeconds(D.seconds);
    }


}
#endregion

