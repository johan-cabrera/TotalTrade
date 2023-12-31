﻿using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class CuentasModel
    {
        CuentasDA cuentasDA = new CuentasDA();
        VentasDA ordenesDA = new VentasDA();

        //Metodo que recibe y retorna el subtotal
        public double getSubTotal(string id)
        {
            return cuentasDA.getSubTotal(int.Parse(id));
        }

        //Metodo que recibe y retorna las cuentas
        public DataTable showBill()
        {
            DataTable bill = new DataTable();
            bill = cuentasDA.showBill();
            return bill;
        }

        //Metodo que da formato a los datos y los manda a insertar
        public void insertBill(string orderID, DateTime date, string subtotal, string tip, string discount, string total)
        {
            cuentasDA.insertBill(int.Parse(orderID), date, double.Parse(subtotal), double.Parse(tip), double.Parse(discount), double.Parse(total));
        }

        //Metodo que obtiene el valor de un registro de las ordenes por mesaID que no este cancelado o cerrado
        public DataTable getTablesInOrders()
        {
            DataTable tables = new DataTable();
            tables = cuentasDA.getTablesInOrders();
            return tables;
        }

        public DataTable getOrderByTableID(string tableID)
        {
            DataTable orders = new DataTable();
            orders = cuentasDA.getOrderByTableID(tableID);
            return orders;
        }

        public DataTable getBill(string billID)
        {
            DataTable bill = new DataTable();
            bill = cuentasDA.getBill(int.Parse(billID));
            return bill;
        }

        public void updateBill(string billID, string orderID, string state)
        {
            DataTable order = ordenesDA.getOrder(int.Parse(orderID));
            DataRow row = order.Rows[0];
            cuentasDA.updateBill(int.Parse(billID), state);
            
        }

        public DataTable receiptBill(string orderID)
        {
            DataTable receipt = new DataTable();
            receipt = cuentasDA.receiptBill(int.Parse(orderID));
            return receipt;
        }
    }
}
