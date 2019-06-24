using System;
using System.Windows;
using System.Windows.Controls;

namespace Options_Window_Library
{
    public class Numeral_System_List_ItemTemplate_Selector: DataTemplateSelector
    {
        public DataTemplate LabelTemplate { get; set; }

        public DataTemplate ItemTemplate { get; set; }

        public DataTemplate ContentSiteTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (container != null)
                if (container is FrameworkElement element)
                    if (element is ContentPresenter presenter)
                        if (presenter.Parent is Panel)
                            return ContentSiteTemplate;

            if (item != null)
            {
                if ( item is INumeral_System_List_Content Item)
                {
                    if (Item is IItem_Numeral_System_List List_Item)
                        return ItemTemplate;
                    else if (Item is ILabel_Numeral_System_List Label)
                        return LabelTemplate;
                }
            }
            

            return null;
        }
    }
}
