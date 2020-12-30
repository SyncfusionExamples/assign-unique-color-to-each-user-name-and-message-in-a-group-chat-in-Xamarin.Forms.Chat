using Syncfusion.XForms.Chat;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace GettingStarted
{
    public class AuthorColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var viewModel = parameter as ViewModel;
            var message = value as IMessage;

            if (viewModel.AuthorColors.ContainsKey(message.Author))
            {
                Color color;
                viewModel.AuthorColors.TryGetValue(message.Author, out color);
                return color;
            }
            else
            {
                return viewModel.AddColorForAuthor(message.Author);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Color.White;
        }
    }
}
