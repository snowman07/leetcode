using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    public class Player
    {
        public string username;
        public Player(string username)
        {

            this.username = username;

        }

        public override string ToString()
        {
            return username;
        }
    }
}
