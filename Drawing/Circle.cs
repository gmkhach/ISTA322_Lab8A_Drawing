﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : iDraw, iColor
    {
        public Circle(int diameter)
        {
            this.diameter = diameter;
        }

        private int diameter;
        private int locX = 0, locY = 0;
        private Ellipse circle = null;

        void iDraw.SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }


        void iDraw.Draw(Canvas canvas)
        {
            if (this.circle != null)
            {
                canvas.Children.Remove(this.circle);
            }
            else
            {
                this.circle = new Ellipse();
            }
            this.circle.Height = this.diameter;
            this.circle.Width = this.diameter;
            Canvas.SetTop(this.circle, this.locY);
            Canvas.SetLeft(this.circle, this.locX);
            canvas.Children.Add(this.circle);
        }

        void iColor.SetColor(Color color)
        {
            if (this.circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;
            }
        }
    }
}
