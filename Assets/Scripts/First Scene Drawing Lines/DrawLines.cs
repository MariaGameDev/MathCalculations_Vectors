using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Draw;

namespace Draw {
    public class DrawLines : MonoBehaviour
    {
        // Coords point = new Coords(10, 20);

        // X and Y coords
        Coords startPoint_X = new Coords(160, 0);
        Coords endPoint_X = new Coords(-160, 0);
        Coords startPoint_Y = new Coords(0, 100);
        Coords endPoint_Y = new Coords(0, -100);

        Coords[] pisces =
        {
            new Coords(0,30),
            new Coords(10,10),
            new Coords(20, 30),
            new Coords(60, 30),
            new Coords(70, 25f),
            //new Coords(75f, 35f),
            //new Coords(65f, 50f),
            //new Coords(30f, 80f),
            //new Coords(30f, 85f),
            //new Coords(30f, 90f),
            //new Coords(30f, 95f),
            //new Coords(40f, 95f),
            //new Coords(50f, 95f),
            //new Coords(45f, 90f)

        };


        void Start()
        {// Debug.Log(point.ToString());
         //Coords.DrawPoint(new Coords(0,0), 2,Color.blue);
         //Coords.DrawPoint(point, 2, Color.gray);

            CoordinatesDraw();


            PiscesSignArray();
            PiscesSignArray();

        }


        void CoordinatesDraw()
        {
            // draw line by X axis
            Coords.DrawLine(startPoint_X, endPoint_X, 1, Color.red);

            // draw green line by Y axis
            Coords.DrawLine(startPoint_Y, endPoint_Y, 1, Color.green);
        }



        void PiscesSignArray()
        {

            foreach (Coords c in pisces)
            {
                Coords.DrawPoint(c, 2, Color.white);
            }

            Coords.DrawLine(pisces[0], pisces[1], 0.5f, Color.white);
            Coords.DrawLine(pisces[1], pisces[2], 0.5f, Color.white);
            Coords.DrawLine(pisces[2], pisces[3], 0.5f, Color.white);
            Coords.DrawLine(pisces[3], pisces[4], 0.5f, Color.white);
        }

    }
}

