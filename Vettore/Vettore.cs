using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettore
{
    internal class Vettore
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Modulo()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }
        public static Vettore Parse(string s)
        {
            string[] strings = s.Split(';');
            return new Vettore(double.Parse(strings[0]), double.Parse(strings[1]));
        }
        public static Vettore operator+(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vettore operator-(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static double operator*(Vettore v1, Vettore v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
        public static Vettore operator*(Vettore v1, double s)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }
        public static Vettore operator*(double s, Vettore v1)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }
        public static Vettore operator/(Vettore v1, double s)
        {
            return new Vettore(v1.X / s, v1.Y / s);
        }
        public static Vettore operator+(Vettore v1)
        {
            return v1;
        }
        public static Vettore operator-(Vettore v1)
        {
            return new Vettore(-v1.X, -v1.Y);
        }
    }
}
