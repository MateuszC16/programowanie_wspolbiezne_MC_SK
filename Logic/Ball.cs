﻿public class Ball
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }
    public double VelocityX { get; set; }
    public double VelocityY { get; set; }

    public Ball(double x, double y, double radius, double velocityX, double velocityY)
    {
        X = x;
        Y = y;
        Radius = radius;
        VelocityX = velocityX;
        VelocityY = velocityY;
    }

    public void Move(double timeToMove)
    {
        X += VelocityX * timeToMove;
        Y += VelocityY * timeToMove;
    }

    public void Bounce(double width, double height)
    {
        if (X - Radius <= 0 || X + Radius >= width) VelocityX = -VelocityX;
        if (Y - Radius <= 0 || Y + Radius >= height) VelocityY = -VelocityY;
    }
}
