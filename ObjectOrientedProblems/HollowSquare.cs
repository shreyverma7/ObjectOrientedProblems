using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProblems
{
    public class HollowSquare
    {
        public void hollowSquare(int n)
        {
            for(int i= 1;i<=n;i++)
            {
                for(int  j= 1; j <= n; j++)
                {
                    if(i==1 || j==1 || i==n || j == n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
