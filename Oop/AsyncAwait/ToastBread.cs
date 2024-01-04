using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class ToastBread
    {
        public async void ToastBreadMethod()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("bread toasted!");
            });
            
        }
    }
}
