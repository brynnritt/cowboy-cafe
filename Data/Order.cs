using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem
    {
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<string> SpecialIntructions { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
