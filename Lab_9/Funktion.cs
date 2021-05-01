using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    public class Funktion

    {
        Random rnd = new Random();

        public int[] Statistical(double tb_1, double tb_2, double tb_3, double tb_4, double tb_5, int max)
        {
            int i = 0;
            
            double[] nums = new double[6];
            nums[1] = tb_1;
            nums[2] = tb_2;
            nums[3] = tb_3;
            nums[4] = tb_4;
            nums[5] = tb_5;

            int[] Statistic = new int[6];
            while (i < max)
            {
                int k;
                k = Find(nums);
                Statistic[k]++;
                i++;
            }
            return Statistic;

        }
        public int Find(double[] nums)
        {
           
            int k = 1;
            double value = Rnd(rnd);
            Math.Round(value, 2);
            double A = value;
            while (A >= 0)
            {
                A = A - nums[k];
                k++;
            }
            k--;
            return k;
        }
        public double Rnd(Random rnd)
        {
            return rnd.NextDouble();
        }

    }
}
