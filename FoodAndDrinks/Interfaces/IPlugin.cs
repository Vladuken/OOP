﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPlugin
    {
        String PName();
        String GetExtention();
        void Transform(string filename);
    }
}
