﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Movies
{   
    record Settings;
    internal class MoviePlayer
    {
        Settings settings;

        Settings Settings { get; }
    }
}
