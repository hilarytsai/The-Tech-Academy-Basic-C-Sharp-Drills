using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace oneparameter
{
    public class Operator
    {
        public int operate(int data)
        {
            return data * 2;
        }
        public double operate(double data)
        {
            return data + 2;
        }
        public int operate(string data2)
        {
            int input = Convert.ToInt32(data2);
            return input / 2;
        }
    }
}