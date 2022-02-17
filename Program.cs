// See https://aka.ms/new-console-template for more information
using System;
public interface Drawable
{
    void draw();
}
public class Rectangle : Drawable                    //creating interface with base class for Rectangle
{
    public void draw()
    {
        Console.WriteLine("drawing rectangle...");     //printing Drwaing recatangle
    }
}
public class Circle : Drawable                          //creating interface with base class for Circle
{
    public void draw()
    {
        Console.WriteLine("drawing circle...");         //printing drawing circle
    }
}
public class TestInterface                             //creating a public tst class
{
    public static void Main()
    {
        Drawable d;
        d = new Rectangle();
        d.draw();
        d = new Circle();
        d.draw();
    }
}




