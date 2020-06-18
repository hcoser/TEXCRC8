using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEX.CRC8;

namespace ExemploCRC8
{
    public partial class frmCRC8 : Form
    {
        public frmCRC8()
        {
            InitializeComponent();
        }

        private void btnCalcularCRC_Click(object sender, EventArgs e)
        {
            byte crc = cCRC8.crc8(0, txtTexoOriginal.Text);

            lblValorCRC.Text = crc.ToString();

        }
    }
}
