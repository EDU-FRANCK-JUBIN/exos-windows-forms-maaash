namespace WindowsForms_Exo
{
    partial class Test
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxVilles = new System.Windows.Forms.ListBox();
            this.radioButtonHomme = new System.Windows.Forms.RadioButton();
            this.radioButtonFemme = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAdresse);
            this.groupBox1.Controls.Add(this.textBoxNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Détails utilisateur";
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(152, 143);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(158, 26);
            this.textBoxAdresse.TabIndex = 3;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(152, 69);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(158, 26);
            this.textBoxNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // listBoxVilles
            // 
            this.listBoxVilles.FormattingEnabled = true;
            this.listBoxVilles.ItemHeight = 20;
            this.listBoxVilles.Items.AddRange(new object[] {
            "Nantes",
            "Toulouse",
            "Munich"});
            this.listBoxVilles.Location = new System.Drawing.Point(27, 240);
            this.listBoxVilles.Name = "listBoxVilles";
            this.listBoxVilles.Size = new System.Drawing.Size(120, 84);
            this.listBoxVilles.TabIndex = 3;
            this.listBoxVilles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButtonHomme
            // 
            this.radioButtonHomme.AutoSize = true;
            this.radioButtonHomme.Location = new System.Drawing.Point(414, 63);
            this.radioButtonHomme.Name = "radioButtonHomme";
            this.radioButtonHomme.Size = new System.Drawing.Size(90, 24);
            this.radioButtonHomme.TabIndex = 4;
            this.radioButtonHomme.TabStop = true;
            this.radioButtonHomme.Text = "Homme";
            this.radioButtonHomme.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemme
            // 
            this.radioButtonFemme.AutoSize = true;
            this.radioButtonFemme.Location = new System.Drawing.Point(414, 102);
            this.radioButtonFemme.Name = "radioButtonFemme";
            this.radioButtonFemme.Size = new System.Drawing.Size(88, 24);
            this.radioButtonFemme.TabIndex = 5;
            this.radioButtonFemme.TabStop = true;
            this.radioButtonFemme.Text = "Femme";
            this.radioButtonFemme.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(414, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "C#";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(414, 279);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 24);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "ADA";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Soumettre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(759, 12);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Nœud1";
            treeNode5.Text = "Label";
            treeNode6.Name = "Nœud2";
            treeNode6.Text = "Button";
            treeNode7.Name = "Nœud3";
            treeNode7.Text = "Checkbox";
            treeNode8.Name = "Nœud0";
            treeNode8.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 297);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButtonFemme);
            this.Controls.Add(this.radioButtonHomme);
            this.Controls.Add(this.listBoxVilles);
            this.Controls.Add(this.groupBox1);
            this.Name = "Test";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ListBox listBoxVilles;
        private System.Windows.Forms.RadioButton radioButtonHomme;
        private System.Windows.Forms.RadioButton radioButtonFemme;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}