using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBazeFirst_HW_Library
{
    public partial class Form_Changing_Data : Form
    {
        public Dictionary<string, string> dicRes;
        public Form_Changing_Data(Dictionary<string, string> dic)
        {

            InitializeComponent();

            dicRes = dic;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            dicRes.Add("Name", textBoxName.Text);
            dicRes.Add("Pages", textBoxPages.Text);
            dicRes.Add("Category", textBoxCategory.Text);
            dicRes.Add("Author", textBoxAuthor.Text);
            dicRes.Add("ProductionHouse", textBoxPubHouse.Text);
            this.Close();
        }
    }
}
