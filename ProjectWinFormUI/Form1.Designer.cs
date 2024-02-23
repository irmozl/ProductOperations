namespace ProjectWinFormUI
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnListCategories = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(92, 68);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(169, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(92, 108);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(169, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // btnListCategories
            // 
            this.btnListCategories.AccessibleName = "";
            this.btnListCategories.Location = new System.Drawing.Point(92, 153);
            this.btnListCategories.Name = "btnListCategories";
            this.btnListCategories.Size = new System.Drawing.Size(168, 23);
            this.btnListCategories.TabIndex = 2;
            this.btnListCategories.Text = "List Categories";
            this.btnListCategories.UseVisualStyleBackColor = true;
            this.btnListCategories.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(92, 193);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(168, 23);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstCategories
            // 
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.Location = new System.Drawing.Point(302, 68);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(432, 225);
            this.lstCategories.TabIndex = 6;
            this.lstCategories.Click += new System.EventHandler(this.lstCategories_Click);
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstKategoriler_SelectedIndexChanged);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(566, 323);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(168, 27);
            this.btnForm2.TabIndex = 8;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(26, 111);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(60, 13);
            this.Price.TabIndex = 20;
            this.Price.Text = "Description";
            // 
            // Namee
            // 
            this.Namee.AutoSize = true;
            this.Namee.Location = new System.Drawing.Point(26, 71);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(35, 13);
            this.Namee.TabIndex = 19;
            this.Namee.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Namee);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnListCategories);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnListCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Namee;
    }
}

