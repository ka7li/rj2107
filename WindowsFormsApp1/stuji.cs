using System;
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
    public partial class stuji : Form
    {
        public stuji()
        {
            InitializeComponent();
        }

        private void stuji_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“classDataSet.stujibenxinxi”中。您可以根据需要移动或删除它。
            this.stujibenxinxiTableAdapter.Fill(this.classDataSet.stujibenxinxi);

        }
    }
}
