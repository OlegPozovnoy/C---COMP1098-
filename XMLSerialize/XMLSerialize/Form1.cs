using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XMLSerialize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            richTextBoxAddress.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            MySerializer serializer = new MySerializer();

            Person person;

            string fileName;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                fileName = openFileDialog1.FileName;


                StreamReader reader = new StreamReader(fileName);
                person = MySerializer.Deserialize(reader);
                reader.Close();

                this.textBoxName.Text = person.Name;
                this.textBoxEmail.Text = person.Email;
                this.richTextBoxAddress.Text = person.Address;


            }
            //Console.WriteLine(result); // <-- For debugging use.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = this.textBoxName.Text;
            person.Email = this.textBoxEmail.Text;
            person.Address = this.richTextBoxAddress.Text;

            var fileResult = saveFileDialog1.ShowDialog();

            
            TextWriter writer = new StreamWriter(saveFileDialog1.FileName);

            MySerializer.Serialize(writer, person);

            writer.Close();
        }
    }
}
