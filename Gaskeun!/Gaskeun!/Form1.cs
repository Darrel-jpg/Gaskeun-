using Npgsql;

namespace Gaskeun_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
            //button3.Image = Properties.Resources.icons8_closed_eye_26;

            textBox1.KeyDown += TextBox1_KeyDown;
            textBox2.KeyDown += TextBox2_KeyDown;
        }

        private bool isPasswordVisible = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                textBox2.PasswordChar = '*';
                button3.Image = Properties.Resources.icons8_closed_eye_26;
                isPasswordVisible = false;
            }
            else
            {
                textBox2.PasswordChar = '\0';
                button3.Image = Properties.Resources.icons8_eye_26;
                isPasswordVisible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Rental;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sqlAdmin = "SELECT COUNT(1) FROM admin WHERE username = @username AND password = @password";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlAdmin, conn))
                {
                    cmd.CommandText = sqlAdmin;
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login sebagai Admin Berhasil", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //else
                    //{
                    //    MessageBox.Show("Login Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }

                string sqlPelanggan = "SELECT COUNT(1) FROM pelanggan WHERE username = @username AND password = @password";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlPelanggan, conn))
                {
                    cmd.CommandText = sqlPelanggan;
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login Berhasil", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Image img = Properties.Resources.Free_Vector___Abstract_background_gradient_colorful_design;
            e.Graphics.DrawImage(img, new Rectangle(0, 0, panel1.Width, panel1.Height));
        }
    }
}
