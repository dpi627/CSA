using System;
using System.IO;
using System.Windows.Forms;

namespace CSA05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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
            File.AppendAllText(_path, $"{user}|{password}\n");
        }
    }
}
