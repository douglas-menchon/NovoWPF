using NovoWPF.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel
{
    public class WindowCloser
    {

        public static bool GetEnableWindowClosing(DependencyObject obj)
        {
            return (bool)obj.GetValue(EnableWindowClosingProperty);
        }

        public static void SetEnableWindowClosing(DependencyObject obj, bool value)
        {
            obj.SetValue(EnableWindowClosingProperty, value);
        }

        // Using a DependencyProperty as the backing store for EnableWindowClosing.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnableWindowClosingProperty =
            DependencyProperty.RegisterAttached("EnableWindowClosing", typeof(bool), typeof(WindowCloser), new PropertyMetadata(false, OnEnableWindowClosingChanged));

        private static void OnEnableWindowClosingChanged(DependencyObject d, DependencyPropertyChangedEventArgs em)
        {
            if (d is Window window)
            {
                window.Loaded += (s, e) =>
                {
                    if (window.DataContext is ICloseWindows vm)
                    {
                        vm.Close += () =>
                        {
                            window.Close();
                        };
                    }
                };

            }
        }
    }
}