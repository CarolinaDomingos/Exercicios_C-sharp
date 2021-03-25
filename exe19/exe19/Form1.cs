using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;

namespace exe19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ficheiro_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ficheiros XML|*.xml"; // filtrar o tipo de ficheiro
            openFileDialog1.Title = "Escolha o ficheiro XML"; // dar um título

            if (openFileDialog1.ShowDialog() == DialogResult.OK) // se estiver tudo bem no file, guardar dentro do tb
            {
                tb_caminho.Text = openFileDialog1.FileName;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int resposta;
            resposta = Convert.ToInt32(MessageBox.Show("Tem a certeza que pretende sair?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (resposta == 6) // se estiver tudo bem no file, guardar dentro do tb
            {
                Application.Exit();
            }
        }

        private void novoUtilizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novo form_novo = new novo();
            form_novo.Show();

        }

        private void btn_lerficheiro_Click(object sender, EventArgs e)
        {
            lst_utilizadores.Items.Clear();

            XmlDocument doc = new XmlDocument();

            doc.Load(tb_caminho.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/utilizadores/utilizador"); // @ para fazer o escape dos carateres

            foreach (XmlNode node in nodelist)
            {
                XmlElement element = node as XmlElement; 
                lst_utilizadores.Items.Add(element.Attributes.GetNamedItem("user").Value);
            }
        }
        
        private void lst_utilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(tb_caminho.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/utilizadores/utilizador");

            XmlNode node = nodelist.Item(lst_utilizadores.SelectedIndex); 

            XmlElement element = node as XmlElement; 

            tb_utilizador.Text = element.Attributes.GetNamedItem("user").Value; 
            tb_palavrapasse.Text = DecryptString(element.Attributes.GetNamedItem("pw").Value); 

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tb_caminho.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/utilizadores/utilizador");

            XmlNode node = nodelist.Item(lst_utilizadores.SelectedIndex);
            XmlElement element = node as XmlElement;

            element.Attributes.GetNamedItem("user").Value = tb_utilizador.Text;
           // tb_palavrapasse.Text = DecryptString(element.Attributes.GetNamedItem("pw").Value);
            element.Attributes.GetNamedItem("pw").Value = EncryptString(tb_palavrapasse.Text);
           

            doc.Save(tb_caminho.Text);

            int temp = lst_utilizadores.SelectedIndex; // guarda numa temporária

            lst_utilizadores.Items.Clear(); // apaga

            lst_utilizadores.SelectedIndex = temp; // volta a mostrar
        }
       

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tb_caminho.Text);

            int resposta;
            resposta = Convert.ToInt32(MessageBox.Show($"Tem a certeza que pretende eliminar o utilizador {tb_utilizador.Text}?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            
            if (resposta == 6) // se estiver tudo bem no file, guardar dentro do tb
            {
                XmlNodeList nodelist = doc.SelectNodes(@"/utilizadores/utilizador");

                XmlNode node = nodelist.Item(lst_utilizadores.SelectedIndex);
                XmlElement element = node as XmlElement;

                element.ParentNode.RemoveChild(nodelist[lst_utilizadores.SelectedIndex]);

                doc.Save(tb_caminho.Text);


                lst_utilizadores.Items.Clear(); // apaga

                foreach (XmlNode node2 in nodelist)
                {
                    XmlElement element2 = node2 as XmlElement;
                    lst_utilizadores.Items.Add(element2.Attributes.GetNamedItem("user").Value);
                }
            }

           else if( resposta == 7)
            {
                MessageBox.Show("Eliminou o utilizador");
            }

            

            
        }

        public static string EncryptString(string Message)
        {
            string Passphrase = "atec";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);

            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the encrypted string as a base64 encoded string

            string enc = Convert.ToBase64String(Results);
            enc = enc.Replace("+", "KKK");
            enc = enc.Replace("/", "JJJ");
            enc = enc.Replace("\\", "III");

            return enc;
        }

        public static string DecryptString(string Message)
        {
            string Passphrase = "atec";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();

            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below

            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));

            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();

            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;

            // Step 4. Convert the input string to a byte[]

            Message = Message.Replace("KKK", "+");
            Message = Message.Replace("JJJ", "/");
            Message = Message.Replace("III", "\\");


            byte[] DataToDecrypt = Convert.FromBase64String(Message);

            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }

            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);
        }
    }
}
