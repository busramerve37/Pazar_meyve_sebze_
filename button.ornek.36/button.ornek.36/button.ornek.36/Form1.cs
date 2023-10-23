using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstTum.Items.Count; i++)
            {
                if (lstTum.Items[i].ToString() == "MUZ" ||
                lstTum.Items[i].ToString() == "ÇİLEK" ||
                lstTum.Items[i].ToString() == "ŞEFTALİ")
                {
                    lstMeyveler.Items.Add(lstTum.Items[i]);
                }
                else
                {
                    lstSebzeler.Items.Add(lstTum.Items[i]);
                }


                
            }
            
        }
    }
}
