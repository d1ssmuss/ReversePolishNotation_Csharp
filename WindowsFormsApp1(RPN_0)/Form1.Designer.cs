namespace WindowsFormsApp1_RPN_0_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPi = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.btnsqrt = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btntimes = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.labelTypestr = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.btnbracketopen = new System.Windows.Forms.Button();
            this.btnbracketclosed = new System.Windows.Forms.Button();
            this.btnprocent = new System.Windows.Forms.Button();
            this.btnsin = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btntg = new System.Windows.Forms.Button();
            this.btnctg = new System.Windows.Forms.Button();
            this.btnpow = new System.Windows.Forms.Button();
            this.btnln = new System.Windows.Forms.Button();
            this.btnlg = new System.Windows.Forms.Button();
            this.btnabs = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelansw = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.Gray;
            this.btnPi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPi.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPi.Location = new System.Drawing.Point(1013, 568);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(109, 86);
            this.btnPi.TabIndex = 0;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.Gray;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnE.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnE.Location = new System.Drawing.Point(1013, 660);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(109, 86);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset.Location = new System.Drawing.Point(863, 384);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(144, 86);
            this.reset.TabIndex = 2;
            this.reset.Text = "CE";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // btnsqrt
            // 
            this.btnsqrt.BackColor = System.Drawing.Color.Gold;
            this.btnsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsqrt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsqrt.Location = new System.Drawing.Point(1128, 660);
            this.btnsqrt.Name = "btnsqrt";
            this.btnsqrt.Size = new System.Drawing.Size(109, 86);
            this.btnsqrt.TabIndex = 3;
            this.btnsqrt.Text = "√";
            this.btnsqrt.UseVisualStyleBackColor = false;
            this.btnsqrt.Click += new System.EventHandler(this.btnsqrt_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.Gold;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnplus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnplus.Location = new System.Drawing.Point(1243, 384);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(109, 86);
            this.btnplus.TabIndex = 4;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.Gold;
            this.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnminus.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnminus.Location = new System.Drawing.Point(1243, 476);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(109, 86);
            this.btnminus.TabIndex = 5;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btntimes
            // 
            this.btntimes.BackColor = System.Drawing.Color.Gold;
            this.btntimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntimes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntimes.Location = new System.Drawing.Point(1243, 568);
            this.btntimes.Name = "btntimes";
            this.btntimes.Size = new System.Drawing.Size(109, 86);
            this.btntimes.TabIndex = 6;
            this.btntimes.Text = "*";
            this.btntimes.UseVisualStyleBackColor = false;
            this.btntimes.Click += new System.EventHandler(this.btntimes_Click);
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Gold;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndiv.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btndiv.Location = new System.Drawing.Point(1243, 660);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(109, 86);
            this.btndiv.TabIndex = 7;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // labelTypestr
            // 
            this.labelTypestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypestr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTypestr.Location = new System.Drawing.Point(206, 18);
            this.labelTypestr.Name = "labelTypestr";
            this.labelTypestr.Size = new System.Drawing.Size(877, 109);
            this.labelTypestr.TabIndex = 8;
            this.labelTypestr.Text = "Введите выражение(инфиксная запись):";
            this.labelTypestr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Input
            // 
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.Location = new System.Drawing.Point(76, 147);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(498, 48);
            this.Input.TabIndex = 9;
            this.Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbracketopen
            // 
            this.btnbracketopen.BackColor = System.Drawing.Color.Chartreuse;
            this.btnbracketopen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbracketopen.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbracketopen.Location = new System.Drawing.Point(1013, 384);
            this.btnbracketopen.Name = "btnbracketopen";
            this.btnbracketopen.Size = new System.Drawing.Size(109, 86);
            this.btnbracketopen.TabIndex = 10;
            this.btnbracketopen.Text = "(";
            this.btnbracketopen.UseVisualStyleBackColor = false;
            this.btnbracketopen.Click += new System.EventHandler(this.btnbracketopen_Click);
            // 
            // btnbracketclosed
            // 
            this.btnbracketclosed.BackColor = System.Drawing.Color.Chartreuse;
            this.btnbracketclosed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbracketclosed.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbracketclosed.Location = new System.Drawing.Point(1128, 384);
            this.btnbracketclosed.Name = "btnbracketclosed";
            this.btnbracketclosed.Size = new System.Drawing.Size(109, 86);
            this.btnbracketclosed.TabIndex = 11;
            this.btnbracketclosed.Text = ")";
            this.btnbracketclosed.UseVisualStyleBackColor = false;
            this.btnbracketclosed.Click += new System.EventHandler(this.btnbracketclosed_Click);
            // 
            // btnprocent
            // 
            this.btnprocent.BackColor = System.Drawing.Color.Gold;
            this.btnprocent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprocent.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnprocent.Location = new System.Drawing.Point(1128, 476);
            this.btnprocent.Name = "btnprocent";
            this.btnprocent.Size = new System.Drawing.Size(109, 86);
            this.btnprocent.TabIndex = 12;
            this.btnprocent.Text = "%";
            this.btnprocent.UseVisualStyleBackColor = false;
            this.btnprocent.Click += new System.EventHandler(this.btnprocent_Click);
            // 
            // btnsin
            // 
            this.btnsin.BackColor = System.Drawing.Color.LightGray;
            this.btnsin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsin.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsin.Location = new System.Drawing.Point(713, 476);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(144, 86);
            this.btnsin.TabIndex = 13;
            this.btnsin.Text = "sin";
            this.btnsin.UseVisualStyleBackColor = false;
            this.btnsin.Click += new System.EventHandler(this.btnsin_Click);
            // 
            // btncos
            // 
            this.btncos.BackColor = System.Drawing.Color.LightGray;
            this.btncos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncos.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncos.Location = new System.Drawing.Point(714, 568);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(144, 86);
            this.btncos.TabIndex = 14;
            this.btncos.Text = "cos";
            this.btncos.UseVisualStyleBackColor = false;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btntg
            // 
            this.btntg.BackColor = System.Drawing.Color.LightGray;
            this.btntg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btntg.Location = new System.Drawing.Point(714, 660);
            this.btntg.Name = "btntg";
            this.btntg.Size = new System.Drawing.Size(144, 86);
            this.btntg.TabIndex = 15;
            this.btntg.Text = "tg";
            this.btntg.UseVisualStyleBackColor = false;
            this.btntg.Click += new System.EventHandler(this.btntg_Click);
            // 
            // btnctg
            // 
            this.btnctg.BackColor = System.Drawing.Color.LightGray;
            this.btnctg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnctg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnctg.Location = new System.Drawing.Point(863, 660);
            this.btnctg.Name = "btnctg";
            this.btnctg.Size = new System.Drawing.Size(144, 86);
            this.btnctg.TabIndex = 16;
            this.btnctg.Text = "ctg";
            this.btnctg.UseVisualStyleBackColor = false;
            this.btnctg.Click += new System.EventHandler(this.btnctg_Click);
            // 
            // btnpow
            // 
            this.btnpow.BackColor = System.Drawing.Color.Gold;
            this.btnpow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpow.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnpow.Location = new System.Drawing.Point(1128, 568);
            this.btnpow.Name = "btnpow";
            this.btnpow.Size = new System.Drawing.Size(109, 86);
            this.btnpow.TabIndex = 17;
            this.btnpow.Text = "^";
            this.btnpow.UseVisualStyleBackColor = false;
            this.btnpow.Click += new System.EventHandler(this.btnpow_Click);
            // 
            // btnln
            // 
            this.btnln.BackColor = System.Drawing.Color.Tan;
            this.btnln.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnln.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnln.Location = new System.Drawing.Point(863, 476);
            this.btnln.Name = "btnln";
            this.btnln.Size = new System.Drawing.Size(144, 86);
            this.btnln.TabIndex = 18;
            this.btnln.Text = "ln";
            this.btnln.UseVisualStyleBackColor = false;
            this.btnln.Click += new System.EventHandler(this.btnln_Click);
            // 
            // btnlg
            // 
            this.btnlg.BackColor = System.Drawing.Color.Tan;
            this.btnlg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlg.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnlg.Location = new System.Drawing.Point(1013, 476);
            this.btnlg.Name = "btnlg";
            this.btnlg.Size = new System.Drawing.Size(109, 86);
            this.btnlg.TabIndex = 19;
            this.btnlg.Text = "lg";
            this.btnlg.UseVisualStyleBackColor = false;
            this.btnlg.Click += new System.EventHandler(this.btnlg_Click);
            // 
            // btnabs
            // 
            this.btnabs.BackColor = System.Drawing.Color.SteelBlue;
            this.btnabs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnabs.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnabs.Location = new System.Drawing.Point(863, 568);
            this.btnabs.Name = "btnabs";
            this.btnabs.Size = new System.Drawing.Size(144, 86);
            this.btnabs.TabIndex = 20;
            this.btnabs.Text = "abs";
            this.btnabs.UseVisualStyleBackColor = false;
            this.btnabs.Click += new System.EventHandler(this.btnabs_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclear.Location = new System.Drawing.Point(714, 384);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(144, 86);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "<-";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // labelresult
            // 
            this.labelresult.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelresult.Location = new System.Drawing.Point(12, 260);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(1340, 59);
            this.labelresult.TabIndex = 22;
            this.labelresult.Text = "Преобразование в обратную польскую запись(результат):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(580, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelansw
            // 
            this.labelansw.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelansw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelansw.Location = new System.Drawing.Point(708, 147);
            this.labelansw.Name = "labelansw";
            this.labelansw.Size = new System.Drawing.Size(555, 48);
            this.labelansw.TabIndex = 24;
            this.labelansw.Click += new System.EventHandler(this.labelansw_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.LightGray;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(57, 577);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(144, 86);
            this.one.TabIndex = 25;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.LightGray;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(217, 577);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(144, 86);
            this.two.TabIndex = 26;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.button2_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.LightGray;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(380, 577);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(144, 86);
            this.three.TabIndex = 27;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(217, 669);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 86);
            this.button4.TabIndex = 28;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.LightGray;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(57, 485);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(144, 86);
            this.four.TabIndex = 29;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.LightGray;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(217, 485);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(144, 86);
            this.five.TabIndex = 30;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.LightGray;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(380, 485);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(144, 86);
            this.six.TabIndex = 31;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.LightGray;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(57, 393);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(144, 86);
            this.seven.TabIndex = 32;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.LightGray;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(217, 393);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(144, 86);
            this.eight.TabIndex = 33;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.LightGray;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(380, 393);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(144, 86);
            this.nine.TabIndex = 34;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1387, 805);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.labelansw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnabs);
            this.Controls.Add(this.btnlg);
            this.Controls.Add(this.btnln);
            this.Controls.Add(this.btnpow);
            this.Controls.Add(this.btnctg);
            this.Controls.Add(this.btntg);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.btnprocent);
            this.Controls.Add(this.btnbracketclosed);
            this.Controls.Add(this.btnbracketopen);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.labelTypestr);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btntimes);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnsqrt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnPi);
            this.Name = "Form1";
            this.Text = "Обратная Польская Запись";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button btnsqrt;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btntimes;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Label labelTypestr;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button btnbracketopen;
        private System.Windows.Forms.Button btnbracketclosed;
        private System.Windows.Forms.Button btnprocent;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btntg;
        private System.Windows.Forms.Button btnctg;
        private System.Windows.Forms.Button btnpow;
        private System.Windows.Forms.Button btnln;
        private System.Windows.Forms.Button btnlg;
        private System.Windows.Forms.Button btnabs;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelansw;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
    }
}

