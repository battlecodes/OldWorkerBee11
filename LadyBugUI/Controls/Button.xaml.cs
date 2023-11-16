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
                Source = new Uri("/LadyBugUI;component/Resources/LadyBugUI.xaml",
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

        public static readonly DependencyProperty ButtonForegroundProperty =
            DependencyProperty.Register(
                "ButtonForeground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ButtonForeground"]));

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

        public static readonly DependencyProperty ClickedCommandProperty =
            DependencyProperty.Register(
                "ClickedCommand",
                typeof(ICommand),
                typeof(Button),
                new PropertyMetadata(null));

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register(
                "ImageSource",
                typeof(string),
                typeof(Button),
                new PropertyMetadata(null));

        public static readonly DependencyProperty LabelFontSizeProperty =
            DependencyProperty.Register(
                "LabelFontSize",
                typeof(double),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["ControlContentThemeFontSize"]));

        public static readonly DependencyProperty LabelFontWeightProperty =
            DependencyProperty.Register(
                "LabelFontWeight",
                typeof(FontWeight),
                typeof(Button),
                new PropertyMetadata(FontWeights.Normal));

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register(
                "LabelText",
                typeof(string),
                typeof(Button),
                new PropertyMetadata(string.Empty));

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

        public static readonly DependencyProperty MouseOverButtonForegroundProperty =
            DependencyProperty.Register(
                "MouseOverButtonForeground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["MouseOverButtonForeground"]));

        public static readonly DependencyProperty PressedButtonBackgroundProperty =
            DependencyProperty.Register(
                "PressedButtonBackground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["PressedButtonBackground"]));

        public static readonly DependencyProperty PressedButtonForegroundProperty =
            DependencyProperty.Register(
                "PressedButtonForeground",
                typeof(Brush),
                typeof(Button),
                new PropertyMetadata(
                    _rsc["PressedButtonForeground"]));


        /// <summary>
        /// Background for the button.
        /// </summary>
        public Brush ButtonBackground
        {
            get => (Brush)GetValue(ButtonBackgroundProperty);
            set => SetValue(ButtonBackgroundProperty, value);
        }

        /// <summary>
        /// Border for the button.
        /// </summary>
        public Brush ButtonBorderBrush
        {
            get => (Brush)GetValue(ButtonBorderBrushProperty);
            set => SetValue(ButtonBorderBrushProperty, value);
        }

        /// <summary>
        ///  Border thickness for the button.
        /// </summary>
        public Thickness ButtonBorderThickness
        {
            get => (Thickness)GetValue(ButtonBorderThicknessProperty);
            set => SetValue(ButtonBorderThicknessProperty, value);
        }

        /// <summary>
        /// Text fill for the button label.
        /// </summary>
        public Brush ButtonForeground
        {
            get => (Brush)GetValue(ButtonForegroundProperty);
            set => SetValue(ButtonForegroundProperty, value);
        }

        /// <summary>
        /// Height of the button.
        /// </summary>
        public double ButtonHeight
        {
            get => (double)GetValue(ButtonHeightProperty);
            set => SetValue(ButtonHeightProperty, value);
        }

        /// <summary>
        /// Width of the button.
        /// </summary>
        public double ButtonWidth
        {
            get => (double)GetValue(ButtonWidthProperty);
            set => SetValue(ButtonWidthProperty, value);
        }

        /// <summary>
        /// Location of the button's image source.
        /// </summary>
        public string ImageSource
        {
            get => (string)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        /// <summary>
        /// Size of the button label's text.
        /// </summary>
        public double LabelFontSize
        {
            get => (double)GetValue(LabelFontSizeProperty);
            set => SetValue(LabelFontSizeProperty, value);
        }

        /// <summary>
        /// Weight of the button label's font.
        /// </summary>
        public FontWeight LabelFontWeight
        {
            get => (FontWeight)GetValue(LabelFontWeightProperty);
            set => SetValue(LabelFontWeightProperty, value);
        }

        /// <summary>
        /// Text for the button's label.
        /// </summary>
        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        /// <summary>
        /// Backgronud for the button on mouse over.
        /// </summary>
        public Brush MouseOverButtonBackground
        {
            get => (Brush)GetValue(MouseOverButtonBackgroundProperty);
            set => SetValue(MouseOverButtonBackgroundProperty, value);
        }

        /// <summary>
        /// Border brush for the button on mouse over.
        /// </summary>
        public Brush MouseOverButtonBorderBrush
        {
            get => (Brush)GetValue(MouseOverButtonBorderBrushProperty);
            set => SetValue(MouseOverButtonBorderBrushProperty, value);
        }

        /// <summary>
        /// Text fill for the button label on mouse over.
        /// </summary>
        public Brush MouseOverbuttonForeground
        {
            get => (Brush)(GetValue(MouseOverButtonForegroundProperty));
            set => SetValue(MouseOverButtonForegroundProperty, value);
        }

        /// <summary>
        /// Background for the button when pressed.
        /// </summary>
        public Brush PressedButtonBackground
        {
            get => (Brush)GetValue(PressedButtonBackgroundProperty);
            set => SetValue(PressedButtonBackgroundProperty, value);
        }

        /// <summary>
        /// Text fill for the button label when pressed.
        /// </summary>
        public Brush PressedButtonForeground
        {
            get => (Brush)GetValue(PressedButtonForegroundProperty);
            set => SetValue(PressedButtonForegroundProperty, value);
        }



        public ICommand ClickedCommand
        {
            get => (ICommand)GetValue(ClickedCommandProperty);
            set => SetValue(ClickedCommandProperty, value);
        }


        public Button()
        {
            InitializeComponent();
        }
    }
}
