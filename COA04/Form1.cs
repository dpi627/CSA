using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COA04
{
    public partial class Form1 : Form
    {
        // 訂單紀錄
        Dictionary<string, string> records = new Dictionary<string, string>();
        // 資料處理類別
        DAC dac;

        public Form1()
        {
            InitializeComponent();
            dac = new DAC(records); // 初始化資料處理類別
        }

        /// <summary>
        /// 重設並顯示紀錄
        /// </summary>
        private void ResetAndDispalyRecord()
        {
            // 清除紀錄
            lstRecord.Items.Clear();
            // 顯示紀錄
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

    /// <summary>
    /// 資料處理類別
    /// </summary>
    public class DAC
    {
        // 資料集合
        private readonly Dictionary<string, string> _orders;

        public DAC(Dictionary<string, string> orders)
        {
            this._orders = orders;
        }

        /// <summary>
        /// 新增訂單
        /// </summary>
        /// <param name="orderDate">訂單日期</param>
        /// <param name="orderPeople">訂房人數</param>
        /// <param name="isPayByCash">是否付現</param>
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

            // 訂單索引鍵
            string orderKey = orderDate.ToString("yyyy年MM月dd日");

            if (IsOrderExist(orderKey))
            {
                MessageBox.Show("資料已經存在無法預訂");
                return;
            }

            // 訂單內容
            string orderValue = $"{orderPeople} 付現：{(isPayByCash ? "是" : "否")}";

            _orders.Add(orderKey, orderValue);
            MessageBox.Show("訂房完成");
        }

        /// <summary>
        /// 判斷訂單是否存在
        /// </summary>
        /// <param name="orderKey">訂單索引鍵</param>
        public bool IsOrderExist(string orderKey)
        {
            return _orders.ContainsKey(orderKey);
        }

        /// <summary>
        /// 取消訂單
        /// </summary>
        /// <param name="orderDate">訂單日期</param>
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
