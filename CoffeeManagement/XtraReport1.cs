using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace CoffeeManagement
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        public void initdata(string total,string saleOff,string date, string ID)
        {
            pTotal.Value = total;
            pSaleOff.Value = saleOff;
            pDate.Value = date;
            pID.Value = ID;
        }
    }
}
