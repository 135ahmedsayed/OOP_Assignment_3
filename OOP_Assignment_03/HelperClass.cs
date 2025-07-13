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
#endregion

