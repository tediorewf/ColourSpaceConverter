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
    public partial class RGBChannelsExtractionForm : Form
    {
        public RGBChannelsExtractionForm()
        {
            InitializeComponent();
        }

        private void RGBChannelsExtractionForm_Load(object sender, EventArgs e)
        {

        }

        private void buildHistogramsButton_Click(object sender, EventArgs e)
        {
            var histogramForm = new HistogramForm();
            histogramForm.ShowDialog();
        }
    }
}
