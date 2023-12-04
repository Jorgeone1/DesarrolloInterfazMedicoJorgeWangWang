namespace InterfazCreativa
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
            Panel panelRegistrarse;
            panelInicio = new Panel();
            label7 = new Label();
            textBoxContraseña = new TextBox();
            ContinuarInicio = new Button();
            textBoxUsuario = new TextBox();
            buttonRegistrarse = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBoxContraseñaRegistro = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            textBoxCorreo = new TextBox();
            buttonInicio = new Button();
            label5 = new Label();
            textUsuarioRegistrarse = new TextBox();
            textBoxContraseñaRegistroRepetir = new TextBox();
            label8 = new Label();
            panelRegistrarse = new Panel();
            panelRegistrarse.SuspendLayout();
            panelInicio.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegistrarse
            // 
            panelRegistrarse.BackColor = Color.FromArgb(192, 255, 255);
            panelRegistrarse.Controls.Add(button1);
            panelRegistrarse.Controls.Add(textBoxContraseñaRegistro);
            panelRegistrarse.Controls.Add(label4);
            panelRegistrarse.Controls.Add(label6);
            panelRegistrarse.Controls.Add(label3);
            panelRegistrarse.Controls.Add(textBoxCorreo);
            panelRegistrarse.Controls.Add(buttonInicio);
            panelRegistrarse.Controls.Add(label5);
            panelRegistrarse.Controls.Add(textUsuarioRegistrarse);
            panelRegistrarse.Controls.Add(textBoxContraseñaRegistroRepetir);
            panelRegistrarse.Controls.Add(label8);
            panelRegistrarse.Location = new Point(89, 75);
            panelRegistrarse.Name = "panelRegistrarse";
            panelRegistrarse.Size = new Size(279, 233);
            panelRegistrarse.TabIndex = 17;
            // 
            // panelInicio
            // 
            panelInicio.BackColor = Color.FromArgb(192, 255, 192);
            panelInicio.Controls.Add(label7);
            panelInicio.Controls.Add(textBoxContraseña);
            panelInicio.Controls.Add(ContinuarInicio);
            panelInicio.Controls.Add(textBoxUsuario);
            panelInicio.Controls.Add(buttonRegistrarse);
            panelInicio.Controls.Add(label1);
            panelInicio.Controls.Add(label2);
            panelInicio.Location = new Point(404, 75);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(279, 233);
            panelInicio.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(86, 18);
            label7.Name = "label7";
            label7.Size = new Size(109, 23);
            label7.TabIndex = 6;
            label7.Text = "Inicio Sesion";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(110, 111);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(152, 23);
            textBoxContraseña.TabIndex = 1;
            textBoxContraseña.TextChanged += textBox2_TextChanged;
            // 
            // ContinuarInicio
            // 
            ContinuarInicio.BackColor = Color.FromArgb(128, 255, 128);
            ContinuarInicio.Location = new Point(160, 181);
            ContinuarInicio.Name = "ContinuarInicio";
            ContinuarInicio.Size = new Size(87, 30);
            ContinuarInicio.TabIndex = 5;
            ContinuarInicio.Text = "Continuar";
            ContinuarInicio.UseVisualStyleBackColor = false;
            ContinuarInicio.Click += button2_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.White;
            textBoxUsuario.Location = new Point(110, 71);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(152, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // buttonRegistrarse
            // 
            buttonRegistrarse.BackColor = Color.FromArgb(128, 255, 128);
            buttonRegistrarse.Location = new Point(43, 181);
            buttonRegistrarse.Name = "buttonRegistrarse";
            buttonRegistrarse.Size = new Size(81, 30);
            buttonRegistrarse.TabIndex = 4;
            buttonRegistrarse.Text = "Registrarse";
            buttonRegistrarse.UseVisualStyleBackColor = false;
            buttonRegistrarse.Click += buttonRegistrarse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 74);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 114);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(162, 181);
            button1.Name = "button1";
            button1.Size = new Size(87, 30);
            button1.TabIndex = 12;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxContraseñaRegistro
            // 
            textBoxContraseñaRegistro.BackColor = Color.White;
            textBoxContraseñaRegistro.Location = new Point(115, 111);
            textBoxContraseñaRegistro.Name = "textBoxContraseñaRegistro";
            textBoxContraseñaRegistro.Size = new Size(152, 23);
            textBoxContraseñaRegistro.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 151);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 10;
            label4.Text = "Repetir Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 115);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 16;
            label6.Text = "Contraseña";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 38);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Usuario";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.White;
            textBoxCorreo.Location = new Point(115, 74);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(152, 23);
            textBoxCorreo.TabIndex = 13;
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = Color.FromArgb(128, 255, 255);
            buttonInicio.Location = new Point(45, 181);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(81, 30);
            buttonInicio.TabIndex = 11;
            buttonInicio.Text = "Inicio";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 77);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 14;
            label5.Text = "Correo";
            // 
            // textUsuarioRegistrarse
            // 
            textUsuarioRegistrarse.BackColor = Color.White;
            textUsuarioRegistrarse.Location = new Point(115, 42);
            textUsuarioRegistrarse.Name = "textUsuarioRegistrarse";
            textUsuarioRegistrarse.Size = new Size(152, 23);
            textUsuarioRegistrarse.TabIndex = 7;
            // 
            // textBoxContraseñaRegistroRepetir
            // 
            textBoxContraseñaRegistroRepetir.Location = new Point(115, 148);
            textBoxContraseñaRegistroRepetir.Name = "textBoxContraseñaRegistroRepetir";
            textBoxContraseñaRegistroRepetir.Size = new Size(152, 23);
            textBoxContraseñaRegistroRepetir.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(91, 16);
            label8.Name = "label8";
            label8.Size = new Size(101, 23);
            label8.TabIndex = 7;
            label8.Text = "Registrarse";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 384);
            Controls.Add(panelInicio);
            Controls.Add(panelRegistrarse);
            Name = "Form1";
            Text = "Form1";
            panelRegistrarse.ResumeLayout(false);
            panelRegistrarse.PerformLayout();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Label label1;
        private Label label2;
        private Button buttonRegistrarse;
        private Button ContinuarInicio;
        private Panel panelInicio;
        private TextBox textBoxContraseñaRegistroRepetir;
        private Button button1;
        private TextBox textUsuarioRegistrarse;
        private Button buttonInicio;
        private Label label3;
        private Label label4;
        private TextBox textBoxCorreo;
        private Label label5;
        private TextBox textBoxContraseñaRegistro;
        private Label label6;
        private Panel panelRegistrarse;
        private Label label7;
        private Label label8;
    }
}