using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetalisForm2 : Form
    {
        public JobDetalisForm2()
        {
            InitializeComponent();
        }

        private void tblJobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblJobDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobDetailsDataSet1);

        }

        private void JobDetalisForm2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“jobDetailsDataSet1.tblJobDetails”中。您可以根据需要移动或移除它。
            this.tblJobDetailsTableAdapter.Fill(this.jobDetailsDataSet1.tblJobDetails);

        }
    }
}
