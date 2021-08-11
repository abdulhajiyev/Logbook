
namespace Logbook
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
            this.components = new System.ComponentModel.Container();
            this.courseLabel = new System.Windows.Forms.Label();
            this.roundCorners = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.topLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.commentLbl = new System.Windows.Forms.Label();
            this.classWorkLbl = new System.Windows.Forms.Label();
            this.controlWorkLbl = new System.Windows.Forms.Label();
            this.nameSurnameLbl = new System.Windows.Forms.Label();
            this.lastSeenLbl = new System.Windows.Forms.Label();
            this.checkPanel = new System.Windows.Forms.Panel();
            this.checkEveryoneRadio = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.checkEveryoneLbl = new System.Windows.Forms.Label();
            this.diamondCount = new Guna.UI2.WinForms.Guna2Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.mainTeacherRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.substituteTeacherRadio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.addMaterialBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.changeSubjectTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.acceptBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.topPanel.SuspendLayout();
            this.topLayoutPanel.SuspendLayout();
            this.checkPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Elektra Text Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.Location = new System.Drawing.Point(8, 21);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(736, 22);
            this.courseLabel.TabIndex = 0;
            this.courseLabel.Text = "FSDE_2202_az   (Basics of developing applications using Windows Forms and WPF)";
            // 
            // roundCorners
            // 
            this.roundCorners.BorderRadius = 20;
            this.roundCorners.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.topPanel.Controls.Add(this.topLayoutPanel);
            this.topPanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(219)))), ((int)(((byte)(253)))));
            this.topPanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowDecoration.Parent = this.topPanel;
            this.topPanel.Size = new System.Drawing.Size(1247, 60);
            this.topPanel.TabIndex = 2;
            // 
            // topLayoutPanel
            // 
            this.topLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.topLayoutPanel.ColumnCount = 15;
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.topLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topLayoutPanel.Controls.Add(this.commentLbl, 13, 0);
            this.topLayoutPanel.Controls.Add(this.classWorkLbl, 9, 0);
            this.topLayoutPanel.Controls.Add(this.controlWorkLbl, 7, 0);
            this.topLayoutPanel.Controls.Add(this.nameSurnameLbl, 1, 0);
            this.topLayoutPanel.Controls.Add(this.lastSeenLbl, 3, 0);
            this.topLayoutPanel.Controls.Add(this.checkPanel, 5, 0);
            this.topLayoutPanel.Controls.Add(this.diamondCount, 11, 0);
            this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayoutPanel.Name = "topLayoutPanel";
            this.topLayoutPanel.RowCount = 1;
            this.topLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topLayoutPanel.Size = new System.Drawing.Size(1247, 60);
            this.topLayoutPanel.TabIndex = 0;
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.BackColor = System.Drawing.Color.Transparent;
            this.commentLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.commentLbl.Location = new System.Drawing.Point(1136, 0);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(81, 60);
            this.commentLbl.TabIndex = 5;
            this.commentLbl.Text = "Comment";
            this.commentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classWorkLbl
            // 
            this.classWorkLbl.AutoSize = true;
            this.classWorkLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classWorkLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classWorkLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.classWorkLbl.Location = new System.Drawing.Point(835, 0);
            this.classWorkLbl.Name = "classWorkLbl";
            this.classWorkLbl.Size = new System.Drawing.Size(100, 60);
            this.classWorkLbl.TabIndex = 5;
            this.classWorkLbl.Text = "Class work";
            this.classWorkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlWorkLbl
            // 
            this.controlWorkLbl.AutoSize = true;
            this.controlWorkLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlWorkLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlWorkLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.controlWorkLbl.Location = new System.Drawing.Point(667, 0);
            this.controlWorkLbl.Name = "controlWorkLbl";
            this.controlWorkLbl.Size = new System.Drawing.Size(121, 60);
            this.controlWorkLbl.TabIndex = 5;
            this.controlWorkLbl.Text = "Control work";
            this.controlWorkLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameSurnameLbl
            // 
            this.nameSurnameLbl.AutoSize = true;
            this.nameSurnameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSurnameLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.nameSurnameLbl.Location = new System.Drawing.Point(105, 0);
            this.nameSurnameLbl.Name = "nameSurnameLbl";
            this.nameSurnameLbl.Size = new System.Drawing.Size(210, 60);
            this.nameSurnameLbl.TabIndex = 3;
            this.nameSurnameLbl.Text = "Name, Surname";
            this.nameSurnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastSeenLbl
            // 
            this.lastSeenLbl.AutoSize = true;
            this.lastSeenLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastSeenLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSeenLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.lastSeenLbl.Location = new System.Drawing.Point(362, 0);
            this.lastSeenLbl.Name = "lastSeenLbl";
            this.lastSeenLbl.Size = new System.Drawing.Size(75, 60);
            this.lastSeenLbl.TabIndex = 4;
            this.lastSeenLbl.Text = "Last seen";
            this.lastSeenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkPanel
            // 
            this.checkPanel.Controls.Add(this.checkEveryoneRadio);
            this.checkPanel.Controls.Add(this.checkEveryoneLbl);
            this.checkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkPanel.Location = new System.Drawing.Point(484, 3);
            this.checkPanel.Name = "checkPanel";
            this.checkPanel.Size = new System.Drawing.Size(136, 54);
            this.checkPanel.TabIndex = 5;
            // 
            // checkEveryoneRadio
            // 
            this.checkEveryoneRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.checkEveryoneRadio.CheckedState.BorderThickness = 0;
            this.checkEveryoneRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.checkEveryoneRadio.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.checkEveryoneRadio.CheckedState.Parent = this.checkEveryoneRadio;
            this.checkEveryoneRadio.Location = new System.Drawing.Point(60, 28);
            this.checkEveryoneRadio.Name = "checkEveryoneRadio";
            this.checkEveryoneRadio.ShadowDecoration.Parent = this.checkEveryoneRadio;
            this.checkEveryoneRadio.Size = new System.Drawing.Size(15, 15);
            this.checkEveryoneRadio.TabIndex = 10;
            this.checkEveryoneRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.checkEveryoneRadio.UncheckedState.BorderThickness = 2;
            this.checkEveryoneRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkEveryoneRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.checkEveryoneRadio.UncheckedState.Parent = this.checkEveryoneRadio;
            this.checkEveryoneRadio.CheckedChanged += new System.EventHandler(this.checkEveryoneRadio_CheckedChanged);
            // 
            // checkEveryoneLbl
            // 
            this.checkEveryoneLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkEveryoneLbl.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEveryoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.checkEveryoneLbl.Location = new System.Drawing.Point(0, 0);
            this.checkEveryoneLbl.Name = "checkEveryoneLbl";
            this.checkEveryoneLbl.Size = new System.Drawing.Size(136, 24);
            this.checkEveryoneLbl.TabIndex = 5;
            this.checkEveryoneLbl.Text = "Check everyone";
            this.checkEveryoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diamondCount
            // 
            this.diamondCount.CausesValidation = false;
            this.diamondCount.Checked = true;
            this.diamondCount.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.diamondCount.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.diamondCount.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.diamondCount.CheckedState.Parent = this.diamondCount;
            this.diamondCount.CustomBorderColor = System.Drawing.Color.Transparent;
            this.diamondCount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.diamondCount.CustomImages.Parent = this.diamondCount;
            this.diamondCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diamondCount.FillColor = System.Drawing.Color.Transparent;
            this.diamondCount.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.diamondCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(182)))), ((int)(((byte)(245)))));
            this.diamondCount.HoverState.Parent = this.diamondCount;
            this.diamondCount.Image = global::Logbook.Properties.Resources.diamond;
            this.diamondCount.Location = new System.Drawing.Point(971, 3);
            this.diamondCount.Name = "diamondCount";
            this.diamondCount.PressedColor = System.Drawing.Color.Transparent;
            this.diamondCount.PressedDepth = 0;
            this.diamondCount.ShadowDecoration.Parent = this.diamondCount;
            this.diamondCount.Size = new System.Drawing.Size(129, 54);
            this.diamondCount.TabIndex = 6;
            this.diamondCount.Text = "5";
            this.diamondCount.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // subjectLabel
            // 
            this.subjectLabel.Font = new System.Drawing.Font("Elektra Text Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.subjectLabel.Location = new System.Drawing.Point(617, 61);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(277, 38);
            this.subjectLabel.TabIndex = 7;
            this.subjectLabel.Text = "Subject:";
            // 
            // mainTeacherRadio
            // 
            this.mainTeacherRadio.AutoSize = true;
            this.mainTeacherRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.mainTeacherRadio.CheckedState.BorderThickness = 0;
            this.mainTeacherRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.mainTeacherRadio.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.mainTeacherRadio.CheckedState.InnerOffset = -4;
            this.mainTeacherRadio.Font = new System.Drawing.Font("Elektra Text Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTeacherRadio.Location = new System.Drawing.Point(12, 61);
            this.mainTeacherRadio.Name = "mainTeacherRadio";
            this.mainTeacherRadio.Size = new System.Drawing.Size(115, 21);
            this.mainTeacherRadio.TabIndex = 9;
            this.mainTeacherRadio.TabStop = true;
            this.mainTeacherRadio.Text = "Main teacher";
            this.mainTeacherRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.mainTeacherRadio.UncheckedState.BorderThickness = 2;
            this.mainTeacherRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mainTeacherRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.mainTeacherRadio.UseVisualStyleBackColor = true;
            this.mainTeacherRadio.CheckedChanged += new System.EventHandler(this.teacher_Checked);
            // 
            // substituteTeacherRadio
            // 
            this.substituteTeacherRadio.AutoSize = true;
            this.substituteTeacherRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.substituteTeacherRadio.CheckedState.BorderThickness = 0;
            this.substituteTeacherRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.substituteTeacherRadio.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.substituteTeacherRadio.CheckedState.InnerOffset = -4;
            this.substituteTeacherRadio.Font = new System.Drawing.Font("Elektra Text Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substituteTeacherRadio.Location = new System.Drawing.Point(133, 61);
            this.substituteTeacherRadio.Name = "substituteTeacherRadio";
            this.substituteTeacherRadio.Size = new System.Drawing.Size(154, 21);
            this.substituteTeacherRadio.TabIndex = 9;
            this.substituteTeacherRadio.TabStop = true;
            this.substituteTeacherRadio.Text = "Substitute teacher";
            this.substituteTeacherRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(190)))), ((int)(((byte)(246)))));
            this.substituteTeacherRadio.UncheckedState.BorderThickness = 2;
            this.substituteTeacherRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.substituteTeacherRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.substituteTeacherRadio.UseVisualStyleBackColor = true;
            this.substituteTeacherRadio.CheckedChanged += new System.EventHandler(this.teacher_Checked);
            // 
            // addMaterialBtn
            // 
            this.addMaterialBtn.Animated = true;
            this.addMaterialBtn.BorderRadius = 5;
            this.addMaterialBtn.CheckedState.Parent = this.addMaterialBtn;
            this.addMaterialBtn.CustomImages.Parent = this.addMaterialBtn;
            this.addMaterialBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.addMaterialBtn.Font = new System.Drawing.Font("Elektra Text Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMaterialBtn.ForeColor = System.Drawing.Color.White;
            this.addMaterialBtn.HoverState.Parent = this.addMaterialBtn;
            this.addMaterialBtn.Location = new System.Drawing.Point(1024, 67);
            this.addMaterialBtn.Name = "addMaterialBtn";
            this.addMaterialBtn.ShadowDecoration.Parent = this.addMaterialBtn;
            this.addMaterialBtn.Size = new System.Drawing.Size(180, 25);
            this.addMaterialBtn.TabIndex = 10;
            this.addMaterialBtn.Text = "Add Material";
            this.addMaterialBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Enabled = false;
            this.mainPanel.Location = new System.Drawing.Point(12, 102);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(1247, 662);
            this.mainPanel.TabIndex = 0;
            // 
            // changeSubjectTxt
            // 
            this.changeSubjectTxt.Animated = true;
            this.changeSubjectTxt.BackColor = System.Drawing.Color.Transparent;
            this.changeSubjectTxt.BorderColor = System.Drawing.Color.Silver;
            this.changeSubjectTxt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.changeSubjectTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeSubjectTxt.DefaultText = "";
            this.changeSubjectTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeSubjectTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeSubjectTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeSubjectTxt.DisabledState.Parent = this.changeSubjectTxt;
            this.changeSubjectTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeSubjectTxt.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.changeSubjectTxt.FocusedState.Parent = this.changeSubjectTxt;
            this.changeSubjectTxt.HoverState.Parent = this.changeSubjectTxt;
            this.changeSubjectTxt.IconRight = global::Logbook.Properties.Resources.pencil_96px;
            this.changeSubjectTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.changeSubjectTxt.Location = new System.Drawing.Point(693, 59);
            this.changeSubjectTxt.Name = "changeSubjectTxt";
            this.changeSubjectTxt.PasswordChar = '\0';
            this.changeSubjectTxt.PlaceholderText = "SomeText";
            this.changeSubjectTxt.SelectedText = "";
            this.changeSubjectTxt.ShadowDecoration.Parent = this.changeSubjectTxt;
            this.changeSubjectTxt.Size = new System.Drawing.Size(23, 21);
            this.changeSubjectTxt.TabIndex = 8;
            this.changeSubjectTxt.WordWrap = false;
            this.changeSubjectTxt.Click += new System.EventHandler(this.changeSubjectTxt_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Animated = true;
            this.acceptBtn.BorderRadius = 5;
            this.acceptBtn.CheckedState.Parent = this.acceptBtn;
            this.acceptBtn.CustomImages.Parent = this.acceptBtn;
            this.acceptBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.acceptBtn.Font = new System.Drawing.Font("Elektra Text Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptBtn.ForeColor = System.Drawing.Color.White;
            this.acceptBtn.HoverState.Parent = this.acceptBtn;
            this.acceptBtn.Location = new System.Drawing.Point(900, 57);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.ShadowDecoration.Parent = this.acceptBtn;
            this.acceptBtn.Size = new System.Drawing.Size(90, 25);
            this.acceptBtn.TabIndex = 10;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.acceptBtn.Visible = false;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Animated = true;
            this.cancelBtn.BorderRadius = 5;
            this.cancelBtn.CheckedState.Parent = this.cancelBtn;
            this.cancelBtn.CustomImages.Parent = this.cancelBtn;
            this.cancelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(210)))), ((int)(((byte)(253)))));
            this.cancelBtn.Font = new System.Drawing.Font("Elektra Text Pro", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.HoverState.Parent = this.cancelBtn;
            this.cancelBtn.Location = new System.Drawing.Point(990, 57);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.ShadowDecoration.Parent = this.cancelBtn;
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 776);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.addMaterialBtn);
            this.Controls.Add(this.substituteTeacherRadio);
            this.Controls.Add(this.mainTeacherRadio);
            this.Controls.Add(this.changeSubjectTxt);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.topLayoutPanel.ResumeLayout(false);
            this.topLayoutPanel.PerformLayout();
            this.checkPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseLabel;
        private Guna.UI2.WinForms.Guna2Elipse roundCorners;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel topLayoutPanel;
        private System.Windows.Forms.Label nameSurnameLbl;
        private System.Windows.Forms.Label lastSeenLbl;
        private System.Windows.Forms.Panel checkPanel;
        private System.Windows.Forms.Label checkEveryoneLbl;
        private System.Windows.Forms.Label classWorkLbl;
        private System.Windows.Forms.Label controlWorkLbl;
        private Guna.UI2.WinForms.Guna2Button diamondCount;
        private Guna.UI2.WinForms.Guna2TextBox changeSubjectTxt;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label commentLbl;
        private Guna.UI2.WinForms.Guna2RadioButton substituteTeacherRadio;
        private Guna.UI2.WinForms.Guna2RadioButton mainTeacherRadio;
        private Guna.UI2.WinForms.Guna2CustomRadioButton checkEveryoneRadio;
        private Guna.UI2.WinForms.Guna2Button addMaterialBtn;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button cancelBtn;
        private Guna.UI2.WinForms.Guna2Button acceptBtn;
    }
}

