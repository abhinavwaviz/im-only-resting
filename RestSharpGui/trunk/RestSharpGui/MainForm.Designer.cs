﻿namespace Swensen.RestSharpGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitterMain = new System.Windows.Forms.SplitContainer();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.grpResponse = new System.Windows.Forms.GroupBox();
            this.tcResponse = new System.Windows.Forms.TabControl();
            this.tpResponseText = new System.Windows.Forms.TabPage();
            this.rtResponseText = new System.Windows.Forms.RichTextBox();
            this.tpResponseHeaders = new System.Windows.Forms.TabPage();
            this.txtResponseHeaders = new System.Windows.Forms.TextBox();
            this.pnlResponseStatus = new System.Windows.Forms.Panel();
            this.lblResponseStatusValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlTopHalfOfRequest = new System.Windows.Forms.Panel();
            this.pnlRequestMethodAndHeaders = new System.Windows.Forms.Panel();
            this.grpHeaders = new System.Windows.Forms.GroupBox();
            this.txtRequestHeaders = new System.Windows.Forms.TextBox();
            this.grpHttpMethod = new System.Windows.Forms.GroupBox();
            this.rbHttpGet = new System.Windows.Forms.RadioButton();
            this.rbHttpPost = new System.Windows.Forms.RadioButton();
            this.pnlRequestUrlAndButtons = new System.Windows.Forms.Panel();
            this.pnlUrl = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearRequest = new System.Windows.Forms.Button();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.grpBody = new System.Windows.Forms.GroupBox();
            this.txtRequestBody = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).BeginInit();
            this.splitterMain.Panel1.SuspendLayout();
            this.splitterMain.Panel2.SuspendLayout();
            this.splitterMain.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.grpResponse.SuspendLayout();
            this.tcResponse.SuspendLayout();
            this.tpResponseText.SuspendLayout();
            this.tpResponseHeaders.SuspendLayout();
            this.pnlResponseStatus.SuspendLayout();
            this.pnlTopHalfOfRequest.SuspendLayout();
            this.pnlRequestMethodAndHeaders.SuspendLayout();
            this.grpHeaders.SuspendLayout();
            this.grpHttpMethod.SuspendLayout();
            this.pnlRequestUrlAndButtons.SuspendLayout();
            this.pnlUrl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterMain
            // 
            this.splitterMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterMain.Location = new System.Drawing.Point(0, 0);
            this.splitterMain.Name = "splitterMain";
            // 
            // splitterMain.Panel1
            // 
            this.splitterMain.Panel1.Controls.Add(this.grpRequest);
            // 
            // splitterMain.Panel2
            // 
            this.splitterMain.Panel2.Controls.Add(this.grpResponse);
            this.splitterMain.Size = new System.Drawing.Size(1703, 551);
            this.splitterMain.SplitterDistance = 1065;
            this.splitterMain.TabIndex = 3;
            // 
            // grpRequest
            // 
            this.grpRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpRequest.Controls.Add(this.grpBody);
            this.grpRequest.Controls.Add(this.pnlTopHalfOfRequest);
            this.grpRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRequest.Location = new System.Drawing.Point(0, 0);
            this.grpRequest.Margin = new System.Windows.Forms.Padding(4);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Padding = new System.Windows.Forms.Padding(4);
            this.grpRequest.Size = new System.Drawing.Size(1065, 551);
            this.grpRequest.TabIndex = 2;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Request";
            // 
            // grpResponse
            // 
            this.grpResponse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpResponse.Controls.Add(this.tcResponse);
            this.grpResponse.Controls.Add(this.pnlResponseStatus);
            this.grpResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResponse.Location = new System.Drawing.Point(0, 0);
            this.grpResponse.Margin = new System.Windows.Forms.Padding(4);
            this.grpResponse.Name = "grpResponse";
            this.grpResponse.Padding = new System.Windows.Forms.Padding(4);
            this.grpResponse.Size = new System.Drawing.Size(634, 551);
            this.grpResponse.TabIndex = 3;
            this.grpResponse.TabStop = false;
            this.grpResponse.Text = "Response";
            // 
            // tcResponse
            // 
            this.tcResponse.Controls.Add(this.tpResponseText);
            this.tcResponse.Controls.Add(this.tpResponseHeaders);
            this.tcResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcResponse.Location = new System.Drawing.Point(4, 49);
            this.tcResponse.Margin = new System.Windows.Forms.Padding(4);
            this.tcResponse.Name = "tcResponse";
            this.tcResponse.SelectedIndex = 0;
            this.tcResponse.Size = new System.Drawing.Size(626, 498);
            this.tcResponse.TabIndex = 6;
            // 
            // tpResponseText
            // 
            this.tpResponseText.Controls.Add(this.rtResponseText);
            this.tpResponseText.Location = new System.Drawing.Point(4, 25);
            this.tpResponseText.Margin = new System.Windows.Forms.Padding(4);
            this.tpResponseText.Name = "tpResponseText";
            this.tpResponseText.Padding = new System.Windows.Forms.Padding(4);
            this.tpResponseText.Size = new System.Drawing.Size(618, 469);
            this.tpResponseText.TabIndex = 0;
            this.tpResponseText.Text = "Body";
            this.tpResponseText.UseVisualStyleBackColor = true;
            // 
            // rtResponseText
            // 
            this.rtResponseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtResponseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResponseText.Location = new System.Drawing.Point(4, 4);
            this.rtResponseText.Margin = new System.Windows.Forms.Padding(4);
            this.rtResponseText.Name = "rtResponseText";
            this.rtResponseText.ReadOnly = true;
            this.rtResponseText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtResponseText.Size = new System.Drawing.Size(610, 461);
            this.rtResponseText.TabIndex = 0;
            this.rtResponseText.Text = "";
            this.rtResponseText.WordWrap = false;
            // 
            // tpResponseHeaders
            // 
            this.tpResponseHeaders.Controls.Add(this.txtResponseHeaders);
            this.tpResponseHeaders.Location = new System.Drawing.Point(4, 25);
            this.tpResponseHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.tpResponseHeaders.Name = "tpResponseHeaders";
            this.tpResponseHeaders.Padding = new System.Windows.Forms.Padding(4);
            this.tpResponseHeaders.Size = new System.Drawing.Size(618, 469);
            this.tpResponseHeaders.TabIndex = 1;
            this.tpResponseHeaders.Text = "Headers";
            this.tpResponseHeaders.UseVisualStyleBackColor = true;
            // 
            // txtResponseHeaders
            // 
            this.txtResponseHeaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResponseHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResponseHeaders.Location = new System.Drawing.Point(4, 4);
            this.txtResponseHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponseHeaders.Multiline = true;
            this.txtResponseHeaders.Name = "txtResponseHeaders";
            this.txtResponseHeaders.ReadOnly = true;
            this.txtResponseHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponseHeaders.Size = new System.Drawing.Size(610, 461);
            this.txtResponseHeaders.TabIndex = 0;
            this.txtResponseHeaders.WordWrap = false;
            // 
            // pnlResponseStatus
            // 
            this.pnlResponseStatus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlResponseStatus.Controls.Add(this.lblResponseStatusValue);
            this.pnlResponseStatus.Controls.Add(this.lblStatus);
            this.pnlResponseStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResponseStatus.Location = new System.Drawing.Point(4, 19);
            this.pnlResponseStatus.Margin = new System.Windows.Forms.Padding(5);
            this.pnlResponseStatus.Name = "pnlResponseStatus";
            this.pnlResponseStatus.Padding = new System.Windows.Forms.Padding(4);
            this.pnlResponseStatus.Size = new System.Drawing.Size(626, 30);
            this.pnlResponseStatus.TabIndex = 5;
            // 
            // lblResponseStatusValue
            // 
            this.lblResponseStatusValue.AutoSize = true;
            this.lblResponseStatusValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblResponseStatusValue.Location = new System.Drawing.Point(56, 4);
            this.lblResponseStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResponseStatusValue.Name = "lblResponseStatusValue";
            this.lblResponseStatusValue.Size = new System.Drawing.Size(0, 17);
            this.lblResponseStatusValue.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.Location = new System.Drawing.Point(4, 4);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status:";
            this.lblStatus.UseWaitCursor = true;
            // 
            // pnlTopHalfOfRequest
            // 
            this.pnlTopHalfOfRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTopHalfOfRequest.Controls.Add(this.pnlRequestMethodAndHeaders);
            this.pnlTopHalfOfRequest.Controls.Add(this.pnlRequestUrlAndButtons);
            this.pnlTopHalfOfRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHalfOfRequest.Location = new System.Drawing.Point(4, 19);
            this.pnlTopHalfOfRequest.Name = "pnlTopHalfOfRequest";
            this.pnlTopHalfOfRequest.Size = new System.Drawing.Size(1057, 232);
            this.pnlTopHalfOfRequest.TabIndex = 9;
            // 
            // pnlRequestMethodAndHeaders
            // 
            this.pnlRequestMethodAndHeaders.Controls.Add(this.grpHeaders);
            this.pnlRequestMethodAndHeaders.Controls.Add(this.grpHttpMethod);
            this.pnlRequestMethodAndHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRequestMethodAndHeaders.Location = new System.Drawing.Point(0, 48);
            this.pnlRequestMethodAndHeaders.Name = "pnlRequestMethodAndHeaders";
            this.pnlRequestMethodAndHeaders.Size = new System.Drawing.Size(1057, 184);
            this.pnlRequestMethodAndHeaders.TabIndex = 6;
            // 
            // grpHeaders
            // 
            this.grpHeaders.Controls.Add(this.txtRequestHeaders);
            this.grpHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpHeaders.Location = new System.Drawing.Point(95, 0);
            this.grpHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.grpHeaders.Name = "grpHeaders";
            this.grpHeaders.Padding = new System.Windows.Forms.Padding(4);
            this.grpHeaders.Size = new System.Drawing.Size(962, 184);
            this.grpHeaders.TabIndex = 6;
            this.grpHeaders.TabStop = false;
            this.grpHeaders.Text = "Headers";
            // 
            // txtRequestHeaders
            // 
            this.txtRequestHeaders.AcceptsReturn = true;
            this.txtRequestHeaders.AcceptsTab = true;
            this.txtRequestHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestHeaders.Location = new System.Drawing.Point(4, 19);
            this.txtRequestHeaders.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestHeaders.Multiline = true;
            this.txtRequestHeaders.Name = "txtRequestHeaders";
            this.txtRequestHeaders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequestHeaders.Size = new System.Drawing.Size(954, 161);
            this.txtRequestHeaders.TabIndex = 3;
            this.txtRequestHeaders.WordWrap = false;
            // 
            // grpHttpMethod
            // 
            this.grpHttpMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpHttpMethod.Controls.Add(this.rbHttpGet);
            this.grpHttpMethod.Controls.Add(this.rbHttpPost);
            this.grpHttpMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpHttpMethod.Location = new System.Drawing.Point(0, 0);
            this.grpHttpMethod.Margin = new System.Windows.Forms.Padding(4);
            this.grpHttpMethod.Name = "grpHttpMethod";
            this.grpHttpMethod.Padding = new System.Windows.Forms.Padding(4);
            this.grpHttpMethod.Size = new System.Drawing.Size(95, 184);
            this.grpHttpMethod.TabIndex = 5;
            this.grpHttpMethod.TabStop = false;
            this.grpHttpMethod.Text = "Method";
            // 
            // rbHttpGet
            // 
            this.rbHttpGet.AutoSize = true;
            this.rbHttpGet.Checked = true;
            this.rbHttpGet.Location = new System.Drawing.Point(8, 23);
            this.rbHttpGet.Margin = new System.Windows.Forms.Padding(4);
            this.rbHttpGet.Name = "rbHttpGet";
            this.rbHttpGet.Size = new System.Drawing.Size(52, 21);
            this.rbHttpGet.TabIndex = 1;
            this.rbHttpGet.TabStop = true;
            this.rbHttpGet.Text = "Get";
            this.rbHttpGet.UseVisualStyleBackColor = true;
            // 
            // rbHttpPost
            // 
            this.rbHttpPost.AutoSize = true;
            this.rbHttpPost.Location = new System.Drawing.Point(8, 52);
            this.rbHttpPost.Margin = new System.Windows.Forms.Padding(4);
            this.rbHttpPost.Name = "rbHttpPost";
            this.rbHttpPost.Size = new System.Drawing.Size(57, 21);
            this.rbHttpPost.TabIndex = 0;
            this.rbHttpPost.Tag = "";
            this.rbHttpPost.Text = "Post";
            this.rbHttpPost.UseVisualStyleBackColor = true;
            // 
            // pnlRequestUrlAndButtons
            // 
            this.pnlRequestUrlAndButtons.Controls.Add(this.pnlUrl);
            this.pnlRequestUrlAndButtons.Controls.Add(this.panel1);
            this.pnlRequestUrlAndButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRequestUrlAndButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlRequestUrlAndButtons.Name = "pnlRequestUrlAndButtons";
            this.pnlRequestUrlAndButtons.Size = new System.Drawing.Size(1057, 48);
            this.pnlRequestUrlAndButtons.TabIndex = 5;
            // 
            // pnlUrl
            // 
            this.pnlUrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlUrl.Controls.Add(this.txtUrl);
            this.pnlUrl.Controls.Add(this.lblUrl);
            this.pnlUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUrl.Location = new System.Drawing.Point(0, 0);
            this.pnlUrl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUrl.Name = "pnlUrl";
            this.pnlUrl.Padding = new System.Windows.Forms.Padding(8);
            this.pnlUrl.Size = new System.Drawing.Size(820, 48);
            this.pnlUrl.TabIndex = 6;
            // 
            // txtUrl
            // 
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUrl.Location = new System.Drawing.Point(38, 8);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(774, 22);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.WordWrap = false;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUrl.Location = new System.Drawing.Point(8, 8);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(30, 17);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Url:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClearRequest);
            this.panel1.Controls.Add(this.btnSubmitRequest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(820, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 48);
            this.panel1.TabIndex = 5;
            // 
            // btnClearRequest
            // 
            this.btnClearRequest.AutoSize = true;
            this.btnClearRequest.Location = new System.Drawing.Point(115, 4);
            this.btnClearRequest.Name = "btnClearRequest";
            this.btnClearRequest.Size = new System.Drawing.Size(112, 34);
            this.btnClearRequest.TabIndex = 5;
            this.btnClearRequest.Text = "Clear";
            this.btnClearRequest.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.AutoSize = true;
            this.btnSubmitRequest.Location = new System.Drawing.Point(4, 4);
            this.btnSubmitRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(104, 34);
            this.btnSubmitRequest.TabIndex = 4;
            this.btnSubmitRequest.Text = "Submit";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            // 
            // grpBody
            // 
            this.grpBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBody.Controls.Add(this.txtRequestBody);
            this.grpBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBody.Location = new System.Drawing.Point(4, 251);
            this.grpBody.Margin = new System.Windows.Forms.Padding(4);
            this.grpBody.Name = "grpBody";
            this.grpBody.Padding = new System.Windows.Forms.Padding(4);
            this.grpBody.Size = new System.Drawing.Size(1057, 296);
            this.grpBody.TabIndex = 10;
            this.grpBody.TabStop = false;
            this.grpBody.Text = "Body";
            // 
            // txtRequestBody
            // 
            this.txtRequestBody.AcceptsReturn = true;
            this.txtRequestBody.AcceptsTab = true;
            this.txtRequestBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRequestBody.Location = new System.Drawing.Point(4, 19);
            this.txtRequestBody.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestBody.Multiline = true;
            this.txtRequestBody.Name = "txtRequestBody";
            this.txtRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequestBody.Size = new System.Drawing.Size(1049, 273);
            this.txtRequestBody.TabIndex = 2;
            this.txtRequestBody.WordWrap = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 551);
            this.Controls.Add(this.splitterMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RestSharp GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitterMain.Panel1.ResumeLayout(false);
            this.splitterMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterMain)).EndInit();
            this.splitterMain.ResumeLayout(false);
            this.grpRequest.ResumeLayout(false);
            this.grpResponse.ResumeLayout(false);
            this.tcResponse.ResumeLayout(false);
            this.tpResponseText.ResumeLayout(false);
            this.tpResponseHeaders.ResumeLayout(false);
            this.tpResponseHeaders.PerformLayout();
            this.pnlResponseStatus.ResumeLayout(false);
            this.pnlResponseStatus.PerformLayout();
            this.pnlTopHalfOfRequest.ResumeLayout(false);
            this.pnlRequestMethodAndHeaders.ResumeLayout(false);
            this.grpHeaders.ResumeLayout(false);
            this.grpHeaders.PerformLayout();
            this.grpHttpMethod.ResumeLayout(false);
            this.grpHttpMethod.PerformLayout();
            this.pnlRequestUrlAndButtons.ResumeLayout(false);
            this.pnlUrl.ResumeLayout(false);
            this.pnlUrl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBody.ResumeLayout(false);
            this.grpBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitterMain;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.GroupBox grpResponse;
        private System.Windows.Forms.TabControl tcResponse;
        private System.Windows.Forms.TabPage tpResponseText;
        private System.Windows.Forms.RichTextBox rtResponseText;
        private System.Windows.Forms.TabPage tpResponseHeaders;
        private System.Windows.Forms.TextBox txtResponseHeaders;
        private System.Windows.Forms.Panel pnlResponseStatus;
        private System.Windows.Forms.Label lblResponseStatusValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlTopHalfOfRequest;
        private System.Windows.Forms.Panel pnlRequestMethodAndHeaders;
        private System.Windows.Forms.GroupBox grpHeaders;
        private System.Windows.Forms.TextBox txtRequestHeaders;
        private System.Windows.Forms.GroupBox grpHttpMethod;
        private System.Windows.Forms.RadioButton rbHttpGet;
        private System.Windows.Forms.RadioButton rbHttpPost;
        private System.Windows.Forms.Panel pnlRequestUrlAndButtons;
        private System.Windows.Forms.Panel pnlUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearRequest;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.GroupBox grpBody;
        private System.Windows.Forms.TextBox txtRequestBody;

    }
}

