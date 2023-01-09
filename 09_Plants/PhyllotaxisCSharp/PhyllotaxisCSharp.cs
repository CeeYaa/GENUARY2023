using System;
using System.Collections.Generic;
using Stride.Core.Mathematics;

namespace PhyllotaxisCSharp
{
    public static class MyPhyllotaxisNodes
    {
        public static Vector2[] GeneratePhyllotaxis(int numPoints, double size, double angleIncrement)
        {
            // Set the initial angle
            double angle = 0;

            // Create a list to store the points
            List<Vector2> points = new List<Vector2>();

            // Iterate over the points and calculate the x and y coordinates
            for (int i = 0; i < numPoints; i++)
            {
                double r = size * Math.Sqrt(i);
                double theta = angle * (Math.PI / 180);
                float x = (float)(r * Math.Cos(theta));
                float y = (float)(r * Math.Sin(theta));

                // Add the point to the list
                points.Add(new Vector2(x, y));

                // Increment the angle
                angle += angleIncrement;
            }

            // Return the array of points
            return points.ToArray();
        }
    }    
}
