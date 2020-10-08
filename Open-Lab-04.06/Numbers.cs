using System;
using System.Linq;
namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers) => numbers.Where(p => p % 2 == 0).ToArray();
        
    }
}
