
namespace Deklaracja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pesel = new System.Windows.Forms.TextBox();
            this.placeofbrith = new System.Windows.Forms.TextBox();
            this.dateofbirth = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.postoffice = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.town = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listofterms = new System.Windows.Forms.ComboBox();
            this.computerspecialist = new System.Windows.Forms.RadioButton();
            this.programmer = new System.Windows.Forms.RadioButton();
            this.qualifications = new System.Windows.Forms.ComboBox();
            this.changetext = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.RadioButton();
            this.second = new System.Windows.Forms.RadioButton();
            this.written = new System.Windows.Forms.CheckBox();
            this.practice = new System.Windows.Forms.CheckBox();
            this.viewtext = new System.Windows.Forms.RichTextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(102, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesel);
            this.groupBox1.Controls.Add(this.placeofbrith);
            this.groupBox1.Controls.Add(this.dateofbirth);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.lastname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(44, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane osobowe ucznia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pesel
            // 
            this.pesel.Location = new System.Drawing.Point(187, 101);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(101, 20);
            this.pesel.TabIndex = 8;
            // 
            // placeofbrith
            // 
            this.placeofbrith.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.placeofbrith.Location = new System.Drawing.Point(297, 74);
            this.placeofbrith.Name = "placeofbrith";
            this.placeofbrith.Size = new System.Drawing.Size(194, 20);
            this.placeofbrith.TabIndex = 7;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Location = new System.Drawing.Point(187, 75);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(88, 20);
            this.dateofbirth.TabIndex = 6;
            // 
            // name
            // 
            this.name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.name.Location = new System.Drawing.Point(186, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(305, 20);
            this.name.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastname.Location = new System.Drawing.Point(186, 19);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(305, 20);
            this.lastname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numer PESEL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data i miejsce urodzenia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imię (imiona):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.phonenumber);
            this.groupBox2.Controls.Add(this.postoffice);
            this.groupBox2.Controls.Add(this.code);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.town);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(44, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adres korespondencyjny";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(358, 106);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(134, 20);
            this.email.TabIndex = 12;
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(187, 106);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(126, 20);
            this.phonenumber.TabIndex = 11;
            // 
            // postoffice
            // 
            this.postoffice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.postoffice.Location = new System.Drawing.Point(272, 76);
            this.postoffice.Name = "postoffice";
            this.postoffice.Size = new System.Drawing.Size(219, 20);
            this.postoffice.TabIndex = 10;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(187, 77);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(60, 20);
            this.code.TabIndex = 9;
            // 
            // address
            // 
            this.address.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.address.Location = new System.Drawing.Point(186, 50);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(305, 20);
            this.address.TabIndex = 8;
            // 
            // town
            // 
            this.town.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.town.Location = new System.Drawing.Point(186, 25);
            this.town.Name = "town";
            this.town.Size = new System.Drawing.Size(305, 20);
            this.town.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "nr telefonu z kierunkowym:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "kod pocztowy i poczta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ulica i numer domu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "miejscowość:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(70, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(457, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(116, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "przeprowadzanego w terminie";
            // 
            // listofterms
            // 
            this.listofterms.FormattingEnabled = true;
            this.listofterms.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.listofterms.Location = new System.Drawing.Point(306, 432);
            this.listofterms.Name = "listofterms";
            this.listofterms.Size = new System.Drawing.Size(121, 21);
            this.listofterms.TabIndex = 5;
            // 
            // computerspecialist
            // 
            this.computerspecialist.AutoSize = true;
            this.computerspecialist.Location = new System.Drawing.Point(61, 19);
            this.computerspecialist.Name = "computerspecialist";
            this.computerspecialist.Size = new System.Drawing.Size(111, 17);
            this.computerspecialist.TabIndex = 6;
            this.computerspecialist.TabStop = true;
            this.computerspecialist.Text = "technik informatyk";
            this.computerspecialist.UseVisualStyleBackColor = true;
            this.computerspecialist.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // programmer
            // 
            this.programmer.AutoSize = true;
            this.programmer.Location = new System.Drawing.Point(247, 19);
            this.programmer.Name = "programmer";
            this.programmer.Size = new System.Drawing.Size(117, 17);
            this.programmer.TabIndex = 7;
            this.programmer.TabStop = true;
            this.programmer.Text = "technik programista";
            this.programmer.UseVisualStyleBackColor = true;
            this.programmer.CheckedChanged += new System.EventHandler(this.programmer_CheckedChanged);
            // 
            // qualifications
            // 
            this.qualifications.FormattingEnabled = true;
            this.qualifications.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.qualifications.Location = new System.Drawing.Point(44, 514);
            this.qualifications.Name = "qualifications";
            this.qualifications.Size = new System.Drawing.Size(91, 21);
            this.qualifications.TabIndex = 8;
            // 
            // changetext
            // 
            this.changetext.AutoSize = true;
            this.changetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changetext.Location = new System.Drawing.Point(152, 517);
            this.changetext.Name = "changetext";
            this.changetext.Size = new System.Drawing.Size(0, 13);
            this.changetext.TabIndex = 9;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.first.Location = new System.Drawing.Point(11, 13);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(112, 17);
            this.first.TabIndex = 10;
            this.first.TabStop = true;
            this.first.Text = "po raz pierwszy";
            this.first.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.second.Location = new System.Drawing.Point(137, 13);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(162, 17);
            this.second.TabIndex = 11;
            this.second.TabStop = true;
            this.second.Text = "po raz kolejny do części";
            this.second.UseVisualStyleBackColor = true;
            // 
            // written
            // 
            this.written.AutoSize = true;
            this.written.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.written.Location = new System.Drawing.Point(380, 555);
            this.written.Name = "written";
            this.written.Size = new System.Drawing.Size(79, 17);
            this.written.TabIndex = 12;
            this.written.Text = "pisemnej,";
            this.written.UseVisualStyleBackColor = true;
            // 
            // practice
            // 
            this.practice.AutoSize = true;
            this.practice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.practice.Location = new System.Drawing.Point(465, 555);
            this.practice.Name = "practice";
            this.practice.Size = new System.Drawing.Size(91, 17);
            this.practice.TabIndex = 13;
            this.practice.Text = "praktycznej";
            this.practice.UseVisualStyleBackColor = true;
            // 
            // viewtext
            // 
            this.viewtext.Location = new System.Drawing.Point(618, 24);
            this.viewtext.Name = "viewtext";
            this.viewtext.Size = new System.Drawing.Size(407, 548);
            this.viewtext.TabIndex = 14;
            this.viewtext.Text = "";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(386, 596);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(175, 23);
            this.confirm.TabIndex = 15;
            this.confirm.Text = "Zatwierdź";
            this.confirm.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(618, 596);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(200, 23);
            this.clear.TabIndex = 16;
            this.clear.Text = "Wyczyść";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(836, 596);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(189, 23);
            this.save.TabIndex = 17;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.computerspecialist);
            this.groupBox3.Controls.Add(this.programmer);
            this.groupBox3.Location = new System.Drawing.Point(73, 459);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 49);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.first);
            this.groupBox4.Controls.Add(this.second);
            this.groupBox4.Location = new System.Drawing.Point(33, 541);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 41);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.viewtext);
            this.Controls.Add(this.practice);
            this.Controls.Add(this.written);
            this.Controls.Add(this.changetext);
            this.Controls.Add(this.qualifications);
            this.Controls.Add(this.listofterms);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Deklaracja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.TextBox placeofbrith;
        private System.Windows.Forms.TextBox dateofbirth;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.TextBox postoffice;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox town;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox listofterms;
        private System.Windows.Forms.RadioButton computerspecialist;
        private System.Windows.Forms.RadioButton programmer;
        private System.Windows.Forms.ComboBox qualifications;
        private System.Windows.Forms.Label changetext;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton second;
        private System.Windows.Forms.CheckBox written;
        private System.Windows.Forms.CheckBox practice;
        private System.Windows.Forms.RichTextBox viewtext;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

