namespace ObserverPattern
{
    partial class frmObserverPattern
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
            this.txtObserver1 = new System.Windows.Forms.TextBox();
            this.txtObserver2 = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.groupSubject = new System.Windows.Forms.GroupBox();
            this.groupObserver = new System.Windows.Forms.GroupBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblObserver1 = new System.Windows.Forms.Label();
            this.lblObserver2 = new System.Windows.Forms.Label();
            this.groupSubject.SuspendLayout();
            this.groupObserver.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObserver1
            // 
            this.txtObserver1.Location = new System.Drawing.Point(150, 60);
            this.txtObserver1.Name = "txtObserver1";
            this.txtObserver1.Size = new System.Drawing.Size(190, 31);
            this.txtObserver1.TabIndex = 0;
            // 
            // txtObserver2
            // 
            this.txtObserver2.Location = new System.Drawing.Point(150, 132);
            this.txtObserver2.Name = "txtObserver2";
            this.txtObserver2.Size = new System.Drawing.Size(190, 31);
            this.txtObserver2.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(150, 46);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(190, 31);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.TextChanged += new System.EventHandler(this.txtSubject_TextChanged);
            // 
            // groupSubject
            // 
            this.groupSubject.Controls.Add(this.lblSubject);
            this.groupSubject.Controls.Add(this.txtSubject);
            this.groupSubject.Location = new System.Drawing.Point(157, 65);
            this.groupSubject.Name = "groupSubject";
            this.groupSubject.Size = new System.Drawing.Size(588, 100);
            this.groupSubject.TabIndex = 3;
            this.groupSubject.TabStop = false;
            this.groupSubject.Text = "Subject";
            // 
            // groupObserver
            // 
            this.groupObserver.Controls.Add(this.lblObserver2);
            this.groupObserver.Controls.Add(this.lblObserver1);
            this.groupObserver.Controls.Add(this.txtObserver1);
            this.groupObserver.Controls.Add(this.txtObserver2);
            this.groupObserver.Location = new System.Drawing.Point(157, 267);
            this.groupObserver.Name = "groupObserver";
            this.groupObserver.Size = new System.Drawing.Size(588, 182);
            this.groupObserver.TabIndex = 4;
            this.groupObserver.TabStop = false;
            this.groupObserver.Text = "Observers";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(18, 46);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(90, 25);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Subject:";
            // 
            // lblObserver1
            // 
            this.lblObserver1.AutoSize = true;
            this.lblObserver1.Location = new System.Drawing.Point(18, 66);
            this.lblObserver1.Name = "lblObserver1";
            this.lblObserver1.Size = new System.Drawing.Size(124, 25);
            this.lblObserver1.TabIndex = 4;
            this.lblObserver1.Text = "Observer 1:";
            // 
            // lblObserver2
            // 
            this.lblObserver2.AutoSize = true;
            this.lblObserver2.Location = new System.Drawing.Point(18, 138);
            this.lblObserver2.Name = "lblObserver2";
            this.lblObserver2.Size = new System.Drawing.Size(124, 25);
            this.lblObserver2.TabIndex = 5;
            this.lblObserver2.Text = "Observer 2:";
            // 
            // frmObserverPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 581);
            this.Controls.Add(this.groupObserver);
            this.Controls.Add(this.groupSubject);
            this.Name = "frmObserverPattern";
            this.Text = "Observer Pattern ";
            this.groupSubject.ResumeLayout(false);
            this.groupSubject.PerformLayout();
            this.groupObserver.ResumeLayout(false);
            this.groupObserver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtObserver1;
        private System.Windows.Forms.TextBox txtObserver2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.GroupBox groupSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox groupObserver;
        private System.Windows.Forms.Label lblObserver2;
        private System.Windows.Forms.Label lblObserver1;
    }
}

