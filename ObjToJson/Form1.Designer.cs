namespace ObjToJson
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
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnConvertToObject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 26);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(776, 380);
            this.txtCode.TabIndex = 0;
            // 
            // btnConvertToObject
            // 
            this.btnConvertToObject.Location = new System.Drawing.Point(499, 469);
            this.btnConvertToObject.Name = "btnConvertToObject";
            this.btnConvertToObject.Size = new System.Drawing.Size(247, 38);
            this.btnConvertToObject.TabIndex = 2;
            this.btnConvertToObject.Text = "JSON => Object";
            this.btnConvertToObject.UseVisualStyleBackColor = true;
            this.btnConvertToObject.Click += new System.EventHandler(this.btnConvertToObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnConvertToObject);
            this.Controls.Add(this.txtCode);
            this.Name = "Form1";
            this.Text = "JSON to Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnConvertToObject;
    }
}

