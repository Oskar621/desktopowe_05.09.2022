namespace whot
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
            this.dane_osobowe_groupbox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nazwisko_input = new System.Windows.Forms.TextBox();
            this.imie_input = new System.Windows.Forms.TextBox();
            this.miejsce_ur_input = new System.Windows.Forms.TextBox();
            this.data_ur_input = new System.Windows.Forms.MaskedTextBox();
            this.pesel_input = new System.Windows.Forms.MaskedTextBox();
            this.adres_kor_groupbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.kod_pocztowy_input = new System.Windows.Forms.MaskedTextBox();
            this.poczta_input = new System.Windows.Forms.TextBox();
            this.ulica_input = new System.Windows.Forms.TextBox();
            this.miejscowosc_input = new System.Windows.Forms.TextBox();
            this.nr_tel_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mail_input = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.termin_egzaminu_combobox = new System.Windows.Forms.ComboBox();
            this.informatyk_radiobutton = new System.Windows.Forms.RadioButton();
            this.programista_radiobutton = new System.Windows.Forms.RadioButton();
            this.egzamin_combobox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.podejscie_groupbox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dane_osobowe_groupbox.SuspendLayout();
            this.adres_kor_groupbox.SuspendLayout();
            this.podejscie_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(145, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEKLARACJA PRZYSTĄPIENIA DO EGZAMINU";
            // 
            // dane_osobowe_groupbox
            // 
            this.dane_osobowe_groupbox.Controls.Add(this.pesel_input);
            this.dane_osobowe_groupbox.Controls.Add(this.data_ur_input);
            this.dane_osobowe_groupbox.Controls.Add(this.miejsce_ur_input);
            this.dane_osobowe_groupbox.Controls.Add(this.imie_input);
            this.dane_osobowe_groupbox.Controls.Add(this.nazwisko_input);
            this.dane_osobowe_groupbox.Controls.Add(this.label4);
            this.dane_osobowe_groupbox.Controls.Add(this.label5);
            this.dane_osobowe_groupbox.Controls.Add(this.label3);
            this.dane_osobowe_groupbox.Controls.Add(this.label2);
            this.dane_osobowe_groupbox.Location = new System.Drawing.Point(52, 84);
            this.dane_osobowe_groupbox.Name = "dane_osobowe_groupbox";
            this.dane_osobowe_groupbox.Size = new System.Drawing.Size(411, 149);
            this.dane_osobowe_groupbox.TabIndex = 1;
            this.dane_osobowe_groupbox.TabStop = false;
            this.dane_osobowe_groupbox.Text = "Dane osobowe ucznia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Imię (imiona):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numer PESEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data i miejsce urodzenia:";
            // 
            // nazwisko_input
            // 
            this.nazwisko_input.Location = new System.Drawing.Point(141, 24);
            this.nazwisko_input.Name = "nazwisko_input";
            this.nazwisko_input.Size = new System.Drawing.Size(264, 20);
            this.nazwisko_input.TabIndex = 4;
            // 
            // imie_input
            // 
            this.imie_input.Location = new System.Drawing.Point(141, 52);
            this.imie_input.Name = "imie_input";
            this.imie_input.Size = new System.Drawing.Size(264, 20);
            this.imie_input.TabIndex = 5;
            // 
            // miejsce_ur_input
            // 
            this.miejsce_ur_input.Location = new System.Drawing.Point(217, 81);
            this.miejsce_ur_input.Name = "miejsce_ur_input";
            this.miejsce_ur_input.Size = new System.Drawing.Size(188, 20);
            this.miejsce_ur_input.TabIndex = 6;
            // 
            // data_ur_input
            // 
            this.data_ur_input.Location = new System.Drawing.Point(137, 81);
            this.data_ur_input.Mask = "00.00.0000";
            this.data_ur_input.Name = "data_ur_input";
            this.data_ur_input.Size = new System.Drawing.Size(62, 20);
            this.data_ur_input.TabIndex = 7;
            // 
            // pesel_input
            // 
            this.pesel_input.Location = new System.Drawing.Point(137, 115);
            this.pesel_input.Mask = "00000000000";
            this.pesel_input.Name = "pesel_input";
            this.pesel_input.Size = new System.Drawing.Size(73, 20);
            this.pesel_input.TabIndex = 8;
            // 
            // adres_kor_groupbox
            // 
            this.adres_kor_groupbox.Controls.Add(this.mail_input);
            this.adres_kor_groupbox.Controls.Add(this.label10);
            this.adres_kor_groupbox.Controls.Add(this.nr_tel_input);
            this.adres_kor_groupbox.Controls.Add(this.miejscowosc_input);
            this.adres_kor_groupbox.Controls.Add(this.ulica_input);
            this.adres_kor_groupbox.Controls.Add(this.poczta_input);
            this.adres_kor_groupbox.Controls.Add(this.kod_pocztowy_input);
            this.adres_kor_groupbox.Controls.Add(this.label9);
            this.adres_kor_groupbox.Controls.Add(this.label8);
            this.adres_kor_groupbox.Controls.Add(this.label7);
            this.adres_kor_groupbox.Controls.Add(this.label6);
            this.adres_kor_groupbox.Location = new System.Drawing.Point(52, 251);
            this.adres_kor_groupbox.Name = "adres_kor_groupbox";
            this.adres_kor_groupbox.Size = new System.Drawing.Size(411, 156);
            this.adres_kor_groupbox.TabIndex = 2;
            this.adres_kor_groupbox.TabStop = false;
            this.adres_kor_groupbox.Text = "Adres Korespondencyjny";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Miejscowość:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ulica i numer domu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kod pocztowy i poczta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Numer telefonu z kierunkowym:";
            // 
            // kod_pocztowy_input
            // 
            this.kod_pocztowy_input.Location = new System.Drawing.Point(126, 86);
            this.kod_pocztowy_input.Mask = "00-0000";
            this.kod_pocztowy_input.Name = "kod_pocztowy_input";
            this.kod_pocztowy_input.Size = new System.Drawing.Size(48, 20);
            this.kod_pocztowy_input.TabIndex = 9;
            // 
            // poczta_input
            // 
            this.poczta_input.Location = new System.Drawing.Point(198, 86);
            this.poczta_input.Name = "poczta_input";
            this.poczta_input.Size = new System.Drawing.Size(207, 20);
            this.poczta_input.TabIndex = 9;
            // 
            // ulica_input
            // 
            this.ulica_input.Location = new System.Drawing.Point(112, 55);
            this.ulica_input.Name = "ulica_input";
            this.ulica_input.Size = new System.Drawing.Size(293, 20);
            this.ulica_input.TabIndex = 10;
            // 
            // miejscowosc_input
            // 
            this.miejscowosc_input.Location = new System.Drawing.Point(110, 24);
            this.miejscowosc_input.Name = "miejscowosc_input";
            this.miejscowosc_input.Size = new System.Drawing.Size(295, 20);
            this.miejscowosc_input.TabIndex = 11;
            // 
            // nr_tel_input
            // 
            this.nr_tel_input.Location = new System.Drawing.Point(158, 119);
            this.nr_tel_input.Name = "nr_tel_input";
            this.nr_tel_input.Size = new System.Drawing.Size(93, 20);
            this.nr_tel_input.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "mail:";
            // 
            // mail_input
            // 
            this.mail_input.Location = new System.Drawing.Point(284, 119);
            this.mail_input.Name = "mail_input";
            this.mail_input.Size = new System.Drawing.Size(121, 20);
            this.mail_input.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label11.Location = new System.Drawing.Point(12, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(489, 32);
            this.label11.TabIndex = 3;
            this.label11.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie prze" +
    "prowadzonego w terminie";
            // 
            // termin_egzaminu_combobox
            // 
            this.termin_egzaminu_combobox.FormattingEnabled = true;
            this.termin_egzaminu_combobox.Items.AddRange(new object[] {
            "styczeń",
            "czerwiec"});
            this.termin_egzaminu_combobox.Location = new System.Drawing.Point(210, 430);
            this.termin_egzaminu_combobox.Name = "termin_egzaminu_combobox";
            this.termin_egzaminu_combobox.Size = new System.Drawing.Size(121, 21);
            this.termin_egzaminu_combobox.TabIndex = 4;
            // 
            // informatyk_radiobutton
            // 
            this.informatyk_radiobutton.AutoSize = true;
            this.informatyk_radiobutton.Location = new System.Drawing.Point(89, 457);
            this.informatyk_radiobutton.Name = "informatyk_radiobutton";
            this.informatyk_radiobutton.Size = new System.Drawing.Size(115, 17);
            this.informatyk_radiobutton.TabIndex = 5;
            this.informatyk_radiobutton.TabStop = true;
            this.informatyk_radiobutton.Text = "Technik informatyk";
            this.informatyk_radiobutton.UseVisualStyleBackColor = true;
            this.informatyk_radiobutton.CheckedChanged += new System.EventHandler(this.informatyk_radiobutton_CheckedChanged);
            // 
            // programista_radiobutton
            // 
            this.programista_radiobutton.AutoSize = true;
            this.programista_radiobutton.Location = new System.Drawing.Point(269, 457);
            this.programista_radiobutton.Name = "programista_radiobutton";
            this.programista_radiobutton.Size = new System.Drawing.Size(121, 17);
            this.programista_radiobutton.TabIndex = 6;
            this.programista_radiobutton.TabStop = true;
            this.programista_radiobutton.Text = "Technik programista";
            this.programista_radiobutton.UseVisualStyleBackColor = true;
            this.programista_radiobutton.CheckedChanged += new System.EventHandler(this.programista_radiobutton_CheckedChanged);
            // 
            // egzamin_combobox
            // 
            this.egzamin_combobox.FormattingEnabled = true;
            this.egzamin_combobox.Items.AddRange(new object[] {
            "INF 04.",
            "INF 03.",
            "INF 02."});
            this.egzamin_combobox.Location = new System.Drawing.Point(15, 500);
            this.egzamin_combobox.Name = "egzamin_combobox";
            this.egzamin_combobox.Size = new System.Drawing.Size(84, 21);
            this.egzamin_combobox.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(117, 503);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(252, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Projektowanie, programowanie i testowanie aplikacji";
            // 
            // podejscie_groupbox
            // 
            this.podejscie_groupbox.Controls.Add(this.checkBox2);
            this.podejscie_groupbox.Controls.Add(this.radioButton3);
            this.podejscie_groupbox.Controls.Add(this.checkBox1);
            this.podejscie_groupbox.Controls.Add(this.radioButton2);
            this.podejscie_groupbox.Location = new System.Drawing.Point(35, 538);
            this.podejscie_groupbox.Name = "podejscie_groupbox";
            this.podejscie_groupbox.Size = new System.Drawing.Size(428, 49);
            this.podejscie_groupbox.TabIndex = 9;
            this.podejscie_groupbox.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "po raz pierwszy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(117, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(141, 17);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "po raz kolejny do części:";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "pisemnej";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(350, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "praktycznej";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zatwierdź";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(671, 596);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Wyczyść";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(855, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 503);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.podejscie_groupbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.egzamin_combobox);
            this.Controls.Add(this.programista_radiobutton);
            this.Controls.Add(this.informatyk_radiobutton);
            this.Controls.Add(this.termin_egzaminu_combobox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.adres_kor_groupbox);
            this.Controls.Add(this.dane_osobowe_groupbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Deklaracja";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dane_osobowe_groupbox.ResumeLayout(false);
            this.dane_osobowe_groupbox.PerformLayout();
            this.adres_kor_groupbox.ResumeLayout(false);
            this.adres_kor_groupbox.PerformLayout();
            this.podejscie_groupbox.ResumeLayout(false);
            this.podejscie_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dane_osobowe_groupbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox data_ur_input;
        private System.Windows.Forms.TextBox miejsce_ur_input;
        private System.Windows.Forms.TextBox imie_input;
        private System.Windows.Forms.TextBox nazwisko_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox pesel_input;
        private System.Windows.Forms.GroupBox adres_kor_groupbox;
        private System.Windows.Forms.TextBox mail_input;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nr_tel_input;
        private System.Windows.Forms.TextBox miejscowosc_input;
        private System.Windows.Forms.TextBox ulica_input;
        private System.Windows.Forms.TextBox poczta_input;
        private System.Windows.Forms.MaskedTextBox kod_pocztowy_input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox termin_egzaminu_combobox;
        private System.Windows.Forms.RadioButton informatyk_radiobutton;
        private System.Windows.Forms.RadioButton programista_radiobutton;
        private System.Windows.Forms.ComboBox egzamin_combobox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox podejscie_groupbox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

