using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LadyBugUI.Controls
{
    /// <summary>
    /// Interaction logic for Button.xaml
    /// </summary>
    public partial class Button : UserControl
    {
        // App level resource dictionary.
        public static readonly ResourceDictionary _rsc =
            new()
            {
                Source = new Uri("/LadyBugUI;component/Resources/Themes/Dark.xaml",
                    UriKind.RelativeOrAbsolute),
            };


        // Dependency Properties
        public static readonly DependencyProperty ButtonBackgroundProperty =
            DependencyProperty.Register(
                "ButtonBackground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ButtonBackground"]));

        public static readonly DependencyProperty ButtonBorderBrushProperty =
            DependencyProperty.Register(
                "ButtonBorderBrush",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ControlElevationBorderBrush"]));

        public static readonly DependencyProperty ButtonBorderThicknessProperty =
            DependencyProperty.Register(
                "ButtonBorderThickness",
                typeof(Thickness),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ButtonBorderThemeThickness"]));

        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register(
                "ButtonHeight",
                typeof(double),
                typeof(Button),
                new FrameworkPropertyMetadata(
                    double.NaN,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public static readonly DependencyProperty ButtonWidthProperty =
            DependencyProperty.Register(
                "ButtonWidth",
                typeof(double),
                typeof(Button),
                new FrameworkPropertyMetadata(
                    double.NaN,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));



        public Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }


        public Brush ButtonBorderBrush
        {
            get => (Brush)GetValue(ButtonBorderBrushProperty);
            set => SetValue(ButtonBorderBrushProperty, value);
        }


        public Thickness ButtonBorderThickness
        {
            get => (Thickness)GetValue(ButtonBorderThicknessProperty);
            set => SetValue(ButtonBorderThicknessProperty, value);
        }


        public double ButtonHeight
        {
            get => (double)GetValue(ButtonHeightProperty);
            set => SetValue(ButtonHeightProperty, value);
        }


        public double ButtonWidth
        {
            get => (double)GetValue(ButtonWidthProperty);
            set => SetValue(ButtonWidthProperty, value);
        }


        public Button()
        {
            InitializeComponent();
        }
    }
}
