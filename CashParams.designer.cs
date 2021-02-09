namespace RCXYZMarginBonus
{
    partial class CashParams
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashParams));
            this.ucPeriod = new ePlus.MetaData.Client.UCPeriod();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contractorsMulti = new ePlus.MetaData.Client.UCPluginMultiSelect();
            this.checkBoxUseActs = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(323, 4);
            this.bOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bOK.Size = new System.Drawing.Size(75, 21);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(403, 4);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bClose.Size = new System.Drawing.Size(75, 21);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Size = new System.Drawing.Size(486, 29);
            // 
            // ucPeriod
            // 
            this.ucPeriod.AutoSize = true;
            this.ucPeriod.DateFrom = new System.DateTime(2006, 10, 30, 14, 2, 0, 906);
            this.ucPeriod.DateTo = new System.DateTime(2006, 10, 30, 14, 2, 0, 921);
            this.ucPeriod.Location = new System.Drawing.Point(63, 34);
            this.ucPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucPeriod.Name = "ucPeriod";
            this.ucPeriod.Size = new System.Drawing.Size(224, 23);
            this.ucPeriod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(486, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 24);
            this.toolStripButton1.Text = "Очистить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // contractorsMulti
            // 
            this.contractorsMulti.AllowSaveState = true;
            this.contractorsMulti.Caption = "Аптека";
            this.contractorsMulti.Location = new System.Drawing.Point(14, 68);
            this.contractorsMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contractorsMulti.Mnemocode = "CONTRACTOR";
            this.contractorsMulti.MultiSelect = true;
            this.contractorsMulti.Name = "contractorsMulti";
            this.contractorsMulti.Pinnable = false;
            this.contractorsMulti.Size = new System.Drawing.Size(451, 161);
            this.contractorsMulti.TabIndex = 156;
            // 
            // checkBoxUseActs
            // 
            this.checkBoxUseActs.AutoSize = true;
            this.checkBoxUseActs.Checked = true;
            this.checkBoxUseActs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseActs.Location = new System.Drawing.Point(15, 237);
            this.checkBoxUseActs.Name = "checkBoxUseActs";
            this.checkBoxUseActs.Size = new System.Drawing.Size(234, 17);
            this.checkBoxUseActs.TabIndex = 157;
            this.checkBoxUseActs.Text = "Учитывать акты возврата от покупателя";
            this.checkBoxUseActs.UseVisualStyleBackColor = true;
            // 
            // CashParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 300);
            this.Controls.Add(this.checkBoxUseActs);
            this.Controls.Add(this.contractorsMulti);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucPeriod);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CashParams";
            this.Load += new System.EventHandler(this.CashParams_Load);
            this.Controls.SetChildIndex(this.ucPeriod, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.contractorsMulti, 0);
            this.Controls.SetChildIndex(this.checkBoxUseActs, 0);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePlus.MetaData.Client.UCPeriod ucPeriod;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private ePlus.MetaData.Client.UCPluginMultiSelect contractorsMulti;
        private System.Windows.Forms.CheckBox checkBoxUseActs;
    }
}