using System.Diagnostics;

namespace MaskedEntryClearValueIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClearForm_Clicked(object sender, EventArgs e)
        {
            Entry1.Value = string.Empty;
            Entry2.Value = string.Empty;
        }

        private void Entry1_ValueChanging(object sender, Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs e)
        {
            Debug.WriteLine($"Entry1_ValueChanging: {e.NewValue}");
        }

        private void Entry2_ValueChanging(object sender, Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs e)
        {
            Debug.WriteLine($"Entry2_ValueChanging: {e.NewValue}");
        }

        private void Entry3_ValueChanged(object sender, Syncfusion.Maui.Toolkit.NumericEntry.NumericEntryValueChangedEventArgs e)
        {
            Debug.WriteLine($"Entry3_ValueChanging: {e.NewValue}");
        }
    }

}
