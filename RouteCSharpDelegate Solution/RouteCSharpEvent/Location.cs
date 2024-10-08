﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCSharpEvent
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Location(int _X, int _Y, int _Z)
        {
            X = _X;
            Y = _Y;
            Z = _Z;
        }
        public override string ToString() => $"( {X} , {Y} , {Z} )";

        public static bool operator ==(Location left, Location right)
            => left.Equals(right);

        public static bool operator !=(Location left, Location right)
            => !left.Equals(right);

    }
}
