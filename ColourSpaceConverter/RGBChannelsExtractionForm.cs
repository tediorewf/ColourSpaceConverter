using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBitmap;

namespace ColourSpaceConverter
{
    public partial class RGBChannelsExtractionForm : Form
    {
        //private Bitmap[] colourChannels;

        public RGBChannelsExtractionForm()
        {
            InitializeComponent();
        }

        private void RGBChannelsExtractionForm_Load(object sender, EventArgs e)
        {

        }

        private void chooseImageButton_Click(object sender, EventArgs e)
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
                var baseBitmap = new Bitmap(filename);
                var colourChannels = ExctractChannels(baseBitmap);
                baseImagePictureBox.Image = baseBitmap;
                redChannelPictureBox.Image = colourChannels[0];
                blueChannelPictureBox.Image = colourChannels[1];
                greenChannelPictureBox.Image = colourChannels[2];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private static Bitmap[] ExctractChannels(Bitmap baseBitmap)
        {
            var colourChannels = new Bitmap[3];
            for (int _ = 0; _ < 3; _++)
            {
                colourChannels[_] = new Bitmap(baseBitmap.Width, baseBitmap.Height);
            }
            using (var fastBaseBitmap = new FastBitmap.FastBitmap(baseBitmap))
            {
                for (int x = 0; x < baseBitmap.Width; x++)
                {
                    for (int y = 0; y < baseBitmap.Height; y++)
                    {
                        var currentPixelColour = fastBaseBitmap[x, y];
                        colourChannels[0].SetPixel(x, y, 
                            Color.FromArgb(currentPixelColour.A, currentPixelColour.R, 0, 0));
                        colourChannels[1].SetPixel(x, y,
                            Color.FromArgb(currentPixelColour.A, 0, currentPixelColour.G, 0));
                        colourChannels[2].SetPixel(x, y, 
                            Color.FromArgb(currentPixelColour.A, 0, 0, currentPixelColour.B));
                    }
                }
            }

            return colourChannels;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
