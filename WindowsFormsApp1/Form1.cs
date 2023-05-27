using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listName = new List<string>();
        string mydocu = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        StringBuilder passwordSymb = new StringBuilder();
        Random random = new Random();
        static public AutoResetEvent _waitHandle = new AutoResetEvent(true);
        public Form1()
        {
            InitializeComponent();
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            size();
            CreateSymbCollection();

        }
        private void size()
        {
            int x = this.Width = 250;
            int y = this.Height = 270;
            var CBSize = new Size(x, y);
            this.MinimumSize = this.MaximumSize = this.Size = CBSize;
        }

        private void CreateSymbCollection()
        {
            for (int i = (int)'A'; i <= (int)'z'; i++)
            {
                if (i <= (int)'Z' || i >= (int)'a')
                {                   
                    passwordSymb.Append((char)i);
                }
            }
            for (int i = (int)'0'; i <= (int)'9'; i++)
            {

                passwordSymb.Append((char)i);
            }
            string specSymb = "!@#$%^&*()";
            for (int i = 0; i < specSymb.Length; i++)
            {
                passwordSymb.Append(specSymb[i]);
            }

        }
        private void Record(string path, string text)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
            }
        }
       
        private void button_add_name_MouseClick(object sender, MouseEventArgs e)
        {

            listName.Add(textBox_nameIN.Text);
            textBox_nameIN.Clear();
            textBox_nameOUT.Clear();
            listName.ForEach(x => textBox_nameOUT.Text += x + "\r\n");

        }
        private List<string> CreateRandomPassword()
        {
            
            List<string> passwordList = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                string pass = "";
                for (int j = 0; j < 12; j++)
                {
                   
                    pass += passwordSymb[random.Next(passwordSymb.Length)];
                   
                }
                passwordList.Add(pass);
            }            
            return passwordList;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i <listName.Count; i++)
            {
                Thread tr = new Thread(() => { Go(listName[i]); });
                tr.Name = (i+1).ToString() + " Поток";
                tr.Start();
                Record(mydocu + @"\output.txt", $"{(DateTime.Now.ToString("HH:mm:ss.ffff"))}\t{tr.Name} Запущен");
                Record(mydocu + @"\output.txt", $"{(DateTime.Now.ToString("HH:mm:ss.ffff"))}\t{tr.Name} Закончен");
                Thread.Sleep(100);

            }
            MessageBox.Show("Создание паролей завершено!");




        }

        private void Go(string Name)
        {
            
                _waitHandle.WaitOne();
                foreach (string password in CreateRandomPassword())
                {
                Record(mydocu + $@"\{Name}-пароли.txt", password);
                }
                _waitHandle?.Set();

            

        }

        
    }
}
