using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPrograming
{
    class Program
    {
        /*动态规划（dynamic programing）
         * 0、1背包问题：
         * 爬楼梯问题
         * ****/
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            Console.WriteLine(Step(10));
            Console.WriteLine(Step(9));
            Console.WriteLine(Step(8));
            Console.WriteLine(Step(7));
            Console.WriteLine(Step(6));
            Console.WriteLine(Step(5));
            Console.WriteLine(Step(4));
            Console.WriteLine(Step(3));
            //////////////////////////////////////////////////
        }


        /*
         * 爬楼梯问题：假设有n阶的楼梯，一次能爬1.2级数,求一共有多少种爬法？f(n)=f(n-1)+f(n-2)
         * ***/
        static int Step(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n < 0) throw new Exception();
            return Step(n - 1) + Step(n - 2);
        }


        /**
         * 0-1背包问题：有N件物品和一个容量为V的背包。第i件物品的体积是c[i]，价值是v[i]。求解将哪些物品装入背包可使价值总和最大。
         * 有5个商品，背包的体积为10，他们的体积为 c[5] = {3,5,2,7,4};  价值为 v[5] = {2,4,1,6,5};
         * ***************/
        static void BackPack()
        {
            int[] c = {3,5,2,7,4};
            int[] v = { 2, 4, 1, 6, 5 };
        }
    }
}
