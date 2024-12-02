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
    }

}
