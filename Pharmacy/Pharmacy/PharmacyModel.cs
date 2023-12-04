﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing.Printing;
using System.Drawing;

namespace Pharmacy
{
    public class PharmacyModel
    {
        public List<string> strListPharmacyDetails { get; set;}        
        public string strTypes { get; set; }
        public int intNumber { get; set; }
        public Decimal decValue { get; set; }
        public bool boolTrueOrFalse {get; set;}
        public string[] strArrayValue { get; set; }
        public DateTime dtValue { get; set; }
		public string userSJMED { get; set; }
    }

	public class mainObject
	{
		public string strShortageProduct { get; set; }
		public string strExpired { get; set; }
		public string strNearToExpired { get; set; }
		
	}

    public class PharmacyProductDetails
    {
        public Int32 intId { get; set; }
        public string strProductName { get; set; }
        public Int32 intTypeOfProduct { get; set; }
        public decimal decUnitPrice { get; set; }
        public int intDiscount { get; set; }
        public DateTime dtDateExpiry { get; set; }
    
    }

    public class WholeSaleProductsObject
    {
        public Int32 intIdWSP { get; set; }
        public Int32 intCode { get; set; }
        public string strDescription { get; set; }
        public Int32 intType { get; set; }
        public DateTime dtDateExpiry { get; set; }
        public Int32 intUnit { get; set; }
        public Int32 intUM { get; set; }
        public decimal decPrice { get; set; }
		public int intVATExempted { get; set; }

        #region Get Auto Genarated Code Number

        public string strCodeNo { get; set; }
        public int intTotalLenght { get; set; }
        public string autoGeneratedCodeNo
        {
            get
            {   
                intTotalLenght = 5;
                if (intTotalLenght > strCodeNo.Length)
                {

                    strCodeNo = strCodeNo.PadLeft(intTotalLenght, '0').ToString();
                }
                else
                {
                    strCodeNo = strCodeNo;
                }


                return strCodeNo;
            }
        }

        #endregion

    }

    public class WholeSaleObject
    {
		public decimal decWSTotal { get; set; }
		public decimal decDTWSTotal { get; set; }
		public int VATExempted { get; set; }
		public decimal decVATExempted { get; set; }
		public string TotalWithVAT { get; set; }
        public int intId { get; set; }
        public int intProductId { get; set; }
        public int StockId { get; set; }
        public int intCompanyId { get; set; }
        public string strProdDesc { get; set; }
        public int intType { get; set; }
        public DateTime DateExpirty { get; set; }
        public DateTime DateOrder { get; set; }
        public int intQuantity { get; set; }
        public decimal decPrice { get; set; }
        public decimal decTotal 
        { 
            get 
            {
                return intQuantity * decPrice;
            }
            
        }
        public double dblVat { get; set; }
        public decimal decVatableSetValue{ get; set; }
        public decimal decVatSetValue { get; set; }
        public decimal decGrandTotal { get; set; }
        public double discVatCalc 
        {
            get 
            {
                return double.Parse(decGrandTotal.ToString()) * (dblVat / 100);
            }
        
        }
        public decimal decVatable 
        {
            get 
            {
                return decGrandTotal - decimal.Parse(discVatCalc.ToString());
            }
        }
        public int InvoiceNo { get; set; }

        #region Get Auto Genarated Invoice Number

        public string strInvoiceNo { get; set; }
        public int intTotalLenght { get; set; }
        public string autoGeneratedInvNo
        {
            get
            {
                DateTime dt = DateTime.Parse(DateTime.Now.ToString());
                intTotalLenght = 5;
                if (intTotalLenght > strInvoiceNo.Length)
                {

                    strInvoiceNo = dt.Year + strInvoiceNo.PadLeft(intTotalLenght, '0').ToString();
                }
                else
                {
                    strInvoiceNo = dt.Year + strInvoiceNo;
                }


                return strInvoiceNo;
            }
        }

        #endregion

    }

    public class OldNewProductName
    {
        public string strOldProductName { get; set; }
        public string strNewProductName { get; set; }
    
    }

    public class DiscountObject
    {
        public Int32 intId { get; set; }
        public string strDiscountDesc { get; set; }
        public Int32 intDiscount { get; set; }
    
    }

    public class StockObject
    {
		public Int32 intIdSJMEDStock { get; set; }
		public Int32 intIdSJMEDProd { get; set; }
        public Int32 intId { get; set; }
		public string strDescription { get; set; }
        public Int32 ProductId { get; set; }
        public Int32 ProductType { get; set; }
        public Int32 intQuantity { get; set; }
        public DateTime dtDateExpiry { get; set; }
        public string strStatus { get; set; }
		public Int32 intPromo { get; set; }
		public DateTime dtPromoExpiry { get; set; }
    }

    public class VoidObject
    {
        public Int32 InvoiceNo { get; set; }
        public Int32 RetInvoiceNo { get; set; }
        public Int32 OrderId { get; set; }
		public string strReceiptNo { get; set; }
        public string strReason { get; set; }
        public string strMessage { get; set; }
		public int intShowFormUse { get; set; }
		public string strVoidStatus { get; set; }
		public int SJMEDSalesOrderId { get; set; }
		public int SJMEDTotalSalesOrdersId { get; set; } 
    }

