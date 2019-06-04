namespace WindowsFormsApplication6
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
            this.lbCity = new System.Windows.Forms.ListBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.lCountry = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bRename = new System.Windows.Forms.Button();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.tbRename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCity
            // 
            this.lbCity.FormattingEnabled = true;
            this.lbCity.Location = new System.Drawing.Point(12, 83);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(139, 95);
            this.lbCity.TabIndex = 0;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(12, 32);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(139, 21);
            this.cbCountry.TabIndex = 1;
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCountry.Location = new System.Drawing.Point(12, 9);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(53, 16);
            this.lCountry.TabIndex = 2;
            this.lCountry.Text = "Country";
            
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCity.Location = new System.Drawing.Point(13, 60);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(30, 16);
            this.lCity.TabIndex = 3;
            this.lCity.Text = "City";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(157, 83);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 27);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(157, 116);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 27);
            this.bRemove.TabIndex = 5;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(157, 149);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 27);
            this.bRename.TabIndex = 6;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // tbAdd
            // 
            this.tbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAdd.Location = new System.Drawing.Point(238, 83);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(153, 22);
            this.tbAdd.TabIndex = 7;
           
            // 
            // tbRename
            // 
            this.tbRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRename.Location = new System.Drawing.Point(238, 154);
            this.tbRename.Name = "tbRename";
            this.tbRename.Size = new System.Drawing.Size(153, 22);
            this.tbRename.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 201);
            this.Controls.Add(this.tbRename);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.lCountry);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.lbCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCity;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bRename;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.TextBox tbRename;
    }
}

