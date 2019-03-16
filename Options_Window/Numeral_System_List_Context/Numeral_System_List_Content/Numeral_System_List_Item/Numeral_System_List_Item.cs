namespace Options_Window
{
    public partial class Numeral_System_List_Item: Numeral_System_List_Content
    {
        public double Image_Width { get; internal set; }

        public virtual string Pin_Image_Uri { get;  }

        public sbyte Numeral_System_Code { get; protected set; }
    }
}
