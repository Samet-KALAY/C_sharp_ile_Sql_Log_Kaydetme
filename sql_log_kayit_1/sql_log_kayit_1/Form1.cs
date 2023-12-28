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

namespace sql_log_kayit_1
{
    public partial class Form1 : Form
    {
        SqlConnection Sql_Connet = new SqlConnection();
        int ID;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Sql_Connet_Click(object sender, EventArgs e)
        {
           
            if (Sql_Connet.State == System.Data.ConnectionState.Open)
            { Sql_Connet.Close(); }
            else
            {
                Sql_Connet.ConnectionString = textBox_Sql_Path.Text;
                Sql_Connet.Open();  }

            if (Sql_Connet.State == System.Data.ConnectionState.Open) { button_Sql_Connet.BackColor = Color.GreenYellow; } else { button_Sql_Connet.BackColor = Color.Red; }

        }

        private void textBox_Sql_Path_TextChanged(object sender, EventArgs e)
        {
            button_Sql_Connet.Enabled = true;

        }

        private void button_log_Add_Click(object sender, EventArgs e)
        {
            if (true)
            {
                #region SQL_Kayıt


                {
                    string query = "SELECT *FROM "+textBox_Mesaj_Tablo.Text +" WHERE Mesaj='" + textBox_Log.Text  + "'";
                    using (SqlCommand command = new SqlCommand(query, Sql_Connet))
                    {
                        Sql_Connet.Close();
                        Sql_Connet.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            #region SQL_Msj_ID_Bul
                            using (SqlCommand cmd = new SqlCommand("SELECT  *FROM "+textBox_Mesaj_Tablo.Text +" WHERE Mesaj = '" + textBox_Log.Text + "'", Sql_Connet))
                            {
                                Sql_Connet.Close();
                                Sql_Connet.Open();
                                SqlDataReader readerlog = cmd.ExecuteReader();
                                if (readerlog.Read())
                                {
                                    ID = Int32.Parse(readerlog["ID"].ToString());
                                }
                            }
                            #endregion
                            #region Log_Kayıt
                            Sql_Connet.Close();
                            Sql_Connet.Open();
                            Sql_Set("INSERT INTO "+textBox_Log_Tablo.Text +"(Msj_No)" +
                              " VALUES ('" + ID + "')");
                            #endregion
                        }
                        else
                        {
                            #region Yeni_Log_Msj
                            Sql_Connet.Close();
                            Sql_Connet.Open();
                            Sql_Set("INSERT INTO "+textBox_Mesaj_Tablo.Text +"(Mesaj)" +
                              " VALUES ('" + textBox_Log.Text + "')");
                            #endregion
                            #region SQL_Msj_ID_Bul
                            using (SqlCommand cmd = new SqlCommand("SELECT  *FROM "+textBox_Mesaj_Tablo.Text +" WHERE Mesaj = '" + textBox_Log.Text + "'", Sql_Connet))
                            {
                                Sql_Connet.Close();
                                Sql_Connet.Open();
                                SqlDataReader readerlog = cmd.ExecuteReader();
                                if (readerlog.Read())
                                {
                                    ID = Int32.Parse(readerlog["ID"].ToString());
                                }
                            }
                            #endregion
                            #region Log_Kayıt
                            Sql_Connet.Close();
                            Sql_Connet.Open();
                            Sql_Set("INSERT INTO "+textBox_Log_Tablo.Text +"(Msj_No)" +
                              " VALUES ('" + ID + "')");
                            #endregion
                        }


                    }
                }



                #endregion

            }
            MessageBox.Show(textBox_Log.Text+ "Mesaj Başarılı bir şekilde Eklendi");
        }

        private void Sql_Set(string code)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(code, Sql_Connet))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
