using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Ugulama2Sayfa164
{
    public partial class FormB : Form
    {


        public FormB()
        {
            InitializeComponent();
        }

        private void FormB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FormB click olayı çalışıyor.");
        }

        private void FormB_Load(object sender, EventArgs e)
        {
            this.Text = "Form Sınıfı Uygulama 2";
            this.BackColor = Color.Green;
            this.ForeColor = Color.Black;
            this.Size = new Size(300, 150);
            lblAdSoyad.Text = "Adınız";
            lblAdSoyad.Location = new Point(10, 10);
            lblAdSoyad.Size = new Size(65, 15);
            lblAdSoyad.ForeColor = Color.White;
            txtAdSoyad.Location = new Point(75, 10);
            txtAdSoyad.Size = new Size(150, 15);
            txtAdSoyad.TabIndex = 1;
            btnGiris.Text = "Tıkla";
            btnGiris.Location = new Point(100, 60);
            btnGiris.Size = new Size(100, 30);
            btnGiris.ForeColor = Color.White;
            btnGiris.BackColor = Color.Black;
            btnGiris.TabIndex = 2;
            txtAdSoyad.KeyPress += txtAdSoyad_KeyPress;
            btnGiris.Click += btnGiris_Click;
            this.Controls.Add(lblAdSoyad);
            this.Controls.Add(txtAdSoyad);
            this.Controls.Add(btnGiris);
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba " +txtAdSoyad.Text);
        }
    }
}
