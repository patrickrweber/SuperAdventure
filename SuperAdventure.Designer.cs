
namespace SuperAdventure
{
    partial class SuperAdventure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblInputName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ouro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experiência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nível";
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.BackColor = System.Drawing.SystemColors.Control;
            this.lblHitPoints.Location = new System.Drawing.Point(93, 34);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 15);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(93, 60);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 15);
            this.lblGold.TabIndex = 5;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.SystemColors.Control;
            this.lblExperience.Location = new System.Drawing.Point(93, 88);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(0, 15);
            this.lblExperience.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(93, 114);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 15);
            this.lblLevel.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 20);
            this.lblNome.TabIndex = 8;
            this.lblNome.Visible = false;
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(3, 9);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(129, 15);
            this.lblInputName.TabIndex = 9;
            this.lblInputName.Text = "Nome do Personagem:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(245, 6);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblInputName);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "MyGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblInputName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConfirmar;
    }
}

