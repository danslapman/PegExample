﻿using System;
using JsonParser;

namespace JsonUser
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new Parser();
            var obj = parser.ParseAll(
@"[
    {
        ""foo"" : null,
        ""array"" : [
            null,
            ""a"",
            ""b""
        ]
    },
    ""foo""
]");
            if (obj == null) Console.WriteLine("null");
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
