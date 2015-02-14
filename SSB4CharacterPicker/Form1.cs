using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSB4CharacterPicker
{
  

    public partial class Form1 : Form
    {
        System.IO.StreamWriter log = new System.IO.StreamWriter("log.txt", true);
        List<string> enabledList = new List<string>();

        public Form1()
        {
           InitializeComponent();
           foreach (Control control in panel1.Controls)
           {
               enabledList.Add(control.Name);
           }
        }


        

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox item in panel1.Controls)
            {
                Console.WriteLine(item.Name + " " + item.Checked);
            }
            foreach (var item in enabledList)
            {
                Console.WriteLine(item);
            }
        }


        private void characterOnChanged(object sender, EventArgs e)
        {
            CheckBox control = (CheckBox)sender;
            if (control.Checked == true)
            {
                enabledList.Add(control.Name);
                Console.WriteLine(enabledList.Count);
                if (enabledList.Count == 51)
                {
                    toggleall.Checked = true;
                }
	{
		 
	}
            }
            else if(control.Checked == false)
            {
                enabledList.Remove(control.Name);
                toggleall.Checked = false;
            }
        }


        private void toggleall_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox control = (CheckBox)sender;
            if (control.Checked == true)
            {
                foreach (CheckBox item in panel1.Controls)
                {
                    item.Checked = true;   
                }
            }
            else if (control.Checked == false)
            {
                foreach(CheckBox item in panel1.Controls)
                {
                    item.Checked = false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        
    }


   
}
