﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary;

public class Product(int id, string name, decimal unitPrice, int unitsInStock)
{
    public int Id => id;
    public string Name => name;
    public decimal UnitPrice => unitPrice;
    public int UnitsInStock => unitsInStock;

}


