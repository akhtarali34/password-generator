using System.Text;

namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length;
            int.TryParse(textBox1.Text, out length);
            if (length <= 0)
            {
                MessageBox.Show("PLEASE ENTER THE VALID POSITIVE INTEGER FOR GENERATION");
                return;
            }
            else
            {
                const string valid_chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@_$";
                StringBuilder result = new StringBuilder();
                Random rand = new Random();

                while (0 < length--)
                {
                    result.Append(valid_chars[rand.Next(valid_chars.Length)]);
                }
                textBox2.Text = result.ToString();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        

        }
    }
}
