using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class AnotherClass
    {
        public async void AnotherMethod()
        {
            // First to execute
            CookEggs cookEggs = new CookEggs();
            var lalala = await cookEggs.CookEggsMethod();

            // Second to execute together
            CookBacons cookBacons = new CookBacons();
            cookBacons.CookBaconsMethod();
            ToastBread toastBread = new ToastBread();
            toastBread.ToastBreadMethod();
        }
    }
}
