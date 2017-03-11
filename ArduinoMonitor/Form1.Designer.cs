namespace ArduinoMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBaud = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialList = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(59, 174);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(50, 3, 10, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(206, 43);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(59, 240);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(50, 3, 3, 50);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(438, 43);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBaud
            // 
            this.textBaud.Location = new System.Drawing.Point(291, 106);
            this.textBaud.Margin = new System.Windows.Forms.Padding(3, 3, 50, 30);
            this.textBaud.Name = "textBaud";
            this.textBaud.Size = new System.Drawing.Size(206, 31);
            this.textBaud.TabIndex = 3;
            this.textBaud.Text = "9600";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(54, 43);
            this.labelPort.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(118, 25);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Serial Port:";
            this.labelPort.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(54, 109);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(119, 25);
            this.labelBaud.TabIndex = 5;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialList
            // 
            this.serialList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialList.FormattingEnabled = true;
            this.serialList.Location = new System.Drawing.Point(291, 40);
            this.serialList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.serialList.Name = "serialList";
            this.serialList.Size = new System.Drawing.Size(206, 33);
            this.serialList.TabIndex = 6;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(291, 174);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(10, 3, 50, 30);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(206, 43);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(556, 316);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.serialList);
            this.Controls.Add(this.labelBaud);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBaud);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Arduino Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox serialList;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

