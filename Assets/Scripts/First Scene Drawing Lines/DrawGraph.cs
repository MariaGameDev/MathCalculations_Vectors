using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Draw {
    public class DrawGraph : MonoBehaviour
    {

        [SerializeField] private int size = 20;

        [SerializeField] private int Xmax = 160;
        [SerializeField] private int Ymax = 100;
        // X and Y coords
        Coords startPoint_X;
        Coords endPoint_X;
        Coords startPoint_Y;
        Coords endPoint_Y;

        private void Start()
        {
            startPoint_X = new Coords(Xmax, 0);
            endPoint_X = new Coords(-Xmax, 0);

            startPoint_Y = new Coords(0, Ymax);
            endPoint_Y = new Coords(0, -Ymax);

            CoordinatesDraw();
            GraphDraw();
        }

        void CoordinatesDraw()
        {
            // draw line by X axis
            Coords.DrawLine(startPoint_X, endPoint_X, 1.5f, Color.red);

            // draw green line by Y axis
            Coords.DrawLine(startPoint_Y, endPoint_Y, 1.5f, Color.green);

        }

        void GraphDraw()
        {
            int xOffset = (int)(160 / (float)size);
            for (int x = -xOffset * size; x <= xOffset * size; x += size)
            {
                Coords.DrawLine(new Coords(x, -Ymax), new Coords(x, Ymax), 0.5f, Color.white);
            }

            int yOffset = (int)(100 / (float)size);
            for (int y = -yOffset * size; y <= yOffset * size; y += size)
            {
                Coords.DrawLine(new Coords(-Xmax, y), new Coords(Xmax, y), 0.5f, Color.white);
            }


        }

    }
}

