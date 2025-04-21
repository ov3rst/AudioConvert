namespace AudioConvert
{
    /// <summary>
    /// Clase del formulario de loading
    /// </summary>
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que inicializa el loader
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loader_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("loading.gif");
            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2, this.Height / 2 - pictureBox1.Height / 2);
            Dock = DockStyle.Fill;
        }
    }
}
