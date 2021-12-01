using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptureRemover
{
    public partial class Form1 : MetroForm
    {
        class Data
        {
            public string Login { get; set; }
            public string Domen { get; set; }
            public string Pass { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (metroComboBox1.SelectedItem == "Mail:Password")
            {

                string data = File.ReadAllText(path.Text);
                                                         
                Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*:\w+([-+.]\w+)*",
                    RegexOptions.IgnoreCase);
          
                MatchCollection emailMatches = emailRegex.Matches(data);

                StringBuilder sb = new StringBuilder();

                foreach (Match emailMatch in emailMatches)
                {
                    sb.AppendLine(emailMatch.Value);
                }

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Title = "Save Combo Files";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.WriteLine(sb.ToString());
                    sw.Close();
                }

            }
            if (metroComboBox1.SelectedItem == "Username:Password")
            {
                string data = File.ReadAllText(path.Text); 
                                                          
                Regex emailRegex = new Regex(@"\w+([-+.]\w+)*:\w+([-+.]\w+)*",
                    RegexOptions.IgnoreCase);
 
                MatchCollection emailMatches = emailRegex.Matches(data);

                StringBuilder sb = new StringBuilder();

                foreach (Match emailMatch in emailMatches)
                {
                    sb.AppendLine(emailMatch.Value);
                }
            

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();   
    saveFileDialog1.Title = "Save Combo Files";
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                     var sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.WriteLine(sb.ToString());
                    sw.Close();

                }

   

            }
            else
            {

            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
     
                Title = "Browse Combolist Files",

        
                Filter = "Combolist files (*.txt)|*.txt",
            
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path.Text = openFileDialog1.FileName;
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/ghoulblack");
        }
    }



}