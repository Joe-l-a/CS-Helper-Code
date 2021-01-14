using System;

namespace CSHelpers
{
    public static class ConsoleMap
    {
        class ConsoleMap
        {
            private char[,] map;

            public ConsoleMap()
            {

            }

            public this[int x, int y] { get => map[x,y]; set => map[x,y] = value; }

            public void Push()
            {

            }

            
        }
    }
}
