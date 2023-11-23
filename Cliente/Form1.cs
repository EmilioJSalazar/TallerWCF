using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MiServicio.ServiceClient oClient = new MiServicio.ServiceClient();
            string res = oClient.GetData(4, 8);
            MessageBox.Show(res);

            MiServicio.CompositeType oData = new MiServicio.CompositeType();
            oData.BoolValue = true;
            var res2 = oClient.GetDataUsingDataContract(oData);
            MessageBox.Show(res2.StringValue);
        }
    }
}
