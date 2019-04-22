using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_class_work
{
    public static class StringExtensions
    {
        public static int GetLenght(this string data)
        {
            return data.Length;
        }
    }
}
