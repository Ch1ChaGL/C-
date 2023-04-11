using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ФормаКурьерскойБД
{
    public partial class ManagerForm : Form
    {
        public ManagerForm(int idManager, int idDepartment)
        {
            InitializeComponent();
            this.idDepartment = idDepartment;
        }
        int idManager;
        int idDepartment;
        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Visible = false;
            CreateOrder createOrderForm = new CreateOrder(idDepartment);
            createOrderForm.ShowDialog();
            Visible = true;
        }
    }
}
