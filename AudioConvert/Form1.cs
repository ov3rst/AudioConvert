using System.Text.RegularExpressions;

namespace AudioConvert
{
    /// <summary>
    /// Formulario principal
    /// </summary>
    public partial class frmHome : Form
    {
        Loader loading;

        public frmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton para limpiar el textbox donse se muestra el audio transcrito
        /// </summary>
        /// <param name="sender">el objeto que ejecuta el evento</param>
        /// <param name="e">evento ejecutado</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        /// <summary>
        /// Boton para salir de la aplicacion
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Boton para abrir el cuadro de dialogo para seleccionar el archivo
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Este es el elemento de seleccion del archivo, cuando se clickea el boton mostramos el cuadro de dialogo
            SelectAudioDialog.ShowDialog();

            //Validacion de tipos de archivos aceptados
            if (!Regex.IsMatch(SelectAudioDialog.FileName, @"\.mp3$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Solo se aceptan archivos .mp3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Este es el elemento que muestra la ruta del archivo.
            txtFileRoute.Text = SelectAudioDialog.FileName;
        }

        /// <summary>
        /// Boton para convertir el audio a texto
        /// </summary>
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            // manejo de error cuando no se ah seleccionado ningun archivo
            if (string.IsNullOrEmpty(txtFileRoute.Text))
            {
                // mostramos un pequeño recuadro avisando que se debe seleccionar un archivo
                MessageBox.Show("Debe seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // metodo que muestra el loader mientras se transcribe el archivo
            ShowLoading();

            //Aqui utilizamos una clase estatica creada para transcribir el audio, el metodo utilizado es asincrono
            var text = await Transcriptor.TranscribeAudio(txtFileRoute.Text);

            // Ocultamos el loader despues de que la accion haya terminado
            HideLoading();

            //Mostramos la transcripcion
            txtResult.Text = text;
        }

        /// <summary>
        /// Metodo que oculta el loader
        /// </summary>
        private void HideLoading()
        {
            //Verificamos que el loader no sea nulo y que este creado en un hilo secundario del procesador
            if (loading is not null && loading.IsHandleCreated) loading.Invoke(loading.Close);
        }

        /// <summary>
        /// Metodo que muestra el loader
        /// </summary>
        private void ShowLoading()
        {
            //Debemos ejecutar el formulario de loading en un hilo secundario del procesador para poder cerrarlo ya que sino lo hacemos asi, se quedaria esperando a que el usuario ejecute una accion para poder cerrarse

            // debemos capturar la instancia actual para poder pasarsela al formulario de loading
            var owner = this;

            // abrimos nuestro loader en un nuevo hilo
            var showLoading = new Thread(() =>
            {
                loading = new Loader();

                // invocamos mediante un delegado al metodo para mostrar el loader y pasamos la instancia de su elemento padre
                owner.Invoke(new Action(() =>
                {
                    loading.ShowDialog(owner);
                }));
            });

            showLoading.SetApartmentState(ApartmentState.STA);

            //Iniciamos el hilo
            showLoading.Start();
        }
    }
}
