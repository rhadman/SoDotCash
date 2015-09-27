using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace SoDotCash.Utility
{
    /// <summary>
    /// This behavior class modifies a TreeView to allow the SelectedItem property to be two-way bound.
    /// 
    /// Implementation by Steve Greatrex as described in this discussion:
    /// http://stackoverflow.com/questions/1000040/data-binding-to-selecteditem-in-a-wpf-treeview
    /// </summary>
    class BindableSelectedItemBehavior : Behavior<TreeView>
    {
        #region SelectedItem Property

        /// <summary>
        /// Replace the SelectedItem functionality in TreeView with new behavior that allows writing by defining set
        /// </summary>
        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        /// <summary>
        /// Register the SelectedItemProperty and set change notification callback
        /// </summary>
        public static readonly DependencyProperty SelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(BindableSelectedItemBehavior), new UIPropertyMetadata(null, OnSelectedItemChanged));

        /// <summary>
        /// Handle the item changed event and properly update the TreeViewItem.IsSelectedProperty value to reflect the selection
        /// </summary>
        private static void OnSelectedItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var item = e.NewValue as TreeViewItem;
            if (item != null)
            {
                item.SetValue(TreeViewItem.IsSelectedProperty, true);
            }
        }

        #endregion

        /// <summary>
        /// Register for SelectedItemChanged event notification when this behavior is attached
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();

            AssociatedObject.SelectedItemChanged += OnTreeViewSelectedItemChanged;
        }

        /// <summary>
        /// Unregister for SelectedItemChanged event notification when this behavior is detached
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();

            if (AssociatedObject != null)
            {
                AssociatedObject.SelectedItemChanged -= OnTreeViewSelectedItemChanged;
            }
        }

        /// <summary>
        /// Change handler called from the associated TreeView
        /// </summary>
        private void OnTreeViewSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            SelectedItem = e.NewValue;
        }
    }
}
