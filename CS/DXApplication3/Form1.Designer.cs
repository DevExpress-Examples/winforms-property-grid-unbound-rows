namespace DXApplication3
{
    partial class Form1
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(219, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.propertyGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.propertyDescriptionControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(196, 444);
            this.splitContainerControl1.SplitterPosition = 326;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.SelectedObject = this;
            this.propertyGridControl1.Size = new System.Drawing.Size(196, 326);
            this.propertyGridControl1.TabIndex = 1;
            // 
            // propertyDescriptionControl1
            // 
            this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
            this.propertyDescriptionControl1.PropertyGrid = this.propertyGridControl1;
            this.propertyDescriptionControl1.Size = new System.Drawing.Size(196, 113);
            this.propertyDescriptionControl1.TabIndex = 2;
            this.propertyDescriptionControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 448);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;


    }
}

