﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ribbon.Model
{
    class PurchaseInfoNJ
    {

        private string _supplier;
        public string SupplierName
        {
            get
            {
                return this._supplier = SupplierFirstName + " "+ SupplierLastName;
            }
            set
            {
                this._supplier = value;
            }
        }

        private string _supplierFirstName;
        public string SupplierFirstName
        {
            get
            {
                return this._supplierFirstName;
            }
            set
            {
                this._supplierFirstName = value;
            }
        }

        private string _supplierLastName;
        public string SupplierLastName
        {
            get
            {
                return this._supplierLastName;
            }
            set
            {
                this._supplierLastName = value;
            }
        } 


        private string _order;
        public string Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
            }
        }

        private string _orderDate;
        public string OrderDate
        {
            get
            {
                return this._orderDate;
            }
            set
            {
                this._orderDate = value;
            }
        }

        private string _orderRemark;
        public string OrderRemark
        {
            get
            {
                return this._orderRemark;
            }
            set
            {
                this._orderRemark = value;
            }
        }

        private long _requestedShipDate;
        public long RequestedShipDate
        {
            get
            {
                return this._requestedShipDate;
            }
            set
            {
                this._requestedShipDate = value;
            }
        }

        private long _statusId;
        public long StatusId
        {
            get
            {
                return this._statusId;
            }
            set
            {
                this._statusId = value;
            }
        }

        private double _discount;
        public double Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        } 
        
    }
}
