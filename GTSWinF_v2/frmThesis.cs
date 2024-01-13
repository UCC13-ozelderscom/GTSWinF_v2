using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTSWinF_v2
{
    public partial class frmThesis : Form
    {
        string vs_ConnStr = @"Data Source=PHOKAIA\SS2019DE;Initial Catalog=GTSDb;Integrated Security=True";


        string vs_SQLCommandAna = ""; // Sql komutlarımı içerecek
        string vs_SQLCommand = "";
        string vs_SQLQuery = "";
        string vs_SQLUpdate = ""; // Update işlemi için
        string Mode = "";
        string username, password;

        public frmThesis()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThesis_Load(object sender, EventArgs e)
        {
            getAuthor();
            getThesisType();
            getUniversity();
            getInstitute(0);
            getLanguage();
            getAdvisor();

            Mode = "I";

            tboxTitle.Focus();
        }

        private void getThesisType()
        {

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {

                vs_SQLCommand = "SELECT TTypeID,Description FROM prmThesisType";

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun

                            // comboboxın ilk satırı -- Hepsi -- yazsın

                            // Data tablolarında olmayan bir satırı oluşturmak için kullanılan bir class var(DataRow classı). combo içine ilk olarak onunn gözükmesini sağlıyacağım
                            DataRow newRow = dset.Tables[0].NewRow(); //  yeni bir satır açıyorum.

                            newRow["TTypeID"] = 0;
                            newRow["Description"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0); // hazırlamış oluğum aslın db tablosunda olmayan kayıdı combo boxın 0.indeksine koyuyorum ki ilk o gözüksün...

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

                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con)) // con nesnesini kullanarak SQL komutunu oluştur..
                {
                    cmd.CommandType = CommandType.Text; // text şeklinde

                    // aşağıda cmd nesnesini kullanabileciğim veri  geliş/gidişini ayarlayan bir DA oluşturuyorum.
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset); // Adaptörüm yarattığı DS i doldursun

                            // comboboxın ilk satırı -- Hepsi -- yazsın

                            // Data tablolarında olmayan bir satırı oluşturmak için kullanılan bir class var(DataRow classı). combo içine ilk olarak onunn gözükmesini sağlıyacağım
                            DataRow newRow = dset.Tables[0].NewRow(); //  yeni bir satır açıyorum.

                            newRow["UniversityID"] = 0;
                            newRow["Name"] = "--- Select ---";

                            dset.Tables[0].Rows.InsertAt(newRow, 0); // hazırlamış oluğum aslın db tablosunda olmayan kayıdı combo boxın 0.indeksine koyuyorum ki ilk o gözüksün...

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

                            ddlsPAdvisor.DataSource = dset.Tables[0];
                            ddlsPAdvisor.ValueMember = "AdvisorID";
                            ddlsPAdvisor.DisplayMember = "Name";
                        }
                    }
                }
            }


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

        private string createDeliveryDT()
        {
            string vs_Year,vs_Month,vs_Day;

            vs_Year = DateTime.Now.Year.ToString();
            vs_Month = DateTime.Now.Month.ToString();
            vs_Day = DateTime.Now.Day.ToString();

            if (vs_Month.Length < 2)
            {
                vs_Month = "0" + vs_Month;
            }

            if (vs_Day.Length < 2)
            {
                vs_Day = "0" + vs_Day;
            }

            return vs_Year + vs_Month + vs_Day;
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

        private void btonSend_Click(object sender, EventArgs e)
        {
            string vs_SQLText = "";

            switch (Mode)
            {
                // Bazı SQL injectionları engellemek açısından ve daha sade bir komut satırı olması için parametrik kullanım tercih edildi.
                case "U":
                    vs_SQLText = "UPDATE Customers SET ";
                    /* vs_SQLText += "CompanyName='" + tboxCompanyName.Text + "' ";*/
                    vs_SQLText += "CompanyName=@CompanyName,";
                    vs_SQLText += "ContactName=@ContactName,";
                    vs_SQLText += "Country=@Country ";
                    vs_SQLText += "WHERE CustomerID=@CustomerID";
                    // SQL Text oluşturuldu...Parametreli...
                    break;

                case "I":
                    vs_SQLText = "INSERT INTO datThesis (Title,Summary,AuthorID,Year,TTypeID,UniversityID,InstituteID,PageCount,LanguageID,DeliveryDT,AdvisorID,PAdvisorID) VALUES (@Title,@Summary,@AuthorID,@Year,@TTypeID,@UniversityID,@InstituteID,@PageCount,@LanguageID,@DeliveryDT,@AdvisorID,@PAdvisorID)";
                    break;
                default:
                    break;
            }

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLText, con))
                {
                    // şimdi sıra parametreleri doldurmada...
                    cmd.Parameters.AddWithValue("Title", tboxTitle.Text);
                    cmd.Parameters.AddWithValue("Summary", tboxSummary.Text);
                    cmd.Parameters.AddWithValue("AuthorID", ddlsAuthor.SelectedValue);
                    cmd.Parameters.AddWithValue("Year", DateTime.Now.Year);
                    cmd.Parameters.AddWithValue("TTypeID", ddlsThesisType.SelectedValue);
                    cmd.Parameters.AddWithValue("UniversityID", ddlsUniversity.SelectedValue);
                    cmd.Parameters.AddWithValue("InstituteID", ddlsInstitute.SelectedValue);
                    cmd.Parameters.AddWithValue("PageCount", nuudPageCount.Value);
                    cmd.Parameters.AddWithValue("LanguageID", ddlsLanguage.SelectedValue);
                    cmd.Parameters.AddWithValue("DeliveryDT", createDeliveryDT());
                    cmd.Parameters.AddWithValue("AdvisorID", ddlsAdvisor.SelectedValue);
                    cmd.Parameters.AddWithValue("PAdvisorID", ddlsPAdvisor.SelectedValue);

                    cmd.CommandType = CommandType.Text;


                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Success ...");
                        this.Close();

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());

                    }
                }
            }
        }
    }
}
