﻿using com.inventory.bean;
using com.inventory.db;
using com.inventory.db.manager;
using java.util;
using Prism.Commands;
using Prism.Mvvm;
using Ribbon.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ribbon.ViewModel
{
    class ManagePurchaseOrderList: BindableBase
    {

        ObservableCollection<PurchaseInfoNJ> _purchaseList;

        public ObservableCollection<PurchaseInfoNJ> PurchaseList
        {
            get
            {
                PurchaseManager purchaseManager = new PurchaseManager();

                _purchaseList = new ObservableCollection<PurchaseInfoNJ>();
                for (Iterator i = purchaseManager.getAllPurchaseOrders().iterator(); i.hasNext(); )
                {
                    PurchaseInfo purchaseInfo = (PurchaseInfo)i.next();
                    PurchaseInfoNJ purchaseInfoNJ = new PurchaseInfoNJ();
                    purchaseInfoNJ.Order = purchaseInfo.getOrderNo();
                    purchaseInfoNJ.OrderRemark = purchaseInfo.getRemarks();
                    purchaseInfoNJ.RequestedShipDate = purchaseInfo.getRequestShippedDate();
                    //purchaseInfoNJ.OrderDate = purchaseInfo.getOrderDate();
                    purchaseInfoNJ.StatusId = purchaseInfo.getStatusId();
                    purchaseInfoNJ.Discount = purchaseInfo.getDiscount();

                    SupplierInfo supplierInfo = new SupplierInfo();
                    SupplierInfoNJ supplierInfoNJ = new SupplierInfoNJ();
                    supplierInfoNJ.SupplierFirstName = supplierInfo.getProfileInfo().getFirstName();
                    supplierInfoNJ.SupplierLastName = supplierInfo.getProfileInfo().getLastName();
                    supplierInfoNJ.SupplierName = supplierInfoNJ.SupplierFirstName + " " + supplierInfoNJ.SupplierLastName;
                   
                    supplierInfoNJ.SupplierUserID = supplierInfo.getProfileInfo().getId();


                    _purchaseList.Add(purchaseInfoNJ);
                }
                return _purchaseList;
            }
            set
            {
                this._purchaseList = value;
            }
        }
    }
}