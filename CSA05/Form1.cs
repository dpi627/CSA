using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CSA05
{
    public partial class Form1 : Form
    {
        private readonly DAC _dac;

        public Form1()
        {
            InitializeComponent();
            _dac = new DAC();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("請確實輸入帳號密碼");
                return;
            }

            _dac.Register(txtUserName.Text, txtPassword.Text);
            MessageBox.Show("註冊成功！");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }

    class DAC
    {
        private readonly string _path;

        public DAC(string path = "users.txt")
        {
            this._path = path;
        }

        public void Register(string user, string password)
        {
            string encryptedPassword = EncryptPassword(password);
            File.AppendAllText(_path, $"{user}|{encryptedPassword}\n");
        }

        private string EncryptPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hash = BitConverter.ToString(bytes).Replace("-", "");  // 轉成十六進制字串
                return hash;
            }
            // BitConverter.ToString(hashBytes) 預設會在每個十六進制數值之間加上 -（連字號），所以用 .Replace("-", "") 來移除，使結果更簡潔
        }
    }
}
