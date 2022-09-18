using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourSpaceConverter
{
    public partial class RGBToGrayScaleForm : Form
    {
        public RGBToGrayScaleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TrySetImage(ofd.FileName);
            }
        }
        private void TrySetImage(string filename)
        {
            try
            {
               /* var baseBitmap = new Bitmap(filename);
                var colourChannels = ExctractChannels(baseBitmap);
                var histogramBitmap = CreateHistogram(baseBitmap, histogramPictureBox.Size);
                baseImagePictureBox.Image = baseBitmap;
                redChannelPictureBox.Image = colourChannels[0];
                blueChannelPictureBox.Image = colourChannels[1];
                greenChannelPictureBox.Image = colourChannels[2];
                histogramPictureBox.Image = histogramBitmap;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
