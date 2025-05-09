using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaskeun_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Tentukan path ke gambar yang ingin ditampilkan
            //string imagePath = Properties.Resources.Screenshot_2025_05_08_222120;
            Image img = Properties.Resources.Free_Vector___Abstract_background_gradient_colorful_design;

            // Gambar gambar di panel
            e.Graphics.DrawImage(img, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }
    }
}
