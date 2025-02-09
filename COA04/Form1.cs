using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COA04
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> records = new Dictionary<string, string>();
        DAC dac;

        public Form1()
        {
            InitializeComponent();
            dac = new DAC(records);
        }

        private void ResetAndDispalyRecord()
        {
            lstRecord.Items.Clear();
            foreach (var record in records)
            {
                lstRecord.Items.Add($"{record.Key}-{record.Value}");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            dac.AddOrder(dtpOrderDate.Value, cbbOrderPeople.Text, radIsPayByCashY.Checked);
            ResetAndDispalyRecord();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dac.RemoveOrder(dtpOrderDate.Value);
            ResetAndDispalyRecord();
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

            if (!int.TryParse(orderPeople, out int people))
            {
                MessageBox.Show("人數請輸入數字");
                return;
            }

            string orderKey = orderDate.ToString("yyyy年MM月dd日");

            if (IsOrderExist(orderKey))
            {
                MessageBox.Show("資料已經存在無法預訂");
                return;
            }

            string orderValue = $"{orderPeople} 付現：{(isPayByCash ? "是" : "否")}";
            _orders.Add(orderKey, orderValue);
            MessageBox.Show("訂房完成");
        }

        public bool IsOrderExist(string orderKey)
        {
            return _orders.ContainsKey(orderKey);
        }

        public void RemoveOrder(DateTime orderDate)
        {
            string orderKey = orderDate.ToString("yyyy年MM月dd日");

            if (!IsOrderExist(orderKey))
            {
                MessageBox.Show("查無紀錄");
                return;
            }

            _orders.Remove(orderKey);

            MessageBox.Show("取消訂單完成");
        }
    }
}
