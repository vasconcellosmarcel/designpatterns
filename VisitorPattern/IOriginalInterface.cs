﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    internal interface IOriginalInterface
    {
        void Accept(IVisitor visitor);
    }
}
