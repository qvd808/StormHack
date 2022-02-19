
namespace Stormhacks.Practices1
{
    partial class MultipleChoice1
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
            this.Question1 = new System.Windows.Forms.Label();
            this.A_btn = new System.Windows.Forms.Button();
            this.B_btn = new System.Windows.Forms.Button();
            this.C_btn = new System.Windows.Forms.Button();
            this.D_btn = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Segoe UI Historic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question1.Location = new System.Drawing.Point(240, 51);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(347, 54);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "He__lo my friends!";
            // 
            // A_btn
            // 
            this.A_btn.Location = new System.Drawing.Point(115, 188);
            this.A_btn.Name = "A_btn";
            this.A_btn.Size = new System.Drawing.Size(79, 78);
            this.A_btn.TabIndex = 1;
            this.A_btn.UseVisualStyleBackColor = true;
            this.A_btn.Click += new System.EventHandler(this.A_btn_Click);
            // 
            // B_btn
            // 
            this.B_btn.Image = global::Stormhacks.Properties.Resources.hand1_e_bot_seg_1_cropped;
            this.B_btn.Location = new System.Drawing.Point(256, 188);
            this.B_btn.Name = "B_btn";
            this.B_btn.Size = new System.Drawing.Size(79, 78);
            this.B_btn.TabIndex = 2;
            this.B_btn.UseVisualStyleBackColor = true;
            // 
            // C_btn
            // 
            this.C_btn.Image = global::Stormhacks.Properties.Resources.hand1_o_bot_seg_1_cropped;
            this.C_btn.Location = new System.Drawing.Point(386, 188);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(79, 78);
            this.C_btn.TabIndex = 3;
            this.C_btn.UseVisualStyleBackColor = true;
            this.C_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // D_btn
            // 
            this.D_btn.Image = global::Stormhacks.Properties.Resources.hand1_y_bot_seg_1_cropped;
            this.D_btn.Location = new System.Drawing.Point(508, 188);
            this.D_btn.Name = "D_btn";
            this.D_btn.Size = new System.Drawing.Size(79, 78);
            this.D_btn.TabIndex = 4;
            this.D_btn.UseVisualStyleBackColor = true;
            this.D_btn.Click += new System.EventHandler(this.D_btn_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(643, 208);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(104, 39);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // MultipleChoice1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 537);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.D_btn);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.B_btn);
            this.Controls.Add(this.A_btn);
            this.Controls.Add(this.Question1);
            this.Name = "MultipleChoice1";
            this.Text = "MultipleChoice1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Button A_btn;
        private System.Windows.Forms.Button B_btn;
        private System.Windows.Forms.Button C_btn;
        private System.Windows.Forms.Button D_btn;
        private System.Windows.Forms.Button submit;
    }
}