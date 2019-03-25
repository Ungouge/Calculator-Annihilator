using System;
using System.Windows;

namespace Message_Popupper
{
    public class Message_Box: IMessage_Box
    {
        public void Pop_Up(string message)
        {
            MessageBox.Show(message);
        }
    }
}
