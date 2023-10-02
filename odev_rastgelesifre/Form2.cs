using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_rastgelesifre
{
    public partial class Form2 : Form
    {
        private List<string> parolalar;

        public Form2(List<string> parolalar)
        {
            InitializeComponent();
            this.parolalar = parolalar;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            int sayac = 0;
            foreach (string parola in parolalar)
            {
                listBox1.Items.Add($"{sayac+1}-) {parola}");
                sayac++;
            }
        }
    }
}
