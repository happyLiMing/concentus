﻿using Concentus.Common.CPlusPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concentus.Structs
{
    internal class ChannelLayout
    {
        internal int nb_channels;
        internal int nb_streams;
        internal int nb_coupled_streams;
        internal readonly byte[] mapping = new byte[256];

        internal void Reset()
        {
            nb_channels = 0;
            nb_streams = 0;
            nb_coupled_streams = 0;
            Arrays.MemSet<byte>(mapping, 0);
        }
    }
}
