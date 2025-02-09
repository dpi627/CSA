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

            DAC dac = new DAC(record);

            foreach (var order in record)
            {
                lstResult.Items.Add(order.Key + " : " + order.Value);
            }
        }
    }

    public class DAC
    {
        private Dictionary<string, string> _orders;

        public DAC(Dictionary<string, string> orders)
        {
            this._orders = orders;
        }

        public void AddOrder(DateTime orderDate, string orderPeople, bool isPayByCash)
        {
            string orderKey = orderDate.ToString("yyyy年MM月dd日");
            string orderValue = $"{orderPeople} 付現：{(isPayByCash ? "是" : "否")}";
            _orders.Add(orderKey, orderValue);
        }
    }
}
