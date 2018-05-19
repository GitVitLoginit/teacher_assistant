namespace MilitaryUnits
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
        /// </summary>yyyyy
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TnumberOfUnits = new System.Windows.Forms.TextBox();
            this.TpostOfCommander = new System.Windows.Forms.TextBox();
            this.TtypeOfArmy = new System.Windows.Forms.TextBox();
            this.Ttask = new System.Windows.Forms.TextBox();
            this.Tstaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Binary = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.XML = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonAdapter = new System.Windows.Forms.Button();
            this.buttonDecorator = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Detachment",
            "Platoon",
            "Company",
            "Battalion",
            "Regiment"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 46);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(155, 109);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select army formation and confirm";
            // 
            // TnumberOfUnits
            // 
            this.TnumberOfUnits.Location = new System.Drawing.Point(330, 46);
            this.TnumberOfUnits.Name = "TnumberOfUnits";
            this.TnumberOfUnits.Size = new System.Drawing.Size(135, 20);
            this.TnumberOfUnits.TabIndex = 3;
            this.TnumberOfUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TnumberOfUnits_KeyPress);
            // 
            // TpostOfCommander
            // 
            this.TpostOfCommander.Location = new System.Drawing.Point(330, 72);
            this.TpostOfCommander.Name = "TpostOfCommander";
            this.TpostOfCommander.Size = new System.Drawing.Size(135, 20);
            this.TpostOfCommander.TabIndex = 4;
            // 
            // TtypeOfArmy
            // 
            this.TtypeOfArmy.Location = new System.Drawing.Point(330, 98);
            this.TtypeOfArmy.Name = "TtypeOfArmy";
            this.TtypeOfArmy.Size = new System.Drawing.Size(135, 20);
            this.TtypeOfArmy.TabIndex = 5;
            // 
            // Ttask
            // 
            this.Ttask.Location = new System.Drawing.Point(330, 124);
            this.Ttask.Name = "Ttask";
            this.Ttask.Size = new System.Drawing.Size(135, 20);
            this.Ttask.TabIndex = 6;
            // 
            // Tstaff
            // 
            this.Tstaff.Location = new System.Drawing.Point(330, 150);
            this.Tstaff.Name = "Tstaff";
            this.Tstaff.Size = new System.Drawing.Size(135, 20);
            this.Tstaff.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(187, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number of units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(189, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Staff";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Task";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(187, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type of army";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(187, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Post of commander";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(485, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(513, 173);
            this.listBox1.TabIndex = 17;
            // 
            // Binary
            // 
            this.Binary.AutoSize = true;
            this.Binary.Location = new System.Drawing.Point(42, 295);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(53, 17);
            this.Binary.TabIndex = 20;
            this.Binary.TabStop = true;
            this.Binary.Text = "binary";
            this.Binary.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(151, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Ser";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(151, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 23;
            this.button7.Text = "Dec";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // XML
            // 
            this.XML.AutoSize = true;
            this.XML.Location = new System.Drawing.Point(42, 346);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(47, 17);
            this.XML.TabIndex = 24;
            this.XML.TabStop = true;
            this.XML.Text = "XML";
            this.XML.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "SerWithChange";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 343);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(176, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "DecWithChange";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonAdapter
            // 
            this.buttonAdapter.Location = new System.Drawing.Point(299, 309);
            this.buttonAdapter.Name = "buttonAdapter";
            this.buttonAdapter.Size = new System.Drawing.Size(94, 23);
            this.buttonAdapter.TabIndex = 27;
            this.buttonAdapter.Text = "Боевой клич";
            this.buttonAdapter.UseVisualStyleBackColor = true;
            this.buttonAdapter.Click += new System.EventHandler(this.buttonAdapter_Click);
            // 
            // buttonDecorator
            // 
            this.buttonDecorator.Location = new System.Drawing.Point(299, 346);
            this.buttonDecorator.Name = "buttonDecorator";
            this.buttonDecorator.Size = new System.Drawing.Size(94, 23);
            this.buttonDecorator.TabIndex = 28;
            this.buttonDecorator.Text = "Боевая сила";
            this.buttonDecorator.UseVisualStyleBackColor = true;
            this.buttonDecorator.Click += new System.EventHandler(this.buttonDecorator_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(299, 387);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(94, 23);
            this.buttonCommand.TabIndex = 29;
            this.buttonCommand.Text = "Рассчитайтесь";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 432);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.buttonDecorator);
            this.Controls.Add(this.buttonAdapter);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tstaff);
            this.Controls.Add(this.Ttask);
            this.Controls.Add(this.TtypeOfArmy);
            this.Controls.Add(this.TpostOfCommander);
            this.Controls.Add(this.TnumberOfUnits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void mainFunc()
        {

        }


        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TnumberOfUnits;
        private System.Windows.Forms.TextBox TpostOfCommander;
        private System.Windows.Forms.TextBox TtypeOfArmy;
        private System.Windows.Forms.TextBox Ttask;
        private System.Windows.Forms.TextBox Tstaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton Binary;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton XML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonAdapter;
        private System.Windows.Forms.Button buttonDecorator;
        private System.Windows.Forms.Button buttonCommand;
    }
}

