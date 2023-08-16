namespace nwe_product
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
            this.txtproname = new System.Windows.Forms.TextBox();
            this.txtpropri = new System.Windows.Forms.TextBox();
            this.txtproid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLwrite = new System.Windows.Forms.Button();
            this.btnXMLread = new System.Windows.Forms.Button();
            this.btnJOSNwrite = new System.Windows.Forms.Button();
            this.btnSOAPread = new System.Windows.Forms.Button();
            this.btnSOAPwrit = new System.Windows.Forms.Button();
            this.btnJOSNread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtproname
            // 
            this.txtproname.Location = new System.Drawing.Point(148, 100);
            this.txtproname.Name = "txtproname";
            this.txtproname.Size = new System.Drawing.Size(165, 20);
            this.txtproname.TabIndex = 13;
            // 
            // txtpropri
            // 
            this.txtpropri.Location = new System.Drawing.Point(148, 166);
            this.txtpropri.Name = "txtpropri";
            this.txtpropri.Size = new System.Drawing.Size(165, 20);
            this.txtpropri.TabIndex = 12;
            // 
            // txtproid
            // 
            this.txtproid.Location = new System.Drawing.Point(148, 49);
            this.txtproid.Name = "txtproid";
            this.txtproid.Size = new System.Drawing.Size(165, 20);
            this.txtproid.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product ID";
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(379, 49);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryWrite.TabIndex = 14;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(497, 49);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryRead.TabIndex = 15;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLwrite
            // 
            this.btnXMLwrite.Location = new System.Drawing.Point(379, 107);
            this.btnXMLwrite.Name = "btnXMLwrite";
            this.btnXMLwrite.Size = new System.Drawing.Size(75, 23);
            this.btnXMLwrite.TabIndex = 16;
            this.btnXMLwrite.Text = "XML Write";
            this.btnXMLwrite.UseVisualStyleBackColor = true;
            this.btnXMLwrite.Click += new System.EventHandler(this.btnXMLwrite_Click);
            // 
            // btnXMLread
            // 
            this.btnXMLread.Location = new System.Drawing.Point(497, 107);
            this.btnXMLread.Name = "btnXMLread";
            this.btnXMLread.Size = new System.Drawing.Size(75, 23);
            this.btnXMLread.TabIndex = 17;
            this.btnXMLread.Text = "XML Read";
            this.btnXMLread.UseVisualStyleBackColor = true;
            this.btnXMLread.Click += new System.EventHandler(this.btnXMLread_Click);
            // 
            // btnJOSNwrite
            // 
            this.btnJOSNwrite.Location = new System.Drawing.Point(379, 235);
            this.btnJOSNwrite.Name = "btnJOSNwrite";
            this.btnJOSNwrite.Size = new System.Drawing.Size(75, 23);
            this.btnJOSNwrite.TabIndex = 18;
            this.btnJOSNwrite.Text = "JSON Write";
            this.btnJOSNwrite.UseVisualStyleBackColor = true;
            this.btnJOSNwrite.Click += new System.EventHandler(this.btnJOSNwrite_Click);
            // 
            // btnSOAPread
            // 
            this.btnSOAPread.Location = new System.Drawing.Point(497, 173);
            this.btnSOAPread.Name = "btnSOAPread";
            this.btnSOAPread.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPread.TabIndex = 19;
            this.btnSOAPread.Text = "SOAP Read";
            this.btnSOAPread.UseVisualStyleBackColor = true;
            this.btnSOAPread.Click += new System.EventHandler(this.btnSOAPread_Click);
            // 
            // btnSOAPwrit
            // 
            this.btnSOAPwrit.Location = new System.Drawing.Point(379, 173);
            this.btnSOAPwrit.Name = "btnSOAPwrit";
            this.btnSOAPwrit.Size = new System.Drawing.Size(75, 23);
            this.btnSOAPwrit.TabIndex = 20;
            this.btnSOAPwrit.Text = "SOAP Write";
            this.btnSOAPwrit.UseVisualStyleBackColor = true;
            this.btnSOAPwrit.Click += new System.EventHandler(this.btnSOAPwrit_Click);
            // 
            // btnJOSNread
            // 
            this.btnJOSNread.Location = new System.Drawing.Point(497, 235);
            this.btnJOSNread.Name = "btnJOSNread";
            this.btnJOSNread.Size = new System.Drawing.Size(75, 23);
            this.btnJOSNread.TabIndex = 21;
            this.btnJOSNread.Text = "JSON Read";
            this.btnJOSNread.UseVisualStyleBackColor = true;
            this.btnJOSNread.Click += new System.EventHandler(this.btnJOSNread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.btnJOSNread);
            this.Controls.Add(this.btnSOAPwrit);
            this.Controls.Add(this.btnSOAPread);
            this.Controls.Add(this.btnJOSNwrite);
            this.Controls.Add(this.btnXMLread);
            this.Controls.Add(this.btnXMLwrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtproname);
            this.Controls.Add(this.txtpropri);
            this.Controls.Add(this.txtproid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtproname;
        private System.Windows.Forms.TextBox txtpropri;
        private System.Windows.Forms.TextBox txtproid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLwrite;
        private System.Windows.Forms.Button btnXMLread;
        private System.Windows.Forms.Button btnJOSNwrite;
        private System.Windows.Forms.Button btnSOAPread;
        private System.Windows.Forms.Button btnSOAPwrit;
        private System.Windows.Forms.Button btnJOSNread;
    }
}

