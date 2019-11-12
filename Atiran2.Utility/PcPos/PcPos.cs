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
        public PcPos(Control ControlClick, Control ResultRRN, Control ResultStatus, Form form)
        {
            _control = ControlClick;
            _resultRRN = ResultRRN;
            _resultStatus = ResultStatus;
            _form = form;
        }

        private static int[] _retryTimeOut = new[] { 5000, 5000, 5000 };
        private static int[] _responseTimeout = new[] { 120000, 5000, 5000 };
        private Control _control, _resultRRN, _resultStatus;
        private Form _form;

        //public PcPosBusiness pcPos;
        //public string IP;
        //public int Port = 8888;
        public bool isAsync = false;
        //public PosResult Result;

        public static string TextBuy => Resources.Buy;
        public static string TextCancelBuy => Resources.Cancel_Buy;

        public void SentAmountToPos(string amount, bool isCanselBuy)
        {
            try
            {
                if (_control.Text == Resources.Buy)
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

                    //this.Ip = IP;
                    //this.Port = Port;
                    this.ConnectionType = PcPosConnectionType.Lan;

                    //set result call back
                    if (isAsync)
                    {
                        this.AsyncSaleTransaction();
                        _control.Text = Resources.Cancel_Buy;
                    }
                    else
                    {
                        _control.Text = Resources.Cancel_Buy;
                        PcPosSaleResult(null, this.SyncSaleTransaction());
                    }

                }
                else if (_control.Text == Resources.Cancel_Buy)
                {
                    this.AbortPcPosOperation();
                    _control.Text = Resources.Buy;
                }
            }
            catch (Exception ex)
            {
                _control.Text = Resources.Buy;
                MessageBox.Show(ex.Message);
            }
        }

        public void PcPosSaleResult(object sender, PosResult pPosResult)
        {
            Action<PosResult> fillResult = delegate (PosResult e)
            {
                //PacketType.Text = e.PacketType;
                //ResponseCode.Text = e.ResponseCode;
                //Amount.Text = e.Amount;
                //CardNo.Text = e.CardNo;
                //ProcessingCode.Text = e.ProcessingCode;
                //TransactionNo.Text = e.TransactionNo;
                //TransactionTime.Text = e.TransactionTime;
                //transactionDate.Text = e.TransactionDate;
                _resultRRN.Text = e.Rrn;
                //ApprovalCode.Text = e.ApprovalCode;
                //Terminal.Text = e.TerminalId;
                //Merchant.Text = e.MerchantId;
                //OptionalField.Text = e.OptionalField;
                _resultStatus.Text = e.PcPosStatus;
                //txtSaleOrderId.Text = e.OrderId;

                //Result = e;

                _control.Text = Resources.Buy;


                if (e.PcPosStatusCode != (int)FrameExchangeResponse.SimultaneousRequestError)
                {
                    //PcPos = null;
                }
            };

            if (_form.InvokeRequired)
            {
                _form.BeginInvoke(new MethodInvoker(() =>
                {
                    fillResult(pPosResult);
                }));
            }
            else
            {
                fillResult(pPosResult);
            }
        }


        #region Method


        private void CreatePcPosObject()
        {
            //if (this == null)
            //{
            this.OnSaleResult += PcPosSaleResult;
            //}
        }

        #endregion


        public void Dispose() => base.Dispose();
    }
}
