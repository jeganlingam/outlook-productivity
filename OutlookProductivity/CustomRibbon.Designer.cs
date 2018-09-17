namespace OutlookProductivity
{
	partial class CustomRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public CustomRibbon()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tab1 = this.Factory.CreateRibbonTab();
			this.ProductivityGroup = this.Factory.CreateRibbonGroup();
			this.BtnIgnore = this.Factory.CreateRibbonButton();
			this.BtnTest = this.Factory.CreateRibbonButton();
			this.BtnUndoIgnore = this.Factory.CreateRibbonButton();
			this.TxtSpecialWords = this.Factory.CreateRibbonEditBox();
			this.tab1.SuspendLayout();
			this.ProductivityGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.ControlId.OfficeId = "TabMail";
			this.tab1.Groups.Add(this.ProductivityGroup);
			this.tab1.Label = "TabMail";
			this.tab1.Name = "tab1";
			// 
			// ProductivityGroup
			// 
			this.ProductivityGroup.Items.Add(this.BtnIgnore);
			this.ProductivityGroup.Items.Add(this.BtnUndoIgnore);
			this.ProductivityGroup.Items.Add(this.TxtSpecialWords);
			this.ProductivityGroup.Items.Add(this.BtnTest);
			this.ProductivityGroup.Label = "Productivity";
			this.ProductivityGroup.Name = "ProductivityGroup";
			// 
			// BtnIgnore
			// 
			this.BtnIgnore.Label = "Ignore";
			this.BtnIgnore.Name = "BtnIgnore";
			this.BtnIgnore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnIgnore_Click);
			// 
			// BtnTest
			// 
			this.BtnTest.Label = "Test";
			this.BtnTest.Name = "BtnTest";
			this.BtnTest.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnTest_Click);
			// 
			// BtnUndoIgnore
			// 
			this.BtnUndoIgnore.Label = "Undo-Ignore";
			this.BtnUndoIgnore.Name = "BtnUndoIgnore";
			this.BtnUndoIgnore.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BtnUndoIgnore_Click);
			// 
			// TxtSpecialWords
			// 
			this.TxtSpecialWords.Label = "Special Words";
			this.TxtSpecialWords.Name = "TxtSpecialWords";
			this.TxtSpecialWords.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TxtSpecialWords_TextChanged);
			// 
			// CustomRibbon
			// 
			this.Name = "CustomRibbon";
			this.RibbonType = "Microsoft.Outlook.Explorer";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbon_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.ProductivityGroup.ResumeLayout(false);
			this.ProductivityGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup ProductivityGroup;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnIgnore;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnTest;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton BtnUndoIgnore;
		internal Microsoft.Office.Tools.Ribbon.RibbonEditBox TxtSpecialWords;
	}

	partial class ThisRibbonCollection
	{
		internal CustomRibbon CustomRibbon
		{
			get { return this.GetRibbon<CustomRibbon>(); }
		}
	}
}
