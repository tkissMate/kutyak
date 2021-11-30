
namespace kutyak
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
            this.listBoxKutyak = new System.Windows.Forms.ListBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxFajta = new System.Windows.Forms.TextBox();
            this.labelFajta = new System.Windows.Forms.Label();
            this.labelSuly = new System.Windows.Forms.Label();
            this.numericUpDownSuly = new System.Windows.Forms.NumericUpDown();
            this.labelDatum = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxKutya = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuly)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxKutyak
            // 
            this.listBoxKutyak.FormattingEnabled = true;
            this.listBoxKutyak.Location = new System.Drawing.Point(317, 39);
            this.listBoxKutyak.Name = "listBoxKutyak";
            this.listBoxKutyak.Size = new System.Drawing.Size(228, 186);
            this.listBoxKutyak.TabIndex = 0;
            this.listBoxKutyak.SelectedIndexChanged += new System.EventHandler(this.listBoxKutyak_SelectedIndexChanged);
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(60, 65);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(27, 13);
            this.labelNev.TabIndex = 1;
            this.labelNev.Text = "Nev";
            this.labelNev.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(156, 65);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(111, 20);
            this.textBoxNev.TabIndex = 2;
            // 
            // textBoxFajta
            // 
            this.textBoxFajta.Location = new System.Drawing.Point(156, 91);
            this.textBoxFajta.Name = "textBoxFajta";
            this.textBoxFajta.Size = new System.Drawing.Size(111, 20);
            this.textBoxFajta.TabIndex = 4;
            // 
            // labelFajta
            // 
            this.labelFajta.AutoSize = true;
            this.labelFajta.Location = new System.Drawing.Point(60, 91);
            this.labelFajta.Name = "labelFajta";
            this.labelFajta.Size = new System.Drawing.Size(30, 13);
            this.labelFajta.TabIndex = 3;
            this.labelFajta.Text = "Fajta";
            // 
            // labelSuly
            // 
            this.labelSuly.AutoSize = true;
            this.labelSuly.Location = new System.Drawing.Point(60, 117);
            this.labelSuly.Name = "labelSuly";
            this.labelSuly.Size = new System.Drawing.Size(27, 13);
            this.labelSuly.TabIndex = 5;
            this.labelSuly.Text = "Suly";
            // 
            // numericUpDownSuly
            // 
            this.numericUpDownSuly.Location = new System.Drawing.Point(156, 117);
            this.numericUpDownSuly.Name = "numericUpDownSuly";
            this.numericUpDownSuly.Size = new System.Drawing.Size(111, 20);
            this.numericUpDownSuly.TabIndex = 6;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(60, 143);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(83, 13);
            this.labelDatum.TabIndex = 7;
            this.labelDatum.Text = "Szuletesi Datum";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(156, 143);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(111, 20);
            this.dateTimePickerDatum.TabIndex = 8;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(63, 246);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 9;
            this.buttonCreate.Text = "Létrehoz";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(190, 246);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Modosít";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(317, 246);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Töröl";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxKutya
            // 
            this.groupBoxKutya.Location = new System.Drawing.Point(36, 30);
            this.groupBoxKutya.Name = "groupBoxKutya";
            this.groupBoxKutya.Size = new System.Drawing.Size(257, 195);
            this.groupBoxKutya.TabIndex = 12;
            this.groupBoxKutya.TabStop = false;
            this.groupBoxKutya.Text = "Kutya adatai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 329);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.numericUpDownSuly);
            this.Controls.Add(this.labelSuly);
            this.Controls.Add(this.textBoxFajta);
            this.Controls.Add(this.labelFajta);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBoxKutyak);
            this.Controls.Add(this.groupBoxKutya);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSuly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxKutyak;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxFajta;
        private System.Windows.Forms.Label labelFajta;
        private System.Windows.Forms.Label labelSuly;
        private System.Windows.Forms.NumericUpDown numericUpDownSuly;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxKutya;
    }
}

