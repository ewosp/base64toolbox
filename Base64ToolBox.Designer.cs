namespace Base64ToolBox {
    partial class Base64ToolBoxForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64ToolBoxForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonGenererImage = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.tabPageResultImage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxResultat = new System.Windows.Forms.PictureBox();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonCopyPictureClipboard = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialogPicture = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageResultImage.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultat)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageResultImage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonGenererImage);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxBlock);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            // 
            // buttonGenererImage
            // 
            this.buttonGenererImage.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonGenererImage.Enabled = false;
            this.buttonGenererImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenererImage.Location = new System.Drawing.Point(355, 400);
            this.buttonGenererImage.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.buttonGenererImage.Name = "buttonGenererImage";
            this.buttonGenererImage.Size = new System.Drawing.Size(106, 23);
            this.buttonGenererImage.TabIndex = 4;
            this.buttonGenererImage.Text = "Générer image";
            this.buttonGenererImage.UseVisualStyleBackColor = false;
            this.buttonGenererImage.Click += new System.EventHandler(this.buttonGenererImage_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(216, 403);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(133, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Pas de retour à la ligne";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 403);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(199, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Retour à la ligne après 76 caractères";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrez le bloc Base 64 à convertir en image :";
            // 
            // textBoxBlock
            // 
            this.textBoxBlock.Location = new System.Drawing.Point(10, 41);
            this.textBoxBlock.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.textBoxBlock.Multiline = true;
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(578, 355);
            this.textBoxBlock.TabIndex = 0;
            this.textBoxBlock.TextChanged += new System.EventHandler(this.textBoxBloc_TextChanged);
            // 
            // tabPageResultImage
            // 
            this.tabPageResultImage.AllowDrop = true;
            this.tabPageResultImage.Controls.Add(this.splitContainer1);
            this.tabPageResultImage.Location = new System.Drawing.Point(4, 22);
            this.tabPageResultImage.Name = "tabPageResultImage";
            this.tabPageResultImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResultImage.Size = new System.Drawing.Size(608, 429);
            this.tabPageResultImage.TabIndex = 2;
            this.tabPageResultImage.Text = "Résultat";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxResultat);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.buttonSavePicture);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCopyPictureClipboard);
            this.splitContainer1.Size = new System.Drawing.Size(602, 423);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // pictureBoxResultat
            // 
            this.pictureBoxResultat.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxResultat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxResultat.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxResultat.Name = "pictureBoxResultat";
            this.pictureBoxResultat.Size = new System.Drawing.Size(602, 376);
            this.pictureBoxResultat.TabIndex = 1;
            this.pictureBoxResultat.TabStop = false;
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(154, 11);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(124, 23);
            this.buttonSavePicture.TabIndex = 3;
            this.buttonSavePicture.Text = "Sauvegarder sous ...";
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonCopyPictureClipboard
            // 
            this.buttonCopyPictureClipboard.Location = new System.Drawing.Point(10, 11);
            this.buttonCopyPictureClipboard.Name = "buttonCopyPictureClipboard";
            this.buttonCopyPictureClipboard.Size = new System.Drawing.Size(124, 23);
            this.buttonCopyPictureClipboard.TabIndex = 2;
            this.buttonCopyPictureClipboard.Text = "Copier";
            this.buttonCopyPictureClipboard.Click += new System.EventHandler(this.buttonCopyPictureClipboard_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "À Propos De";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mime64ToolBox.Properties.Resources.EWOSP;
            this.pictureBox1.Location = new System.Drawing.Point(266, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 285);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(10, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(182, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.espace-win.org/EWOSP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // saveFileDialogPicture
            // 
            this.saveFileDialogPicture.DefaultExt = "png";
            this.saveFileDialogPicture.FileName = "mon image décodée";
            this.saveFileDialogPicture.Filter = "Images (*.jpg,*.gif,*.bmp,*.png)|*.jpg;*.gif;*.bmp;*.png";
            this.saveFileDialogPicture.Title = "Sauvegarder l\'image";
            // 
            // Base64ToolBoxForm
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "Base64ToolBoxForm";
            this.Text = "Base64 ToolBox";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageResultImage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultat)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBlock;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonGenererImage;
        private System.Windows.Forms.TabPage tabPageResultImage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxResultat;
        private System.Windows.Forms.Button buttonCopyPictureClipboard;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

