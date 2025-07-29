namespace _4lr
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
            number_labo = new Label();
            bytesLabo = new Label();
            pmLabo = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numberTB = new TextBox();
            bytes = new TextBox();
            generateButton = new Button();
            button1 = new Button();
            roundsTB = new TextBox();
            fermaViewTB = new TextBox();
            fermaTimeTB = new TextBox();
            rabinViewTB = new TextBox();
            rabinTimeTB = new TextBox();
            detViewTB = new TextBox();
            detTimeTB = new TextBox();
            warning = new Label();
            ccText = new TextBox();
            label1 = new Label();
            cc2 = new RadioButton();
            cc16 = new RadioButton();
            rootsText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rootFindTime = new TextBox();
            AliceBox = new GroupBox();
            secretKey1 = new TextBox();
            aliceGeneralTb = new TextBox();
            aliceSecretTb = new TextBox();
            aliceGeneralNum = new Label();
            alicePrivateNum = new Label();
            labo123 = new Label();
            button2 = new Button();
            BobBox = new GroupBox();
            secretKey2 = new TextBox();
            bobGeneralTb = new TextBox();
            bobSecretTb = new TextBox();
            bobGeneralNum = new Label();
            bobPrivateNum = new Label();
            labo321 = new Label();
            button3 = new Button();
            diffieHellmanBtn = new Button();
            gLabo = new Label();
            AliceBox.SuspendLayout();
            BobBox.SuspendLayout();
            SuspendLayout();
            // 
            // number_labo
            // 
            number_labo.AutoSize = true;
            number_labo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            number_labo.Location = new Point(152, 13);
            number_labo.Margin = new Padding(5, 0, 5, 0);
            number_labo.Name = "number_labo";
            number_labo.Size = new Size(130, 28);
            number_labo.TabIndex = 0;
            number_labo.Text = "Число в 10сс";
            // 
            // bytesLabo
            // 
            bytesLabo.AutoSize = true;
            bytesLabo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            bytesLabo.Location = new Point(525, 85);
            bytesLabo.Margin = new Padding(5, 0, 5, 0);
            bytesLabo.Name = "bytesLabo";
            bytesLabo.Size = new Size(67, 28);
            bytesLabo.TabIndex = 1;
            bytesLabo.Text = "Байты";
            // 
            // pmLabo
            // 
            pmLabo.AutoSize = true;
            pmLabo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pmLabo.Location = new Point(504, 13);
            pmLabo.Margin = new Padding(5, 0, 5, 0);
            pmLabo.Name = "pmLabo";
            pmLabo.Size = new Size(105, 28);
            pmLabo.TabIndex = 2;
            pmLabo.Text = "Проверки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 367);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 3;
            label4.Text = "Тест Ферма";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 437);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 28);
            label5.TabIndex = 4;
            label5.Text = "Тест Рабина-Миллера";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 519);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(224, 28);
            label6.TabIndex = 5;
            label6.Text = "Тест теории делимости";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(789, 326);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 28);
            label7.TabIndex = 6;
            label7.Text = "Время";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(388, 326);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 28);
            label8.TabIndex = 7;
            label8.Text = "Вид Числа";
            // 
            // numberTB
            // 
            numberTB.Location = new Point(98, 46);
            numberTB.Margin = new Padding(5);
            numberTB.Name = "numberTB";
            numberTB.Size = new Size(264, 34);
            numberTB.TabIndex = 8;
            // 
            // bytes
            // 
            bytes.Location = new Point(436, 113);
            bytes.Margin = new Padding(5);
            bytes.Name = "bytes";
            bytes.Size = new Size(275, 34);
            bytes.TabIndex = 8;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(128, 202);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(215, 59);
            generateButton.TabIndex = 9;
            generateButton.Text = "Генерировать";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Location = new Point(463, 197);
            button1.Name = "button1";
            button1.Size = new Size(215, 64);
            button1.TabIndex = 9;
            button1.Text = "Проверить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // roundsTB
            // 
            roundsTB.Location = new Point(436, 46);
            roundsTB.Margin = new Padding(5);
            roundsTB.Name = "roundsTB";
            roundsTB.Size = new Size(275, 34);
            roundsTB.TabIndex = 8;
            // 
            // fermaViewTB
            // 
            fermaViewTB.Location = new Point(300, 364);
            fermaViewTB.Name = "fermaViewTB";
            fermaViewTB.Size = new Size(326, 34);
            fermaViewTB.TabIndex = 10;
            fermaViewTB.TextAlign = HorizontalAlignment.Center;
            // 
            // fermaTimeTB
            // 
            fermaTimeTB.Location = new Point(682, 364);
            fermaTimeTB.Name = "fermaTimeTB";
            fermaTimeTB.Size = new Size(304, 34);
            fermaTimeTB.TabIndex = 10;
            // 
            // rabinViewTB
            // 
            rabinViewTB.Location = new Point(300, 434);
            rabinViewTB.Name = "rabinViewTB";
            rabinViewTB.Size = new Size(326, 34);
            rabinViewTB.TabIndex = 10;
            rabinViewTB.TextAlign = HorizontalAlignment.Center;
            // 
            // rabinTimeTB
            // 
            rabinTimeTB.Location = new Point(682, 437);
            rabinTimeTB.Name = "rabinTimeTB";
            rabinTimeTB.Size = new Size(304, 34);
            rabinTimeTB.TabIndex = 10;
            // 
            // detViewTB
            // 
            detViewTB.Location = new Point(300, 516);
            detViewTB.Name = "detViewTB";
            detViewTB.Size = new Size(326, 34);
            detViewTB.TabIndex = 10;
            detViewTB.TextAlign = HorizontalAlignment.Center;
            // 
            // detTimeTB
            // 
            detTimeTB.Location = new Point(682, 519);
            detTimeTB.Name = "detTimeTB";
            detTimeTB.Size = new Size(304, 34);
            detTimeTB.TabIndex = 10;
            // 
            // warning
            // 
            warning.AutoSize = true;
            warning.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            warning.ForeColor = Color.Maroon;
            warning.Location = new Point(33, 562);
            warning.Margin = new Padding(5, 0, 5, 0);
            warning.Name = "warning";
            warning.Size = new Size(0, 28);
            warning.TabIndex = 2;
            // 
            // ccText
            // 
            ccText.Location = new Point(100, 113);
            ccText.Name = "ccText";
            ccText.Size = new Size(262, 34);
            ccText.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(128, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(205, 28);
            label1.TabIndex = 0;
            label1.Text = "Запись в указаной сс";
            // 
            // cc2
            // 
            cc2.AutoSize = true;
            cc2.Location = new Point(152, 153);
            cc2.Name = "cc2";
            cc2.Size = new Size(59, 32);
            cc2.TabIndex = 12;
            cc2.TabStop = true;
            cc2.Text = "2cc";
            cc2.UseVisualStyleBackColor = true;
            // 
            // cc16
            // 
            cc16.AutoSize = true;
            cc16.Location = new Point(230, 153);
            cc16.Name = "cc16";
            cc16.Size = new Size(70, 32);
            cc16.TabIndex = 14;
            cc16.TabStop = true;
            cc16.Text = "16cc";
            cc16.UseVisualStyleBackColor = true;
            // 
            // rootsText
            // 
            rootsText.Location = new Point(1101, 46);
            rootsText.Multiline = true;
            rootsText.Name = "rootsText";
            rootsText.Size = new Size(317, 454);
            rootsText.TabIndex = 15;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.HelpBalloon;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1140, 13);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 28);
            label2.TabIndex = 1;
            label2.Text = "Первообразные корни";
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.HelpBalloon;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1101, 522);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 1;
            label3.Text = "Время:";
            // 
            // rootFindTime
            // 
            rootFindTime.Location = new Point(1193, 519);
            rootFindTime.Name = "rootFindTime";
            rootFindTime.Size = new Size(225, 34);
            rootFindTime.TabIndex = 16;
            // 
            // AliceBox
            // 
            AliceBox.Controls.Add(secretKey1);
            AliceBox.Controls.Add(aliceGeneralTb);
            AliceBox.Controls.Add(aliceSecretTb);
            AliceBox.Controls.Add(aliceGeneralNum);
            AliceBox.Controls.Add(alicePrivateNum);
            AliceBox.Controls.Add(labo123);
            AliceBox.Controls.Add(button2);
            AliceBox.Location = new Point(29, 645);
            AliceBox.Name = "AliceBox";
            AliceBox.Size = new Size(537, 292);
            AliceBox.TabIndex = 17;
            AliceBox.TabStop = false;
            AliceBox.Text = "Алиса";
            // 
            // secretKey1
            // 
            secretKey1.Location = new Point(271, 242);
            secretKey1.Name = "secretKey1";
            secretKey1.Size = new Size(236, 34);
            secretKey1.TabIndex = 3;
            // 
            // aliceGeneralTb
            // 
            aliceGeneralTb.Location = new Point(271, 185);
            aliceGeneralTb.Name = "aliceGeneralTb";
            aliceGeneralTb.Size = new Size(236, 34);
            aliceGeneralTb.TabIndex = 3;
            // 
            // aliceSecretTb
            // 
            aliceSecretTb.Location = new Point(271, 65);
            aliceSecretTb.Name = "aliceSecretTb";
            aliceSecretTb.Size = new Size(236, 34);
            aliceSecretTb.TabIndex = 3;
            // 
            // aliceGeneralNum
            // 
            aliceGeneralNum.AutoSize = true;
            aliceGeneralNum.Location = new Point(26, 185);
            aliceGeneralNum.Name = "aliceGeneralNum";
            aliceGeneralNum.Size = new Size(199, 28);
            aliceGeneralNum.TabIndex = 2;
            aliceGeneralNum.Text = "Общее число Алисы";
            // 
            // alicePrivateNum
            // 
            alicePrivateNum.AutoSize = true;
            alicePrivateNum.Location = new Point(26, 65);
            alicePrivateNum.Name = "alicePrivateNum";
            alicePrivateNum.Size = new Size(232, 28);
            alicePrivateNum.TabIndex = 1;
            alicePrivateNum.Text = "Секретное число Алисы";
            // 
            // labo123
            // 
            labo123.AutoSize = true;
            labo123.Location = new Point(26, 248);
            labo123.Name = "labo123";
            labo123.Size = new Size(165, 28);
            labo123.TabIndex = 0;
            labo123.Text = "Секретный ключ";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(325, 96);
            button2.Name = "button2";
            button2.Size = new Size(130, 37);
            button2.TabIndex = 9;
            button2.Text = "Генерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Alice_Click;
            // 
            // BobBox
            // 
            BobBox.Controls.Add(secretKey2);
            BobBox.Controls.Add(bobGeneralTb);
            BobBox.Controls.Add(bobSecretTb);
            BobBox.Controls.Add(bobGeneralNum);
            BobBox.Controls.Add(bobPrivateNum);
            BobBox.Controls.Add(labo321);
            BobBox.Controls.Add(button3);
            BobBox.Location = new Point(881, 645);
            BobBox.Name = "BobBox";
            BobBox.Size = new Size(537, 292);
            BobBox.TabIndex = 17;
            BobBox.TabStop = false;
            BobBox.Text = "Боб";
            // 
            // secretKey2
            // 
            secretKey2.Location = new Point(275, 245);
            secretKey2.Name = "secretKey2";
            secretKey2.Size = new Size(223, 34);
            secretKey2.TabIndex = 3;
            // 
            // bobGeneralTb
            // 
            bobGeneralTb.Location = new Point(275, 179);
            bobGeneralTb.Name = "bobGeneralTb";
            bobGeneralTb.Size = new Size(223, 34);
            bobGeneralTb.TabIndex = 3;
            // 
            // bobSecretTb
            // 
            bobSecretTb.Location = new Point(275, 65);
            bobSecretTb.Name = "bobSecretTb";
            bobSecretTb.Size = new Size(223, 34);
            bobSecretTb.TabIndex = 3;
            // 
            // bobGeneralNum
            // 
            bobGeneralNum.AutoSize = true;
            bobGeneralNum.Location = new Point(40, 185);
            bobGeneralNum.Name = "bobGeneralNum";
            bobGeneralNum.Size = new Size(185, 28);
            bobGeneralNum.TabIndex = 2;
            bobGeneralNum.Text = "Общее число Боба";
            // 
            // bobPrivateNum
            // 
            bobPrivateNum.AutoSize = true;
            bobPrivateNum.Location = new Point(40, 65);
            bobPrivateNum.Name = "bobPrivateNum";
            bobPrivateNum.Size = new Size(218, 28);
            bobPrivateNum.TabIndex = 1;
            bobPrivateNum.Text = "Секретное число Боба";
            // 
            // labo321
            // 
            labo321.AutoSize = true;
            labo321.Location = new Point(40, 248);
            labo321.Name = "labo321";
            labo321.Size = new Size(165, 28);
            labo321.TabIndex = 0;
            labo321.Text = "Секретный ключ";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(312, 96);
            button3.Name = "button3";
            button3.Size = new Size(130, 37);
            button3.TabIndex = 9;
            button3.Text = "Генерировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += bob_Click;
            // 
            // diffieHellmanBtn
            // 
            diffieHellmanBtn.Location = new Point(662, 776);
            diffieHellmanBtn.Name = "diffieHellmanBtn";
            diffieHellmanBtn.Size = new Size(136, 61);
            diffieHellmanBtn.TabIndex = 18;
            diffieHellmanBtn.Text = "Начать";
            diffieHellmanBtn.UseVisualStyleBackColor = true;
            diffieHellmanBtn.Click += diffieHellmanBtn_Click;
            // 
            // gLabo
            // 
            gLabo.AutoSize = true;
            gLabo.Location = new Point(650, 851);
            gLabo.Name = "gLabo";
            gLabo.Size = new Size(148, 28);
            gLabo.TabIndex = 2;
            gLabo.Text = "Генератор g = ";
            gLabo.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 1000);
            Controls.Add(diffieHellmanBtn);
            Controls.Add(AliceBox);
            Controls.Add(BobBox);
            Controls.Add(gLabo);
            Controls.Add(rootFindTime);
            Controls.Add(rootsText);
            Controls.Add(cc16);
            Controls.Add(cc2);
            Controls.Add(ccText);
            Controls.Add(detTimeTB);
            Controls.Add(rabinTimeTB);
            Controls.Add(fermaTimeTB);
            Controls.Add(detViewTB);
            Controls.Add(rabinViewTB);
            Controls.Add(fermaViewTB);
            Controls.Add(button1);
            Controls.Add(generateButton);
            Controls.Add(bytes);
            Controls.Add(roundsTB);
            Controls.Add(numberTB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(warning);
            Controls.Add(pmLabo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bytesLabo);
            Controls.Add(label1);
            Controls.Add(number_labo);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            AliceBox.ResumeLayout(false);
            AliceBox.PerformLayout();
            BobBox.ResumeLayout(false);
            BobBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label number_labo;
        private Label bytesLabo;
        private Label pmLabo;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox numberTB;
        private TextBox bytes;
        private Button generateButton;
        private Button button1;
        private TextBox roundsTB;
        private TextBox fermaViewTB;
        private TextBox fermaTimeTB;
        private TextBox rabinViewTB;
        private TextBox rabinTimeTB;
        private TextBox detViewTB;
        private TextBox detTimeTB;
        private Label warning;
        private TextBox ccText;
        private Label label1;
        private RadioButton cc2;
        private RadioButton cc16;
        private TextBox rootsText;
        private Label label2;
        private Label label3;
        private TextBox rootFindTime;
        private GroupBox AliceBox;
        private GroupBox BobBox;
        private Label aliceGeneralNum;
        private Label alicePrivateNum;
        private Label labo123;
        private Label bobGeneralNum;
        private Label labo321;
        private Label bobPrivateNum;
        private Button diffieHellmanBtn;
        private TextBox aliceSecretTb;
        private Button button2;
        private TextBox bobSecretTb;
        private Button button3;
        private TextBox secretKey1;
        private TextBox aliceGeneralTb;
        private TextBox secretKey2;
        private TextBox bobGeneralTb;
        private Label gLabo;
    }
}