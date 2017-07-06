using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace HostApp.Controls
{
    public sealed partial class FlipContainerControl : UserControl
    {
        public FlipContainerControl()
        {
            this.InitializeComponent();
            shortcutCtrl.TargetedIndexChanged += ShortcutCtrl_TargetedIndexChanged;
        }

        private async void ShortcutCtrl_TargetedIndexChanged(object sender, CustomControls.TargetedIndexEventArgs e)
        {
            await System.Threading.Tasks.Task.Delay(100);
            flipView.SelectedIndex = e.TargetedIndex;
            flipView.UpdateLayout();
            shortcutOutput.Text = $"Targeted index : {e.TargetedIndex}";
        }
    }
}
