using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using FirstFloor.ModernUI.Windows.Controls;

namespace SoDotCash.Models
{
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

        public void GoBack()
        {
            if (_historic.Count > 1)
            {
                _historic.RemoveAt(_historic.Count - 1);
                NavigateTo(_historic.Last(), null);
            }
        }

        public void NavigateTo(string pageKey)
        {
            NavigateTo(pageKey, null);
        }

        public void NavigateTo(string pageKey, object parameter)
        {
            lock (_pagesByKey)
            {
                if(!_pagesByKey.ContainsKey(pageKey))
                    throw new ArgumentException($"No such page: {pageKey}. Did you forget to call NavigationService.Configure?", nameof(pageKey));

                var frame = GetDescendantFromName(Application.Current.MainWindow) as ModernFrame;

                if (frame != null)
                    frame.Source = _pagesByKey[pageKey];

                Parameter = parameter;
                _historic.Add(pageKey);
                CurrentPageKey = pageKey;
            }
        }

        public string CurrentPageKey { get; private set; }
        public object Parameter { get; private set; }

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