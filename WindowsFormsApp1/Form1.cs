using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public string hayStr;
        public CFG cfg = new CFG();
        
        
        private void needleBox_TextChanged(object sender, EventArgs e)
        {
            resultBox.Text = "";
            
            if(needleBox.Text.Length==0)
                return;
            
            cfg.KMPSearch(needleBox.Text, hayStr);
            
            List<int> result = cfg.A;
            foreach (var item in result)
            {
                resultBox.Text += $@"Found pattern at {item}"+"\n";
            }
            
            cfg.A.Clear();
            
        }

        private void haystackBox_TextChanged(object sender, EventArgs e)
        {
            hayStr = haystackBox.Text;
        }
    }
}