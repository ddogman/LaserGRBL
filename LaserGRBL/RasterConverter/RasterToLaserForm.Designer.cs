﻿namespace LaserGRBL.RasterConverter
{
	partial class RasterToLaserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RasterToLaserForm));
            this.RightGrid = new System.Windows.Forms.TableLayoutPanel();
            this.TCOriginalPreview = new System.Windows.Forms.TabControl();
            this.TpPreview = new System.Windows.Forms.TabPage();
            this.WB = new LaserGRBL.UserControls.WaitingProgressBar();
            this.PbConverted = new System.Windows.Forms.PictureBox();
            this.TpOriginal = new System.Windows.Forms.TabPage();
            this.PbOriginal = new System.Windows.Forms.PictureBox();
            this.FlipControl = new System.Windows.Forms.TableLayoutPanel();
            this.BtFlipV = new LaserGRBL.UserControls.ImageButton();
            this.BtFlipH = new LaserGRBL.UserControls.ImageButton();
            this.BtRotateCW = new LaserGRBL.UserControls.ImageButton();
            this.BtRotateCCW = new LaserGRBL.UserControls.ImageButton();
            this.BtnRevert = new LaserGRBL.UserControls.ImageButton();
            this.BtnReverse = new LaserGRBL.UserControls.ImageButton();
            this.BtnCrop = new LaserGRBL.UserControls.ImageButton();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.GbCenterlineOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBLineThreshold = new LaserGRBL.UserControls.ColorSlider();
            this.TBCornerThreshold = new LaserGRBL.UserControls.ColorSlider();
            this.CbLineThreshold = new System.Windows.Forms.CheckBox();
            this.CbCornerThreshold = new System.Windows.Forms.CheckBox();
            this.GbVectorizeOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.UDSpotRemoval = new System.Windows.Forms.NumericUpDown();
            this.CbSpotRemoval = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.UDOptimize = new System.Windows.Forms.NumericUpDown();
            this.UDSmoothing = new System.Windows.Forms.NumericUpDown();
            this.CbOptimize = new System.Windows.Forms.CheckBox();
            this.CbSmoothing = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbFillingDirection = new LaserGRBL.UserControls.EnumComboBox();
            this.LblFillingQuality = new System.Windows.Forms.Label();
            this.UDFillingQuality = new System.Windows.Forms.NumericUpDown();
            this.LblFillingLineLbl = new System.Windows.Forms.Label();
            this.UDDownSample = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDownSample = new System.Windows.Forms.CheckBox();
            this.lOptimizeFast = new System.Windows.Forms.Label();
            this.BtnFillingQualityInfo = new LaserGRBL.UserControls.ImageButton();
            this.CbOptimizeFast = new System.Windows.Forms.CheckBox();
            this.GbParameters = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CbResize = new LaserGRBL.UserControls.EnumComboBox();
            this.LblGrayscale = new System.Windows.Forms.Label();
            this.CbMode = new LaserGRBL.UserControls.EnumComboBox();
            this.TBRed = new LaserGRBL.UserControls.ColorSlider();
            this.LblRed = new System.Windows.Forms.Label();
            this.LblBlue = new System.Windows.Forms.Label();
            this.LblGreen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBGreen = new LaserGRBL.UserControls.ColorSlider();
            this.TbBright = new LaserGRBL.UserControls.ColorSlider();
            this.TBBlue = new LaserGRBL.UserControls.ColorSlider();
            this.TbContrast = new LaserGRBL.UserControls.ColorSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.CbThreshold = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TbThreshold = new LaserGRBL.UserControls.ColorSlider();
            this.TBWhiteClip = new LaserGRBL.UserControls.ColorSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.GbLineToLineOptions = new System.Windows.Forms.GroupBox();
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.CbDirections = new LaserGRBL.UserControls.EnumComboBox();
            this.UDQuality = new System.Windows.Forms.NumericUpDown();
            this.CbLinePreview = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblDitherMode = new System.Windows.Forms.Label();
            this.CbDither = new System.Windows.Forms.ComboBox();
            this.BtnQualityInfo = new LaserGRBL.UserControls.ImageButton();
            this.GbConversionTool = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.RbCenterline = new System.Windows.Forms.RadioButton();
            this.RbDithering = new System.Windows.Forms.RadioButton();
            this.RbVectorize = new System.Windows.Forms.RadioButton();
            this.RbLineToLineTracing = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.WT = new System.Windows.Forms.Timer(this.components);
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.RightGrid.SuspendLayout();
            this.TCOriginalPreview.SuspendLayout();
            this.TpPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbConverted)).BeginInit();
            this.TpOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).BeginInit();
            this.FlipControl.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.GbCenterlineOptions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GbVectorizeOptions.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSpotRemoval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOptimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSmoothing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDFillingQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDDownSample)).BeginInit();
            this.GbParameters.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.GbLineToLineOptions.SuspendLayout();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuality)).BeginInit();
            this.GbConversionTool.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightGrid
            // 
            resources.ApplyResources(this.RightGrid, "RightGrid");
            this.RightGrid.Controls.Add(this.TCOriginalPreview, 1, 0);
            this.RightGrid.Controls.Add(this.FlipControl, 1, 1);
            this.RightGrid.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.RightGrid.Controls.Add(this.tableLayoutPanel1, 3, 1);
            this.RightGrid.Name = "RightGrid";
            this.TT.SetToolTip(this.RightGrid, resources.GetString("RightGrid.ToolTip"));
            // 
            // TCOriginalPreview
            // 
            resources.ApplyResources(this.TCOriginalPreview, "TCOriginalPreview");
            this.RightGrid.SetColumnSpan(this.TCOriginalPreview, 3);
            this.TCOriginalPreview.Controls.Add(this.TpPreview);
            this.TCOriginalPreview.Controls.Add(this.TpOriginal);
            this.TCOriginalPreview.Name = "TCOriginalPreview";
            this.TCOriginalPreview.SelectedIndex = 0;
            this.TT.SetToolTip(this.TCOriginalPreview, resources.GetString("TCOriginalPreview.ToolTip"));
            // 
            // TpPreview
            // 
            resources.ApplyResources(this.TpPreview, "TpPreview");
            this.TpPreview.Controls.Add(this.WB);
            this.TpPreview.Controls.Add(this.PbConverted);
            this.TpPreview.Name = "TpPreview";
            this.TT.SetToolTip(this.TpPreview, resources.GetString("TpPreview.ToolTip"));
            this.TpPreview.UseVisualStyleBackColor = true;
            // 
            // WB
            // 
            resources.ApplyResources(this.WB, "WB");
            this.WB.BarColor = System.Drawing.Color.SteelBlue;
            this.WB.BorderColor = System.Drawing.Color.Black;
            this.WB.BouncingMode = LaserGRBL.UserControls.WaitingProgressBar.BouncingModeEnum.PingPong;
            this.WB.DrawProgressString = false;
            this.WB.FillColor = System.Drawing.Color.White;
            this.WB.FillStyle = LaserGRBL.UserControls.FillStyles.Solid;
            this.WB.Interval = 25D;
            this.WB.Maximum = 20D;
            this.WB.Minimum = 0D;
            this.WB.Name = "WB";
            this.WB.ProgressStringDecimals = 0;
            this.WB.Reverse = true;
            this.WB.Running = false;
            this.WB.Step = 1D;
            this.WB.ThrowExceprion = false;
            this.TT.SetToolTip(this.WB, resources.GetString("WB.ToolTip"));
            this.WB.Value = 0D;
            // 
            // PbConverted
            // 
            resources.ApplyResources(this.PbConverted, "PbConverted");
            this.PbConverted.BackColor = System.Drawing.Color.White;
            this.PbConverted.Name = "PbConverted";
            this.PbConverted.TabStop = false;
            this.TT.SetToolTip(this.PbConverted, resources.GetString("PbConverted.ToolTip"));
            this.PbConverted.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbConvertedMouseDown);
            this.PbConverted.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbConvertedMouseMove);
            this.PbConverted.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbConvertedMouseUp);
            this.PbConverted.Resize += new System.EventHandler(this.PbConverted_Resize);
            // 
            // TpOriginal
            // 
            resources.ApplyResources(this.TpOriginal, "TpOriginal");
            this.TpOriginal.Controls.Add(this.PbOriginal);
            this.TpOriginal.Name = "TpOriginal";
            this.TT.SetToolTip(this.TpOriginal, resources.GetString("TpOriginal.ToolTip"));
            this.TpOriginal.UseVisualStyleBackColor = true;
            // 
            // PbOriginal
            // 
            resources.ApplyResources(this.PbOriginal, "PbOriginal");
            this.PbOriginal.BackColor = System.Drawing.Color.White;
            this.PbOriginal.Name = "PbOriginal";
            this.PbOriginal.TabStop = false;
            this.TT.SetToolTip(this.PbOriginal, resources.GetString("PbOriginal.ToolTip"));
            // 
            // FlipControl
            // 
            resources.ApplyResources(this.FlipControl, "FlipControl");
            this.FlipControl.Controls.Add(this.BtFlipV, 5, 0);
            this.FlipControl.Controls.Add(this.BtFlipH, 4, 0);
            this.FlipControl.Controls.Add(this.BtRotateCW, 2, 0);
            this.FlipControl.Controls.Add(this.BtRotateCCW, 3, 0);
            this.FlipControl.Controls.Add(this.BtnRevert, 0, 0);
            this.FlipControl.Controls.Add(this.BtnReverse, 7, 0);
            this.FlipControl.Controls.Add(this.BtnCrop, 6, 0);
            this.FlipControl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.FlipControl.Name = "FlipControl";
            this.TT.SetToolTip(this.FlipControl, resources.GetString("FlipControl.ToolTip"));
            // 
            // BtFlipV
            // 
            resources.ApplyResources(this.BtFlipV, "BtFlipV");
            this.BtFlipV.AltImage = null;
            this.BtFlipV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtFlipV.Coloration = System.Drawing.Color.Empty;
            this.BtFlipV.Image = ((System.Drawing.Image)(resources.GetObject("BtFlipV.Image")));
            this.BtFlipV.Name = "BtFlipV";
            this.BtFlipV.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtFlipV, resources.GetString("BtFlipV.ToolTip"));
            this.BtFlipV.UseAltImage = false;
            this.BtFlipV.Click += new System.EventHandler(this.BtFlipVClick);
            // 
            // BtFlipH
            // 
            resources.ApplyResources(this.BtFlipH, "BtFlipH");
            this.BtFlipH.AltImage = null;
            this.BtFlipH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtFlipH.Coloration = System.Drawing.Color.Empty;
            this.BtFlipH.Image = ((System.Drawing.Image)(resources.GetObject("BtFlipH.Image")));
            this.BtFlipH.Name = "BtFlipH";
            this.BtFlipH.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtFlipH, resources.GetString("BtFlipH.ToolTip"));
            this.BtFlipH.UseAltImage = false;
            this.BtFlipH.Click += new System.EventHandler(this.BtFlipHClick);
            // 
            // BtRotateCW
            // 
            resources.ApplyResources(this.BtRotateCW, "BtRotateCW");
            this.BtRotateCW.AltImage = null;
            this.BtRotateCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtRotateCW.Coloration = System.Drawing.Color.Empty;
            this.BtRotateCW.Image = ((System.Drawing.Image)(resources.GetObject("BtRotateCW.Image")));
            this.BtRotateCW.Name = "BtRotateCW";
            this.BtRotateCW.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtRotateCW, resources.GetString("BtRotateCW.ToolTip"));
            this.BtRotateCW.UseAltImage = false;
            this.BtRotateCW.Click += new System.EventHandler(this.BtRotateCWClick);
            // 
            // BtRotateCCW
            // 
            resources.ApplyResources(this.BtRotateCCW, "BtRotateCCW");
            this.BtRotateCCW.AltImage = null;
            this.BtRotateCCW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtRotateCCW.Coloration = System.Drawing.Color.Empty;
            this.BtRotateCCW.Image = ((System.Drawing.Image)(resources.GetObject("BtRotateCCW.Image")));
            this.BtRotateCCW.Name = "BtRotateCCW";
            this.BtRotateCCW.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtRotateCCW, resources.GetString("BtRotateCCW.ToolTip"));
            this.BtRotateCCW.UseAltImage = false;
            this.BtRotateCCW.Click += new System.EventHandler(this.BtRotateCCWClick);
            // 
            // BtnRevert
            // 
            resources.ApplyResources(this.BtnRevert, "BtnRevert");
            this.BtnRevert.AltImage = null;
            this.BtnRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRevert.Coloration = System.Drawing.Color.Empty;
            this.BtnRevert.Image = ((System.Drawing.Image)(resources.GetObject("BtnRevert.Image")));
            this.BtnRevert.Name = "BtnRevert";
            this.BtnRevert.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnRevert, resources.GetString("BtnRevert.ToolTip"));
            this.BtnRevert.UseAltImage = false;
            this.BtnRevert.Click += new System.EventHandler(this.BtnRevertClick);
            // 
            // BtnReverse
            // 
            resources.ApplyResources(this.BtnReverse, "BtnReverse");
            this.BtnReverse.AltImage = null;
            this.BtnReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnReverse.Coloration = System.Drawing.Color.Empty;
            this.BtnReverse.Image = ((System.Drawing.Image)(resources.GetObject("BtnReverse.Image")));
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnReverse, resources.GetString("BtnReverse.ToolTip"));
            this.BtnReverse.UseAltImage = false;
            this.BtnReverse.Click += new System.EventHandler(this.BtnReverse_Click);
            // 
            // BtnCrop
            // 
            resources.ApplyResources(this.BtnCrop, "BtnCrop");
            this.BtnCrop.AltImage = null;
            this.BtnCrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCrop.Coloration = System.Drawing.Color.Empty;
            this.BtnCrop.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrop.Image")));
            this.BtnCrop.Name = "BtnCrop";
            this.BtnCrop.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnCrop, resources.GetString("BtnCrop.ToolTip"));
            this.BtnCrop.UseAltImage = false;
            this.BtnCrop.Click += new System.EventHandler(this.BtnCropClick);
            // 
            // tableLayoutPanel8
            // 
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.Controls.Add(this.GbCenterlineOptions, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.GbVectorizeOptions, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.GbParameters, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.GbLineToLineOptions, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.GbConversionTool, 0, 1);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.RightGrid.SetRowSpan(this.tableLayoutPanel8, 2);
            this.TT.SetToolTip(this.tableLayoutPanel8, resources.GetString("tableLayoutPanel8.ToolTip"));
            // 
            // GbCenterlineOptions
            // 
            resources.ApplyResources(this.GbCenterlineOptions, "GbCenterlineOptions");
            this.GbCenterlineOptions.Controls.Add(this.tableLayoutPanel3);
            this.GbCenterlineOptions.Name = "GbCenterlineOptions";
            this.GbCenterlineOptions.TabStop = false;
            this.TT.SetToolTip(this.GbCenterlineOptions, resources.GetString("GbCenterlineOptions.ToolTip"));
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TBLineThreshold, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.TBCornerThreshold, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.CbLineThreshold, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.CbCornerThreshold, 3, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.TT.SetToolTip(this.tableLayoutPanel3, resources.GetString("tableLayoutPanel3.ToolTip"));
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.TT.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.TT.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // TBLineThreshold
            // 
            resources.ApplyResources(this.TBLineThreshold, "TBLineThreshold");
            this.TBLineThreshold.BackColor = System.Drawing.Color.Transparent;
            this.TBLineThreshold.BarInnerColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TBLineThreshold.BarOuterColor = System.Drawing.Color.Gold;
            this.TBLineThreshold.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBLineThreshold.ElapsedInnerColor = System.Drawing.Color.Yellow;
            this.TBLineThreshold.ElapsedOuterColor = System.Drawing.Color.Gold;
            this.TBLineThreshold.LargeChange = ((uint)(5u));
            this.TBLineThreshold.Name = "TBLineThreshold";
            this.TBLineThreshold.SmallChange = ((uint)(1u));
            this.TBLineThreshold.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBLineThreshold.ThumbSize = 8;
            this.TT.SetToolTip(this.TBLineThreshold, resources.GetString("TBLineThreshold.ToolTip"));
            this.TBLineThreshold.Value = 10;
            this.TBLineThreshold.ValueChanged += new System.EventHandler(this.TBLineThreshold_ValueChanged);
            this.TBLineThreshold.DoubleClick += new System.EventHandler(this.TBLineThreshold_DoubleClick);
            // 
            // TBCornerThreshold
            // 
            resources.ApplyResources(this.TBCornerThreshold, "TBCornerThreshold");
            this.TBCornerThreshold.BackColor = System.Drawing.Color.Transparent;
            this.TBCornerThreshold.BarInnerColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TBCornerThreshold.BarOuterColor = System.Drawing.Color.Gold;
            this.TBCornerThreshold.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBCornerThreshold.ElapsedInnerColor = System.Drawing.Color.Yellow;
            this.TBCornerThreshold.ElapsedOuterColor = System.Drawing.Color.Gold;
            this.TBCornerThreshold.LargeChange = ((uint)(5u));
            this.TBCornerThreshold.Maximum = 360;
            this.TBCornerThreshold.Name = "TBCornerThreshold";
            this.TBCornerThreshold.SmallChange = ((uint)(1u));
            this.TBCornerThreshold.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBCornerThreshold.ThumbSize = 8;
            this.TT.SetToolTip(this.TBCornerThreshold, resources.GetString("TBCornerThreshold.ToolTip"));
            this.TBCornerThreshold.Value = 110;
            this.TBCornerThreshold.ValueChanged += new System.EventHandler(this.TBCornerThreshold_ValueChanged);
            this.TBCornerThreshold.DoubleClick += new System.EventHandler(this.TBCornerThreshold_DoubleClick);
            // 
            // CbLineThreshold
            // 
            resources.ApplyResources(this.CbLineThreshold, "CbLineThreshold");
            this.CbLineThreshold.Name = "CbLineThreshold";
            this.TT.SetToolTip(this.CbLineThreshold, resources.GetString("CbLineThreshold.ToolTip"));
            this.CbLineThreshold.UseVisualStyleBackColor = true;
            this.CbLineThreshold.CheckedChanged += new System.EventHandler(this.CbUseLineThreshold_CheckedChanged);
            // 
            // CbCornerThreshold
            // 
            resources.ApplyResources(this.CbCornerThreshold, "CbCornerThreshold");
            this.CbCornerThreshold.Name = "CbCornerThreshold";
            this.TT.SetToolTip(this.CbCornerThreshold, resources.GetString("CbCornerThreshold.ToolTip"));
            this.CbCornerThreshold.UseVisualStyleBackColor = true;
            this.CbCornerThreshold.CheckedChanged += new System.EventHandler(this.CbCornerThreshold_CheckedChanged);
            // 
            // GbVectorizeOptions
            // 
            resources.ApplyResources(this.GbVectorizeOptions, "GbVectorizeOptions");
            this.GbVectorizeOptions.Controls.Add(this.tableLayoutPanel5);
            this.GbVectorizeOptions.Name = "GbVectorizeOptions";
            this.GbVectorizeOptions.TabStop = false;
            this.TT.SetToolTip(this.GbVectorizeOptions, resources.GetString("GbVectorizeOptions.ToolTip"));
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.UDSpotRemoval, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.CbSpotRemoval, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label24, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label23, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.UDOptimize, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.UDSmoothing, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.CbOptimize, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.CbSmoothing, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.CbFillingDirection, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.LblFillingQuality, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.UDFillingQuality, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.LblFillingLineLbl, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.UDDownSample, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.CbDownSample, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.lOptimizeFast, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.BtnFillingQualityInfo, 3, 6);
            this.tableLayoutPanel5.Controls.Add(this.CbOptimizeFast, 1, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.TT.SetToolTip(this.tableLayoutPanel5, resources.GetString("tableLayoutPanel5.ToolTip"));
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            this.TT.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
            // 
            // UDSpotRemoval
            // 
            resources.ApplyResources(this.UDSpotRemoval, "UDSpotRemoval");
            this.UDSpotRemoval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UDSpotRemoval.Name = "UDSpotRemoval";
            this.TT.SetToolTip(this.UDSpotRemoval, resources.GetString("UDSpotRemoval.ToolTip"));
            this.UDSpotRemoval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.UDSpotRemoval.ValueChanged += new System.EventHandler(this.UDSpotRemoval_ValueChanged);
            // 
            // CbSpotRemoval
            // 
            resources.ApplyResources(this.CbSpotRemoval, "CbSpotRemoval");
            this.CbSpotRemoval.Name = "CbSpotRemoval";
            this.TT.SetToolTip(this.CbSpotRemoval, resources.GetString("CbSpotRemoval.ToolTip"));
            this.CbSpotRemoval.UseVisualStyleBackColor = true;
            this.CbSpotRemoval.CheckedChanged += new System.EventHandler(this.CbSpotRemoval_CheckedChanged);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            this.TT.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            this.TT.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
            // 
            // UDOptimize
            // 
            resources.ApplyResources(this.UDOptimize, "UDOptimize");
            this.UDOptimize.DecimalPlaces = 1;
            this.UDOptimize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UDOptimize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.UDOptimize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.UDOptimize.Name = "UDOptimize";
            this.TT.SetToolTip(this.UDOptimize, resources.GetString("UDOptimize.ToolTip"));
            this.UDOptimize.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.UDOptimize.ValueChanged += new System.EventHandler(this.UDOptimize_ValueChanged);
            // 
            // UDSmoothing
            // 
            resources.ApplyResources(this.UDSmoothing, "UDSmoothing");
            this.UDSmoothing.DecimalPlaces = 1;
            this.UDSmoothing.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UDSmoothing.Name = "UDSmoothing";
            this.TT.SetToolTip(this.UDSmoothing, resources.GetString("UDSmoothing.ToolTip"));
            this.UDSmoothing.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.UDSmoothing.ValueChanged += new System.EventHandler(this.UDSmoothing_ValueChanged);
            // 
            // CbOptimize
            // 
            resources.ApplyResources(this.CbOptimize, "CbOptimize");
            this.CbOptimize.Name = "CbOptimize";
            this.TT.SetToolTip(this.CbOptimize, resources.GetString("CbOptimize.ToolTip"));
            this.CbOptimize.UseVisualStyleBackColor = true;
            this.CbOptimize.CheckedChanged += new System.EventHandler(this.CbOptimize_CheckedChanged);
            // 
            // CbSmoothing
            // 
            resources.ApplyResources(this.CbSmoothing, "CbSmoothing");
            this.CbSmoothing.Name = "CbSmoothing";
            this.TT.SetToolTip(this.CbSmoothing, resources.GetString("CbSmoothing.ToolTip"));
            this.CbSmoothing.UseVisualStyleBackColor = true;
            this.CbSmoothing.CheckedChanged += new System.EventHandler(this.CbSmoothing_CheckedChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.TT.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // CbFillingDirection
            // 
            resources.ApplyResources(this.CbFillingDirection, "CbFillingDirection");
            this.tableLayoutPanel5.SetColumnSpan(this.CbFillingDirection, 3);
            this.CbFillingDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFillingDirection.FormattingEnabled = true;
            this.CbFillingDirection.Name = "CbFillingDirection";
            this.CbFillingDirection.SelectedItem = null;
            this.TT.SetToolTip(this.CbFillingDirection, resources.GetString("CbFillingDirection.ToolTip"));
            this.CbFillingDirection.SelectedIndexChanged += new System.EventHandler(this.CbFillingDirection_SelectedIndexChanged);
            // 
            // LblFillingQuality
            // 
            resources.ApplyResources(this.LblFillingQuality, "LblFillingQuality");
            this.LblFillingQuality.Name = "LblFillingQuality";
            this.TT.SetToolTip(this.LblFillingQuality, resources.GetString("LblFillingQuality.ToolTip"));
            // 
            // UDFillingQuality
            // 
            resources.ApplyResources(this.UDFillingQuality, "UDFillingQuality");
            this.UDFillingQuality.DecimalPlaces = 3;
            this.UDFillingQuality.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDFillingQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDFillingQuality.Name = "UDFillingQuality";
            this.TT.SetToolTip(this.UDFillingQuality, resources.GetString("UDFillingQuality.ToolTip"));
            this.UDFillingQuality.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.UDFillingQuality.ValueChanged += new System.EventHandler(this.UDFillingQuality_ValueChanged);
            // 
            // LblFillingLineLbl
            // 
            resources.ApplyResources(this.LblFillingLineLbl, "LblFillingLineLbl");
            this.LblFillingLineLbl.Name = "LblFillingLineLbl";
            this.TT.SetToolTip(this.LblFillingLineLbl, resources.GetString("LblFillingLineLbl.ToolTip"));
            // 
            // UDDownSample
            // 
            resources.ApplyResources(this.UDDownSample, "UDDownSample");
            this.UDDownSample.DecimalPlaces = 1;
            this.UDDownSample.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UDDownSample.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.UDDownSample.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDDownSample.Name = "UDDownSample";
            this.TT.SetToolTip(this.UDDownSample, resources.GetString("UDDownSample.ToolTip"));
            this.UDDownSample.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDDownSample.ValueChanged += new System.EventHandler(this.UDDownSample_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.TT.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // CbDownSample
            // 
            resources.ApplyResources(this.CbDownSample, "CbDownSample");
            this.CbDownSample.Name = "CbDownSample";
            this.TT.SetToolTip(this.CbDownSample, resources.GetString("CbDownSample.ToolTip"));
            this.CbDownSample.UseVisualStyleBackColor = true;
            this.CbDownSample.CheckedChanged += new System.EventHandler(this.CbDownSample_CheckedChanged);
            // 
            // lOptimizeFast
            // 
            resources.ApplyResources(this.lOptimizeFast, "lOptimizeFast");
            this.lOptimizeFast.Name = "lOptimizeFast";
            this.TT.SetToolTip(this.lOptimizeFast, resources.GetString("lOptimizeFast.ToolTip"));
            // 
            // BtnFillingQualityInfo
            // 
            resources.ApplyResources(this.BtnFillingQualityInfo, "BtnFillingQualityInfo");
            this.BtnFillingQualityInfo.AltImage = null;
            this.BtnFillingQualityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnFillingQualityInfo.Coloration = System.Drawing.Color.Empty;
            this.BtnFillingQualityInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnFillingQualityInfo.Image")));
            this.BtnFillingQualityInfo.Name = "BtnFillingQualityInfo";
            this.BtnFillingQualityInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnFillingQualityInfo, resources.GetString("BtnFillingQualityInfo.ToolTip"));
            this.BtnFillingQualityInfo.UseAltImage = false;
            this.BtnFillingQualityInfo.Click += new System.EventHandler(this.BtnFillingQualityInfo_Click);
            // 
            // CbOptimizeFast
            // 
            resources.ApplyResources(this.CbOptimizeFast, "CbOptimizeFast");
            this.CbOptimizeFast.Name = "CbOptimizeFast";
            this.TT.SetToolTip(this.CbOptimizeFast, resources.GetString("CbOptimizeFast.ToolTip"));
            this.CbOptimizeFast.UseVisualStyleBackColor = true;
            this.CbOptimizeFast.CheckedChanged += new System.EventHandler(this.CbOptimizeFast_CheckedChanged);
            // 
            // GbParameters
            // 
            resources.ApplyResources(this.GbParameters, "GbParameters");
            this.GbParameters.Controls.Add(this.tableLayoutPanel2);
            this.GbParameters.Name = "GbParameters";
            this.GbParameters.TabStop = false;
            this.TT.SetToolTip(this.GbParameters, resources.GetString("GbParameters.ToolTip"));
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.CbResize, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblGrayscale, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CbMode, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBRed, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblRed, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LblBlue, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.LblGreen, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.TBGreen, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbBright, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.TBBlue, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.TbContrast, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.CbThreshold, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbThreshold, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.TBWhiteClip, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.TT.SetToolTip(this.tableLayoutPanel2, resources.GetString("tableLayoutPanel2.ToolTip"));
            // 
            // CbResize
            // 
            resources.ApplyResources(this.CbResize, "CbResize");
            this.CbResize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbResize.FormattingEnabled = true;
            this.CbResize.Name = "CbResize";
            this.CbResize.SelectedItem = null;
            this.TT.SetToolTip(this.CbResize, resources.GetString("CbResize.ToolTip"));
            this.CbResize.SelectedIndexChanged += new System.EventHandler(this.CbResizeSelectedIndexChanged);
            // 
            // LblGrayscale
            // 
            resources.ApplyResources(this.LblGrayscale, "LblGrayscale");
            this.LblGrayscale.Name = "LblGrayscale";
            this.TT.SetToolTip(this.LblGrayscale, resources.GetString("LblGrayscale.ToolTip"));
            // 
            // CbMode
            // 
            resources.ApplyResources(this.CbMode, "CbMode");
            this.CbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMode.FormattingEnabled = true;
            this.CbMode.Name = "CbMode";
            this.CbMode.SelectedItem = null;
            this.TT.SetToolTip(this.CbMode, resources.GetString("CbMode.ToolTip"));
            this.CbMode.SelectedIndexChanged += new System.EventHandler(this.CbMode_SelectedIndexChanged);
            // 
            // TBRed
            // 
            resources.ApplyResources(this.TBRed, "TBRed");
            this.TBRed.BackColor = System.Drawing.Color.Transparent;
            this.TBRed.BarInnerColor = System.Drawing.Color.Firebrick;
            this.TBRed.BarOuterColor = System.Drawing.Color.DarkRed;
            this.TBRed.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBRed.ElapsedInnerColor = System.Drawing.Color.Red;
            this.TBRed.ElapsedOuterColor = System.Drawing.Color.DarkRed;
            this.TBRed.LargeChange = ((uint)(5u));
            this.TBRed.Maximum = 160;
            this.TBRed.Minimum = 40;
            this.TBRed.Name = "TBRed";
            this.TBRed.SmallChange = ((uint)(1u));
            this.TBRed.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBRed.ThumbSize = 8;
            this.TT.SetToolTip(this.TBRed, resources.GetString("TBRed.ToolTip"));
            this.TBRed.Value = 100;
            this.TBRed.ValueChanged += new System.EventHandler(this.TBRed_ValueChanged);
            this.TBRed.DoubleClick += new System.EventHandler(this.OnRGBCBDoubleClick);
            // 
            // LblRed
            // 
            resources.ApplyResources(this.LblRed, "LblRed");
            this.LblRed.Name = "LblRed";
            this.TT.SetToolTip(this.LblRed, resources.GetString("LblRed.ToolTip"));
            // 
            // LblBlue
            // 
            resources.ApplyResources(this.LblBlue, "LblBlue");
            this.LblBlue.Name = "LblBlue";
            this.TT.SetToolTip(this.LblBlue, resources.GetString("LblBlue.ToolTip"));
            // 
            // LblGreen
            // 
            resources.ApplyResources(this.LblGreen, "LblGreen");
            this.LblGreen.Name = "LblGreen";
            this.TT.SetToolTip(this.LblGreen, resources.GetString("LblGreen.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.TT.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // TBGreen
            // 
            resources.ApplyResources(this.TBGreen, "TBGreen");
            this.TBGreen.BackColor = System.Drawing.Color.Transparent;
            this.TBGreen.BarInnerColor = System.Drawing.Color.Green;
            this.TBGreen.BarOuterColor = System.Drawing.Color.DarkGreen;
            this.TBGreen.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBGreen.LargeChange = ((uint)(5u));
            this.TBGreen.Maximum = 160;
            this.TBGreen.Minimum = 40;
            this.TBGreen.Name = "TBGreen";
            this.TBGreen.SmallChange = ((uint)(1u));
            this.TBGreen.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBGreen.ThumbSize = 8;
            this.TT.SetToolTip(this.TBGreen, resources.GetString("TBGreen.ToolTip"));
            this.TBGreen.Value = 100;
            this.TBGreen.ValueChanged += new System.EventHandler(this.TBGreen_ValueChanged);
            this.TBGreen.DoubleClick += new System.EventHandler(this.OnRGBCBDoubleClick);
            // 
            // TbBright
            // 
            resources.ApplyResources(this.TbBright, "TbBright");
            this.TbBright.BackColor = System.Drawing.Color.Transparent;
            this.TbBright.BarInnerColor = System.Drawing.Color.DimGray;
            this.TbBright.BarOuterColor = System.Drawing.Color.Black;
            this.TbBright.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TbBright.ElapsedInnerColor = System.Drawing.Color.White;
            this.TbBright.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbBright.LargeChange = ((uint)(5u));
            this.TbBright.Maximum = 160;
            this.TbBright.Minimum = 40;
            this.TbBright.Name = "TbBright";
            this.TbBright.SmallChange = ((uint)(1u));
            this.TbBright.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TbBright.ThumbSize = 8;
            this.TT.SetToolTip(this.TbBright, resources.GetString("TbBright.ToolTip"));
            this.TbBright.Value = 100;
            this.TbBright.ValueChanged += new System.EventHandler(this.TbBright_ValueChanged);
            this.TbBright.DoubleClick += new System.EventHandler(this.OnRGBCBDoubleClick);
            // 
            // TBBlue
            // 
            resources.ApplyResources(this.TBBlue, "TBBlue");
            this.TBBlue.BackColor = System.Drawing.Color.Transparent;
            this.TBBlue.BarInnerColor = System.Drawing.Color.MediumBlue;
            this.TBBlue.BarOuterColor = System.Drawing.Color.DarkBlue;
            this.TBBlue.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBBlue.ElapsedInnerColor = System.Drawing.Color.DodgerBlue;
            this.TBBlue.ElapsedOuterColor = System.Drawing.Color.SteelBlue;
            this.TBBlue.LargeChange = ((uint)(5u));
            this.TBBlue.Maximum = 160;
            this.TBBlue.Minimum = 40;
            this.TBBlue.Name = "TBBlue";
            this.TBBlue.SmallChange = ((uint)(1u));
            this.TBBlue.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBBlue.ThumbSize = 8;
            this.TT.SetToolTip(this.TBBlue, resources.GetString("TBBlue.ToolTip"));
            this.TBBlue.Value = 100;
            this.TBBlue.ValueChanged += new System.EventHandler(this.TBBlue_ValueChanged);
            this.TBBlue.DoubleClick += new System.EventHandler(this.OnRGBCBDoubleClick);
            // 
            // TbContrast
            // 
            resources.ApplyResources(this.TbContrast, "TbContrast");
            this.TbContrast.BackColor = System.Drawing.Color.Transparent;
            this.TbContrast.BarInnerColor = System.Drawing.Color.DimGray;
            this.TbContrast.BarOuterColor = System.Drawing.Color.Black;
            this.TbContrast.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TbContrast.ElapsedInnerColor = System.Drawing.Color.White;
            this.TbContrast.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbContrast.LargeChange = ((uint)(5u));
            this.TbContrast.Maximum = 160;
            this.TbContrast.Minimum = 40;
            this.TbContrast.Name = "TbContrast";
            this.TbContrast.SmallChange = ((uint)(1u));
            this.TbContrast.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TbContrast.ThumbSize = 8;
            this.TT.SetToolTip(this.TbContrast, resources.GetString("TbContrast.ToolTip"));
            this.TbContrast.Value = 100;
            this.TbContrast.ValueChanged += new System.EventHandler(this.TbContrast_ValueChanged);
            this.TbContrast.DoubleClick += new System.EventHandler(this.OnRGBCBDoubleClick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.TT.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // CbThreshold
            // 
            resources.ApplyResources(this.CbThreshold, "CbThreshold");
            this.CbThreshold.Name = "CbThreshold";
            this.TT.SetToolTip(this.CbThreshold, resources.GetString("CbThreshold.ToolTip"));
            this.CbThreshold.UseVisualStyleBackColor = true;
            this.CbThreshold.CheckedChanged += new System.EventHandler(this.CbThreshold_CheckedChanged);
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            this.TT.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
            // 
            // TbThreshold
            // 
            resources.ApplyResources(this.TbThreshold, "TbThreshold");
            this.TbThreshold.BackColor = System.Drawing.Color.Transparent;
            this.TbThreshold.BarInnerColor = System.Drawing.Color.DimGray;
            this.TbThreshold.BarOuterColor = System.Drawing.Color.Black;
            this.TbThreshold.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TbThreshold.ElapsedInnerColor = System.Drawing.Color.White;
            this.TbThreshold.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TbThreshold.LargeChange = ((uint)(5u));
            this.TbThreshold.Name = "TbThreshold";
            this.TbThreshold.SmallChange = ((uint)(1u));
            this.TbThreshold.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TbThreshold.ThumbSize = 8;
            this.TT.SetToolTip(this.TbThreshold, resources.GetString("TbThreshold.ToolTip"));
            this.TbThreshold.ValueChanged += new System.EventHandler(this.TbThreshold_ValueChanged);
            this.TbThreshold.DoubleClick += new System.EventHandler(this.OnThresholdDoubleClick);
            // 
            // TBWhiteClip
            // 
            resources.ApplyResources(this.TBWhiteClip, "TBWhiteClip");
            this.TBWhiteClip.BackColor = System.Drawing.Color.Transparent;
            this.TBWhiteClip.BarInnerColor = System.Drawing.Color.DimGray;
            this.TBWhiteClip.BarOuterColor = System.Drawing.Color.Black;
            this.TBWhiteClip.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.TBWhiteClip.ElapsedInnerColor = System.Drawing.Color.White;
            this.TBWhiteClip.ElapsedOuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBWhiteClip.LargeChange = ((uint)(5u));
            this.TBWhiteClip.Name = "TBWhiteClip";
            this.TBWhiteClip.SmallChange = ((uint)(1u));
            this.TBWhiteClip.ThumbRoundRectSize = new System.Drawing.Size(4, 4);
            this.TBWhiteClip.ThumbSize = 8;
            this.TT.SetToolTip(this.TBWhiteClip, resources.GetString("TBWhiteClip.ToolTip"));
            this.TBWhiteClip.Value = 5;
            this.TBWhiteClip.ValueChanged += new System.EventHandler(this.TBWhiteClip_ValueChanged);
            this.TBWhiteClip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TBWhiteClip_MouseDown);
            this.TBWhiteClip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TBWhiteClip_MouseUp);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.TT.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // GbLineToLineOptions
            // 
            resources.ApplyResources(this.GbLineToLineOptions, "GbLineToLineOptions");
            this.GbLineToLineOptions.Controls.Add(this.TLP);
            this.GbLineToLineOptions.Name = "GbLineToLineOptions";
            this.GbLineToLineOptions.TabStop = false;
            this.TT.SetToolTip(this.GbLineToLineOptions, resources.GetString("GbLineToLineOptions.ToolTip"));
            // 
            // TLP
            // 
            resources.ApplyResources(this.TLP, "TLP");
            this.TLP.Controls.Add(this.CbDirections, 1, 1);
            this.TLP.Controls.Add(this.UDQuality, 1, 2);
            this.TLP.Controls.Add(this.CbLinePreview, 0, 3);
            this.TLP.Controls.Add(this.label5, 0, 2);
            this.TLP.Controls.Add(this.label27, 0, 1);
            this.TLP.Controls.Add(this.label8, 2, 2);
            this.TLP.Controls.Add(this.LblDitherMode, 0, 0);
            this.TLP.Controls.Add(this.CbDither, 1, 0);
            this.TLP.Controls.Add(this.BtnQualityInfo, 3, 2);
            this.TLP.Name = "TLP";
            this.TT.SetToolTip(this.TLP, resources.GetString("TLP.ToolTip"));
            // 
            // CbDirections
            // 
            resources.ApplyResources(this.CbDirections, "CbDirections");
            this.TLP.SetColumnSpan(this.CbDirections, 3);
            this.CbDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDirections.FormattingEnabled = true;
            this.CbDirections.Name = "CbDirections";
            this.CbDirections.SelectedItem = null;
            this.TT.SetToolTip(this.CbDirections, resources.GetString("CbDirections.ToolTip"));
            this.CbDirections.SelectedIndexChanged += new System.EventHandler(this.CbDirectionsSelectedIndexChanged);
            // 
            // UDQuality
            // 
            resources.ApplyResources(this.UDQuality, "UDQuality");
            this.UDQuality.DecimalPlaces = 3;
            this.UDQuality.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UDQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDQuality.Name = "UDQuality";
            this.TT.SetToolTip(this.UDQuality, resources.GetString("UDQuality.ToolTip"));
            this.UDQuality.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.UDQuality.ValueChanged += new System.EventHandler(this.UDQuality_ValueChanged);
            // 
            // CbLinePreview
            // 
            resources.ApplyResources(this.CbLinePreview, "CbLinePreview");
            this.CbLinePreview.Checked = true;
            this.CbLinePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TLP.SetColumnSpan(this.CbLinePreview, 3);
            this.CbLinePreview.Name = "CbLinePreview";
            this.TT.SetToolTip(this.CbLinePreview, resources.GetString("CbLinePreview.ToolTip"));
            this.CbLinePreview.UseVisualStyleBackColor = true;
            this.CbLinePreview.CheckedChanged += new System.EventHandler(this.CbLinePreview_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.TT.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            this.TT.SetToolTip(this.label27, resources.GetString("label27.ToolTip"));
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.TT.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // LblDitherMode
            // 
            resources.ApplyResources(this.LblDitherMode, "LblDitherMode");
            this.LblDitherMode.Name = "LblDitherMode";
            this.TT.SetToolTip(this.LblDitherMode, resources.GetString("LblDitherMode.ToolTip"));
            // 
            // CbDither
            // 
            resources.ApplyResources(this.CbDither, "CbDither");
            this.TLP.SetColumnSpan(this.CbDither, 3);
            this.CbDither.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDither.FormattingEnabled = true;
            this.CbDither.Name = "CbDither";
            this.TT.SetToolTip(this.CbDither, resources.GetString("CbDither.ToolTip"));
            this.CbDither.SelectedIndexChanged += new System.EventHandler(this.CbDither_SelectedIndexChanged);
            // 
            // BtnQualityInfo
            // 
            resources.ApplyResources(this.BtnQualityInfo, "BtnQualityInfo");
            this.BtnQualityInfo.AltImage = null;
            this.BtnQualityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnQualityInfo.Coloration = System.Drawing.Color.Empty;
            this.BtnQualityInfo.Image = ((System.Drawing.Image)(resources.GetObject("BtnQualityInfo.Image")));
            this.BtnQualityInfo.Name = "BtnQualityInfo";
            this.BtnQualityInfo.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
            this.TT.SetToolTip(this.BtnQualityInfo, resources.GetString("BtnQualityInfo.ToolTip"));
            this.BtnQualityInfo.UseAltImage = false;
            this.BtnQualityInfo.Click += new System.EventHandler(this.BtnQualityInfo_Click);
            // 
            // GbConversionTool
            // 
            resources.ApplyResources(this.GbConversionTool, "GbConversionTool");
            this.GbConversionTool.Controls.Add(this.tableLayoutPanel4);
            this.GbConversionTool.Name = "GbConversionTool";
            this.GbConversionTool.TabStop = false;
            this.TT.SetToolTip(this.GbConversionTool, resources.GetString("GbConversionTool.ToolTip"));
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.RbCenterline, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.RbDithering, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.RbVectorize, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.RbLineToLineTracing, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.TT.SetToolTip(this.tableLayoutPanel4, resources.GetString("tableLayoutPanel4.ToolTip"));
            // 
            // RbCenterline
            // 
            resources.ApplyResources(this.RbCenterline, "RbCenterline");
            this.tableLayoutPanel4.SetColumnSpan(this.RbCenterline, 3);
            this.RbCenterline.Name = "RbCenterline";
            this.TT.SetToolTip(this.RbCenterline, resources.GetString("RbCenterline.ToolTip"));
            this.RbCenterline.UseVisualStyleBackColor = true;
            this.RbCenterline.CheckedChanged += new System.EventHandler(this.RbCenterline_CheckedChanged);
            // 
            // RbDithering
            // 
            resources.ApplyResources(this.RbDithering, "RbDithering");
            this.tableLayoutPanel4.SetColumnSpan(this.RbDithering, 3);
            this.RbDithering.Name = "RbDithering";
            this.TT.SetToolTip(this.RbDithering, resources.GetString("RbDithering.ToolTip"));
            this.RbDithering.UseVisualStyleBackColor = true;
            this.RbDithering.CheckedChanged += new System.EventHandler(this.RbDithering_CheckedChanged);
            // 
            // RbVectorize
            // 
            resources.ApplyResources(this.RbVectorize, "RbVectorize");
            this.tableLayoutPanel4.SetColumnSpan(this.RbVectorize, 3);
            this.RbVectorize.Name = "RbVectorize";
            this.TT.SetToolTip(this.RbVectorize, resources.GetString("RbVectorize.ToolTip"));
            this.RbVectorize.UseVisualStyleBackColor = true;
            this.RbVectorize.CheckedChanged += new System.EventHandler(this.RbVectorize_CheckedChanged);
            // 
            // RbLineToLineTracing
            // 
            resources.ApplyResources(this.RbLineToLineTracing, "RbLineToLineTracing");
            this.RbLineToLineTracing.Checked = true;
            this.tableLayoutPanel4.SetColumnSpan(this.RbLineToLineTracing, 3);
            this.RbLineToLineTracing.Name = "RbLineToLineTracing";
            this.RbLineToLineTracing.TabStop = true;
            this.TT.SetToolTip(this.RbLineToLineTracing, resources.GetString("RbLineToLineTracing.ToolTip"));
            this.RbLineToLineTracing.UseVisualStyleBackColor = true;
            this.RbLineToLineTracing.CheckedChanged += new System.EventHandler(this.RbLineToLineTracing_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.BtnCancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreate, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.TT.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // BtnCancel
            // 
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.TT.SetToolTip(this.BtnCancel, resources.GetString("BtnCancel.ToolTip"));
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // BtnCreate
            // 
            resources.ApplyResources(this.BtnCreate, "BtnCreate");
            this.BtnCreate.Name = "BtnCreate";
            this.TT.SetToolTip(this.BtnCreate, resources.GetString("BtnCreate.ToolTip"));
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreateClick);
            // 
            // WT
            // 
            this.WT.Interval = 50;
            this.WT.Tick += new System.EventHandler(this.WTTick);
            // 
            // RasterToLaserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RightGrid);
            this.MinimizeBox = false;
            this.Name = "RasterToLaserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.TT.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RasterToLaserFormFormClosing);
            this.Load += new System.EventHandler(this.RasterToLaserForm_Load);
            this.RightGrid.ResumeLayout(false);
            this.RightGrid.PerformLayout();
            this.TCOriginalPreview.ResumeLayout(false);
            this.TpPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbConverted)).EndInit();
            this.TpOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).EndInit();
            this.FlipControl.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.GbCenterlineOptions.ResumeLayout(false);
            this.GbCenterlineOptions.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.GbVectorizeOptions.ResumeLayout(false);
            this.GbVectorizeOptions.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDSpotRemoval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDOptimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDSmoothing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDFillingQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UDDownSample)).EndInit();
            this.GbParameters.ResumeLayout(false);
            this.GbParameters.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.GbLineToLineOptions.ResumeLayout(false);
            this.GbLineToLineOptions.PerformLayout();
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDQuality)).EndInit();
            this.GbConversionTool.ResumeLayout(false);
            this.GbConversionTool.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel RightGrid;
		private System.Windows.Forms.TabControl TCOriginalPreview;
		private System.Windows.Forms.TabPage TpPreview;
		private System.Windows.Forms.PictureBox PbConverted;
		private System.Windows.Forms.TabPage TpOriginal;
		private System.Windows.Forms.PictureBox PbOriginal;
		private System.Windows.Forms.GroupBox GbParameters;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label LblGrayscale;
		private System.Windows.Forms.Label label2;
		private UserControls.EnumComboBox CbMode;
		private UserControls.ColorSlider TbBright;
		private UserControls.ColorSlider TbContrast;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown UDQuality;
		private System.Windows.Forms.Button BtnCreate;
		private UserControls.ColorSlider TBRed;
		private System.Windows.Forms.Label LblRed;
		private UserControls.ColorSlider TBGreen;
		private System.Windows.Forms.Label LblGreen;
		private System.Windows.Forms.Label LblBlue;
		private UserControls.ColorSlider TBBlue;
		private System.Windows.Forms.CheckBox CbLinePreview;
		private UserControls.ColorSlider TbThreshold;
		private System.Windows.Forms.CheckBox CbThreshold;
		private System.Windows.Forms.GroupBox GbLineToLineOptions;
		private System.Windows.Forms.TableLayoutPanel TLP;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.RadioButton RbVectorize;
		private System.Windows.Forms.RadioButton RbLineToLineTracing;
		private System.Windows.Forms.GroupBox GbConversionTool;
		private System.Windows.Forms.GroupBox GbVectorizeOptions;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.NumericUpDown UDSpotRemoval;
		private System.Windows.Forms.NumericUpDown UDSmoothing;
		private System.Windows.Forms.NumericUpDown UDOptimize;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.CheckBox CbSpotRemoval;
		private System.Windows.Forms.CheckBox CbSmoothing;
		private System.Windows.Forms.CheckBox CbOptimize;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Label label27;
		private UserControls.EnumComboBox CbDirections;
		private System.Windows.Forms.Label label8;
		private UserControls.EnumComboBox CbResize;
		private System.Windows.Forms.Label label28;
		private LaserGRBL.UserControls.WaitingProgressBar WB;
		private System.Windows.Forms.Timer WT;
		private System.Windows.Forms.TableLayoutPanel FlipControl;
		private LaserGRBL.UserControls.ImageButton BtFlipV;
		private LaserGRBL.UserControls.ImageButton BtFlipH;
		private LaserGRBL.UserControls.ImageButton BtRotateCW;
		private LaserGRBL.UserControls.ImageButton BtRotateCCW;
		private System.Windows.Forms.NumericUpDown UDFillingQuality;
		private UserControls.EnumComboBox CbFillingDirection;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label LblFillingQuality;
		private System.Windows.Forms.Label LblFillingLineLbl;
		private LaserGRBL.UserControls.ImageButton BtnCrop;
		private LaserGRBL.UserControls.ImageButton BtnRevert;
		private System.Windows.Forms.ToolTip TT;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.RadioButton RbDithering;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown UDDownSample;
		private System.Windows.Forms.CheckBox CbDownSample;
		private System.Windows.Forms.Label LblDitherMode;
		private System.Windows.Forms.ComboBox CbDither;
		private UserControls.ImageButton BtnQualityInfo;
		private UserControls.ImageButton BtnFillingQualityInfo;
		private UserControls.ColorSlider TBWhiteClip;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lOptimizeFast;
		private System.Windows.Forms.CheckBox CbOptimizeFast;
		private UserControls.ImageButton BtnReverse;
        private System.Windows.Forms.RadioButton RbCenterline;
        private System.Windows.Forms.GroupBox GbCenterlineOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox CbLineThreshold;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox CbCornerThreshold;
		private UserControls.ColorSlider TBLineThreshold;
		private UserControls.ColorSlider TBCornerThreshold;
	}
}