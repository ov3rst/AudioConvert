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
            label1.Location = new Point(40, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 33);
            label1.TabIndex = 0;
            label1.Text = "Ruta o Url del Audio";
            // 
            // txtFileRoute
            // 
            txtFileRoute.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileRoute.Location = new Point(40, 180);
            txtFileRoute.Margin = new Padding(4, 5, 4, 5);
            txtFileRoute.Name = "txtFileRoute";
            txtFileRoute.Size = new Size(451, 49);
            txtFileRoute.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.White;
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(501, 180);
            btnBrowse.Margin = new Padding(4, 5, 4, 5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(156, 49);
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
            btnConvert.Location = new Point(40, 257);
            btnConvert.Margin = new Padding(4, 5, 4, 5);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(617, 50);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convertir a texto";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(40, 387);
            txtResult.Margin = new Padding(4, 5, 4, 5);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(615, 269);
            txtResult.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 343);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(297, 33);
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
            btnClear.Location = new Point(397, 668);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(134, 50);
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
            btnClose.Location = new Point(540, 668);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(117, 50);
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
            label3.Location = new Point(90, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(554, 58);
            label3.TabIndex = 8;
            label3.Text = "Convertidor Audio a Texto";
            // 
            // SelectAudioDialog
            // 
            SelectAudioDialog.Title = "Seleccione un audio";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(699, 740);
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
            Margin = new Padding(4, 5, 4, 5);
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
