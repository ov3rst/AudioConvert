namespace AudioConvert
{
    public partial class frmHome : Form
    {
        Loader loading;

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SelectAudioDialog.ShowDialog();
            txtFileRoute.Text = SelectAudioDialog.FileName;
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFileRoute.Text))
            {
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ShowLoading();

            var text = await Transcriptor.TranscribeAudio(txtFileRoute.Text);

            HideLoading();

            txtResult.Text = text;
        }

        private void HideLoading()
        {
            if (loading is not null) loading.Hide();
        }

        private void ShowLoading()
        {
            loading = new Loader();
            loading.TopLevel = false;
            loading.Dock = DockStyle.Fill;
            loading.Opacity = 50;
            this.Controls.Add(loading);
            this.Controls.SetChildIndex(loading, 0);
            loading.Show();
        }
    }
}
