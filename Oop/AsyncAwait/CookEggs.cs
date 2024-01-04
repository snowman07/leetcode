using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class CookEggs
    {
        public async Task<bool> CookEggsMethod()
        {
            bool res = false;
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("eggs cooked!");
                res = true;
            });
            return res;
            
        }
    }
}
