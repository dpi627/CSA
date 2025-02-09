using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA04
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> record = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }
    }

    public class DAC
    {
        private Dictionary<string, string> _record;

        public DAC(Dictionary<string, string> record)
        {
            this._record = record;
        }

        public void Add(string key, string value)
        {
            _record.Add(key, value);
        }
    }
}
