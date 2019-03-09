namespace Options_Window
{
    partial class Numeral_System_List_Context
    {
        public interface INumeral_System_List_Item: INumeral_System_List_Content
        {
            double Image_Width { get; set; }

            string Pin_Image_Uri { get; set; }

            sbyte Numeral_System_Code { get;}
        }
    }
}
