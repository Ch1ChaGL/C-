using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Задание_13Вариант
{
    public partial class Form2 : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\Практика c#\\8_Задание_13Вариант\\8_Задание_13Вариант\\Airport.mdf\";Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            InitializeComponent();
        }
        byte[] photoBytes;
        private void load_Click(object sender, EventArgs e)
        {


            // Создание диалогового окна для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображения (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            // Проверка, был ли выбран файл
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получение пути к выбранному файлу
                string filePath = openFileDialog.FileName;

                // Чтение фотографии из файла и преобразование в массив байтов

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        photoBytes = br.ReadBytes((int)fs.Length);
                        // Отображение фотографии в PictureBox
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    // Создание команды SQL INSERT с параметром для фотографии
                    string insertQuery = "INSERT INTO PlaneTypes (PlaneTypeID,PlaneTypeName, PlaneImage, NumberOfSeats ) VALUES (@id, @Name,@Photo, @Number)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Привязка параметра к массиву байтов фотографии
                        SqlParameter photoParam = new SqlParameter("@Photo", SqlDbType.VarBinary);
                        photoParam.Value = photoBytes;
                        SqlParameter idpar = new SqlParameter("@id", SqlDbType.Int);
                        idpar.Value = int.Parse(id.Text);
                        SqlParameter name = new SqlParameter("@Name", SqlDbType.NVarChar);
                        name.Value = Name2.Text;
                        SqlParameter numberofseats = new SqlParameter("@Number", SqlDbType.Int);
                        numberofseats.Value = int.Parse(Number.Text);
                        command.Parameters.Add(idpar);
                        command.Parameters.Add(name);
                        command.Parameters.Add(photoParam);
                        command.Parameters.Add(numberofseats);
                        // Выполнение команды INSERT
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            updateDataGridView();
            pictureBox1.Image = null;
            Number.Text = string.Empty;
            id.Text = string.Empty;
            Name2.Text = string.Empty;
        }
        
        private void updateDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand("select PlaneTypeID,PlaneTypeName,NumberOfSeats  from PlaneTypes", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
        private void TextChange(object sender, EventArgs e)
        {
            if(id.Text != "" && Name2.Text != "" && Number.Text != "" && pictureBox1.Image != null)
            {
                button1.Enabled = true;
               
            }
            else
            {
               
                button1.Enabled = false;
            }
            if(id.Text != "")
            {
                del.Enabled = true;
            }
            else
            {
                del.Enabled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateDataGridView();
            Name2.TextChanged += TextChange;
            id.TextChanged += TextChange;
            Number.TextChanged += TextChange;
            button1.Enabled = false;
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand($"delete from PlaneTypes where PlaneTypeID = {int.Parse(id.Text)}", connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
