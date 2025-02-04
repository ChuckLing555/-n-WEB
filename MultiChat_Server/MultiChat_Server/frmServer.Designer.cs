namespace MultiChat_Server
{
    partial class frmServer
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
            this.lvwMess = new System.Windows.Forms.ListView();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwMess
            // 
            this.lvwMess.HideSelection = false;
            this.lvwMess.Location = new System.Drawing.Point(12, 12);
            this.lvwMess.Name = "lvwMess";
            this.lvwMess.Size = new System.Drawing.Size(559, 346);
            this.lvwMess.TabIndex = 0;
            this.lvwMess.UseCompatibleStateImageBehavior = false;
            this.lvwMess.View = System.Windows.Forms.View.List;
            // 
            // txtMess
            // 
            this.txtMess.Location = new System.Drawing.Point(12, 375);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(455, 48);
            this.txtMess.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(473, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 48);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // frmSever
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 435);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMess);
            this.Controls.Add(this.lvwMess);
            this.Name = "frmSever";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

