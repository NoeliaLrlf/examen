using System;

namespace ConsoleApp1
{
    public class InvalidDivision : Exception
    {
        public InvalidDivision(string meg) : base(meg)
        {
        }
    }
}