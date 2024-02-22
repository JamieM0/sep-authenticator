using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Collections.Specialized;
using sep_authenticator.Models;
using sep_authenticator.DAL;
using System.Drawing.Text;
using System.IO;
using OtpNet;
using ZXing;

namespace sep_authenticator
{
    public partial class frmMain : Form
    {
        Token[] tokens;
        Totp[] totps;
        Label[] codes;
        CircularProgressBar[] bars;
        public frmMain()
        {
            InitializeComponent();
            AddToMainMenu();

            totps = new Totp[tokens.Length];
            //CircularProgressBar Arrays
            bars = new CircularProgressBar[tokens.Length];
            codes = new Label[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                totps[i] = new Totp(Base32Encoding.ToBytes(tokens[i].Secret));
                //foreach(Panel pnl in pnlTokenHolder.Controls)
                //{
                //    bars[i] = (CircularProgressBar)pnl.Controls.Find()
                //}
                bars[i] = (CircularProgressBar)pnlTokenHolder.Controls.Find("bar_" + tokens[i].Id, true).FirstOrDefault();
                codes[i] = (Label)pnlTokenHolder.Controls.Find("lbCode_" + tokens[i].Id, true).FirstOrDefault();
            }
            RefreshValues();
            tmrTick.Start();
        }

        private void addTokenFromSetupKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAddToken.Visible = true;
        }

        private void btnAddToken_Click(object sender, EventArgs e)
        {
            AddToken();
        }

        private void AddToken()
        {
            // Assume a variable (string setupCode) contains the setup code
            // For example: setupCode = "otpauth://totp/Example:user@example.com?secret=JBSWY3DPEHPK3PXP&issuer=Example"
            // If invalid, append otpauth://totp/ to the start of the setup code

            bool validSetupKey = false;
            string setupCode = txtSetupKey.Text;
            string originalSetupCode = setupCode;
            int i = 0;
            do
            {
                try
                {
                    // Parse the setup code as a URI
                    Uri uri = new Uri(setupCode);

                    string scheme = uri.Scheme;

                    string path = uri.AbsolutePath;

                    string[] pathParts = path.Split(':');

                    string type = pathParts[0].TrimStart('/');

                    string label = pathParts[1];

                    string[] labelParts = label.Split(':');

                    string issuerFromLabel = labelParts.Length > 1 ? labelParts[0] : null;

                    string name = labelParts.Last();

                    string query = uri.Query;

                    NameValueCollection queryParameters = HttpUtility.ParseQueryString(query);

                    string secret = queryParameters["secret"];

                    string issuerFromQuery = queryParameters["issuer"];

                    string issuer = issuerFromQuery ?? issuerFromLabel;
                    //MessageBox.Show(name);
                    //MessageBox.Show(issuer);
                    //MessageBox.Show(secret);
                    //Console.WriteLine($"Issuer: {issuer}");
                    //Console.WriteLine($"Name: {name}");
                    Token token = new Token(name, secret, issuer, DateTime.Now, DateTime.Now);
                    TokenDAL.AddToken(token);
                    validSetupKey = true;
                    Hide();
                    new frmMain().Show();
                }
                catch
                {
                    if (i == 0)
                        setupCode = "totp/" + originalSetupCode;
                    else if (i == 1)
                        setupCode = "otpauth://" + originalSetupCode;
                    else if (i == 2)
                        setupCode = "otpauth://totp/" + originalSetupCode;
                    else if (i == 3)
                        break;
                    i++;
                    validSetupKey = false;

                }
            } while (validSetupKey == false);

            if (validSetupKey == false)
            {
                MessageBox.Show("Invalid Setup Key");
            }
        }

