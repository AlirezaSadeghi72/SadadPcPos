using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atiran2.SadadPcPos.Properties;
using Atiran2.Utility.PcPos;
using Sadad.PcPos.Core;

namespace Atiran2.SadadPcPos
{
    public class Form1 : Form
    {
        //public PcPosBusiness PcPos;
        //private int[] retryTimeOut = new[] { 5000, 5000, 5000 };
        //private int[] responseTimeout = new[] { 120000, 5000, 5000 };

        private string IP_Pos = "192.168.100.1";
        private RadioButton radioButtonSync;
        private RadioButton radioButtonAsync;
        private int Port_Pos = 8888;
        private PcPos Pc;
        public Form1()
        {
            InitializeComponent();

            Pc = new PcPos(btnSale, RRN, PcPosStatus, this);
        }

        private TextBox txtSaleOrderId;
        private Label label106;
        private TextBox RRN;
        private TextBox Terminal;
        private Label label7;
        private TextBox ApprovalCode;
        private Label label6;
        private TextBox Merchant;
        private Label label5;
        private TextBox OptionalField;
        private Label label4;
        private TextBox PcPosStatus;
        private Label label3;
        private Label label14;
        public Label ResponseCoderrr;
        private Label label13;
        private Label label17;
        private Label label1;
        private TextBox txtPayAmount;
        private Label label12;
        private Label label16;
        private TextBox transactionDate;
        private TextBox txtSerialNo;
        private Label label11;
        private TextBox TransactionTime;
        private Button btnSale;
        private Label label10;
        private TextBox ResponseCode;
        private TextBox TransactionNo;
        private TextBox CardNo;
        private Label label9;
        private TextBox Amount;
        private TextBox ProcessingCode;
        private TextBox PacketType;
        private Label label2;

