using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSWinF_v2
{
    public partial class frmTQuery : Form
    {
        string vs_ConnStr = @"Data Source=PHOKAIA\SS2019DE;Initial Catalog=GTSDb;Integrated Security=True";

        string vs_SQLCommand = "";
        string vs_SQLQuery = "";
        string vs_SQLUpdate = ""; // Update işlemi için
        string vs_Where;
        string Mode = "";
        string username, password;

        public frmTQuery()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTQuery_Load(object sender, EventArgs e)
        {
            getThesisType();
            getUniversity();
            getInstitute(0);
            getAuthor();
            getAdvisor();
            getYear();
            getLanguage();
            
            PrepareGrid();
            PrepareQuery();
            BindGrid(); 

            tboxThesisNo.Focus();
        }

        private void getThesisType()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT TTypeID,Description FROM prmThesisType";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text; 

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); 

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["TTypeID"] = 0;
                            newRow["Description"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0); 

                            ddlsThesisType.DataSource = dset.Tables[0];
                            ddlsThesisType.ValueMember = "TTypeID";
                            ddlsThesisType.DisplayMember = "Description";
                        }
                    }
                }
            }


        }

        private void getUniversity()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT UniversityID,Name FROM prmUniversity";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) 
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["UniversityID"] = 0;
                            newRow["Name"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0); 

                            ddlsUniversity.DataSource = dset.Tables[0];
                            ddlsUniversity.ValueMember = "UniversityID";
                            ddlsUniversity.DisplayMember = "Name";
                        }
                    }
                }
            }

        }

        private void getInstitute(int prmUniversityID)
        {
            ddlsInstitute.DataSource = null;
            ddlsInstitute.Items.Clear();

            if (prmUniversityID == 0)
            {
                //ddlsInstitute.Items.Clear();
                ddlsInstitute.Items.Insert(0, "--- Select ---");
                ddlsInstitute.SelectedIndex = 0;
            }
            else
            {
                using (SqlConnection con = new SqlConnection(vs_ConnStr))
                {
                    vs_SQLCommand = "SELECT InstituteID,Name FROM prmInstitute WHERE UniversityID=" + prmUniversityID;

                    using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataSet dset = new DataSet())
                            {
                                sda.Fill(dset);

                                DataRow newRow = dset.Tables[0].NewRow();
                                newRow["InstituteID"] = 0;
                                newRow["Name"] = "--- Select ---";
                                dset.Tables[0].Rows.InsertAt(newRow, 0);

                                ddlsInstitute.DataSource = dset.Tables[0];
                                ddlsInstitute.ValueMember = "InstituteID";
                                ddlsInstitute.DisplayMember = "Name";

                            }
                        }
                    }
                }
            }
        }

        private void getAuthor()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT AuthorID,Name FROM prmAuthor";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["AuthorID"] = 0;
                            newRow["Name"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0);

                            ddlsAuthor.DataSource = dset.Tables[0];
                            ddlsAuthor.ValueMember = "AuthorID";
                            ddlsAuthor.DisplayMember = "Name";
                        }
                    }
                }
            }


        }

        private void getAdvisor()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT AdvisorID,Name FROM prmAdvisor";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["AdvisorID"] = 0;
                            newRow["Name"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0);

                            ddlsAdvisor.DataSource = dset.Tables[0];
                            ddlsAdvisor.ValueMember = "AdvisorID";
                            ddlsAdvisor.DisplayMember = "Name";
                        }
                    }
                }
            }


        }

        private void getYear()
        {
            ddlsYearBegin.Items.Insert(0, "--- Select ---");            
            ddlsYearEnd.Items.Insert(0, "--- Select ---");            
            
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                ddlsYearBegin.Items.Add(i);
                ddlsYearEnd.Items.Add(i);
            }

            ddlsYearBegin.SelectedIndex = 0;
            ddlsYearEnd.SelectedIndex = 0;

        }

        private void getLanguage()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                vs_SQLCommand = "SELECT LanguageID,Description FROM prmLanguage";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            DataRow newRow = dset.Tables[0].NewRow();

                            newRow["LanguageID"] = 0;
                            newRow["Description"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0);

                            ddlsLanguage.DataSource = dset.Tables[0];
                            ddlsLanguage.ValueMember = "LanguageID";
                            ddlsLanguage.DisplayMember = "Description";
                        }
                    }
                }
            }

        }

        private void PrepareGrid()
        {
            dgrdThesis.AutoGenerateColumns = true;

            dgrdThesis.RowHeadersVisible = false;

            dgrdThesis.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //dgrdThesis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

            dgrdThesis.ReadOnly = true;

            dgrdThesis.AllowUserToAddRows = false;

            dgrdThesis.AllowUserToDeleteRows = false;

            dgrdThesis.AllowUserToResizeRows = false;

            
            dgrdThesis.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            foreach (DataGridViewColumn column in dgrdThesis.Columns)
            {
                column.Width = 150;
            }


            //dgrdThesis.Columns[0].Width = 50;
            //dgrdThesis.Columns[1].Width = 200;
            //dgrdThesis.Columns[2].Width = 200;
            //dgrdThesis.Columns[3].Width = 200;
            //dgrdThesis.Columns[4].Width = 50;
            //dgrdThesis.Columns[5].Width = 100;
            //dgrdThesis.Columns[6].Width = 100;
            //dgrdThesis.Columns[7].Width = 100;
            //dgrdThesis.Columns[8].Width = 50;
            //dgrdThesis.Columns[9].Width = 100;
            //dgrdThesis.Columns[10].Width = 100;
            //dgrdThesis.Columns[11].Width = 100;
            //dgrdThesis.Columns[12].Width = 100;

            //dgrdThesis.Columns[0].HeaderText = "No";
            //dgrdThesis.Columns[1].HeaderText = "Title";
            //dgrdThesis.Columns[2].HeaderText = "Summary";
            //dgrdThesis.Columns[3].HeaderText = "Author";
            //dgrdThesis.Columns[4].HeaderText = "Year";
            //dgrdThesis.Columns[5].HeaderText = "Type";
            //dgrdThesis.Columns[6].HeaderText = "University";
            //dgrdThesis.Columns[7].HeaderText = "Institute";
            //dgrdThesis.Columns[8].HeaderText = "Page";
            //dgrdThesis.Columns[9].HeaderText = "Language";
            //dgrdThesis.Columns[10].HeaderText = "Delivery";
            //dgrdThesis.Columns[11].HeaderText = "Advisor";
            //dgrdThesis.Columns[12].HeaderText = "PAdvisor";

            //dgrdThesis.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgrdThesis.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgrdThesis.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgrdThesis.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //dgrdThesis.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            //dgrdThesis.Columns[1].DefaultCellStyle.BackColor = Color.LightGray;
            //dgrdThesis.Columns[2].DefaultCellStyle.BackColor = Color.LightGray;


        }

        private void PrepareQuery() 
        {
            vs_SQLQuery += "SELECT ";
            vs_SQLQuery += "ThesisID,";
            vs_SQLQuery += "Title,";
            vs_SQLQuery += "Summary,";
            vs_SQLQuery += "prmAuthor.Name AS Author,";
            vs_SQLQuery += "Year,";
            vs_SQLQuery += "prmThesisType.Description AS TType,";
            vs_SQLQuery += "prmUniversity.Name AS University,";
            vs_SQLQuery += "prmInstitute.Name AS Institute,";
            vs_SQLQuery += "PageCount,";
            vs_SQLQuery += "prmLanguage.Description AS Language,";
            vs_SQLQuery += "DeliveryDT,";
            vs_SQLQuery += "prmAdvisor.Name AS Advisor,";
            vs_SQLQuery += "p.Name AS PAdvisor ";
            vs_SQLQuery += "FROM datThesis ";
            vs_SQLQuery += "INNER JOIN prmAuthor ON datThesis.AuthorID=prmAuthor.AuthorID ";
            vs_SQLQuery += "INNER JOIN prmThesisType ON datThesis.TTypeID=prmThesisType.TTYpeID ";
            vs_SQLQuery += "INNER JOIN prmUniversity ON datThesis.UniversityID=prmUniversity.UniversityID ";
            vs_SQLQuery += "INNER JOIN prmInstitute ON datThesis.InstituteID=prmInstitute.InstituteID ";
            vs_SQLQuery += "INNER JOIN prmLanguage ON datThesis.LanguageID=prmLanguage.LanguageID ";
            vs_SQLQuery += "INNER JOIN prmAdvisor ON datThesis.AdvisorID=prmAdvisor.AdvisorID ";
            vs_SQLQuery += "LEFT JOIN prmAdvisor p ON datThesis.PAdvisorID=p.AdvisorID ";
            vs_SQLQuery += "WHERE ThesisID > 0";
        }

        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLQuery, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);
                            
                            dgrdThesis.DataSource = dset.Tables[0];
                            
                        }
                    }
                }
            }
        }

        private void ddlsUniversity_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (ddlsUniversity.SelectedIndex > 0)
            {
                getInstitute(Convert.ToInt32(ddlsUniversity.SelectedValue));
            }
            else
            {
                getInstitute(0);
            }
                
        }

        private void btonRunQuery_Click(object sender, EventArgs e)
        {
            vs_SQLQuery = ""; // Query mi temizliyorum
            vs_Where = ""; // Where koşulunu temizliyorum

            PrepareQuery();

            if (tboxThesisNo.Text.Trim() != "")
            {
                vs_Where += " AND ThesisID = " + tboxThesisNo.Text.Trim();
            }

            if (ddlsUniversity.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.UniversityID = " + ddlsUniversity.SelectedValue;
            }

            if (ddlsInstitute.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.InstituteID = " + ddlsInstitute.SelectedValue;
            }

            if (ddlsThesisType.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.TTypeID = " + ddlsThesisType.SelectedValue;
            }

            if (ddlsAuthor.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.AuthorID = " + ddlsAuthor.SelectedValue;
            }

            if (ddlsAdvisor.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.AdvisorID = " + ddlsAdvisor.SelectedValue;
            }

            if (ddlsYearBegin.SelectedIndex > 0)
            {
                vs_Where += " AND Year >= " + ddlsYearBegin.SelectedItem;
            }

            if (ddlsYearEnd.SelectedIndex > 0)
            {
                vs_Where += " AND Year <= " + ddlsYearEnd.SelectedItem;
            }

            if (ddlsLanguage.SelectedIndex > 0)
            {
                vs_Where += " AND datThesis.LanguageID = " + ddlsLanguage.SelectedValue;
            }



            vs_SQLQuery += vs_Where;

            BindGrid();





        }
    }
}
