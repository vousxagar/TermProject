using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class SaleDetail : Form
    {
        public SaleDetail(int SaleID)
        {
            InitializeComponent();

            this.SaleID = SaleID;
        }
        int SaleID = 0;

        private void SaleDetail_Load(object sender, EventArgs e)
        {
            DataAccess _DataAccess = new DataAccess();

            foreach (Details SaleItemsDetails in _DataAccess.RetreiveSaleItems(SaleID))
            {
                SaleItemsGridView.Rows.Add(SaleItemsDetails.Name, SaleItemsDetails.Price, SaleItemsDetails.Quantity);
            }
        }
    }
}
