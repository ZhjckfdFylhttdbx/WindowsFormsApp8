using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string loginquarry = $"insert into[dbo].[Table] ([Фамилия],[Имя],[Отчество],[Группа],[Пол]) values( N'" + textBoxFamilia.Text+"',N' " +textBoxName.Text+"', N'"+textBoxOtchestvo.Text+"',N'"+textBoxGroup.Text+"', N'"+textBoxPol.Text+"')";
            SqlCommand logincommand = new SqlCommand(loginquarry, database.GetConnection());
            sqlDataAdapter.SelectCommand = logincommand;
            sqlDataAdapter.Fill(dataTable);
            MessageBox.Show("Успешное заполнение!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
