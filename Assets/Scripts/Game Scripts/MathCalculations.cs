﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathCalculations 
{
    //here is implemented a method that gives a NORMAL of given Vector
    static public Coords GetNormal(Coords vector)
    {
        //Vector normal = ((vx/vectorMagnitude), (vy/vectorMagnitude));
        float lenght = Distance(new Coords(0, 0, 0), vector);
        vector.x /= lenght;
        vector.y /= lenght;
        vector.z /= lenght;

        return vector;
    }

    static public float Distance(Coords point1, Coords point2)
    {
        // length of Vector (vectorMagnitude) = Mathf.Sqrt(x2 + y2); -> 2 = sqr
        float diffSquared = Square(point1.x - point2.x) +
                            Square(point1.y - point2.y) +
                            Square(point1.z - point2.z);
        float squareRoot = Mathf.Sqrt(diffSquared);
        return squareRoot;
       
    }

    static public float Square(float value)
    {
        return value * value;
    }

    static public float DotProduct(Coords vector1, Coords vector2)
    {
        //(v.x*w.x) + (v.y * w.y)
        return (vector1.x * vector2.x) + (vector1.y * vector2.y) + (vector1.z * vector2.z);
    }

    static public float Angle(Coords vector1, Coords vector2)
    {
        //0=cos-1(v*w/ ||v|| ||w||)
        float dotDivide = DotProduct(vector1, vector2) / 
            (Distance(new Coords(0, 0, 0), vector1) * Distance(new Coords(0, 0, 0), vector2));
        return Mathf.Acos(dotDivide); //it return radians. for degrees * 180/Mathf.PI
    }
}
