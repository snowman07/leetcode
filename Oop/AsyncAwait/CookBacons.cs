using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class CookBacons
    {
        public async void CookBaconsMethod()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("bacons cooked!");
            });
            
        }
    }
}