	public class SJMEDProductsObject
	{
		//public string strReceiptNo {get; set;}
		public Int32 intIdSJMEDStock { get; set; }
		public Int32 intIdSJMEDProd { get; set; }
		public string strCodeNo { get; set; }
		public string strDescription { get; set; }
		public Int32 intType { get; set; }
		public Int32 intUnit { get; set; }
		public Int32 intUM { get; set; }
		public decimal decPrice { get; set; }
		public DateTime dtDateExpiry { get; set; }
		public Int32 intQuantity { get; set; }
		public Int32 intPromo { get; set; }
		public DateTime dtPromoExpiry { get; set; }
		public int intVATExempted { get; set; }
	}

	public class SJMEDSaleOrderObject
	{
		//public bool blnAmtRecIsKeyPress { get; set; }
		public int intOldProductId { get; set; }
		public int intProductId { get; set; }
        public int intStockId { get; set; }
		public int intType { get; set; }
        public string strDesc { get; set; }
		public string strDiscount { get; set; }
        public string strResults { get; set; }
        public string strCustomer { get; set; }
		public string strReceiptNoPrint { get; set; }
        public int intQuantity { get; set; }
        public int intDiscount { get; set; }
        public int intPromo { get; set; }
        public int intOldQty { get; set; }
        public int intOldStock { get; set; }
		public int VATExempted { get; set; }
		public decimal TotalVatExempted { get; set; }
        public string strOldGrandTotal { get; set; }
        public decimal decPrice { get; set; }
        public decimal decInsertTotal { get; set; }
        public decimal decTotal
        {
            get 
            {
                return intQuantity * decPrice;
                
            }
        }

		#region VAT computation

		public double dblVat { get; set; }
		public decimal decVatableSetValue { get; set; }
		public decimal decVatSetValue { get; set; }
		public decimal decGrandTotal { get; set; }
		public double discVatCalc
		{
			get
			{
				return double.Parse(decGrandTotal.ToString()) * (dblVat / 100);
			}

		}
		public decimal decVatable
		{
			get
			{
				return decGrandTotal - decimal.Parse(discVatCalc.ToString());
			}
		}

		#endregion

		#region change computation

		public decimal decAmtRec { get; set; }
        public decimal decChange
        {

            get 
            {
                return decAmtRec - decGrandTotal;
            
            }
        }

		public decimal decChangeSetValue { get; set; }
		public DateTime dtPromoExpiry { get; set; }
		public DateTime dtOrder { get; set; }

		#endregion

		#region Discount Calculation
		public string SPDiscount { get; set; }
		public string ProDiscount { get; set; }

		public double dblDiscount { get; set; }
		public decimal decProdOrderTotal { get; set; }
		public double dblDiscountCalc
		{
			get
			{
				return double.Parse(decProdOrderTotal.ToString()) * (dblDiscount / 100);
			}
		}
		public decimal decTotalDiscount
		{
			get
			{
				return decProdOrderTotal - decimal.Parse(dblDiscountCalc.ToString());
			}

		}

		public double dblPromoDiscount { get; set; }
		public decimal decPromodOrderTotal { get; set; }
		public double dblPromoDiscountCalc
		{
			get
			{
				return double.Parse(decPromodOrderTotal.ToString()) * (dblPromoDiscount / 100);
			}
		}
		public decimal decPromoTotalDiscount
		{
			get
			{
				return decPromodOrderTotal - decimal.Parse(dblPromoDiscountCalc.ToString());
			}

		}

		#endregion
        
		#region Get Auto Genarated Invoice Number

		public string strReceiptNo { get; set; }
		public int intTotalLenght { get; set; }
		public string autoGenerateReceiptNo
		{
			get
			{
				//DateTime dt = DateTime.Parse(DateTime.Now.ToString());
				intTotalLenght = 5;
				if (intTotalLenght > strReceiptNo.Length)
				{

					strReceiptNo = Properties.Settings.Default.ReceiptNo + strReceiptNo.PadLeft(intTotalLenght, '0').ToString();
				}
				else
				{
					strReceiptNo = Properties.Settings.Default.ReceiptNo + strReceiptNo;
				}


				return strReceiptNo;
			}
		}

		#endregion

    }

	#region Report Object

	public class reportObject
	{
		public string strSP { get; set; }
		public string strDataSet { get; set; }
		public string strRDLC { get; set; }
		public string strParameter { get; set; }
		public int iCase { get; set; }
		public string DateOrderParmater { get; set; }
		public string DateFrom { get; set; }
		public string DateTo { get; set; }
		public string MonthlyOrDaily { get; set; }
		public string DateToday { get; set; }

	}
		
	#endregion

	#region Print Text

	public class PrintText
    {
        public PrintText(string text, Font font) : this(text, font, new StringFormat()) { }

        public PrintText(string text, Font font, StringFormat stringFormat)
        {
            Text = text;
            Font = font;
            StringFormat = stringFormat;
        }

        public string Text { get; set; }

        public Font Font { get; set; }

        /// <summary> Default is horizontal string formatting </summary>
        public StringFormat StringFormat { get; set; }
    }

    #endregion

}
 