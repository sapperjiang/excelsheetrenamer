using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinYinParse
{
    public partial class AddDic : Form
    {
        public string strEnglisTxt;
        public string strHanzi=string.Empty;
        public AddDic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strEnglisTxt = TB_EnglishTxt.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void AddDic_Load(object sender, EventArgs e)
        {
            this.LB_UntrasnLatedText.Text = strHanzi;
        }
    }
}
