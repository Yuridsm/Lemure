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

        private string ConvertStr(string str, char pattern)
        {
            return str;//.Replace('\\', '');
        }


        static void Main(string[] args)
        {
            var s = "{\"Guid\":\"00000000-0000-0000-0000-000000000000\",\"Name\":\"First SecurityContext\",\"DefaultTimestamperld\":\"1d1befba-5833-4fdd-ba74-5985aa554826\",\"TrustedItems\":[\"cbf29b73-5ef4-4cf9-b089-13db45dca991\",\"cefdb1d4-9add-4cc1-b7f0-2709e87ec6ee\"],\"AlgorithmConfigGuid\":\"d4a83bd8-db5c-4375-9f34-c2c09d4561e5\"}";
            Console.WriteLine(s.Replace("\\", ""));
        }
    }
}
