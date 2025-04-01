namespace SportTeamsForm
{
    partial class Form1
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            view = new TabPage();
            viewOne = new TabPage();
            EditById = new TabPage();
            EditName = new TabPage();
            EditCount = new TabPage();
            EditProfessional = new TabPage();
            AddTeam = new TabPage();
            DeleteTeam = new TabPage();
            viewAllBtn = new Button();
            viewOneBtn = new Button();
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            EditIdBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            CancelBtn = new Button();
            textBox1 = new TextBox();
            numericUpDown3 = new NumericUpDown();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            NameNextBtn = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            numericUpDown4 = new NumericUpDown();
            button5 = new Button();
            label11 = new Label();
            label12 = new Label();
            button6 = new Button();
            numericUpDown5 = new NumericUpDown();
            button7 = new Button();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tabControl1.SuspendLayout();
            viewOne.SuspendLayout();
            EditById.SuspendLayout();
            EditName.SuspendLayout();
            EditCount.SuspendLayout();
            AddTeam.SuspendLayout();
            DeleteTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(deleteBtn);
            splitContainer1.Panel1.Controls.Add(editBtn);
            splitContainer1.Panel1.Controls.Add(addBtn);
            splitContainer1.Panel1.Controls.Add(viewOneBtn);
            splitContainer1.Panel1.Controls.Add(viewAllBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(613, 439);
            splitContainer1.SplitterDistance = 125;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(tabControl1);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(484, 439);
            splitContainer2.SplitterDistance = 257;
            splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(484, 259);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(view);
            tabControl1.Controls.Add(viewOne);
            tabControl1.Controls.Add(EditById);
            tabControl1.Controls.Add(EditName);
            tabControl1.Controls.Add(EditCount);
            tabControl1.Controls.Add(EditProfessional);
            tabControl1.Controls.Add(AddTeam);
            tabControl1.Controls.Add(DeleteTeam);
            tabControl1.Location = new Point(3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(478, 171);
            tabControl1.TabIndex = 0;
            // 
            // view
            // 
            view.Location = new Point(4, 24);
            view.Name = "view";
            view.Padding = new Padding(3);
            view.Size = new Size(470, 143);
            view.TabIndex = 0;
            view.Text = "view";
            view.UseVisualStyleBackColor = true;
            // 
            // viewOne
            // 
            viewOne.Controls.Add(numericUpDown2);
            viewOne.Controls.Add(button1);
            viewOne.Controls.Add(label3);
            viewOne.Controls.Add(label4);
            viewOne.Location = new Point(4, 24);
            viewOne.Name = "viewOne";
            viewOne.Padding = new Padding(3);
            viewOne.Size = new Size(470, 143);
            viewOne.TabIndex = 1;
            viewOne.Text = "viewOne";
            viewOne.UseVisualStyleBackColor = true;
            // 
            // EditById
            // 
            EditById.Controls.Add(CancelBtn);
            EditById.Controls.Add(numericUpDown1);
            EditById.Controls.Add(EditIdBtn);
            EditById.Controls.Add(label2);
            EditById.Controls.Add(label1);
            EditById.Location = new Point(4, 24);
            EditById.Name = "EditById";
            EditById.Size = new Size(470, 143);
            EditById.TabIndex = 3;
            EditById.Text = "EditId";
            EditById.UseVisualStyleBackColor = true;
            // 
            // EditName
            // 
            EditName.Controls.Add(textBox2);
            EditName.Controls.Add(button3);
            EditName.Controls.Add(NameNextBtn);
            EditName.Controls.Add(label9);
            EditName.Controls.Add(label10);
            EditName.Location = new Point(4, 24);
            EditName.Name = "EditName";
            EditName.Size = new Size(470, 143);
            EditName.TabIndex = 4;
            EditName.Text = "EditName";
            EditName.UseVisualStyleBackColor = true;
            // 
            // EditCount
            // 
            EditCount.Controls.Add(button4);
            EditCount.Controls.Add(numericUpDown4);
            EditCount.Controls.Add(button5);
            EditCount.Controls.Add(label11);
            EditCount.Controls.Add(label12);
            EditCount.Location = new Point(4, 24);
            EditCount.Name = "EditCount";
            EditCount.Size = new Size(470, 143);
            EditCount.TabIndex = 5;
            EditCount.Text = "EditCount";
            EditCount.UseVisualStyleBackColor = true;
            // 
            // EditProfessional
            // 
            EditProfessional.Location = new Point(4, 24);
            EditProfessional.Name = "EditProfessional";
            EditProfessional.Size = new Size(470, 143);
            EditProfessional.TabIndex = 6;
            EditProfessional.Text = "EditProfessional";
            EditProfessional.UseVisualStyleBackColor = true;
            // 
            // AddTeam
            // 
            AddTeam.Controls.Add(label8);
            AddTeam.Controls.Add(label7);
            AddTeam.Controls.Add(label6);
            AddTeam.Controls.Add(label5);
            AddTeam.Controls.Add(button2);
            AddTeam.Controls.Add(checkBox1);
            AddTeam.Controls.Add(numericUpDown3);
            AddTeam.Controls.Add(textBox1);
            AddTeam.Location = new Point(4, 24);
            AddTeam.Name = "AddTeam";
            AddTeam.Size = new Size(470, 143);
            AddTeam.TabIndex = 7;
            AddTeam.Text = "AddTeam";
            AddTeam.UseVisualStyleBackColor = true;
            // 
            // DeleteTeam
            // 
            DeleteTeam.Controls.Add(button6);
            DeleteTeam.Controls.Add(numericUpDown5);
            DeleteTeam.Controls.Add(button7);
            DeleteTeam.Controls.Add(label13);
            DeleteTeam.Controls.Add(label14);
            DeleteTeam.Location = new Point(4, 24);
            DeleteTeam.Name = "DeleteTeam";
            DeleteTeam.Size = new Size(470, 143);
            DeleteTeam.TabIndex = 8;
            DeleteTeam.Text = "DeleteTeam";
            DeleteTeam.UseVisualStyleBackColor = true;
            // 
            // viewAllBtn
            // 
            viewAllBtn.Location = new Point(7, 21);
            viewAllBtn.Name = "viewAllBtn";
            viewAllBtn.Size = new Size(110, 35);
            viewAllBtn.TabIndex = 0;
            viewAllBtn.Text = "просмотреть все";
            viewAllBtn.UseVisualStyleBackColor = true;
            viewAllBtn.Click += button1_Click;
            // 
            // viewOneBtn
            // 
            viewOneBtn.Location = new Point(7, 62);
            viewOneBtn.Name = "viewOneBtn";
            viewOneBtn.Size = new Size(110, 38);
            viewOneBtn.TabIndex = 1;
            viewOneBtn.Text = "просмотреть один";
            viewOneBtn.UseVisualStyleBackColor = true;
            viewOneBtn.Click += button2_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(7, 106);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(110, 31);
            addBtn.TabIndex = 2;
            addBtn.Text = "добавить";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(7, 143);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(110, 30);
            editBtn.TabIndex = 3;
            editBtn.Text = "редактировать";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(7, 179);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(110, 30);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(128, 56);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(389, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "поиск";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 58);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 6;
            label3.Text = "введите id команды";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 5);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 5;
            label4.Text = "поиск команды";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(128, 56);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // EditIdBtn
            // 
            EditIdBtn.Location = new Point(389, 115);
            EditIdBtn.Name = "EditIdBtn";
            EditIdBtn.Size = new Size(75, 23);
            EditIdBtn.TabIndex = 7;
            EditIdBtn.Text = "поиск";
            EditIdBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 58);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 6;
            label2.Text = "введите id команды";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 5;
            label1.Text = "редактор команд";
            label1.Click += label1_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(308, 115);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "отмена";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(128, 53);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(161, 23);
            numericUpDown3.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(129, 82);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(189, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "комакнда профессиональная";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(390, 115);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 4;
            label5.Text = "добавить команду";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 27);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 5;
            label6.Text = "название команды";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 55);
            label7.Name = "label7";
            label7.Size = new Size(119, 15);
            label7.TabIndex = 6;
            label7.Text = "количество игроков";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 82);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(308, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "отмена";
            button3.UseVisualStyleBackColor = true;
            // 
            // NameNextBtn
            // 
            NameNextBtn.Location = new Point(389, 115);
            NameNextBtn.Name = "NameNextBtn";
            NameNextBtn.Size = new Size(75, 23);
            NameNextBtn.TabIndex = 12;
            NameNextBtn.Text = "далее";
            NameNextBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 58);
            label9.Name = "label9";
            label9.Size = new Size(163, 15);
            label9.TabIndex = 11;
            label9.Text = "введите новое имя команды";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 5);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 10;
            label10.Text = "изменить имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 15;
            // 
            // button4
            // 
            button4.Location = new Point(308, 115);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 14;
            button4.Text = "отмена";
            button4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(213, 56);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(120, 23);
            numericUpDown4.TabIndex = 13;
            // 
            // button5
            // 
            button5.Location = new Point(389, 115);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "поиск";
            button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 58);
            label11.Name = "label11";
            label11.Size = new Size(200, 15);
            label11.TabIndex = 11;
            label11.Text = "введите новое количество игроков";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 5);
            label12.Name = "label12";
            label12.Size = new Size(174, 15);
            label12.TabIndex = 10;
            label12.Text = "изменить количество игроков";
            // 
            // button6
            // 
            button6.Location = new Point(308, 115);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 14;
            button6.Text = "отмена";
            button6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(128, 56);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(120, 23);
            numericUpDown5.TabIndex = 13;
            // 
            // button7
            // 
            button7.Location = new Point(389, 115);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 12;
            button7.Text = "поиск";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 58);
            label13.Name = "label13";
            label13.Size = new Size(115, 15);
            label13.TabIndex = 11;
            label13.Text = "введите id команды";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(7, 5);
            label14.Name = "label14";
            label14.Size = new Size(101, 15);
            label14.TabIndex = 10;
            label14.Text = "редактор команд";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 439);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            viewOne.ResumeLayout(false);
            viewOne.PerformLayout();
            EditById.ResumeLayout(false);
            EditById.PerformLayout();
            EditName.ResumeLayout(false);
            EditName.PerformLayout();
            EditCount.ResumeLayout(false);
            EditCount.PerformLayout();
            AddTeam.ResumeLayout(false);
            AddTeam.PerformLayout();
            DeleteTeam.ResumeLayout(false);
            DeleteTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListBox listBox1;
        private TabControl tabControl1;
        private TabPage view;
        private TabPage viewOne;
        private TabPage EditById;
        private TabPage EditName;
        private TabPage EditCount;
        private TabPage EditProfessional;
        private TabPage AddTeam;
        private TabPage DeleteTeam;
        private Button viewAllBtn;
        private Button button6;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private Button viewOneBtn;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Button EditIdBtn;
        private Label label2;
        private Label label1;
        private Button CancelBtn;
        private Label label5;
        private Button button2;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown3;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Button button3;
        private Button NameNextBtn;
        private Label label9;
        private Label label10;
        private Label label8;
        private TextBox textBox2;
        private Button button4;
        private NumericUpDown numericUpDown4;
        private Button button5;
        private Label label11;
        private Label label12;
        private NumericUpDown numericUpDown5;
        private Button button7;
        private Label label13;
        private Label label14;
    }
}
