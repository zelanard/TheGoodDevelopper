using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGoodDevelopper.Model;

namespace TheGoodDevelopper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogController logController = new LogController();
            logController.Start();
        }
    }
}
