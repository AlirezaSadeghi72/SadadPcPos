using Sadad.PcPos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atiran2.Utility.PcPos
{
    public class PcPos : PcPosBusiness, IDisposable
    {

        private static int[] _retryTimeOut = new[] { 5000, 5000, 5000 };
        private static int[] _responseTimeout = new[] { 120000, 5000, 5000 };
        
        public static string TextBuy => Resources.Buy;
        public static string TextCancelBuy => Resources.Cancel_Buy;

        public bool isAsync = true;
        //public PosResult Result;


        public (Form form, Button Sale, Control RRN, Control PcPosStatus, Control ResponseCodeMessage, Control ResponseCode, Control Amount, Control TransactionTime, Control TransactionDate) Controls;

        public void SentAmountToPos(string amount)
        {
            if (Controls.Sale == null || Controls.form == null) 
                throw new NullReferenceException();
            try
            {
                if (Controls.Sale.Text == Resources.Buy)
                {
                    CreatePcPosObject();

                    #region Clear PcPos Data
                    this.ClearAmount();
                    this.ClearBillInfo();
                    this.ClearCardInfo();
                    this.ClearMultiAccountsData();
                    this.ClearMultiSaleId();
                    this.ClearOrderId();
                    this.ClearSaleId();
                    #endregion

                    this.Amount = amount;
                    this.RetryTimeOut = _retryTimeOut;
                    this.ResponseTimeOut = _responseTimeout;
                    
                    this.ConnectionType = PcPosConnectionType.Lan;

                    //set result call back
                    if (isAsync)
                    {
                        this.AsyncSaleTransaction();
                        Controls.Sale.Text = Resources.Cancel_Buy;
                    }
                    else
                    {
                        Controls.Sale.Text = Resources.Cancel_Buy;
                        PcPosSaleResult(null, this.SyncSaleTransaction());
                    }

                }
                else if (Controls.Sale.Text == Resources.Cancel_Buy)
                {
                    this.AbortPcPosOperation();
                    Controls.Sale.Text = Resources.Buy;
                }
            }
            catch (Exception ex)
            {
                Controls.Sale.Text = Resources.Buy;
                MessageBox.Show(ex.Message);
            }
        }

        public void PcPosSaleResult(object sender, PosResult pPosResult)
        {
            Action<PosResult> fillResult = delegate (PosResult e)
            {
                if (Controls.RRN != null) Controls.RRN.Text = e.Rrn;
                if (Controls.PcPosStatus != null) Controls.PcPosStatus.Text = e.PcPosStatus;
                if (Controls.ResponseCodeMessage != null) Controls.ResponseCodeMessage.Text = e.ResponseCodeMessage;
                if (Controls.ResponseCode != null) Controls.ResponseCode.Text = e.ResponseCode;
                if (Controls.Amount != null) Controls.Amount.Text = e.Amount;
                if (Controls.TransactionTime != null) Controls.TransactionTime.Text = e.TransactionTime;
                if (Controls.TransactionDate != null) Controls.TransactionDate.Text = e.TransactionDate;

                //Result = e;

                Controls.Sale.Text = Resources.Buy;


                if (e.PcPosStatusCode != (int)FrameExchangeResponse.SimultaneousRequestError)
                {
                    //PcPos = null;
                }
            };

            if (Controls.form.InvokeRequired)
            {
                Controls.form.BeginInvoke(new MethodInvoker(() =>
                {
                    fillResult(pPosResult);
                }));
            }
            else
            {
                fillResult(pPosResult);
            }
        }

        private void CreatePcPosObject()
        {
            this.OnSaleResult += PcPosSaleResult;
        }
        
        public void Dispose() => base.Dispose();
        
    }
}
