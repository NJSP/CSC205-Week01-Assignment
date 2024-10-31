using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    internal class DigitMod
    {
        int num = 0;

        public DigitMod(int Num)
        {
            this.num = Num;
        }
        public int[] SplitNum()
        {
            int first_digit = this.num % 10;
            int second_digit = (this.num / 10) % 10;
            int third_digit = (this.num /100) % 10;
            int fourth_digit = (this.num / 1000) % 10;
            int[] NumDig = [first_digit, second_digit, third_digit, fourth_digit];
            return NumDig;

        }
        public int GetSum()
        {
            int[] digits = SplitNum();
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += digits[i];
            }
            return sum;
        }
    }
}
