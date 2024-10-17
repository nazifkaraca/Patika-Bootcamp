using System;

namespace Polymorphism
{
	public class BaseGeometricShape
	{
		public int Height { get; set; }
		public int Width { get; set; }

        // Create a constructor for ease
        public BaseGeometricShape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        // Create a method to calculate area
        public virtual double CalculateArea()
        {
            return Height * Width;
        }
    }

    // Calculation for square
	public sealed class Square : BaseGeometricShape
	{
        // A side information is enough for square
        public Square(int side) : base(side, side) { }
    }

    // Calculation for rectangle
    public sealed class Rectangle : BaseGeometricShape 
    {
        public Rectangle(int height, int width) : base(height, width) { }
    }

    // Calculation for right angled triangle
	public sealed class RightTriangle : BaseGeometricShape
	{
        public RightTriangle(int height, int width) : base(height, width) { }

        // Override base method for right triangle area
        public override double CalculateArea() 
        {
            return Height * Width / 2.0;
        }
    }
}
