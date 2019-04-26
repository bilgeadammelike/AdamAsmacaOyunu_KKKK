using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        List<string> m_listKelimeler = new List<string>();
        public Form1()
        {
            InitializeComponent();

            m_listKelimeler.Add("TELEFON");
            m_listKelimeler.Add("DEFTER");
            m_listKelimeler.Add("KITAP");
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char cAlfabe = 'A'; cAlfabe <= 'Z'; cAlfabe++)
            {
                Button button = new Button();
                button.Text = cAlfabe.ToString();
                button.Width = 25;
                button.Height = 25;

                button.Click += Btn_Click;

                flpAlfabe.Controls.Add(button);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            button.Enabled = false;
        }
    }
}
