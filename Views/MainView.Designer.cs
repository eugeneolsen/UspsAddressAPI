namespace UspsAddressApi
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.buttonCityState = new System.Windows.Forms.Button();
            this.labelApi = new System.Windows.Forms.Label();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelLookUp = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(81, 183);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 16);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxCity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(122, 180);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.ReadOnly = true;
            this.textBoxCity.Size = new System.Drawing.Size(158, 22);
            this.textBoxCity.TabIndex = 4;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(73, 211);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(43, 16);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "State:";
            // 
            // textBoxState
            // 
            this.textBoxState.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxState.Location = new System.Drawing.Point(122, 208);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.ReadOnly = true;
            this.textBoxState.Size = new System.Drawing.Size(46, 22);
            this.textBoxState.TabIndex = 6;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMessage});
            this.statusStrip.Location = new System.Drawing.Point(0, 304);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(317, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusMessage
            // 
            this.statusMessage.BackColor = System.Drawing.SystemColors.Control;
            this.statusMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMessage.ForeColor = System.Drawing.Color.Maroon;
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // labelZipCode
            // 
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.ForeColor = System.Drawing.Color.White;
            this.labelZipCode.Location = new System.Drawing.Point(12, 144);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(104, 16);
            this.labelZipCode.TabIndex = 0;
            this.labelZipCode.Text = "5-Digit Zip Code:";
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZipCode.Location = new System.Drawing.Point(122, 141);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(100, 22);
            this.textBoxZipCode.TabIndex = 1;
            // 
            // buttonCityState
            // 
            this.buttonCityState.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCityState.Location = new System.Drawing.Point(158, 257);
            this.buttonCityState.Name = "buttonCityState";
            this.buttonCityState.Size = new System.Drawing.Size(147, 26);
            this.buttonCityState.TabIndex = 2;
            this.buttonCityState.Text = "Get City and State";
            this.buttonCityState.UseVisualStyleBackColor = true;
            this.buttonCityState.Click += new System.EventHandler(this.buttonCityState_Click);
            // 
            // labelApi
            // 
            this.labelApi.AutoSize = true;
            this.labelApi.BackColor = System.Drawing.Color.White;
            this.labelApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.labelApi.Location = new System.Drawing.Point(118, 35);
            this.labelApi.Name = "labelApi";
            this.labelApi.Size = new System.Drawing.Size(71, 37);
            this.labelApi.TabIndex = 9;
            this.labelApi.Text = "API";
            this.labelApi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::UspsAddressApi.Properties.Resources.edit_find;
            this.pictureBoxSearch.Location = new System.Drawing.Point(223, 20);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearch.TabIndex = 10;
            this.pictureBoxSearch.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::UspsAddressApi.Properties.Resources.dsn_brd_eagle_302x134;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(192, 79);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelLookUp
            // 
            this.labelLookUp.AutoSize = true;
            this.labelLookUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLookUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelLookUp.Location = new System.Drawing.Point(15, 105);
            this.labelLookUp.Name = "labelLookUp";
            this.labelLookUp.Size = new System.Drawing.Size(273, 19);
            this.labelLookUp.TabIndex = 11;
            this.labelLookUp.Text = "Look up city and state by ZIP Code";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelCopyright.Location = new System.Drawing.Point(12, 264);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(125, 14);
            this.labelCopyright.TabIndex = 12;
            this.labelCopyright.Text = "© 2019 Eugene C. Olsen";
            // 
            // MainView
            // 
            this.AcceptButton = this.buttonCityState;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(317, 326);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelLookUp);
            this.Controls.Add(this.pictureBoxSearch);
            this.Controls.Add(this.labelApi);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonCityState);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.labelZipCode);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainView";
            this.Text = "United States Postal Service - Address API";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Button buttonCityState;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelApi;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.Label labelLookUp;
        private System.Windows.Forms.Label labelCopyright;
    }
}

