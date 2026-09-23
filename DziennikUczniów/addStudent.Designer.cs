namespace DziennikUczniów
{
    partial class addStudent
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
            boxId = new TextBox();
            lbId = new Label();
            lbName = new Label();
            boxName = new TextBox();
            lbLstName = new Label();
            boxLastname = new TextBox();
            label3 = new Label();
            boxMath = new TextBox();
            label4 = new Label();
            boxTech = new TextBox();
            label5 = new Label();
            boxPhysic = new TextBox();
            label6 = new Label();
            boxPol = new TextBox();
            label7 = new Label();
            boxObcy = new TextBox();
            rchNotes = new RichTextBox();
            rtbComments = new Label();
            btnConfirm = new Button();
            btnCancel2 = new Button();
            SuspendLayout();
            // 
            // boxId
            // 
            boxId.Location = new Point(114, 25);
            boxId.Name = "boxId";
            boxId.ReadOnly = true;
            boxId.Size = new Size(193, 23);
            boxId.TabIndex = 0;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(16, 28);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 1;
            lbId.Text = "Id:";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(16, 57);
            lbName.Name = "lbName";
            lbName.Size = new Size(33, 15);
            lbName.TabIndex = 3;
            lbName.Text = "Imie:";
            // 
            // boxName
            // 
            boxName.Location = new Point(114, 54);
            boxName.Name = "boxName";
            boxName.Size = new Size(193, 23);
            boxName.TabIndex = 2;
            // 
            // lbLstName
            // 
            lbLstName.AutoSize = true;
            lbLstName.Location = new Point(12, 86);
            lbLstName.Name = "lbLstName";
            lbLstName.Size = new Size(60, 15);
            lbLstName.TabIndex = 5;
            lbLstName.Text = "Nazwisko:";
            // 
            // boxLastname
            // 
            boxLastname.Location = new Point(114, 83);
            boxLastname.Name = "boxLastname";
            boxLastname.Size = new Size(193, 23);
            boxLastname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Matematyka:";
            // 
            // boxMath
            // 
            boxMath.Location = new Point(114, 112);
            boxMath.Name = "boxMath";
            boxMath.Size = new Size(193, 23);
            boxMath.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 9;
            label4.Text = "Technologia:";
            // 
            // boxTech
            // 
            boxTech.Location = new Point(114, 141);
            boxTech.Name = "boxTech";
            boxTech.Size = new Size(193, 23);
            boxTech.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 173);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Fizyka:";
            // 
            // boxPhysic
            // 
            boxPhysic.Location = new Point(114, 170);
            boxPhysic.Name = "boxPhysic";
            boxPhysic.Size = new Size(193, 23);
            boxPhysic.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 202);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Jęz. Pol: ";
            // 
            // boxPol
            // 
            boxPol.Location = new Point(114, 199);
            boxPol.Name = "boxPol";
            boxPol.Size = new Size(193, 23);
            boxPol.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 231);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 15;
            label7.Text = "Jęz. Obcy:";
            // 
            // boxObcy
            // 
            boxObcy.Location = new Point(114, 228);
            boxObcy.Name = "boxObcy";
            boxObcy.Size = new Size(193, 23);
            boxObcy.TabIndex = 14;
            // 
            // rchNotes
            // 
            rchNotes.Location = new Point(114, 257);
            rchNotes.Name = "rchNotes";
            rchNotes.Size = new Size(193, 96);
            rchNotes.TabIndex = 16;
            rchNotes.Text = "";
            // 
            // rtbComments
            // 
            rtbComments.AutoSize = true;
            rtbComments.Location = new Point(16, 260);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(43, 15);
            rtbComments.TabIndex = 17;
            rtbComments.Text = "Uwagi:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(192, 255, 192);
            btnConfirm.Location = new Point(232, 359);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 18;
            btnConfirm.Text = "Zatwierdź";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel2
            // 
            btnCancel2.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel2.Location = new Point(148, 359);
            btnCancel2.Name = "btnCancel2";
            btnCancel2.Size = new Size(75, 23);
            btnCancel2.TabIndex = 19;
            btnCancel2.Text = "Anuluj";
            btnCancel2.UseVisualStyleBackColor = false;
            btnCancel2.Click += btnCancel2_Click;
            // 
            // btnCancel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 394);
            Controls.Add(btnCancel2);
            Controls.Add(btnConfirm);
            Controls.Add(rtbComments);
            Controls.Add(rchNotes);
            Controls.Add(label7);
            Controls.Add(boxObcy);
            Controls.Add(label6);
            Controls.Add(boxPol);
            Controls.Add(label5);
            Controls.Add(boxPhysic);
            Controls.Add(label4);
            Controls.Add(boxTech);
            Controls.Add(label3);
            Controls.Add(boxMath);
            Controls.Add(lbLstName);
            Controls.Add(boxLastname);
            Controls.Add(lbName);
            Controls.Add(boxName);
            Controls.Add(lbId);
            Controls.Add(boxId);
            Name = "btnCancel";
            Text = "addStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox boxId;
        private Label lbId;
        private Label lbName;
        private TextBox boxName;
        private Label lbLstName;
        private TextBox boxLastname;
        private Label label3;
        private TextBox boxMath;
        private Label label4;
        private TextBox boxTech;
        private Label label5;
        private TextBox boxPhysic;
        private Label label6;
        private TextBox boxPol;
        private Label label7;
        private TextBox boxObcy;
        private RichTextBox rchNotes;
        private Label rtbComments;
        private Button btnConfirm;
        private Button btnCancel2;
    }
}