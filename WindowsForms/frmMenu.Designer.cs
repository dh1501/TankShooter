
namespace SuperTank.WindowsForms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.pnAboutUs = new System.Windows.Forms.Panel();
            this.btnAboutUsMenu = new System.Windows.Forms.Button();
            this.picMinus = new System.Windows.Forms.PictureBox();
            this.picMultiply = new System.Windows.Forms.PictureBox();
            this.pnInstructions = new System.Windows.Forms.Panel();
            this.flowLayoutPanelInstructions = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnLevel = new System.Windows.Forms.Panel();
            this.btnLevelMenu = new System.Windows.Forms.Button();
            this.btnLevel6 = new System.Windows.Forms.Button();
            this.btnLevel5 = new System.Windows.Forms.Button();
            this.btnLevel4 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnTitle.SuspendLayout();
            this.pnAboutUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).BeginInit();
            this.pnInstructions.SuspendLayout();
            this.pnLevel.SuspendLayout();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkRed;
            this.pnTitle.Controls.Add(this.picMinus);
            this.pnTitle.Controls.Add(this.picMultiply);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(500, 40);
            this.pnTitle.TabIndex = 26;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseMove);
            // 
            // pnAboutUs
            // 
            this.pnAboutUs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnAboutUs.BackgroundImage")));
            this.pnAboutUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnAboutUs.Controls.Add(this.btnAboutUsMenu);
            this.pnAboutUs.Location = new System.Drawing.Point(0, -1125);
            this.pnAboutUs.Name = "pnAboutUs";
            this.pnAboutUs.Size = new System.Drawing.Size(500, 600);
            this.pnAboutUs.TabIndex = 24;
            this.pnAboutUs.Visible = false;
            // 
            // btnAboutUsMenu
            // 
            this.btnAboutUsMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAboutUsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAboutUsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutUsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUsMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAboutUsMenu.Location = new System.Drawing.Point(186, 413);
            this.btnAboutUsMenu.Name = "btnAboutUsMenu";
            this.btnAboutUsMenu.Size = new System.Drawing.Size(139, 53);
            this.btnAboutUsMenu.TabIndex = 24;
            this.btnAboutUsMenu.TabStop = false;
            this.btnAboutUsMenu.Text = "Menu";
            this.btnAboutUsMenu.UseVisualStyleBackColor = false;
            this.btnAboutUsMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picMinus
            // 
            this.picMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinus.Image = ((System.Drawing.Image)(resources.GetObject("picMinus.Image")));
            this.picMinus.Location = new System.Drawing.Point(430, 5);
            this.picMinus.Name = "picMinus";
            this.picMinus.Size = new System.Drawing.Size(30, 30);
            this.picMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinus.TabIndex = 2;
            this.picMinus.TabStop = false;
            this.picMinus.Click += new System.EventHandler(this.picMinus_Click);
            this.picMinus.MouseEnter += new System.EventHandler(this.picMinus_MouseEnter);
            this.picMinus.MouseLeave += new System.EventHandler(this.picMinus_MouseLeave);
            // 
            // picMultiply
            // 
            this.picMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMultiply.Image = ((System.Drawing.Image)(resources.GetObject("picMultiply.Image")));
            this.picMultiply.Location = new System.Drawing.Point(467, 5);
            this.picMultiply.Name = "picMultiply";
            this.picMultiply.Size = new System.Drawing.Size(30, 30);
            this.picMultiply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMultiply.TabIndex = 0;
            this.picMultiply.TabStop = false;
            this.picMultiply.Click += new System.EventHandler(this.picMultiply_Click);
            this.picMultiply.MouseEnter += new System.EventHandler(this.picMultiply_MouseEnter);
            this.picMultiply.MouseLeave += new System.EventHandler(this.picMultiply_MouseLeave);
            // 
            // pnInstructions
            // 
            this.pnInstructions.BackColor = System.Drawing.Color.DarkRed;
            this.pnInstructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInstructions.BackgroundImage")));
            this.pnInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnInstructions.Controls.Add(this.flowLayoutPanelInstructions);
            this.pnInstructions.Controls.Add(this.button1);
            this.pnInstructions.Location = new System.Drawing.Point(1000, 40);
            this.pnInstructions.Name = "pnInstructions";
            this.pnInstructions.Size = new System.Drawing.Size(500, 600);
            this.pnInstructions.TabIndex = 24;
            // 
            // flowLayoutPanelInstructions
            // 
            this.flowLayoutPanelInstructions.AllowDrop = true;
            this.flowLayoutPanelInstructions.AutoScroll = true;
            this.flowLayoutPanelInstructions.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelInstructions.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.flowLayoutPanelInstructions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInstructions.Location = new System.Drawing.Point(35, 129);
            this.flowLayoutPanelInstructions.Name = "flowLayoutPanelInstructions";
            this.flowLayoutPanelInstructions.Size = new System.Drawing.Size(430, 380);
            this.flowLayoutPanelInstructions.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(180, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 53);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnLevel
            // 
            this.pnLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLevel.BackgroundImage")));
            this.pnLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLevel.Controls.Add(this.btnLevelMenu);
            this.pnLevel.Controls.Add(this.btnLevel6);
            this.pnLevel.Controls.Add(this.btnLevel5);
            this.pnLevel.Controls.Add(this.btnLevel4);
            this.pnLevel.Controls.Add(this.btnLevel3);
            this.pnLevel.Controls.Add(this.btnLevel2);
            this.pnLevel.Controls.Add(this.btnLevel1);
            this.pnLevel.Location = new System.Drawing.Point(500, 40);
            this.pnLevel.Name = "pnLevel";
            this.pnLevel.Size = new System.Drawing.Size(500, 600);
            this.pnLevel.TabIndex = 14;
            // 
            // btnLevelMenu
            // 
            this.btnLevelMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnLevelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevelMenu.BackgroundImage")));
            this.btnLevelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLevelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevelMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevelMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevelMenu.Location = new System.Drawing.Point(145, 384);
            this.btnLevelMenu.Name = "btnLevelMenu";
            this.btnLevelMenu.Size = new System.Drawing.Size(204, 64);
            this.btnLevelMenu.TabIndex = 22;
            this.btnLevelMenu.TabStop = false;
            this.btnLevelMenu.UseVisualStyleBackColor = false;
            this.btnLevelMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLevel6
            // 
            this.btnLevel6.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel6.BackgroundImage")));
            this.btnLevel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel6.Enabled = false;
            this.btnLevel6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel6.Location = new System.Drawing.Point(261, 276);
            this.btnLevel6.Name = "btnLevel6";
            this.btnLevel6.Size = new System.Drawing.Size(165, 53);
            this.btnLevel6.TabIndex = 19;
            this.btnLevel6.TabStop = false;
            this.btnLevel6.Tag = "6";
            this.btnLevel6.UseVisualStyleBackColor = false;
            this.btnLevel6.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel5
            // 
            this.btnLevel5.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel5.BackgroundImage")));
            this.btnLevel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel5.Enabled = false;
            this.btnLevel5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel5.Location = new System.Drawing.Point(74, 275);
            this.btnLevel5.Name = "btnLevel5";
            this.btnLevel5.Size = new System.Drawing.Size(165, 53);
            this.btnLevel5.TabIndex = 18;
            this.btnLevel5.TabStop = false;
            this.btnLevel5.Tag = "5";
            this.btnLevel5.UseVisualStyleBackColor = false;
            this.btnLevel5.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel4
            // 
            this.btnLevel4.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel4.BackgroundImage")));
            this.btnLevel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel4.Enabled = false;
            this.btnLevel4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel4.Location = new System.Drawing.Point(261, 200);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.Size = new System.Drawing.Size(165, 53);
            this.btnLevel4.TabIndex = 17;
            this.btnLevel4.TabStop = false;
            this.btnLevel4.Tag = "4";
            this.btnLevel4.UseVisualStyleBackColor = false;
            this.btnLevel4.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel3.BackgroundImage")));
            this.btnLevel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel3.Enabled = false;
            this.btnLevel3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel3.Location = new System.Drawing.Point(74, 199);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(165, 53);
            this.btnLevel3.TabIndex = 16;
            this.btnLevel3.TabStop = false;
            this.btnLevel3.Tag = "3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel2.BackgroundImage")));
            this.btnLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel2.Enabled = false;
            this.btnLevel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel2.Location = new System.Drawing.Point(261, 124);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(165, 53);
            this.btnLevel2.TabIndex = 13;
            this.btnLevel2.TabStop = false;
            this.btnLevel2.Tag = "2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLevel1.BackgroundImage")));
            this.btnLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel1.Enabled = false;
            this.btnLevel1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLevel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel1.Location = new System.Drawing.Point(74, 123);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(165, 53);
            this.btnLevel1.TabIndex = 12;
            this.btnLevel1.TabStop = false;
            this.btnLevel1.Tag = "1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenu.BackgroundImage")));
            this.pnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenu.Controls.Add(this.pnAboutUs);
            this.pnMenu.Controls.Add(this.pictureBox4);
            this.pnMenu.Controls.Add(this.pictureBox3);
            this.pnMenu.Controls.Add(this.pictureBox2);
            this.pnMenu.Controls.Add(this.pictureBox1);
            this.pnMenu.Location = new System.Drawing.Point(0, 37);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(500, 613);
            this.pnMenu.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(142, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(142, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(142, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(142, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(204, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 640);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnInstructions);
            this.Controls.Add(this.pnLevel);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnAboutUs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).EndInit();
            this.pnInstructions.ResumeLayout(false);
            this.pnLevel.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLevel;
        private System.Windows.Forms.Button btnLevelMenu;
        private System.Windows.Forms.Button btnLevel6;
        private System.Windows.Forms.Button btnLevel5;
        private System.Windows.Forms.Button btnLevel4;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Panel pnAboutUs;
        private System.Windows.Forms.Button btnAboutUsMenu;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.PictureBox picMinus;
        private System.Windows.Forms.PictureBox picMultiply;
        private System.Windows.Forms.Panel pnInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInstructions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}