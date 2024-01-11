using Interfaz2;
using System.Runtime.InteropServices;
/**
 * Autor: Jorge Wang Wang
 */

namespace InterfazBancoTemaNuevo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Metodo que inicia el formulario
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            // Agrega un manejador de eventos SizeChanged al panelContenedor
            panelContenedor.SizeChanged += PanelContenedor_SizeChanged;

        }
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        /// <summary>
        /// Actualiza el tamaño de la imagen cada vez que haya un cambio de tamaño del panel
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">argumentos del evento</param>
    
        private void PanelContenedor_SizeChanged(object sender, EventArgs e)
        {
            // Calcula el nuevo tamaño para pictureBox1 y label1
            int newWidth = panelContenedor.ClientSize.Width;
            int newHeight = panelContenedor.ClientSize.Height;

            pictureBox1.Size = new Size((newWidth - 100) / 2, newHeight / 2);

            // Actualiza la ubicación del label en relación con panelContenedor
            label1.Location = new Point((newWidth - 250) / 3, (newHeight + 20) / 2);
            label1.Size = new Size(newWidth / 2, newHeight / 2);

        }
        /// <summary>
        /// Sobrescribe el manejo personalalizado de los mensajes de windows para redimensionar la aplicacion
        /// </summary>
        /// <param name="msg"> mensaje de windows</param>
        protected override void WndProc(ref Message msg)
        {
            switch (msg.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref msg);
                    var hitpoint = this.PointToClient(new Point(msg.LParam.ToInt32() & 0xffff, msg.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitpoint))
                        msg.Result = new IntPtr(HTBOTTOMRIGHT);

                    break;
                default:
                    base.WndProc(ref msg);
                    break;
            }
        }
        /// <summary>
        /// Sobrescribe el evento de cambio de tamaño de la aplicacion dando un minimo la cual puede disminuir
        /// </summary>
        /// <param name="e">argumentos del evento</param>
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);


            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        /// <summary>
        /// metodo para sobrescribir la zona del agarre de la aplicacion para darle otro toque.
        /// </summary>
        /// <param name="e">argumentos del evento de pintura</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush bluebrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(bluebrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);

        }
        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Metodo que realiza las acciones al pulsar, en este caso minimiza el programa
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">argumentos del evento</param>
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;
        /// <summary>
        /// Metodo que al pulsar el boton, la aplicacion ocupa toda la pantalla
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">argumentos del evento</param>
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            pictureBox1.Size = new Size(898, 678);//449k 339
            pictureBox1.Location = new Point(292, 99);
            label1.Location = new Point(755, 670);
            label1.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        /// <summary>
        /// Boton que al pulsar cierra la aplicación
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumento</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metodo que al pulsar el boton, vuelve a su tamaño original antes de ser maximizado
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumento</param>
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            pictureBox1.Size = new Size(449, 339);
            pictureBox1.Location = new Point(196, 79);
            label1.Location = new Point(361, 370);
            label1.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// Metodo que permite agarrar el panel para poder mover la aplicacion.
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e"> eventos del argumentos</param>
        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// metodo que al pulsar el boton abre el formulario 2 y cambie su color
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumentos</param>
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
            button1.BackColor = Color.FromArgb(12, 61, 92);
        }
        /// <summary>
        /// metodo que al pulsar el boton abre el formulario 3 y cambie su color
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumentos</param>
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
            InicioSesion.BackColor = Color.FromArgb(12, 61, 92);
        }
        /// <summary>
        /// metodo que al pulsar el boton abre el formulario 6 y cambie su color
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumentos</param>
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form6>();
            button3.BackColor = Color.FromArgb(12, 61, 92);
        }
        /// <summary>
        /// metodo que sustituye el panelContendor principal con la ventana del formulario y con sus funciones.
        /// </summary>
        /// <typeparam name="miForm">el form llamado</typeparam>
        private void AbrirFormulario<miForm>() where miForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<miForm>().FirstOrDefault(); ;
            if (formulario == null)
            {
                formulario = new miForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }
        /// <summary>
        /// Metodo que cuando detecta que el formulario que sustituyo al panelContenedor se cierre, el boton vuelve al boton su color original.
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumento</param>
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form2"] == null)
                button1.BackColor = Color.FromArgb(37, 54, 75);
            if (Application.OpenForms["Form3"] == null)
                InicioSesion.BackColor = Color.FromArgb(37, 54, 75);
            if (Application.OpenForms["Form4"] == null)
                button3.BackColor = Color.FromArgb(37, 54, 75);
            if (Application.OpenForms["Form5"] == null)
                button4.BackColor = Color.FromArgb(37, 54, 75);
            if (Application.OpenForms["Form6"] == null)
                button5.BackColor = Color.FromArgb(37, 54, 75);
        }
        /// <summary>
        /// Metodo que sustituye el panelContenedor por el formulario 5 y cambia el color del boton
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumentos</param>
        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form5>();
            button4.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que sustituye el panelContenedor por el formulario 4 y cambia el color del boton
        /// </summary>
        /// <param name="sender">el objeto que hace funcionar el evento</param>
        /// <param name="e">eventos del argumentos</param>
        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
            button5.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}