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
using System.Linq;

namespace exe17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ficheiros XML|*.xml"; // filtrar o tipo de ficheiro
            openFileDialog1.Title = "Escolha o ficheiro XML"; // dar um título

            if(openFileDialog1.ShowDialog() == DialogResult.OK) // se estiver tudo bem no file, guardar dentro do tb
            {
                tb_ficheiro.Text = openFileDialog1.FileName;
            }
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            lst_imagens.Items.Clear();

            XmlDocument doc = new XmlDocument();

            doc.Load(tb_ficheiro.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/galeria/imagem"); // @ para fazer o escape dos carateres

            foreach(XmlNode node in nodelist)
            {
                XmlElement element = node as XmlElement; // para mostrar o conteudo dos atributos do ficheiro que estão dentro dos elementos
                lst_imagens.Items.Add(element.Attributes.GetNamedItem("ficheiro").Value);// adiciona o atributo do elemente com o nome ficheiro
            }
        }

        private void lst_imagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(tb_ficheiro.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/galeria/imagem");

            XmlNode node = nodelist.Item(lst_imagens.SelectedIndex); // para passar o id do que está selecionado

            XmlElement element = node as XmlElement; // para ir buscar o elemento

            tb_id.Text = element.Attributes.GetNamedItem("id").Value; // para mostrar o valor do id
            tb_descricao.Text = element.Attributes.GetNamedItem("descricao").Value; // para mostrar o valor da descrição
            tb_endereco.Text = element.Attributes.GetNamedItem("ficheiro").Value; // para mostrar o valor do ficheiro


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {


            XmlDocument doc = new XmlDocument();
            doc.Load(tb_ficheiro.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/galeria/imagem");

            XmlNode node = nodelist.Item(lst_imagens.SelectedIndex);
            XmlElement element = node as XmlElement;

            element.Attributes.GetNamedItem("id").Value = tb_id.Text;
            element.Attributes.GetNamedItem("descricao").Value = tb_descricao.Text;
            element.Attributes.GetNamedItem("ficheiro").Value = tb_endereco.Text;

            doc.Save(tb_ficheiro.Text);

            int temp = lst_imagens.SelectedIndex; // guarda numa temporária

            lst_imagens.Items.Clear(); // apaga

            foreach (XmlNode node2 in nodelist)
            {
                XmlElement element2 = node2 as XmlElement;
                lst_imagens.Items.Add(element2.Attributes.GetNamedItem("ficheiro").Value);
            }

            lst_imagens.SelectedIndex = temp; // volta a mostrar
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tb_ficheiro.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/galeria/imagem");

            XmlNode node = nodelist.Item(lst_imagens.SelectedIndex);
            XmlElement element = node as XmlElement;

            element.ParentNode.RemoveChild(nodelist[lst_imagens.SelectedIndex]);

            doc.Save(tb_ficheiro.Text);


            btn_carregar_Click(null, null);
            tb_id.Text = "";
            tb_descricao.Text = "";
            tb_endereco.Text = "";
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(tb_ficheiro.Text);

            XmlNodeList nodelist = doc.SelectNodes(@"/galeria/imagem");

            XmlNode node = doc.SelectSingleNode("/galeria");
            XmlElement element = doc.CreateElement("imagem");

            element.SetAttribute("id", tb_id.Text); // definir o atributo
            element.SetAttribute("descricao", tb_descricao.Text);
            element.SetAttribute("ficheiro", tb_endereco.Text);

           node.AppendChild(element); // adicionar

            doc.Save(tb_ficheiro.Text);


            btn_carregar_Click(null, null);
            tb_id.Text = "";
            tb_descricao.Text = "";
            tb_endereco.Text = "";
        }
    }
}

