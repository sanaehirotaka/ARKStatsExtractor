﻿namespace ARKBreedingStats
{
    partial class CreatureBox
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatureBox));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelStatHeader = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.statDisplayTo = new ARKBreedingStats.StatDisplay();
            this.statDisplaySp = new ARKBreedingStats.StatDisplay();
            this.statDisplayDm = new ARKBreedingStats.StatDisplay();
            this.statDisplayWe = new ARKBreedingStats.StatDisplay();
            this.statDisplayFo = new ARKBreedingStats.StatDisplay();
            this.statDisplayOx = new ARKBreedingStats.StatDisplay();
            this.statDisplaySt = new ARKBreedingStats.StatDisplay();
            this.statDisplayHP = new ARKBreedingStats.StatDisplay();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.labelGender);
            this.groupBox1.Controls.Add(this.labelStatHeader);
            this.groupBox1.Controls.Add(this.buttonEdit);
            this.groupBox1.Controls.Add(this.statDisplayTo);
            this.groupBox1.Controls.Add(this.statDisplaySp);
            this.groupBox1.Controls.Add(this.statDisplayDm);
            this.groupBox1.Controls.Add(this.statDisplayWe);
            this.groupBox1.Controls.Add(this.statDisplayFo);
            this.groupBox1.Controls.Add(this.statDisplayOx);
            this.groupBox1.Controls.Add(this.statDisplaySt);
            this.groupBox1.Controls.Add(this.statDisplayHP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creature";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(6, 22);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(13, 13);
            this.labelGender.TabIndex = 16;
            this.labelGender.Text = "?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numericUpDown7);
            this.panel1.Controls.Add(this.numericUpDown6);
            this.panel1.Controls.Add(this.numericUpDown5);
            this.panel1.Controls.Add(this.numericUpDown4);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBoxFemale);
            this.panel1.Controls.Add(this.checkBoxMale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxOwner);
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 198);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(102, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(53, 23);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(56, 97);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(32, 17);
            this.checkBoxFemale.TabIndex = 19;
            this.checkBoxFemale.Text = "F";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Location = new System.Drawing.Point(94, 97);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(35, 17);
            this.checkBoxMale.TabIndex = 18;
            this.checkBoxMale.Text = "M";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Owner";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(56, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(99, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(56, 58);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(99, 20);
            this.textBoxOwner.TabIndex = 14;
            // 
            // labelStatHeader
            // 
            this.labelStatHeader.AutoSize = true;
            this.labelStatHeader.Location = new System.Drawing.Point(31, 22);
            this.labelStatHeader.Name = "labelStatHeader";
            this.labelStatHeader.Size = new System.Drawing.Size(97, 13);
            this.labelStatHeader.TabIndex = 13;
            this.labelStatHeader.Text = "W   D     B           C";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(178, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(18, 18);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 17);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(3, 40);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 23;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(3, 63);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown3.TabIndex = 24;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(3, 86);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown4.TabIndex = 25;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(3, 109);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown5.TabIndex = 26;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(3, 132);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown6.TabIndex = 27;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(3, 155);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown7.TabIndex = 28;
            // 
            // statDisplayTo
            // 
            this.statDisplayTo.Location = new System.Drawing.Point(6, 202);
            this.statDisplayTo.Name = "statDisplayTo";
            this.statDisplayTo.Size = new System.Drawing.Size(166, 20);
            this.statDisplayTo.TabIndex = 7;
            // 
            // statDisplaySp
            // 
            this.statDisplaySp.Location = new System.Drawing.Point(6, 179);
            this.statDisplaySp.Name = "statDisplaySp";
            this.statDisplaySp.Size = new System.Drawing.Size(166, 20);
            this.statDisplaySp.TabIndex = 6;
            // 
            // statDisplayDm
            // 
            this.statDisplayDm.Location = new System.Drawing.Point(6, 156);
            this.statDisplayDm.Name = "statDisplayDm";
            this.statDisplayDm.Size = new System.Drawing.Size(166, 20);
            this.statDisplayDm.TabIndex = 5;
            // 
            // statDisplayWe
            // 
            this.statDisplayWe.Location = new System.Drawing.Point(6, 133);
            this.statDisplayWe.Name = "statDisplayWe";
            this.statDisplayWe.Size = new System.Drawing.Size(166, 20);
            this.statDisplayWe.TabIndex = 4;
            // 
            // statDisplayFo
            // 
            this.statDisplayFo.Location = new System.Drawing.Point(6, 110);
            this.statDisplayFo.Name = "statDisplayFo";
            this.statDisplayFo.Size = new System.Drawing.Size(166, 20);
            this.statDisplayFo.TabIndex = 3;
            // 
            // statDisplayOx
            // 
            this.statDisplayOx.Location = new System.Drawing.Point(6, 87);
            this.statDisplayOx.Name = "statDisplayOx";
            this.statDisplayOx.Size = new System.Drawing.Size(166, 20);
            this.statDisplayOx.TabIndex = 2;
            // 
            // statDisplaySt
            // 
            this.statDisplaySt.Location = new System.Drawing.Point(6, 64);
            this.statDisplaySt.Name = "statDisplaySt";
            this.statDisplaySt.Size = new System.Drawing.Size(166, 20);
            this.statDisplaySt.TabIndex = 1;
            // 
            // statDisplayHP
            // 
            this.statDisplayHP.Location = new System.Drawing.Point(6, 41);
            this.statDisplayHP.Name = "statDisplayHP";
            this.statDisplayHP.Size = new System.Drawing.Size(166, 20);
            this.statDisplayHP.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "D";
            // 
            // CreatureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreatureBox";
            this.Size = new System.Drawing.Size(195, 226);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private StatDisplay statDisplayTo;
        private StatDisplay statDisplaySp;
        private StatDisplay statDisplayDm;
        private StatDisplay statDisplayWe;
        private StatDisplay statDisplayFo;
        private StatDisplay statDisplayOx;
        private StatDisplay statDisplaySt;
        private StatDisplay statDisplayHP;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelStatHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}