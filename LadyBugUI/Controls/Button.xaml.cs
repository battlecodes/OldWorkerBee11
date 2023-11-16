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

        public static readonly DependencyProperty MouseOverButtonBackgroundProperty =
            DependencyProperty.Register(
                "MouseOverButtonBackground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["MouseOverButtonBackground"]));

        public static readonly DependencyProperty MouseOverButtonBorderBrushProperty =
            DependencyProperty.Register(
                "MouseOverButtonBorderBrush",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ControlElevationBorderBrush"]));

        public static readonly DependencyProperty PressedButtonBackgroundProperty =
            DependencyProperty.Register(
                "PressedButtonBackground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["PressedButtonBackground"]));



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


        public Brush MouseOverButtonBackground
        {
            get => (Brush)GetValue(MouseOverButtonBackgroundProperty);
            set => SetValue(MouseOverButtonBackgroundProperty, value);
        }


        public Brush MouseOverButtonBorderBrush
        {
            get => (Brush)GetValue(MouseOverButtonBorderBrushProperty);
            set => SetValue(MouseOverButtonBorderBrushProperty, value);
        }


        public Brush PressedButtonBackground
        {
            get => (Brush)GetValue(PressedButtonBackgroundProperty);
            set => SetValue(PressedButtonBackgroundProperty, value);
        }


        public Button()
        {
            InitializeComponent();
        }
    }
}
