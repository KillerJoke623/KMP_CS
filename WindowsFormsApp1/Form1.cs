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
        
        public CFG cfg = new CFG();
        
        
        private void needleBox_TextChanged(object sender, EventArgs e)
        {
            if(needleBox.Text.Length==0)
                return;
            if (haystackBox.Text.Length!=0)
            {
                linkCFG();
            }
            
        }

        private void haystackBox_TextChanged(object sender, EventArgs e)
        {
            if(haystackBox.Text.Length==0)
                return;
            
            if (needleBox.Text.Length!=0)
            {
                linkCFG();
            }
        }

        private void linkCFG()
        {
            resultBox.Text = "";
            cfg.KMPSearch(needleBox.Text, haystackBox.Text);
            
            List<int> result = cfg.A;
            foreach (var item in result)
            {
                resultBox.Text += $@"Found pattern at {item}"+"\n";
            }
            
            cfg.A.Clear();
        }
    }
}