namespace CollegeMate
{
    partial class DayEvents
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dayEventContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Telegrafico", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Events";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewEvent.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEvent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewEvent.Location = new System.Drawing.Point(31, 192);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(122, 53);
            this.btnNewEvent.TabIndex = 2;
            this.btnNewEvent.Text = "New Event";
            this.btnNewEvent.UseVisualStyleBackColor = false;
            this.btnNewEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dayEventContainer
            // 
            this.dayEventContainer.ForeColor = System.Drawing.Color.Black;
            this.dayEventContainer.Location = new System.Drawing.Point(203, 58);
            this.dayEventContainer.Name = "dayEventContainer";
            this.dayEventContainer.Size = new System.Drawing.Size(299, 187);
            this.dayEventContainer.TabIndex = 3;
            // 
            // DayEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(529, 267);
            this.Controls.Add(this.dayEventContainer);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.label2);
            this.Name = "DayEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.lblday_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel dayEventContainer;
    }
}