using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace FinalProject
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string password = passWord.Text;

            if(name=="root" && password == "Sercan.123")
            {
                string myConnnection = "datasource=localhost; port=3306;username=root;password=Sercan.123";
                MySqlConnection myConn = new MySqlConnection(myConnnection);

                try
                {
                    myConn.Open();
                    if (myConn.State != ConnectionState.Closed)
                    {
                        MessageBox.Show("Bağlantı Başarılı Bir Şekilde Gerçekleşti");
                        Form3 form3 = new Form3();
                        form3.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Maalesef Bağlantı Yapılamadı...!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola hatalı!!!");
            }

       

        }
    }
}
