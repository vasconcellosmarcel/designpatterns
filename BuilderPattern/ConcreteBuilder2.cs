﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ConcreteBuilder2 : Builder
    {
        // This is the code we want to hide
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartX");
        }
        public override void BuildPartB()
        {
            _product.Add("PartY");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
