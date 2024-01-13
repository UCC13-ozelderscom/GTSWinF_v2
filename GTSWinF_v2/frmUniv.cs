using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSWinF_v2
{
    public partial class frmUniv : Form
    {
        // Global

        string vs_ConnStr = @"Data Source=PHOKAIA\SS2019DE;Initial Catalog=GTSDb;Integrated Security=True";

        string vs_SQLCommand = "";
        string vs_SQLQuery = "";
        string vs_SQLUpdate = "";
        string vs_Where;

        string Mode="";

        public frmUniv()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            PrepareGrid();

            vs_SQLCommand = "SELECT UniversityID, Name FROM prmUniversity WHERE UniversityID > 0 ";

            BindGrid(vs_SQLCommand);

        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrepareGrid()
        {
            dgrdUniversity.AutoGenerateColumns = true;

            dgrdUniversity.RowHeadersVisible = false;

            dgrdUniversity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgrdUniversity.ReadOnly = true;

            dgrdUniversity.AllowUserToAddRows = false;

            dgrdUniversity.AllowUserToDeleteRows = false;

            //dgrdUniversity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            
            dgrdUniversity.AllowUserToResizeRows = false;

            dgrdUniversity.DefaultCellStyle.Font = new Font("Segoe UI", 10);




        }

        private void BindGrid(string prmSQLText)
        {

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(prmSQLText, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            dgrdUniversity.DataSource = dset.Tables[0];

                            dgrdUniversity.Columns[0].Visible = false;
                            dgrdUniversity.Columns[1].Width = 200;
                        }
                    }
                }
            }
        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            Mode = "U";
            ShowData(Mode);
        }

        private void ShowData(string prmMode)
        {
            switch (prmMode)
            {
                case "I":

                    tboxUnivName.Text = "";

                    break;

                case "U":
                    tboxUnivName.Text = dgrdUniversity.CurrentRow.Cells[1].Value.ToString();
                    break;

                default:
                    break;
            }

            tabcUniversity.SelectedTab = tabcUniversity.TabPages[1]; 

        }

        private void RecordSave()
        {
            switch (Mode)

            {
                case "U":

                    vs_SQLUpdate = $"UPDATE prmUniversity SET Name='{tboxUnivName.Text}' WHERE UniversityID={dgrdUniversity.CurrentRow.Cells[0].Value}";

                    break;

                case "I":

                    vs_SQLUpdate = $"INSERT INTO prmUniversity(Name) VALUES ('{tboxUnivName.Text}')";

                    break;

                case "D":
                    vs_SQLUpdate = $"DELETE FROM prmUniversity WHERE UniversityID = {dgrdUniversity.CurrentRow.Cells[0].Value}";
                    break;

                default:
                    break;
            }

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLUpdate, con))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Success....");

                        BindGrid(vs_SQLCommand);

                        tabcUniversity.SelectedTab = tabcUniversity.TabPages[0];
                    }
                    catch (Exception message)
                    {
                        if (Mode == "D")
                        {
                            MessageBox.Show("Operation break. Maybe record is using...");
                        }

                        else
                        {
                            MessageBox.Show(message.ToString());
                        }




                    }
                }
            }

        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            RecordSave();



        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            Mode = "I";
            ShowData(Mode);
                
        }

        private void dgrdUniversity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mode="U";
            ShowData(Mode);
        }

        private void dgrdUniversity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            Mode="D";
            RecordSave();
        }
    }
}
