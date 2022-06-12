﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Application.Common.Interfaces
{
    public interface IFileWrapper
    {
        void WriteAllBytes(string outputFile, byte[] content);
    }
}
