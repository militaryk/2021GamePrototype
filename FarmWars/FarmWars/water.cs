﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmWars
{
    class water
    {
        public int width;
        public int height;
        public int y;
        public int x;
        public int waterchance;
        public int PosX;
        public int PosY;
        public int LX;
        public int LY;
        public int RX;
        public int RY;
        public int UX;
        public int UY;
        public int DX;
        public int DY;
        bool newlake = true;
        Image newImage = Image.FromFile("../../../Art/ground/water.jpg");


        public void DrawWater(Graphics g)
        {
            Random water = new Random();
            int waterchance = water.Next(1, 100);

            if (waterchance == 1)
            {
                WaterCentre(g);

            }

        }

        private void WaterCentre(Graphics g)
        {
            //Define the solid brush with a default colour of orange
            SolidBrush br = new SolidBrush(Color.SandyBrown);

            //Define the pen with the colour black
            Pen pen1 = new Pen(Color.Black);


            if (newlake == true)
            {
                //Calcualte the X and Y of each indervidual square
                PosX = width * x;
                PosY = height * y;


                // Create rectangle for ellipse.
                Rectangle rect = new Rectangle(PosX, PosY, width, height);
                g.DrawImage(newImage, rect);

                newlake = false;
            }

            GetNearest();


            Random waternext = new Random();
            int waternextchance = waternext.Next(0, 4);

            if (waternextchance == 1)
            {
                WaterLeft(g);

            }
        }
        private void WaterLeft(Graphics g)
        {
            //For Left
            //Calcualte the X and Y of each indervidual square

            PosX = width * LX;
            PosY = height * LY;

            // Create rectangle for ellipse.
            Rectangle rectL = new Rectangle(PosX, PosY, width, height);

            g.DrawImage(newImage, rectL);

            WaterCentre(g);


        }


        private void GetNearest()
        {
            LX = x - 1;
            LY = y;
            RX = x + 1;
            RY = y;
            UX = x;
            UY = y + 1;
            DX = x;
            DY = y - 1;
        }
    }
}