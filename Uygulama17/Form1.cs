using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama17
{
    public partial class Form1 : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnumara_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(txtnumara.Text, out int sonuc))
            {
                errorProvider.SetError(txtnumara, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(txtnumara, "Numara girişi hatalı");
            }
        }

        private void txtAdSoyad_Validating(object sender, CancelEventArgs e)
        {
            {
                if (txtAdSoyad.Text == "")
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtAdSoyad, "Adı ve soyadı giriniz.");
                }
                else
                {
                    errorProvider.SetError(txtAdSoyad, "");
                }
            }
        }

        private void txtDersNotu_Validating(object sender, CancelEventArgs e)
        {
            int dersNotu;
            if (int.TryParse(txtDersNotu.Text, out dersNotu))
            {
                if (dersNotu < 0 || dersNotu > 100)
                {
                    e.Cancel = true;
                    errorProvider.SetError(txtDersNotu, "0 - 100 arasında değer giriniz.");
                }
                else
                {
                    errorProvider.SetError(txtDersNotu, "");
                }
            }
                else
            {
                e.Cancel = true;
                errorProvider.SetError(txtDersNotu, "Sayısal değer giriniz.");
            }
        }
    }
}
    

