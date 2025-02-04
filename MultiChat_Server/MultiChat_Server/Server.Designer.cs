namespace MultiChat_Server
{
    partial class Server
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
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lvwMess = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 430);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(460, 49);
            this.txtMess.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(478, 430);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 49);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lvwMess
            // 
            this.lvwMess.HideSelection = false;
            this.lvwMess.Location = new System.Drawing.Point(12, 12);
            this.lvwMess.Name = "lvwMess";
            this.lvwMess.Size = new System.Drawing.Size(558, 412);
            this.lvwMess.TabIndex = 3;
            this.lvwMess.UseCompatibleStateImageBehavior = false;
            this.lvwMess.View = System.Windows.Forms.View.List;
            // 
            // Server
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 495);
            this.Controls.Add(this.lvwMess);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Server_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lvwMess;
    }
}