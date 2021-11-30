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

namespace kutyak
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;
        int id;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "kutyak";
            sb.CharacterSet = "utf8";
            sb.ConvertZeroDateTime = true;
            connection = new MySqlConnection(sb.ConnectionString);
            sql = connection.CreateCommand();

            AdatokBetoltese();
        }

        private void AdatokBetoltese()
        {
            listBoxKutyak.Items.Clear();
            try
            {
                connection.Open();
                sql.CommandText = "select * from kutyak";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Kutya uj = new Kutya(dr.GetInt32("id"), dr.GetString("nev"), dr.GetString("fajta"), dr.GetInt32("suly"), dr.GetDateTime("szuldatum"));
                        listBoxKutyak.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            sql.CommandText = "INSERT INTO `kutyak` (`id`, `nev`, `fajta`, `suly`, `szuldatum`) VALUES (NULL, @nev, @fajta, @suly, @szulDatum);";
            sql.Parameters.AddWithValue("@nev",textBoxNev.Text);
            sql.Parameters.AddWithValue("@fajta",textBoxFajta.Text);
            sql.Parameters.AddWithValue("@suly",numericUpDownSuly.Value);
            sql.Parameters.AddWithValue("@szulDatum",dateTimePickerDatum.Value);

            sqlExecute();

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            sql.CommandText = "UPDATE `kutyak` SET `nev`=@nev,`fajta`=@fajta,`suly`=@suly,`szuldatum`=@szulDatum WHERE id = @id;";
            sql.Parameters.AddWithValue("@nev", textBoxNev.Text);
            sql.Parameters.AddWithValue("@fajta", textBoxFajta.Text);
            sql.Parameters.AddWithValue("@suly", numericUpDownSuly.Value);
            sql.Parameters.AddWithValue("@szulDatum", dateTimePickerDatum.Value);
            sql.Parameters.AddWithValue("@id",id);

            sqlExecute();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            sql.CommandText = "DELETE FROM `kutyak` WHERE `kutyak`.`id` = @id";
            sql.Parameters.AddWithValue("@id", id);

            sqlExecute();
        }

        private void listBoxKutyak_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kutya kivalasztott = (Kutya)listBoxKutyak.SelectedItem;
            id = kivalasztott.Id;
            textBoxNev.Text = kivalasztott.Nev;
            textBoxFajta.Text = kivalasztott.Fajta;
            numericUpDownSuly.Value = kivalasztott.Suly;
            dateTimePickerDatum.Value = kivalasztott.SzulDatum;

        }

        void sqlExecute()
        {
            try
            {
                connection.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            sql.Parameters.Clear();
            AdatokBetoltese();
            textBoxNev.Text = "";
            textBoxFajta.Text = "";
            numericUpDownSuly.Value = 0;
            dateTimePickerDatum.Value = DateTime.Now;
        }
    }
}
