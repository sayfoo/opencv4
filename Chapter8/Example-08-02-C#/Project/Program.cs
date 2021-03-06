﻿using System;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using Tesseract;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static double Angle(OpenCvSharp.Point pt1, OpenCvSharp.Point pt0, OpenCvSharp.Point pt2)
        {
            double u1 = pt1.X - pt0.X;
            double u2 = pt1.Y - pt0.Y;
            double v1 = pt2.X - pt0.X;
            double v2 = pt2.Y - pt0.Y;

            return (u1 * v1 + u2 * v2) / (Math.Sqrt(u1 * u1 + u2 * u2) * Math.Sqrt(v1 * v1 + v2 * v2));
        }
    }
}