        private void AddToMainMenu()
        {
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile(Path.Combine(Application.StartupPath, "JetBrainsMono.ttf"));
            Font JetBrains16 = new Font(fonts.Families[0], 16);
            Font JetBrains14 = new Font(fonts.Families[0], 14);
            Font JetBrains12 = new Font(fonts.Families[0], 12);
            Font JetBrains40 = new Font(fonts.Families[0], 40);

            Token[] localTokens = TokenDAL.GetTokens();
            tokens = localTokens;
            foreach(Token token in localTokens)
            {
                int x,y = 0;
                //1. Get Token Container (Panel) Location. If ID is even (or 0) it's on the left, otherwise it's on the right.
                if (token.Id % 2 == 0)
                    x = 502;
                else
                    x = 14;
                y = 0 + ((tokens.Length / 2)-1) * 146;
                Panel pnl = new Panel();
                pnl.Size = new Size(494, 120);
                pnl.Location = new Point(x, y);
                pnlTokenHolder.Controls.Add(pnl);

                //2. Initialise Username/Issuer Label
                Label name = new Label();
                name.Text = $"{token.Issuer} ({token.Name})";
                name.Font = JetBrains14;
                name.Location = new Point(0, 4);
                name.AutoSize = true;
                pnl.Controls.Add(name);

                //3. Initialise More Button
                Button more = new Button();
                more.Font = JetBrains12;
                more.Location = new Point(432,50);
                more.Size=new Size(52, 27);
                more.Text = "...";
                more.Tag = token.Id;
                more.Click += More_Click;
                more.BringToFront();
                pnl.Controls.Add(more);

                //4. Circular Progress Bar
                CircularProgressBar bar = new CircularProgressBar();
                bar.Font = JetBrains16;
                bar.Location = new Point(0, 20);
                bar.Size = new Size(100, 100);
                bar.Maximum = 30;
                bar.Text = "30";
                bar.Value = 30;
                bar.BarColor1 = Color.LimeGreen;
                bar.BarColor2 = Color.DeepSkyBlue;
                bar.ForeColor = Color.DimGray;
                bar.LineColor = Color.DimGray;
                bar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
                bar.ProgressShape = CircularProgressBar._ProgressShape.Flat;
                bar.TextMode = CircularProgressBar._TextMode.Value;
                bar.Name = "bar_" + token.Id;
                pnl.Controls.Add(bar);

                //5. Initialise Code Label
                Label code = new Label();
                code.Font = JetBrains40;
                code.Location = new Point(91,33);
                code.Text = "000000";
                code.AutoSize = true;
                code.Name = "lbCode_" + token.Id;
                pnl.Controls.Add(code);

                //6. Setup ID Label
                Label ID = new Label();
                ID.Location = new Point(0, 0);
                ID.Text = token.Id.ToString();
                ID.Visible = false;
                pnl.Controls.Add(ID);
            }
        }

        private void More_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //Get button name from the sender
            int ID = Convert.ToInt32(((Button)sender).Tag);
            Token token = TokenDAL.GetTokenFromID(ID);
            Hide();
            new frmAddEntry(true, token).Show();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTokenClose_Click(object sender, EventArgs e)
        {
            pnlAddToken.Visible = false;
        }

        bool changed = false;
        private void RefreshValues()
        {
            for(int i=0; i<tokens.Length; i++)
            {
                if (codes[i].Text != totps[i].ComputeTotp())
                    changed = true;
                codes[i].Text = totps[i].ComputeTotp();
            }
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            foreach(CircularProgressBar bar in bars)
            {
                bar.Value--;
                if (bar.Value == 0 || changed)
                {
                    changed = false;
                    RefreshValues();
                    bar.Value = 30;
                }
            }
        }

        Image QRCode = null;
        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Allow copy effect
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Disallow drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            // Check if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Get the image from the data
                QRCode = (Image)e.Data.GetData(DataFormats.Bitmap);
                // Do something with the image
                Console.WriteLine("Image size: {0} x {1}", QRCode.Width, QRCode.Height);
                BarcodeReader reader = new BarcodeReader();
                reader.AutoRotate = true;
                reader.TryInverted = true;
                reader.Options.PossibleFormats = new List<BarcodeFormat>();
                reader.Options.PossibleFormats.Add(BarcodeFormat.QR_CODE);
                using(var image = (Bitmap)QRCode)
                {
                    var result = reader.Decode(image);
                    if(result != null)
                    {
                        txtSetupKey.Text = result.Text;
                        MessageBox.Show(result.Text);
                        AddToken();
                    }
                    else
                    {
                        MessageBox.Show("No QR Code found in the image.");
                    }
                }
            }
            else
            {
                // No image found in the data
                Console.WriteLine("No image found in the data");
            }
        }

        private void pnlTokenHolder_DragDrop(object sender, DragEventArgs e)
        {
            // Check if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Get the image from the data
                QRCode = (Image)e.Data.GetData(DataFormats.Bitmap);
                // Do something with the image
                Console.WriteLine("Image size: {0} x {1}", QRCode.Width, QRCode.Height);
                BarcodeReader reader = new BarcodeReader();
                reader.AutoRotate = true;
                reader.TryInverted = true;
                reader.Options.PossibleFormats = new List<BarcodeFormat>();
                reader.Options.PossibleFormats.Add(BarcodeFormat.QR_CODE);
                using (var image = (Bitmap)QRCode)
                {
                    var result = reader.Decode(image);
                    if (result != null)
                    {
                        txtSetupKey.Text = result.Text;
                        MessageBox.Show(result.Text);
                        AddToken();
                    }
                    else
                    {
                        MessageBox.Show("No QR Code found in the image.");
                    }
                }
            }
            else
            {
                // No image found in the data
                Console.WriteLine("No image found in the data");
            }
        }

        private void pnlTokenHolder_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data is an image
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                // Allow copy effect
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Disallow drop
                e.Effect = DragDropEffects.None;
            }
        }

        private void addCustomTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmAddEntry().Show();
        }
    }
}
