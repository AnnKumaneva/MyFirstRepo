using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest_Kumaneva.business_object
{
    class Products
    {
        public string productName { get; set; }
        public string unitPrice { get; set; }
        public string quantityPerUnit { get; set; }
        public string unitsInStock { get; set; }
        public string unitsOnOrder { get; set; }
        public string reorderLevel { get; set; }

        public Products (string productName, string unitPrice, string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLevel)
        {
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.quantityPerUnit = quantityPerUnit;
            this.unitsInStock = unitsInStock;
            this.unitsOnOrder = unitsOnOrder;
            this.reorderLevel = reorderLevel;
        }


    }
}
