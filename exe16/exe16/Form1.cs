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
using System.Xml.Linq;

namespace exe16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("formandos.xml");

            var formandos = from formando in doc.Descendants("formando")
                            select new
                            {
                                Nome = formando.Element("nome").Value,
                                Morada = formando.Element("morada").Value,
                                Email = formando.Element("email").Value,
                                Telef = formando.Element("telefone").Value,
                                Idade = formando.Element("idade").Value,
                                Curso = formando.Element("curso").Value,
                            };

            foreach (var formando in formandos)
            {
                 rtb_todos.Text += formando.Nome + " - " + formando.Morada + " - " + formando.Email + " - " + formando.Telef + " - " + formando.Idade + " - " + formando.Curso + "\n";
            }
                
            

            XmlDocument documento = new XmlDocument(); // é mais pequeno, quando não se precisa de ler o documento todo

            documento.Load("formandos.xml"); // carrega o ficheiro
            XmlNodeList nodelist = documento.SelectNodes("formandos/formando"); // vai buscar os nós na lista

            foreach (XmlNode node in nodelist)
            {
                if (!cbb_filtrar.Items.Contains(node.SelectSingleNode("curso").InnerText)) //só adiciona se não existir esse valor na combobox
                {
                    cbb_filtrar.Items.Add(node.SelectSingleNode("curso").InnerText); // mostra os valores na combobox que estão no texto do nó da plataforma
                }

            }

            var formandos25 = from formando in doc.Descendants("formando")
                              where Convert.ToInt32(formando.Element("idade").Value) > 25
                            select new
                            {
                                Nome = formando.Element("nome").Value,
                                Morada = formando.Element("morada").Value,
                                Email = formando.Element("email").Value,
                                Telef = formando.Element("telefone").Value,
                                Idade = formando.Element("idade").Value,
                                Curso = formando.Element("curso").Value,
                            };

            foreach (var formando in formandos25)
            {
                rtb_25.Text += formando.Nome + " - " + formando.Morada + " - " + formando.Email + " - " + formando.Telef + " - " + formando.Idade + " - " + formando.Curso + "\n";
            }

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            rtb_curso.Text = ""; // para que cada vez que filtre limpe a richtextbox

            XDocument xmlDoc = XDocument.Load("formandos.xml"); //carregar o ficheiro


                var formandos = from formando in xmlDoc.Descendants("formando")
                                where formando.Element("curso").Value == cbb_filtrar.SelectedItem.ToString()
                                select new
                                {
                                    Nome = formando.Element("nome").Value,
                                    Morada = formando.Element("morada").Value,
                                    Email = formando.Element("email").Value,
                                    Telef = formando.Element("telefone").Value,
                                    Idade = formando.Element("idade").Value,
                                    Curso = formando.Element("curso").Value,
                                };

                foreach (var formando in formandos)
                {
                    rtb_curso.Text += formando.Nome + " - " + formando.Morada + " - " + formando.Email + " - " + formando.Telef + " - " + formando.Idade + " - " + formando.Curso + "\n";
                }
            }
        }
    }
