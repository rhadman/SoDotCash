using System.ComponentModel;
using System.Linq;
using System.Windows.Media;
using FirstFloor.ModernUI.Presentation;

namespace SoDotCash.ViewModels
{
    /// <summary>
    /// View model for the settings selection
    /// </summary>
    public class SettingsViewModel : NotifyPropertyChanged
    {

        public SettingsViewModel()
        {
            // add the default themes
            _themes.Add(new Link {DisplayName = "dark", Source = AppearanceManager.DarkThemeSource});
            _themes.Add(new Link {DisplayName = "light", Source = AppearanceManager.LightThemeSource});

            // Ensure our font size value reflects the font size in use
            SelectedFontSize = AppearanceManager.Current.FontSize == FontSize.Large ? FontLarge : FontSmall;

            // Synchronize view model variables with in-use variables
            SyncThemeAndColor();

            // Recieve notification of appearance changes
            AppearanceManager.Current.PropertyChanged += OnAppearanceManagerPropertyChanged;
        }

        /// <summary>
        /// Update the viewmodel variables for theme and color to reflect those in use
        /// </summary>
        private void SyncThemeAndColor()
        {
            // synchronizes the selected viewmodel theme with the actual theme used by the appearance manager.
            SelectedTheme = _themes.FirstOrDefault(l => l.Source.Equals(AppearanceManager.Current.ThemeSource));
            
            // and make sure accent color is up-to-date
            SelectedAccentColor = AppearanceManager.Current.AccentColor;

            //write settings to the config file so that they will be loaded next time
            Properties.Settings.Default.Theme = SelectedTheme?.DisplayName;
            Properties.Settings.Default.Accent = SelectedAccentColor.ToString();
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Handle change of appearance property by updating our state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAppearanceManagerPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ThemeSource" || e.PropertyName == "AccentColor")
            {
                SyncThemeAndColor();
            }
        }

        /// <summary>
        /// Available font size
        /// </summary>
        private const string FontSmall = "small";

        private const string FontLarge = "large";
        public string[] FontSizes => new[] {FontSmall, FontLarge};

        /// <summary>
        /// The current UI accent color
        /// </summary>
        private Color _selectedAccentColor;

        public Color SelectedAccentColor
        {
            get { return _selectedAccentColor; }
            set
            {
                if (_selectedAccentColor != value)
                {
                    _selectedAccentColor = value;
                    OnPropertyChanged("SelectedAccentColor");

                    AppearanceManager.Current.AccentColor = value;
                }
            }
        }

        /// <summary>
        /// List of available color themes
        /// </summary>
        private readonly LinkCollection _themes = new LinkCollection();

        public LinkCollection Themes => _themes;

        /// <summary>
        /// The selected color theme for the application
        /// </summary>
        private Link _selectedTheme;

        public Link SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                if (_selectedTheme != value)
                {
                    _selectedTheme = value;
                    OnPropertyChanged("SelectedTheme");

                    // and update the actual theme
                    AppearanceManager.Current.ThemeSource = value.Source;
                }
            }
        }

        /// <summary>
        /// Selected font size for the application
        /// </summary>
        private string _selectedFontSize;

        public string SelectedFontSize
        {
            get { return _selectedFontSize; }
            set
            {
                if (_selectedFontSize != value)
                {
                    _selectedFontSize = value;
                    OnPropertyChanged("SelectedFontSize");

                    AppearanceManager.Current.FontSize = value == FontLarge ? FontSize.Large : FontSize.Small;
                }
            }
        }

        /// <summary>
        /// Available accent colors
        /// </summary>
        public Color[] AccentColors { get; } =
            {
                Color.FromRgb(0xa4, 0xc4, 0x00), // lime
                Color.FromRgb(0x60, 0xa9, 0x17), // green
                Color.FromRgb(0x00, 0x8a, 0x00), // emerald
                Color.FromRgb(0x00, 0xab, 0xa9), // teal
                Color.FromRgb(0x1b, 0xa1, 0xe2), // cyan
                Color.FromRgb(0x00, 0x50, 0xef), // cobalt
                Color.FromRgb(0x6a, 0x00, 0xff), // indigo
                Color.FromRgb(0xaa, 0x00, 0xff), // violet
                Color.FromRgb(0xf4, 0x72, 0xd0), // pink
                Color.FromRgb(0xd8, 0x00, 0x73), // magenta
                Color.FromRgb(0xa2, 0x00, 0x25), // crimson
                Color.FromRgb(0xe5, 0x14, 0x00), // red
                Color.FromRgb(0xfa, 0x68, 0x00), // orange
                Color.FromRgb(0xf0, 0xa3, 0x0a), // amber
                Color.FromRgb(0xe3, 0xc8, 0x00), // yellow
                Color.FromRgb(0x82, 0x5a, 0x2c), // brown
                Color.FromRgb(0x6d, 0x87, 0x64), // olive
                Color.FromRgb(0x64, 0x76, 0x87), // steel
                Color.FromRgb(0x76, 0x60, 0x8a), // mauve
                Color.FromRgb(0x87, 0x79, 0x4e) // taupe
            };

    }
}
