using System;
using System.Collections.Generic;

namespace Lemure
{
    class Program
    {

        static bool IsVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u';
        static string GetWeightCategory(decimal bmi) => bmi switch
        {
            < 18.5m => "underweight",
            < 25m => "normal",
            < 30m => "overweight",
            _ => "obese"
        };

        enum Dimension
        {
            OneDimension,
            TwoDimension,
            ThreeDimension,
            NthDimension,
        }

        class Plan
        {
            public readonly Dimension _dimension;
            public Point Point { get; protected set; }
            private static List<Point> _points { get; set; }
            internal Plan(Dimension dimension, Point point)
            {
                _dimension = dimension;
                Point = point;
                _points = new();
                _points.Add(point);
            }

            public static void GetPoints()
            {
                Console.WriteLine($"----------------------------");
                foreach(var point in _points)
                {
                    Console.WriteLine($"Static List -> {point.ToString()}");
                }
                Console.WriteLine($"----------------------------");
            }

            public void SetPoint(Point point)
            {
                _points.Add(point);
                Point = point;
            }

            public void GetPoint()
            {
                Console.WriteLine(Point.ToString());
            }

        }

        class Point
        {
            private readonly decimal _x;
            private readonly decimal _y;
            internal Point(decimal x, decimal y){
                _x = x;
                _y = y;
            }

            public override bool Equals(Object obj)
            {
                if(obj is not Point) return false;

                var point = obj as Point;

                if((_x == point._x) && (_y == point._y))
                {
                    return true;
                }

                return false;
            }

            public override string ToString()
            {
                return $"x: {_x} & Y: {_y}";
            }
        }


        static void Main(string[] args)
        {
            Point a1 = new(23.392873456m, 3.45674567m);
            Point a2 = new(2.0m, 3.4m);
            Point a3 = new(25.392873456m, 3.45674567m);
            Point a4 = new(26.392873456m, 3.45674567m);
            Point a5 = new(58.345673456m, 3.45674567m);

            Plan p = new(Dimension.TwoDimension, a1);
            p.GetPoint();
            Plan.GetPoints();

            p.SetPoint(a2);
            Plan.GetPoints();

            p.SetPoint(a3);
            Plan.GetPoints();

            p.SetPoint(a4);
            Plan.GetPoints();

            p.SetPoint(a5);
            Plan.GetPoints();
            
        }
    }
}
