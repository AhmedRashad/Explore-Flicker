﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ExploreFlicker.Converters
{
    public class VisibleWhenFalseConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (value is bool && (bool)value) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
