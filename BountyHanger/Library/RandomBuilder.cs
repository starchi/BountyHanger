using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BountyHanger.Library
{
    public static class RandomBuilder
    {
        private static Random randomBuilder = new Random(DateTime.Now.Millisecond);
        
        public static double GetDouble() {
            return randomBuilder.NextDouble();
        }
    }
}
