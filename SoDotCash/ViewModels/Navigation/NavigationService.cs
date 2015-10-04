using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Windows.Controls;

namespace SoDotCash.ViewModels.Navigation
{
    /// <summary>
    /// Basic NavigationService provided by ModernUI
    /// </summary>
    public class NavigationService : IModernNavigationService
    {
        private readonly Dictionary<string, Uri> _pagesByKey;
        private readonly List<string> _historic;

        #region [ Constructors ]

        public NavigationService()
        {
            _pagesByKey = new Dictionary<string, Uri>();
            _historic = new List<string>();
        }

        #endregion

        #region [ IModernNavigationService Implementation ]

        /// <summary>
        /// Return to the previous page in the navigation stack
        /// </summary>
        public void GoBack()
        {
            if (_historic.Count > 1)
            {
                // Remove the current page from the history stack
                _historic.RemoveAt(_historic.Count - 1);

                // Navigate to the previous page
                NavigateTo(_historic.Last(), null);
            }
        }

        /// <summary>
        /// Navigate to a different page
        /// </summary>
        /// <param name="pageKey">Key identifying the page to navigate to</param>
        public void NavigateTo(string pageKey)
        {
            // Relay to parameter-accepting call
            NavigateTo(pageKey, null);
        }

        /// <summary>
        /// Navigate to a different page
        /// </summary>
        /// <param name="pageKey">Key identifying the page to navigate to</param>
        /// <param name="parameter">(optional) Parameter to be consumed by the new page</param>
        public void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {
                // Verify that the key is a known key
                if(!_pagesByKey.ContainsKey(pageKey))
                    throw new ArgumentException($"No such page: {pageKey}. Did you forget to call NavigationService.Configure?", nameof(pageKey));

                // Retrieve the main frame that displays pages
                var frame = GetDescendantFromName(Application.Current.MainWindow) as ModernFrame;
                if (frame != null)
                    // Update the frame to use the new page
                    frame.Source = _pagesByKey[pageKey];

                Parameter = parameter;

                // Don't add to history if we're returning to the page
                if (!_historic.Any() || _historic.Last() != pageKey)
                    _historic.Add(pageKey);

                // Store current page key
                CurrentPageKey = pageKey;
            }
        }

        /// <summary>
        /// Key identifying the current page in the display
        /// </summary>
        public string CurrentPageKey { get; private set; }

        /// <summary>
        /// Optional parameter passed for current page consumption
        /// </summary>
        public object Parameter { get; private set; }

        /// <summary>
        /// Clear the entire navigation history
        /// </summary>
        public void ClearNavigationHistory()
        {
            _historic.Clear();
        }

        #endregion

        #region [ Helpers ]

        public static FrameworkElement GetDescendantFromName(DependencyObject parent, string name = "ContentFrame")
        {
            var count = VisualTreeHelper.GetChildrenCount(parent);

            if (count < 1)
            {
                return null;
            }

            for (var i = 0; i < count; i++)
            {
                var frameworkElement = VisualTreeHelper.GetChild(parent, i) as FrameworkElement;

                if (frameworkElement != null)
                {
                    if(frameworkElement.Name == name)
                        return frameworkElement;
                    frameworkElement = GetDescendantFromName(frameworkElement, name);
                    if (frameworkElement != null)
                    {
                        return frameworkElement;
                    }
                }
            }
            return null;
        }

        public void Configure(string key, Uri pageType)
        {
            lock (_pagesByKey)
            {
                if (_pagesByKey.ContainsKey(key))
                    _pagesByKey[key] = pageType;
                else
                    _pagesByKey.Add(key, pageType);

            }
        }

        #endregion
    }
}