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

    /// <summary>
    /// 資料處理類別
    /// </summary>
    class DAC
    {
        /// <summary>
        /// 檔案路徑
        /// </summary>
        private readonly string _path;

        /// <summary>
        /// 初始化資料處理類別
        /// </summary>
        /// <param name="path">檔案路徑</param>
        public DAC(string path = "users.txt")
        {
            this._path = path;
        }

        /// <summary>
        /// 註冊並加密密碼
        /// </summary>
        /// <param name="userName">使用者名稱</param>
        /// <param name="password">使用者密碼</param>
        public void Register(string userName, string password)
        {
            string encryptedPassword = EncryptPassword(password);
            File.AppendAllText(_path, $"{userName}|{encryptedPassword}\n");
        }

        /// <summary>
        /// 使用 SHA256 加密密碼
        /// </summary>
        /// <param name="password">密碼</param>
        /// <returns>加密後的密碼(十六進制)</returns>
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
