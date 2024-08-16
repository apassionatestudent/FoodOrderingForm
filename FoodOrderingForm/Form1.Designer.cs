namespace FoodOrderingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.radDineIn = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.lblMenu = new System.Windows.Forms.Label();
            this.ckbChicken = new System.Windows.Forms.CheckBox();
            this.lblBurgers = new System.Windows.Forms.Label();
            this.ckbBeef = new System.Windows.Forms.CheckBox();
            this.ckbPork = new System.Windows.Forms.CheckBox();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.ckbCoke = new System.Windows.Forms.CheckBox();
            this.ckbSprite = new System.Windows.Forms.CheckBox();
            this.ckbRoyal = new System.Windows.Forms.CheckBox();
            this.lblFries = new System.Windows.Forms.Label();
            this.ckbSpicy = new System.Windows.Forms.CheckBox();
            this.ckbSweetSpicy = new System.Windows.Forms.CheckBox();
            this.ckbRegular = new System.Windows.Forms.CheckBox();
            this.lblCurrentTotal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblPaymentMethod
            // 
            resources.ApplyResources(this.lblPaymentMethod, "lblPaymentMethod");
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            resources.GetString("cmbPaymentMethod.Items"),
            resources.GetString("cmbPaymentMethod.Items1"),
            resources.GetString("cmbPaymentMethod.Items2")});
            resources.ApplyResources(this.cmbPaymentMethod, "cmbPaymentMethod");
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            // 
            // radDineIn
            // 
            resources.ApplyResources(this.radDineIn, "radDineIn");
            this.radDineIn.Name = "radDineIn";
            this.radDineIn.TabStop = true;
            this.radDineIn.UseVisualStyleBackColor = true;
            this.radDineIn.CheckedChanged += new System.EventHandler(this.radDineIn_CheckedChanged);
            // 
            // radTakeOut
            // 
            resources.ApplyResources(this.radTakeOut, "radTakeOut");
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.TabStop = true;
            this.radTakeOut.UseVisualStyleBackColor = true;
            this.radTakeOut.CheckedChanged += new System.EventHandler(this.radTakeOut_CheckedChanged);
            // 
            // lblMenu
            // 
            resources.ApplyResources(this.lblMenu, "lblMenu");
            this.lblMenu.Name = "lblMenu";
            // 
            // ckbChicken
            // 
            resources.ApplyResources(this.ckbChicken, "ckbChicken");
            this.ckbChicken.Name = "ckbChicken";
            this.ckbChicken.UseVisualStyleBackColor = true;
            // 
            // lblBurgers
            // 
            resources.ApplyResources(this.lblBurgers, "lblBurgers");
            this.lblBurgers.Name = "lblBurgers";
            // 
            // ckbBeef
            // 
            resources.ApplyResources(this.ckbBeef, "ckbBeef");
            this.ckbBeef.Name = "ckbBeef";
            this.ckbBeef.UseVisualStyleBackColor = true;
            // 
            // ckbPork
            // 
            resources.ApplyResources(this.ckbPork, "ckbPork");
            this.ckbPork.Name = "ckbPork";
            this.ckbPork.UseVisualStyleBackColor = true;
            // 
            // lblDrinks
            // 
            resources.ApplyResources(this.lblDrinks, "lblDrinks");
            this.lblDrinks.Name = "lblDrinks";
            // 
            // ckbCoke
            // 
            resources.ApplyResources(this.ckbCoke, "ckbCoke");
            this.ckbCoke.Name = "ckbCoke";
            this.ckbCoke.UseVisualStyleBackColor = true;
            // 
            // ckbSprite
            // 
            resources.ApplyResources(this.ckbSprite, "ckbSprite");
            this.ckbSprite.Name = "ckbSprite";
            this.ckbSprite.UseVisualStyleBackColor = true;
            // 
            // ckbRoyal
            // 
            resources.ApplyResources(this.ckbRoyal, "ckbRoyal");
            this.ckbRoyal.Name = "ckbRoyal";
            this.ckbRoyal.UseVisualStyleBackColor = true;
            // 
            // lblFries
            // 
            resources.ApplyResources(this.lblFries, "lblFries");
            this.lblFries.Name = "lblFries";
            // 
            // ckbSpicy
            // 
            resources.ApplyResources(this.ckbSpicy, "ckbSpicy");
            this.ckbSpicy.Name = "ckbSpicy";
            this.ckbSpicy.UseVisualStyleBackColor = true;
            // 
            // ckbSweetSpicy
            // 
            resources.ApplyResources(this.ckbSweetSpicy, "ckbSweetSpicy");
            this.ckbSweetSpicy.Name = "ckbSweetSpicy";
            this.ckbSweetSpicy.UseVisualStyleBackColor = true;
            // 
            // ckbRegular
            // 
            resources.ApplyResources(this.ckbRegular, "ckbRegular");
            this.ckbRegular.Name = "ckbRegular";
            this.ckbRegular.UseVisualStyleBackColor = true;
            // 
            // lblCurrentTotal
            // 
            resources.ApplyResources(this.lblCurrentTotal, "lblCurrentTotal");
            this.lblCurrentTotal.Name = "lblCurrentTotal";
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.btnOrder, "btnOrder");
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            resources.ApplyResources(this.lstBox, "lstBox");
            this.lstBox.Name = "lstBox";
            // 
            // lblOrderDetails
            // 
            resources.ApplyResources(this.lblOrderDetails, "lblOrderDetails");
            this.lblOrderDetails.Name = "lblOrderDetails";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCurrentTotal);
            this.Controls.Add(this.ckbRegular);
            this.Controls.Add(this.ckbSweetSpicy);
            this.Controls.Add(this.ckbSpicy);
            this.Controls.Add(this.lblFries);
            this.Controls.Add(this.ckbRoyal);
            this.Controls.Add(this.ckbSprite);
            this.Controls.Add(this.ckbCoke);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.ckbPork);
            this.Controls.Add(this.ckbBeef);
            this.Controls.Add(this.lblBurgers);
            this.Controls.Add(this.ckbChicken);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.radTakeOut);
            this.Controls.Add(this.radDineIn);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radDineIn;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.CheckBox ckbChicken;
        private System.Windows.Forms.Label lblBurgers;
        private System.Windows.Forms.CheckBox ckbBeef;
        private System.Windows.Forms.CheckBox ckbPork;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.CheckBox ckbCoke;
        private System.Windows.Forms.CheckBox ckbSprite;
        private System.Windows.Forms.CheckBox ckbRoyal;
        private System.Windows.Forms.Label lblFries;
        private System.Windows.Forms.CheckBox ckbSpicy;
        private System.Windows.Forms.CheckBox ckbSweetSpicy;
        private System.Windows.Forms.CheckBox ckbRegular;
        private System.Windows.Forms.Label lblCurrentTotal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
    }
}

