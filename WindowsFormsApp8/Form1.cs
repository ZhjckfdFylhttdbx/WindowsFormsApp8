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

        private void buttonShow1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
            else groupBox1.Visible = false;
        }

        private void buttonShow2_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == false)
            {
                groupBox2.Visible = true;
            }
            else groupBox2.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Database database1 = new Database();
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            DataTable dataTable1 = new DataTable();
            string loginquarry1 = $"select count(*) from [dbo].[Table] where [Фамилия] = " + textBoxFamiliaDel.Text + ",[Имя] =  " + textBoxNameDel.Text + ",[Отчество] = " + textBoxOtchestvoDel.Text + ",[Группа] = " + textBoxGroupDel.Text + ",[Пол] = " + textBoxPolDel.Text + "";
            SqlCommand logincommand1 = new SqlCommand(loginquarry1, database1.GetConnection());
            sqlDataAdapter1.SelectCommand = logincommand1;
            sqlDataAdapter1.Fill(dataTable1);
            MessageBox.Show("Успешноеудаление!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Convert.ToInt32(dataTable1.Rows[0][0].ToString()) ==1)
            {
            Database database = new Database();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string loginquarry = $"delete from [dbo].[Table] where [Фамилия] = " + textBoxFamiliaDel.Text + ",[Имя] = " + textBoxNameDel.Text + ",[Отчество] = " + textBoxOtchestvoDel.Text + ",[Группа] = " + textBoxGroupDel.Text + ",[Пол] = " + textBoxPolDel.Text + "";
            SqlCommand logincommand = new SqlCommand(loginquarry, database.GetConnection());
            sqlDataAdapter.SelectCommand = logincommand;
            sqlDataAdapter.Fill(dataTable);
            MessageBox.Show("Успешноеудаление!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Данный студент не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
