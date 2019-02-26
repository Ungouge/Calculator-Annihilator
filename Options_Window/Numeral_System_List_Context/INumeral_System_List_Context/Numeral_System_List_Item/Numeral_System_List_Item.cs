using System;
using Common_Library;

namespace Options_Window
{
    partial class OWXYZ
    {
        partial class Numeral_System_List_Context
        {
            public partial class Numeral_System_List_Item: INumeral_System_List_Context
            {
                public string Numeral_System_List_Item_Text { get; set; }

                internal sbyte numeral_System_Code;

                public string Pin_Image_Uri { get; set; }

                public double Text_Width { get; set; }

                public double Image_Width { get; set; }

                public double Opacity { get; set; }

                internal Numeral_System_List_Item(OWXYZ _OptionsWindow, sbyte _numeral_System_Code)
                    :this (_numeral_System_Code, _OptionsWindow)
                {
                    Pin_Image_Uri = AppDomain.CurrentDomain.BaseDirectory + @"Library\Images\Pins\PinnedItem_64x_Clear.png";
                }

                protected Numeral_System_List_Item(sbyte _numeral_System_Code, OWXYZ _OptionsWindow)
                {
                    numeral_System_Code = _numeral_System_Code;

                    Numeral_System_List_Item_Text = Numeral_System.Numeral_System_Dictionary_Name(
                        numeral_System_Code, _OptionsWindow.Options.Standard_Messages);

                    Image_Width = _OptionsWindow._Bindable_Resources.ComboBox_List_Image_Height;

                    Text_Width = _OptionsWindow._Bindable_Resources.ComboBox_Element_Width - Image_Width;

                    Opacity = 0e0;
                }

            }
        }
    }
}
