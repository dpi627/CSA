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
        DAC dac;

        public Form1()
        {
            InitializeComponent();
            dac = new DAC(record);
        }

        private void resetAndDispalyRecord()
        {
            lstRecord.Items.Clear();
            foreach (var item in record)
            {
                lstRecord.Items.Add($"{item.Key}-{item.Value}");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            dac.AddOrder(dtpOrderDate.Value, cbbOrderPeople.Text, radIsPayByCashY.Checked);
            resetAndDispalyRecord();
        }
    }

    public class DAC
    {
        private readonly Dictionary<string, string> _orders;

        public DAC(Dictionary<string, string> orders)
        {
            this._orders = orders;
        }

        public void AddOrder(DateTime orderDate, string orderPeople, bool isPayByCash)
        {
            if (string.IsNullOrWhiteSpace(orderPeople))
            {
                MessageBox.Show("請選擇人數");
                return;
            }

            string orderKey = orderDate.ToString("yyyy年MM月dd日");

            if (IsExistOrder(orderKey))
            {
                MessageBox.Show("資料已經存在無法預訂");
                return;
            }

            string orderValue = $"{orderPeople} 付現：{(isPayByCash ? "是" : "否")}";
            _orders.Add(orderKey, orderValue);
            MessageBox.Show("訂房完成");
        }

        public bool IsExistOrder(string orderKey)
        {
            return _orders.ContainsKey(orderKey);
        }

        public void RemoveOrder(string orderKey)
        {
            _orders.Remove(orderKey);
        }
    }
}