        private void InitializeComponent()
        {
            this.txtSaleOrderId = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.RRN = new System.Windows.Forms.TextBox();
            this.Terminal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ApprovalCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Merchant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OptionalField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PcPosStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ResponseCoderrr = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.transactionDate = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TransactionTime = new System.Windows.Forms.TextBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ResponseCode = new System.Windows.Forms.TextBox();
            this.TransactionNo = new System.Windows.Forms.TextBox();
            this.CardNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.ProcessingCode = new System.Windows.Forms.TextBox();
            this.PacketType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonSync = new System.Windows.Forms.RadioButton();
            this.radioButtonAsync = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSaleOrderId
            // 
            this.txtSaleOrderId.Location = new System.Drawing.Point(12, 201);
            this.txtSaleOrderId.Name = "txtSaleOrderId";
            this.txtSaleOrderId.Size = new System.Drawing.Size(120, 20);
            this.txtSaleOrderId.TabIndex = 134;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(165, 204);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(45, 13);
            this.label106.TabIndex = 135;
            this.label106.Text = "Order Id";
            // 
            // RRN
            // 
            this.RRN.Location = new System.Drawing.Point(12, 12);
            this.RRN.Name = "RRN";
            this.RRN.Size = new System.Drawing.Size(120, 20);
            this.RRN.TabIndex = 118;
            // 
            // Terminal
            // 
            this.Terminal.Location = new System.Drawing.Point(12, 66);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(120, 20);
            this.Terminal.TabIndex = 122;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Transaction Date";
            // 
            // ApprovalCode
            // 
            this.ApprovalCode.Location = new System.Drawing.Point(12, 39);
            this.ApprovalCode.Name = "ApprovalCode";
            this.ApprovalCode.Size = new System.Drawing.Size(120, 20);
            this.ApprovalCode.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Transaction Time";
            // 
            // Merchant
            // 
            this.Merchant.Location = new System.Drawing.Point(12, 93);
            this.Merchant.Name = "Merchant";
            this.Merchant.Size = new System.Drawing.Size(120, 20);
            this.Merchant.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Transaction No";
            // 
            // OptionalField
            // 
            this.OptionalField.Location = new System.Drawing.Point(12, 120);
            this.OptionalField.Name = "OptionalField";
            this.OptionalField.Size = new System.Drawing.Size(120, 20);
            this.OptionalField.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 103;
            this.label4.Text = "Proccessing Code";
            // 
            // PcPosStatus
            // 
            this.PcPosStatus.Location = new System.Drawing.Point(12, 147);
            this.PcPosStatus.Name = "PcPosStatus";
            this.PcPosStatus.Size = new System.Drawing.Size(120, 20);
            this.PcPosStatus.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Card No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "RRN";
            // 
            // ResponseCoderrr
            // 
            this.ResponseCoderrr.AutoSize = true;
            this.ResponseCoderrr.Location = new System.Drawing.Point(367, 42);
            this.ResponseCoderrr.Name = "ResponseCoderrr";
            this.ResponseCoderrr.Size = new System.Drawing.Size(83, 13);
            this.ResponseCoderrr.TabIndex = 104;
            this.ResponseCoderrr.Text = "Response Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 127;
            this.label13.Text = "Approval Code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(731, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 133;
            this.label17.Text = "مبلغ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Packet Type";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(509, 39);
            this.txtPayAmount.MaxLength = 15;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(218, 20);
            this.txtPayAmount.TabIndex = 101;
            this.txtPayAmount.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 124;
            this.label12.Text = "Terminal";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(400, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 132;
            this.label16.Text = "Serial No";
            // 
            // transactionDate
            // 
            this.transactionDate.Location = new System.Drawing.Point(223, 174);
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transactionDate.Size = new System.Drawing.Size(120, 20);
            this.transactionDate.TabIndex = 116;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(223, 201);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSerialNo.Size = new System.Drawing.Size(120, 20);
            this.txtSerialNo.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 123;
            this.label11.Text = "Merchant";
            // 
            // TransactionTime
            // 
            this.TransactionTime.Location = new System.Drawing.Point(223, 147);
            this.TransactionTime.Name = "TransactionTime";
            this.TransactionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionTime.Size = new System.Drawing.Size(120, 20);
            this.TransactionTime.TabIndex = 115;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSale.Location = new System.Drawing.Point(589, 69);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(80, 23);
            this.btnSale.TabIndex = 102;
            this.btnSale.Text = "خرید";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "Optional Field";
            // 
            // ResponseCode
            // 
            this.ResponseCode.Location = new System.Drawing.Point(223, 39);
            this.ResponseCode.Name = "ResponseCode";
            this.ResponseCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResponseCode.Size = new System.Drawing.Size(120, 20);
            this.ResponseCode.TabIndex = 111;
            // 
            // TransactionNo
            // 
            this.TransactionNo.Location = new System.Drawing.Point(223, 120);
            this.TransactionNo.Name = "TransactionNo";
            this.TransactionNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransactionNo.Size = new System.Drawing.Size(120, 20);
            this.TransactionNo.TabIndex = 114;
            // 
            // CardNo
            // 
            this.CardNo.Location = new System.Drawing.Point(223, 66);
            this.CardNo.Name = "CardNo";
            this.CardNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardNo.Size = new System.Drawing.Size(120, 20);
            this.CardNo.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 119;
            this.label9.Text = "PcPos Status";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(12, 174);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(120, 20);
            this.Amount.TabIndex = 130;
            // 
            // ProcessingCode
            // 
            this.ProcessingCode.Location = new System.Drawing.Point(223, 93);
            this.ProcessingCode.Name = "ProcessingCode";
            this.ProcessingCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProcessingCode.Size = new System.Drawing.Size(120, 20);
            this.ProcessingCode.TabIndex = 113;
            // 
            // PacketType
            // 
            this.PacketType.Location = new System.Drawing.Point(223, 12);
            this.PacketType.Name = "PacketType";
            this.PacketType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PacketType.Size = new System.Drawing.Size(120, 20);
            this.PacketType.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "Amount";
            // 
            // radioButtonSync
            // 
            this.radioButtonSync.AutoSize = true;
            this.radioButtonSync.Location = new System.Drawing.Point(655, 11);
            this.radioButtonSync.Name = "radioButtonSync";
            this.radioButtonSync.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSync.TabIndex = 136;
            this.radioButtonSync.Text = "Sync";
            this.radioButtonSync.UseVisualStyleBackColor = true;
            // 
            // radioButtonAsync
            // 
            this.radioButtonAsync.AutoSize = true;
            this.radioButtonAsync.Checked = true;
            this.radioButtonAsync.Location = new System.Drawing.Point(568, 11);
            this.radioButtonAsync.Name = "radioButtonAsync";
            this.radioButtonAsync.Size = new System.Drawing.Size(54, 17);
            this.radioButtonAsync.TabIndex = 137;
            this.radioButtonAsync.TabStop = true;
            this.radioButtonAsync.Text = "Async";
            this.radioButtonAsync.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(769, 240);
            this.Controls.Add(this.radioButtonSync);
            this.Controls.Add(this.radioButtonAsync);
            this.Controls.Add(this.txtSaleOrderId);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.RRN);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ApprovalCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Merchant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OptionalField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PcPosStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ResponseCoderrr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.transactionDate);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TransactionTime);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ResponseCode);
            this.Controls.Add(this.TransactionNo);
            this.Controls.Add(this.CardNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.ProcessingCode);
            this.Controls.Add(this.PacketType);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            btnSale.Text = (btnSale.Text != PcPos.TextBuy && btnSale.Text != PcPos.TextCancelBuy) ? PcPos.TextBuy : btnSale.Text;

            CleanResult();

            Pc.Ip = IP_Pos;
            Pc.Port = Port_Pos;
            Pc.isAsync = radioButtonAsync.Checked;
            Pc.SentAmountToPos(txtPayAmount.Text, (btnSale.Text != PcPos.TextBuy && btnSale.Text != PcPos.TextCancelBuy));
        }

        //#region Event PcPosObject
        //private void btnSale_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (btnSale.Text == Resources.Buy)
        //        {
        //            CleanResult();
        //            CreatePcPosObject();

        //            #region Clear PcPos Data
        //            PcPos.ClearAmount();
        //            PcPos.ClearBillInfo();
        //            PcPos.ClearCardInfo();
        //            PcPos.ClearMultiAccountsData();
        //            PcPos.ClearMultiSaleId();
        //            PcPos.ClearOrderId();
        //            PcPos.ClearSaleId();
        //            #endregion

        //            PcPos.Amount = txtPayAmount.Text;
        //            PcPos.RetryTimeOut = retryTimeOut;
        //            PcPos.ResponseTimeOut = responseTimeout;

        //            //if (cmbConnectionType.SelectedItem.ToString().Contains("Lan"))
        //            //{// اتصال از طريق lan

        //            PcPos.Ip = IP_Pos;//selectedIpDevice[0].IpAddress;
        //            PcPos.Port = Port_Pos;//Convert.ToInt32(selectedIpDevice[0].Port);
        //            PcPos.ConnectionType = PcPosConnectionType.Lan;

        //            //set result call back

        //            //set result call back
        //            if (radioButtonAsync.Checked)
        //            {
        //                //PcPos.OnSaleResult += PcPosSaleResult;
        //                PcPos.AsyncSaleTransaction();
        //                btnSale.Text = Resources.Cancel_Buy;
        //            }
        //            else if (radioButtonSync.Checked)
        //            {
        //                btnSale.Text = Resources.Cancel_Buy;
        //                PcPosSaleResult(null, PcPos.SyncSaleTransaction());
        //            }
        //            //}

        //        }
        //        else if (btnSale.Text == Resources.Cancel_Buy)
        //        {
        //            PcPos.AbortPcPosOperation();
        //            btnSale.Enabled = true;
        //            btnSale.Text = Resources.Buy;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        btnSale.Enabled = true;
        //        btnSale.Text = Resources.Buy;
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void PcPosSaleResult(object sender, PosResult pPosResult)
        //{
        //    Action<PosResult> fillResult = delegate (PosResult e)
        //    {
        //        PacketType.Text = e.PacketType;
        //        ResponseCode.Text = e.ResponseCode;
        //        Amount.Text = e.Amount;
        //        CardNo.Text = e.CardNo;
        //        ProcessingCode.Text = e.ProcessingCode;
        //        TransactionNo.Text = e.TransactionNo;
        //        TransactionTime.Text = e.TransactionTime;
        //        transactionDate.Text = e.TransactionDate;
        //        RRN.Text = e.Rrn;
        //        ApprovalCode.Text = e.ApprovalCode;
        //        Terminal.Text = e.TerminalId;
        //        Merchant.Text = e.MerchantId;
        //        OptionalField.Text = e.OptionalField;
        //        PcPosStatus.Text = e.PcPosStatus;
        //        txtSaleOrderId.Text = e.OrderId;

        //        btnSale.Text = Resources.Buy;


        //        if (e.PcPosStatusCode != (int)FrameExchangeResponse.SimultaneousRequestError)
        //        {
        //            //PcPos = null;
        //        }
        //    };

        //    if (this.InvokeRequired)
        //    {
        //        this.BeginInvoke(new MethodInvoker(() =>
        //        {
        //            fillResult(pPosResult);
        //        }));
        //    }
        //    else
        //    {
        //        fillResult(pPosResult);
        //    }
        //}

        //#endregion

        //#region Method

        //private void CreatePcPosObject()
        //{
        //    if (PcPos == null)
        //    {
        //        PcPos = new PcPosBusiness();
        //        PcPos.OnSaleResult += PcPosSaleResult;
        //    }
        //}

        //#endregion
        private void CleanResult()
        {
            PacketType.Text = "";
            ResponseCode.Text = "";
            Amount.Text = "";
            CardNo.Text = "";
            ProcessingCode.Text = "";
            TransactionNo.Text = "";
            TransactionTime.Text = "";
            transactionDate.Text = "";
            RRN.Text = "";
            ApprovalCode.Text = "";
            Terminal.Text = "";
            Merchant.Text = "";
            OptionalField.Text = "";
            PcPosStatus.Text = "";
            txtSaleOrderId.Text = "";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //PcPos?.Dispose();
            Pc?.Dispose();
        }
    }
}