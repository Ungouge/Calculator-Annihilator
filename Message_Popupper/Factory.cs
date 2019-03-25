using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Popupper
{
    public static class Factory
    {
        public static IMessage_Box Get_Message_Box
        {
            get
            {
                return new Message_Box();
            }
        }
    }
}
