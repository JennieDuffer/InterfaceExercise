using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string BrandName { get; set; }

        public bool HasSalesPeople { get; set; }
    }
}
