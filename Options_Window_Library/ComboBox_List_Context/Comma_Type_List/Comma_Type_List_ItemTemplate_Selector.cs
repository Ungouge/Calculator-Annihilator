using System;
using System.Windows;
using System.Windows.Controls;

namespace Options_Window_Library
{
    public class Comma_Type_List_ItemTemplate_Selector : DataTemplateSelector
    {
        public DataTemplate Add_New_ItemTemplate { get; set; }

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
                if (item is Add_New_Comma_Type_List_Item Add_Item)
                    return Add_New_ItemTemplate;

            return ItemTemplate;
        }
    }
}