using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TestWithGiasutinhocGuide.Resources.BillCalculate
{
    class BillCalculate
    {
        private int _Amount;
        private double _Price;

        public BillCalculate(int amount, double price)
        {
            _Amount = amount;
            _Price = price;
        }

        public double getPrice()
        {
            return _Price;
        }

        public int getAmount()
        {
            return _Amount;
        }

        public void setPrice(double price)
        {
            _Price = price;
        }

        public void setAmount(int amount)
        {
            _Amount = amount;
        }

        public double TotalBill()
        {
            return _Price * _Amount;
        }
    }
}