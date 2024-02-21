using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sep_authenticator
{
    public partial class frmTemplate : Form
    {
        public frmTemplate()
        {
            InitializeComponent();
            // Create a private font collection
            PrivateFontCollection fonts = new PrivateFontCollection();

            // Add the embedded font
            fonts.AddFontFile(Path.Combine(Application.StartupPath, "JetBrainsMono.ttf"));

            // Create a Font object from the collection
            Font myFont = new Font(fonts.Families[0],40);

            // Apply the font to your UI elements
            label1.Font = myFont;

            tmrTick.Start();

        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value--;
        }
    }
}
