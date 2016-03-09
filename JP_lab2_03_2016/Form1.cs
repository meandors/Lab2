using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace JP_lab2_03_2016
{
    public partial class Form1 : Form
    {
        MemoryStream memory;
        public Form1()
        {
            InitializeComponent();
            memory = new MemoryStream();
        }

        private void bPrzegladaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            fileDialog.ShowDialog();

            tbPath.Text = fileDialog.FileName;

        }

        private void bOdczyt_Click(object sender, EventArgs e)
        {
            if (rbPlik.Checked)
            {
                if (File.Exists(tbPath.Text))
                {
                    using (FileStream fileStream = new FileStream(tbPath.Text, FileMode.Open))
                    {

                        if (cbKompresja.Checked && cbSzyfrowanie.Checked)
                        { 
                            decryptAndDecompress(fileStream);
                        }
                        else if (cbKompresja.Checked && !cbSzyfrowanie.Checked)
                        {
                            decompress(fileStream);
                        }
                        else if (!cbKompresja.Checked && cbSzyfrowanie.Checked)
                        {
                            decrypt(fileStream);
                        }
                        else
                        {
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                tbResult.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
                else if (rbPamiec.Checked)
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        if (cbKompresja.Checked && cbSzyfrowanie.Checked)
                        { 
                            decryptAndDecompress(memoryStream);
                        }
                        else if (cbKompresja.Checked && !cbSzyfrowanie.Checked)
                        {
                            decompress(memoryStream);
                        }
                        else if (!cbKompresja.Checked && cbSzyfrowanie.Checked)
                        {
                            decrypt(memoryStream);
                        }
                        else
                        {
                            using (StreamReader reader = new StreamReader(memoryStream))
                            {
                                tbResult.Text = reader.ReadToEnd();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Brak pliku o podanej nazwie");
                }
            }
        }

        private void bZapis_Click(object sender, EventArgs e)
        {
            if (rbPlik.Checked)
            {
                using (FileStream fileStream = new FileStream(tbPath.Text, FileMode.Create))
                {
                    if (cbKompresja.Checked && cbSzyfrowanie.Checked)
                    {
                        encryptAndCompress(tbResult.Text, fileStream);
                    }
                    else if (cbKompresja.Checked && !cbSzyfrowanie.Checked)
                    {
                        compress(tbResult.Text, fileStream);
                    }
                    else if (!cbKompresja.Checked && cbSzyfrowanie.Checked)
                    {
                        encrypt(tbResult.Text, fileStream);
                        tbResult.Text = "";

                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(fileStream))
                        {
                            writer.Write(tbResult.Text);
                            tbResult.Text = "";
                            MessageBox.Show("Zapisano do pliku!");
                        }
                    }
                }
            }
            else if (rbPamiec.Checked)
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    if (cbKompresja.Checked && cbSzyfrowanie.Checked)
                    {
                        encryptAndCompress(tbResult.Text, memoryStream);
                    }
                    else if (cbKompresja.Checked && !cbSzyfrowanie.Checked)
                    {
                        compress(tbResult.Text, memoryStream);
                    }
                    else if (!cbKompresja.Checked && cbSzyfrowanie.Checked)
                    {
                        encrypt(tbResult.Text, memoryStream);
                        tbResult.Text = "";
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(memoryStream))
                        {
                            writer.Write(tbResult.Text);
                            tbResult.Text = "";
                            MessageBox.Show("Zapisano do pliku!");
                        }
                    }
                }
            }
        }
        public void decompress(Stream stream)
        {
            using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
            {
                using (StreamReader reader = new StreamReader(deflateStream))
                {
                    tbResult.Text = reader.ReadToEnd();
                }
            }
        }
        public void compress(string text, Stream stream)
        {
            using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Compress))
            {
                using (StreamWriter write = new StreamWriter(deflateStream))
                {
                    write.Write(tbResult.Text);
                    tbResult.Text = "";
                }
            }
        }
        public void encrypt(string text, Stream stream)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

            using (CryptoStream cryptoStream = new CryptoStream(stream, cryptic.CreateEncryptor(), CryptoStreamMode.Write))
            {
                using(StreamWriter writer = new StreamWriter(cryptoStream)){
                    writer.Write(text);
                    tbResult.Text = "";
                }
            }
        }
        public void decrypt(Stream stream)
        {
            
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

            using (CryptoStream cryptoStream = new CryptoStream(stream, cryptic.CreateDecryptor(), CryptoStreamMode.Read))
            {
                using (StreamReader reader = new StreamReader(cryptoStream))
                {
                    tbResult.Text = reader.ReadToEnd();
                }
            }
        }
        private void encryptAndCompress(string text, Stream stream)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");

            using (CryptoStream cryptoStream = new CryptoStream(stream, cryptic.CreateEncryptor(), CryptoStreamMode.Write))
            {
                using (DeflateStream compress = new DeflateStream(cryptoStream, CompressionMode.Compress))
                using (StreamWriter writer = new StreamWriter(cryptoStream))
                {
                    writer.Write(text);
                    tbResult.Text = "";
                }
            }
        }
        private void decryptAndDecompress(Stream stream)
        {
            DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();

            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            
            using (CryptoStream cryptoStream = new CryptoStream(stream, cryptic.CreateDecryptor(), CryptoStreamMode.Read))
            {
                using (DeflateStream decompress = new DeflateStream(cryptoStream, CompressionMode.Decompress))
                    using (StreamReader reader = new StreamReader(cryptoStream))
                    {
                        tbResult.Text = reader.ReadToEnd();
                    }
            }
        }
    }
}
