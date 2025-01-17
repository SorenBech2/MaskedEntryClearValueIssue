﻿using System.Diagnostics;

namespace MaskedEntryClearValueIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ComboBoxResetting.ItemsSource = new string[] { "Item 1", "Item 2", "Item 3" };
        }

        private void ClearForm_Clicked(object sender, EventArgs e)
        {
            Entry1.Value = string.Empty;
            Email.Value = string.Empty;
            ComboBoxResetting.SelectedIndex = -1;
        }

        private void Entry1_ValueChanging(object sender, Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs e)
        {
            Debug.WriteLine($"Entry1_ValueChanging: {e.NewValue}");
        }

        private void Email_ValueChanging(object sender, Syncfusion.Maui.Inputs.MaskedEntryValueChangingEventArgs e)
        {
            Debug.WriteLine($"Email_ValueChanging: {e.NewValue}");
        }

        private void Entry3_ValueChanged(object sender, Syncfusion.Maui.Toolkit.NumericEntry.NumericEntryValueChangedEventArgs e)
        {
            Debug.WriteLine($"Entry3_ValueChanging: {e.NewValue}");
        }
    }

}
