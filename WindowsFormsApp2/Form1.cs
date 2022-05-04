using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Dog barbos = new Dog("Barbos"); // создаем объект класса 
        public Form1()
        {
            InitializeComponent();
        }
        // Form1_Load отвечает за то, что появиться в форме при загрузке 
        private void Form1_Load(object sender, EventArgs e)
        {
            // помещаем в pictureBox1 фото собаки и Stretch под размеры pictureBox1 
            pictureBox1.Image = Image.FromFile("C:\\2dog.gif"); pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            button1.Text = "Dog Voice"; // текст на кнопке 
            label1.Text = ""; // текст на label 
            label1.Font = new Font("Serif", 10, FontStyle.Bold);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            barbos.Dog_gav("C:\\dog8.wav"); 
            label1.Text = "My name is " + barbos.getDogName();
        }
        }
    }
