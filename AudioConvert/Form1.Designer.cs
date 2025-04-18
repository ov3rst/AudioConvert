namespace AudioConvert
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFileRoute = new TextBox();
            btnBrowse = new Button();
            btnConvert = new Button();
            txtResult = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            btnClose = new Button();
            label3 = new Label();
            SelectAudioDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 82);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 0;
            label1.Text = "Ruta o Url del Audio";
            // 
            // txtFileRoute
            // 
            txtFileRoute.Font = new Font("Comic Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileRoute.Location = new Point(28, 108);
            txtFileRoute.Name = "txtFileRoute";
            txtFileRoute.Size = new Size(317, 30);
            txtFileRoute.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.White;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(351, 108);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(109, 30);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Seleccionar";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.White;
            btnConvert.Cursor = Cursors.Hand;
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(28, 154);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(432, 30);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convertir a texto";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Comic Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(28, 232);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(432, 163);
            txtResult.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 206);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 4;
            label2.Text = "Audio Convertido a Texto";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(278, 401);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(378, 401);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 30);
            btnClose.TabIndex = 7;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(63, 19);
            label3.Name = "label3";
            label3.Size = new Size(367, 38);
            label3.TabIndex = 8;
            label3.Text = "Convertidor Audio a Texto";
            // 
            // SelectAudioDialog
            // 
            SelectAudioDialog.Title = "Seleccione un audio";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(489, 444);
            Controls.Add(label3);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(txtResult);
            Controls.Add(label2);
            Controls.Add(btnConvert);
            Controls.Add(btnBrowse);
            Controls.Add(txtFileRoute);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "frmHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileRoute;
        private Button btnBrowse;
        private Button btnConvert;
        private TextBox txtResult;
        private Label label2;
        private Button btnClear;
        private Button btnClose;
        private Label label3;
        private OpenFileDialog SelectAudioDialog;
    }
}
