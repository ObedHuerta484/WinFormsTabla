namespace WinFormsTabla
{
    partial class Form1
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
            panelprincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.DarkTurquoise;
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(12, 12);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(776, 426);
            panelprincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkTurquoise;
            label1.Font = new Font("Bahnschrift Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(609, 372);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 5;
            label1.Text = "Obed Josue ";
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.DeepSkyBlue;
            richTextBoxresultados.Font = new Font("Poor Richard", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxresultados.ForeColor = Color.Transparent;
            richTextBoxresultados.Location = new Point(401, 98);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(183, 278);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonver.ForeColor = Color.Red;
            buttonver.Location = new Point(95, 336);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(167, 40);
            buttonver.TabIndex = 3;
            buttonver.Text = "Ver tabla";
            buttonver.UseVisualStyleBackColor = true;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxnum.Location = new Point(95, 187);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(81, 31);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.BackColor = Color.White;
            labelnumero.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelnumero.ForeColor = Color.MediumSeaGreen;
            labelnumero.Location = new Point(95, 98);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(274, 30);
            labelnumero.TabIndex = 1;
            labelnumero.Text = " ¿Cual tabla quieres? ";
            labelnumero.Click += labelnumero_Click;
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.BackColor = Color.White;
            labeltitulo.Font = new Font("Stencil", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitulo.ForeColor = Color.Blue;
            labeltitulo.Location = new Point(20, 22);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(455, 44);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = " Tabla de Multiplicar ";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Label label1;
    }
}
