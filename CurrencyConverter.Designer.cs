namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            this.btnCurrencyConv = new System.Windows.Forms.Button();
            this.wbBody = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnCurrencyConv
            // 
            this.btnCurrencyConv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCurrencyConv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurrencyConv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCurrencyConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrencyConv.Location = new System.Drawing.Point(0, 0);
            this.btnCurrencyConv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCurrencyConv.Name = "btnCurrencyConv";
            this.btnCurrencyConv.Size = new System.Drawing.Size(806, 43);
            this.btnCurrencyConv.TabIndex = 0;
            this.btnCurrencyConv.Text = "Currency Converter";
            this.btnCurrencyConv.UseVisualStyleBackColor = false;
            this.btnCurrencyConv.Click += new System.EventHandler(this.btnCurrencyConv_Click);
            // 
            // wbBody
            // 
            this.wbBody.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wbBody.Location = new System.Drawing.Point(0, 47);
            this.wbBody.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbBody.MinimumSize = new System.Drawing.Size(13, 13);
            this.wbBody.Name = "wbBody";
            this.wbBody.ScriptErrorsSuppressed = true;
            this.wbBody.Size = new System.Drawing.Size(806, 368);
            this.wbBody.TabIndex = 1;
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 415);
            this.Controls.Add(this.wbBody);
            this.Controls.Add(this.btnCurrencyConv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CurrencyConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            this.Load += new System.EventHandler(this.CurrencyConverter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCurrencyConv;
        private System.Windows.Forms.WebBrowser wbBody;
    }
}

