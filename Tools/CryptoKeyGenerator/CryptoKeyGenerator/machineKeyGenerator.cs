using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKeyGenerator
{   //http://msdn.microsoft.com/en-us/library/w8h3skw9%28v=vs.100%29.aspx
    public partial class machineKeyGenerator : Form
    {
        private const string CONFIG_FMT = "<machineKey validationKey=\"{0}\"\r\n            decryptionKey=\"{2}\"\r\n            validation=\"{1}\"\r\n            decryption=\"{3}\" />";

        public machineKeyGenerator()
        {
            InitializeComponent();
        }

        private void generateConfig_Click(object sender, EventArgs e)
        {
            string valKey = Generate(int.Parse(validationLength.Text));
            string decKey = Generate(int.Parse(decryptionLength.Text));
            string valType = validationFormat.Text;
            string decType = decryptionFormat.Text;

            resultingConfig.Text = string.Format(CONFIG_FMT,valKey, valType, decKey, decType);
        }

        private string Generate(int len)
        {
            byte[] buff = new byte[len / 2];
            RNGCryptoServiceProvider rng = new
                                    RNGCryptoServiceProvider();
            rng.GetBytes(buff);
            StringBuilder sb = new StringBuilder(len);

            for (int i = 0; i < buff.Length; i++)
                sb.Append(string.Format("{0:X2}", buff[i]));

            return sb.ToString();
        }

        private void validationFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drp = (ComboBox)sender;
            switch (drp.Text) {
                case ("AES"):
                    validationLength.Text = "64";
                    validationLength.ReadOnly = true;
                    break;
                case ("MD5"):
                    validationLength.Text = "32";
                    validationLength.ReadOnly = true;
                    break;
                case ("SHA1"):
                    validationLength.Text = "40";
                    validationLength.ReadOnly = true;
                    break;
                case ("3DES"):
                    validationLength.Text = "48";
                    validationLength.ReadOnly = true;
                    break;
                case ("HMACSHA256"):
                    validationLength.Text = "64";
                    validationLength.ReadOnly = true;
                    break;
                case ("HMACSHA384"):
                    validationLength.Text = "96";
                    validationLength.ReadOnly = true;
                    break;
                case ("HMACSHA512"):
                    validationLength.Text = "128";
                    validationLength.ReadOnly = true;
                    break;
                case ("alg"):
                    validationLength.Text = "0";
                    validationLength.ReadOnly = false;
                    break;
                default: //other
                    break;
            }
        }

        private void decryptionFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drp = (ComboBox)sender;
            switch (drp.Text)
            {
                case ("AES"):
                    decryptionLength.Text = "64";
                    decryptionLength.ReadOnly = true;
                    break;
                case ("DES"):
                    decryptionLength.Text = "16";
                    decryptionLength.ReadOnly = true;
                    break;
                case ("3DES"):
                    decryptionLength.Text = "48";
                    decryptionLength.ReadOnly = true;
                    break;
                case ("alg"):
                    decryptionLength.Text = "0";
                    decryptionLength.ReadOnly = false;
                    break;
                default: //other
                    break;
            }
        }
    }
}
