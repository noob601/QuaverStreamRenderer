﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQSConsole
{
    internal static class Shared
    {
        public static readonly uint[] Color = new uint[96]
        {
            0xFF3366FF, 0xFFFF7E33, 0xFF33FF66, 0xFFFF3381, 0xFF33E1E1, 0xFFE433E1,
            0xFF99E133, 0xFF4B33E1, 0xFFFFCC33, 0xFF33B4FF, 0xFFFF3333, 0xFF33FFB1,
            0xFFFF33CC, 0xFF4EFF33, 0xFF9933FF, 0xFFE7FF33, 0xFF3366FF, 0xFFFF7E33,
            0xFF33FF66, 0xFFFF3381, 0xFF33E1E1, 0xFFE433E1, 0xFF99E133, 0xFF4B33E1,
            0xFFFFCC33, 0xFF33B4FF, 0xFFFF3333, 0xFF33FFB1, 0xFFFF33CC, 0xFF4EFF33,
            0xFF9933FF, 0xFFE7FF33, 0xFF3366FF, 0xFFFF7E33, 0xFF33FF66, 0xFFFF3381,
            0xFF33E1E1, 0xFFE433E1, 0xFF99E133, 0xFF4B33E1, 0xFFFFCC33, 0xFF33B4FF,
            0xFFFF3333, 0xFF33FFB1, 0xFFFF33CC, 0xFF4EFF33, 0xFF9933FF, 0xFFE7FF33,
            0xFF3366FF, 0xFFFF7E33, 0xFF33FF66, 0xFFFF3381, 0xFF33E1E1, 0xFFE433E1,
            0xFF99E133, 0xFF4B33E1, 0xFFFFCC33, 0xFF33B4FF, 0xFFFF3333, 0xFF33FFB1,
            0xFFFF33CC, 0xFF4EFF33, 0xFF9933FF, 0xFFE7FF33, 0xFF3366FF, 0xFFFF7E33,
            0xFF33FF66, 0xFFFF3381, 0xFF33E1E1, 0xFFE433E1, 0xFF99E133, 0xFF4B33E1,
            0xFFFFCC33, 0xFF33B4FF, 0xFFFF3333, 0xFF33FFB1, 0xFFFF33CC, 0xFF4EFF33,
            0xFF9933FF, 0xFFE7FF33, 0xFF3366FF, 0xFFFF7E33, 0xFF33FF66, 0xFFFF3381,
            0xFF33E1E1, 0xFFE433E1, 0xFF99E133, 0xFF4B33E1, 0xFFFFCC33, 0xFF33B4FF,
            0xFFFF3333, 0xFF33FFB1, 0xFFFF33CC, 0xFF4EFF33, 0xFF9933FF, 0xFFE7FF33
        };

        public const char ProgressFill = '█';
        public const char ProgressBegin = '├';
        public const char ProgressEnd = '┤';
    }
}
