using sep_authenticator.DAL;
using sep_authenticator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sep_authenticator.Models;

namespace sep_authenticator
{
    public partial class frmAddEntry : Form
    {
        string image;
        Token editToken;
        public frmAddEntry()
        {
            InitializeComponent();
        }
        public frmAddEntry(bool editMode, Token token)
        {
            InitializeComponent();
            if (editMode)
            {
                txtUsername.Text = token.Name;
                txtSetupKey.Text = token.Secret;
                txtIssuer.Text = token.Issuer;
                //btnAdd.Text = "Save";
            }
            //btnSaveEntry.Text = "Save & Close";
            btnCancel.Text = "Delete";
            editToken = token;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(btnCancel.Text!="Delete")
            {
                Hide();
                new frmMain().Show();
            }
            else
            {
                //Delete entry
                TokenDAL.DeleteToken(editToken);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the open file dialog to select an image
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Display the selected image in the picture box
                pbImage.Image = new Bitmap(ofd.FileName);
                image = ofd.FileName;
            }
        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            Token token = new Token(txtUsername.Text, txtSetupKey.Text,txtIssuer.Text,DateTime.Now,DateTime.Now);
            if (editToken == null || editToken == new Token())
                TokenDAL.AddToken(token);
            else
                TokenDAL.EditToken(token);
            Hide();
            new frmMain().Show();
        }
    }
}
