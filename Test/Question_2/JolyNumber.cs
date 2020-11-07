using System;
using System.Collections.Generic;
using System.Text;

namespace Question_2
{
    public class JolyNumber
    {
        public int Number { get; set; }

        public JolyNumber(int value)
        {
            Number = value;
        }

        public JolyNumber()
        {
            Number = 0;
        }

        public virtual void Increment()
        {
            Number++;
        }

        public void Increment(int value)
        {
            Number += value;
        }
    }
}
