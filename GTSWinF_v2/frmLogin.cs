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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GTSWinF_v2
{
    public partial class frmLogin : Form
    {
        // Global Kısım
        // Aşağıdaki değişgen VT bağlanabilmek için gerekli olan bağlantı cümleciğidir. Şu makinaya..şu database e bağlanmak istiyorum gibi
        string vs_ConnStr = @"Data Source=PHOKAIA\SS2019DE;Initial Catalog=GTSDb;User Id=sa;Password=Doga251200;Integrated Security=True";


        string vs_SQLCommand = ""; 
        string vs_SQLQuery = ""; 
        string vs_SQLUpdate = ""; // Update işlemi için
        string Mode = "";
        int userID;
        string username, password,usertype;
 

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btonLogin_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(vs_ConnStr);

            connection.Open(); 

            username = tboxUserName.Text;

            password = tboxUserPassw.Text;

            vs_SQLCommand="SELECT UserID,UserName,UserType FROM datUser WHERE UserName=@userName AND UserPassw=@userPassw";

            using (SqlConnection con = new SqlConnection(vs_ConnStr))
            {
                using (SqlCommand cmd = new SqlCommand(vs_SQLCommand, con))
                {
                    cmd.Parameters.AddWithValue("@userName", username); // Parametreler ayarlanıyor
                    cmd.Parameters.AddWithValue("@userPassw", password);

                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dset = new DataSet())
                        {
                            sda.Fill(dset);

                            if (dset.Tables[0].Rows.Count > 0)
                            {
                                userID = Convert.ToInt32(dset.Tables[0].Rows[0]["UserID"]);
                                username = dset.Tables[0].Rows[0]["UserName"].ToString();
                                usertype = dset.Tables[0].Rows[0]["UserType"].ToString();

                                connection.Close();

                                frmMain frmMain = new frmMain();

                                frmMain.Text += " - " + username+ " / " + usertype;

                                if (usertype == "U")
                                {
                                    frmMain.menuGTS.Items[1].Enabled = false;
                                }
  

                                frmMain.ShowDialog();
                                this.Hide();

                            }
                            else 
                            {
                                tboxUserName.Clear();
                                tboxUserPassw.Clear();

                                MessageBox.Show("UserName or UserPass Wrong! Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                tboxUserName.Focus();
                            }

                        }
                    }
                }


            }









            //SqlDataReader dr = cmd.ExecuteReader(); // bu verileri veritabanından  oku ve dr içine göm

            //if (dr.Read()) // dr nesnemde içi doluysa,degerleri okuduysan
            //{
            //    int userid = dr.GetInt32(0);
            //    string usertype = dr.GetString(1);


            //    //Admin panel formundan bir nesne üret
            //    //anapaneli göster Show ile
            //    //bunu(şu anki ekranda açık olan Login formunu gizle)

            //    if (usertype == "A") // Admin
            //    {
            //        //AdminPanelForm admin = new AdminPanelForm();

            //        //admin.userId = id;
            //        //admin.depName = depName;
            //        //admin.nameSurname = nameSurname;
            //        //admin.ShowDialog();

            //    }
            //    // değilse normal kullanıcıdır.Normal kullanıcı formunu aç
            //    //UserPanelForm user = new UserPanelForm();
            //    //user.userIdUP = id;
            //    //user.depName = depName;
            //    //user.nameSurname = nameSurname;
            //    //user.Show();

            //    frmMain frmMain = new frmMain();
            //    frmMain.ShowDialog();
            //    this.Hide();

            //}
            //else
            //{

            //    dr.Close();
            //    MessageBox.Show("UserName or UserPass Wrong! Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// hatalı girişler için mesaj kutusu oluşturduk.


            //}
            //connection.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tboxUserName.Focus();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
