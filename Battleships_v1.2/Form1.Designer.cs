
namespace Battleships_v1._2
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioHorizontal = new System.Windows.Forms.RadioButton();
            this.radioVertical = new System.Windows.Forms.RadioButton();
            this.DirQ = new System.Windows.Forms.Label();
            this.LenQ = new System.Windows.Forms.Label();
            this.button323 = new System.Windows.Forms.Button();
            this.button322 = new System.Windows.Forms.Button();
            this.button314 = new System.Windows.Forms.Button();
            this.button313 = new System.Windows.Forms.Button();
            this.button312 = new System.Windows.Forms.Button();
            this.button311 = new System.Windows.Forms.Button();
            this.button321 = new System.Windows.Forms.Button();
            this.button332 = new System.Windows.Forms.Button();
            this.button331 = new System.Windows.Forms.Button();
            this.button341 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.WinL = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.PS5 = new System.Windows.Forms.Button();
            this.PS4 = new System.Windows.Forms.Button();
            this.PS9 = new System.Windows.Forms.Button();
            this.PS8 = new System.Windows.Forms.Button();
            this.PS7 = new System.Windows.Forms.Button();
            this.PS6 = new System.Windows.Forms.Button();
            this.PS3 = new System.Windows.Forms.Button();
            this.PS2 = new System.Windows.Forms.Button();
            this.PS1 = new System.Windows.Forms.Button();
            this.PS0 = new System.Windows.Forms.Button();
            this.ES5 = new System.Windows.Forms.Button();
            this.ES4 = new System.Windows.Forms.Button();
            this.ES9 = new System.Windows.Forms.Button();
            this.ES8 = new System.Windows.Forms.Button();
            this.ES7 = new System.Windows.Forms.Button();
            this.ES6 = new System.Windows.Forms.Button();
            this.ES3 = new System.Windows.Forms.Button();
            this.ES2 = new System.Windows.Forms.Button();
            this.ES1 = new System.Windows.Forms.Button();
            this.ES0 = new System.Windows.Forms.Button();
            this.ErrLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioHorizontal
            // 
            this.radioHorizontal.AutoSize = true;
            this.radioHorizontal.Location = new System.Drawing.Point(550, 252);
            this.radioHorizontal.Name = "radioHorizontal";
            this.radioHorizontal.Size = new System.Drawing.Size(73, 17);
            this.radioHorizontal.TabIndex = 280;
            this.radioHorizontal.TabStop = true;
            this.radioHorizontal.Text = "Vízszintes";
            this.radioHorizontal.UseVisualStyleBackColor = true;
            this.radioHorizontal.Click += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioVertical
            // 
            this.radioVertical.AutoSize = true;
            this.radioVertical.Location = new System.Drawing.Point(464, 252);
            this.radioVertical.Name = "radioVertical";
            this.radioVertical.Size = new System.Drawing.Size(80, 17);
            this.radioVertical.TabIndex = 279;
            this.radioVertical.TabStop = true;
            this.radioVertical.Text = "Függőleges";
            this.radioVertical.UseVisualStyleBackColor = true;
            // 
            // DirQ
            // 
            this.DirQ.AutoSize = true;
            this.DirQ.Location = new System.Drawing.Point(468, 225);
            this.DirQ.Name = "DirQ";
            this.DirQ.Size = new System.Drawing.Size(149, 13);
            this.DirQ.TabIndex = 278;
            this.DirQ.Text = "Milyen irányba épüljön a hajó?";
            // 
            // LenQ
            // 
            this.LenQ.AutoSize = true;
            this.LenQ.Location = new System.Drawing.Point(468, 9);
            this.LenQ.Name = "LenQ";
            this.LenQ.Size = new System.Drawing.Size(145, 13);
            this.LenQ.TabIndex = 277;
            this.LenQ.Text = "Milyen hosszú legyen a hajó?";
            // 
            // button323
            // 
            this.button323.BackColor = System.Drawing.Color.Aquamarine;
            this.button323.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button323.ForeColor = System.Drawing.Color.Teal;
            this.button323.Location = new System.Drawing.Point(580, 130);
            this.button323.Margin = new System.Windows.Forms.Padding(0);
            this.button323.Name = "button323";
            this.button323.Size = new System.Drawing.Size(54, 27);
            this.button323.TabIndex = 291;
            this.button323.Tag = "5";
            this.button323.UseVisualStyleBackColor = false;
            this.button323.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button322
            // 
            this.button322.BackColor = System.Drawing.Color.Aquamarine;
            this.button322.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button322.ForeColor = System.Drawing.Color.Teal;
            this.button322.Location = new System.Drawing.Point(511, 130);
            this.button322.Margin = new System.Windows.Forms.Padding(0);
            this.button322.Name = "button322";
            this.button322.Size = new System.Drawing.Size(54, 27);
            this.button322.TabIndex = 290;
            this.button322.Tag = "4";
            this.button322.UseVisualStyleBackColor = false;
            this.button322.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button314
            // 
            this.button314.BackColor = System.Drawing.Color.Aquamarine;
            this.button314.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button314.ForeColor = System.Drawing.Color.Teal;
            this.button314.Location = new System.Drawing.Point(607, 171);
            this.button314.Margin = new System.Windows.Forms.Padding(0);
            this.button314.Name = "button314";
            this.button314.Size = new System.Drawing.Size(27, 27);
            this.button314.TabIndex = 289;
            this.button314.Tag = "9";
            this.button314.UseVisualStyleBackColor = false;
            this.button314.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button313
            // 
            this.button313.BackColor = System.Drawing.Color.Aquamarine;
            this.button313.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button313.ForeColor = System.Drawing.Color.Teal;
            this.button313.Location = new System.Drawing.Point(550, 171);
            this.button313.Margin = new System.Windows.Forms.Padding(0);
            this.button313.Name = "button313";
            this.button313.Size = new System.Drawing.Size(27, 27);
            this.button313.TabIndex = 288;
            this.button313.Tag = "8";
            this.button313.UseVisualStyleBackColor = false;
            this.button313.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button312
            // 
            this.button312.BackColor = System.Drawing.Color.Aquamarine;
            this.button312.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button312.ForeColor = System.Drawing.Color.Teal;
            this.button312.Location = new System.Drawing.Point(496, 171);
            this.button312.Margin = new System.Windows.Forms.Padding(0);
            this.button312.Name = "button312";
            this.button312.Size = new System.Drawing.Size(27, 27);
            this.button312.TabIndex = 287;
            this.button312.Tag = "7";
            this.button312.UseVisualStyleBackColor = false;
            this.button312.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button311
            // 
            this.button311.BackColor = System.Drawing.Color.Aquamarine;
            this.button311.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button311.ForeColor = System.Drawing.Color.Teal;
            this.button311.Location = new System.Drawing.Point(440, 171);
            this.button311.Margin = new System.Windows.Forms.Padding(0);
            this.button311.Name = "button311";
            this.button311.Size = new System.Drawing.Size(27, 27);
            this.button311.TabIndex = 286;
            this.button311.Tag = "6";
            this.button311.UseVisualStyleBackColor = false;
            this.button311.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button321
            // 
            this.button321.BackColor = System.Drawing.Color.Aquamarine;
            this.button321.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button321.ForeColor = System.Drawing.Color.Teal;
            this.button321.Location = new System.Drawing.Point(440, 130);
            this.button321.Margin = new System.Windows.Forms.Padding(0);
            this.button321.Name = "button321";
            this.button321.Size = new System.Drawing.Size(54, 27);
            this.button321.TabIndex = 285;
            this.button321.Tag = "3";
            this.button321.UseVisualStyleBackColor = false;
            this.button321.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button332
            // 
            this.button332.BackColor = System.Drawing.Color.Aquamarine;
            this.button332.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button332.ForeColor = System.Drawing.Color.Teal;
            this.button332.Location = new System.Drawing.Point(555, 90);
            this.button332.Margin = new System.Windows.Forms.Padding(0);
            this.button332.Name = "button332";
            this.button332.Size = new System.Drawing.Size(79, 27);
            this.button332.TabIndex = 284;
            this.button332.Tag = "2";
            this.button332.UseVisualStyleBackColor = false;
            this.button332.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button331
            // 
            this.button331.BackColor = System.Drawing.Color.Aquamarine;
            this.button331.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button331.ForeColor = System.Drawing.Color.Teal;
            this.button331.Location = new System.Drawing.Point(440, 90);
            this.button331.Margin = new System.Windows.Forms.Padding(0);
            this.button331.Name = "button331";
            this.button331.Size = new System.Drawing.Size(81, 27);
            this.button331.TabIndex = 283;
            this.button331.Tag = "1";
            this.button331.UseVisualStyleBackColor = false;
            this.button331.Click += new System.EventHandler(this.Ship_Click);
            // 
            // button341
            // 
            this.button341.BackColor = System.Drawing.Color.Aquamarine;
            this.button341.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button341.ForeColor = System.Drawing.Color.Teal;
            this.button341.Location = new System.Drawing.Point(482, 49);
            this.button341.Margin = new System.Windows.Forms.Padding(0);
            this.button341.Name = "button341";
            this.button341.Size = new System.Drawing.Size(108, 27);
            this.button341.TabIndex = 282;
            this.button341.Tag = "0";
            this.button341.UseVisualStyleBackColor = false;
            this.button341.Click += new System.EventHandler(this.Ship_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(494, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 292;
            this.btnAdd.Text = "Hozzáad";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 94);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 23);
            this.btnStart.TabIndex = 293;
            this.btnStart.Text = "Játék indítása";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(351, 65);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(94, 23);
            this.btnCustom.TabIndex = 294;
            this.btnCustom.Text = "Saját elrendezés";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(331, 36);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(134, 23);
            this.btnRand.TabIndex = 295;
            this.btnRand.Text = "Véletlenszerű elrendezés";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Location = new System.Drawing.Point(597, 279);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 296;
            this.btnDone.Text = "Kész";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 297;
            this.btnCancel.Text = "Mégse";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewGame.Location = new System.Drawing.Point(330, 345);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 296;
            this.btnNewGame.Text = "Új játék";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // WinL
            // 
            this.WinL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WinL.AutoSize = true;
            this.WinL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinL.ForeColor = System.Drawing.Color.DarkRed;
            this.WinL.Location = new System.Drawing.Point(0, 0);
            this.WinL.Name = "WinL";
            this.WinL.Size = new System.Drawing.Size(109, 25);
            this.WinL.TabIndex = 296;
            this.WinL.Text = "Ön nyert!";
            this.WinL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuit.Location = new System.Drawing.Point(330, 374);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 297;
            this.btnQuit.Text = "Kilépés";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // PS5
            // 
            this.PS5.BackColor = System.Drawing.Color.Aquamarine;
            this.PS5.Enabled = false;
            this.PS5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS5.ForeColor = System.Drawing.Color.Teal;
            this.PS5.Location = new System.Drawing.Point(174, 392);
            this.PS5.Margin = new System.Windows.Forms.Padding(0);
            this.PS5.Name = "PS5";
            this.PS5.Size = new System.Drawing.Size(54, 27);
            this.PS5.TabIndex = 305;
            this.PS5.UseVisualStyleBackColor = false;
            // 
            // PS4
            // 
            this.PS4.BackColor = System.Drawing.Color.Aquamarine;
            this.PS4.Enabled = false;
            this.PS4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS4.ForeColor = System.Drawing.Color.Teal;
            this.PS4.Location = new System.Drawing.Point(105, 392);
            this.PS4.Margin = new System.Windows.Forms.Padding(0);
            this.PS4.Name = "PS4";
            this.PS4.Size = new System.Drawing.Size(54, 27);
            this.PS4.TabIndex = 304;
            this.PS4.UseVisualStyleBackColor = false;
            // 
            // PS9
            // 
            this.PS9.BackColor = System.Drawing.Color.Aquamarine;
            this.PS9.Enabled = false;
            this.PS9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS9.ForeColor = System.Drawing.Color.Teal;
            this.PS9.Location = new System.Drawing.Point(201, 433);
            this.PS9.Margin = new System.Windows.Forms.Padding(0);
            this.PS9.Name = "PS9";
            this.PS9.Size = new System.Drawing.Size(27, 27);
            this.PS9.TabIndex = 303;
            this.PS9.UseVisualStyleBackColor = false;
            // 
            // PS8
            // 
            this.PS8.BackColor = System.Drawing.Color.Aquamarine;
            this.PS8.Enabled = false;
            this.PS8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS8.ForeColor = System.Drawing.Color.Teal;
            this.PS8.Location = new System.Drawing.Point(144, 433);
            this.PS8.Margin = new System.Windows.Forms.Padding(0);
            this.PS8.Name = "PS8";
            this.PS8.Size = new System.Drawing.Size(27, 27);
            this.PS8.TabIndex = 302;
            this.PS8.UseVisualStyleBackColor = false;
            // 
            // PS7
            // 
            this.PS7.BackColor = System.Drawing.Color.Aquamarine;
            this.PS7.Enabled = false;
            this.PS7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS7.ForeColor = System.Drawing.Color.Teal;
            this.PS7.Location = new System.Drawing.Point(90, 433);
            this.PS7.Margin = new System.Windows.Forms.Padding(0);
            this.PS7.Name = "PS7";
            this.PS7.Size = new System.Drawing.Size(27, 27);
            this.PS7.TabIndex = 301;
            this.PS7.UseVisualStyleBackColor = false;
            // 
            // PS6
            // 
            this.PS6.BackColor = System.Drawing.Color.Aquamarine;
            this.PS6.Enabled = false;
            this.PS6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS6.ForeColor = System.Drawing.Color.Teal;
            this.PS6.Location = new System.Drawing.Point(34, 433);
            this.PS6.Margin = new System.Windows.Forms.Padding(0);
            this.PS6.Name = "PS6";
            this.PS6.Size = new System.Drawing.Size(27, 27);
            this.PS6.TabIndex = 300;
            this.PS6.UseVisualStyleBackColor = false;
            // 
            // PS3
            // 
            this.PS3.BackColor = System.Drawing.Color.Aquamarine;
            this.PS3.Enabled = false;
            this.PS3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS3.ForeColor = System.Drawing.Color.Teal;
            this.PS3.Location = new System.Drawing.Point(34, 392);
            this.PS3.Margin = new System.Windows.Forms.Padding(0);
            this.PS3.Name = "PS3";
            this.PS3.Size = new System.Drawing.Size(54, 27);
            this.PS3.TabIndex = 299;
            this.PS3.UseVisualStyleBackColor = false;
            // 
            // PS2
            // 
            this.PS2.BackColor = System.Drawing.Color.Aquamarine;
            this.PS2.Enabled = false;
            this.PS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS2.ForeColor = System.Drawing.Color.Teal;
            this.PS2.Location = new System.Drawing.Point(149, 352);
            this.PS2.Margin = new System.Windows.Forms.Padding(0);
            this.PS2.Name = "PS2";
            this.PS2.Size = new System.Drawing.Size(79, 27);
            this.PS2.TabIndex = 298;
            this.PS2.UseVisualStyleBackColor = false;
            // 
            // PS1
            // 
            this.PS1.BackColor = System.Drawing.Color.Aquamarine;
            this.PS1.Enabled = false;
            this.PS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS1.ForeColor = System.Drawing.Color.Teal;
            this.PS1.Location = new System.Drawing.Point(34, 352);
            this.PS1.Margin = new System.Windows.Forms.Padding(0);
            this.PS1.Name = "PS1";
            this.PS1.Size = new System.Drawing.Size(81, 27);
            this.PS1.TabIndex = 297;
            this.PS1.UseVisualStyleBackColor = false;
            // 
            // PS0
            // 
            this.PS0.BackColor = System.Drawing.Color.Aquamarine;
            this.PS0.Enabled = false;
            this.PS0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PS0.ForeColor = System.Drawing.Color.Teal;
            this.PS0.Location = new System.Drawing.Point(34, 311);
            this.PS0.Margin = new System.Windows.Forms.Padding(0);
            this.PS0.Name = "PS0";
            this.PS0.Size = new System.Drawing.Size(108, 27);
            this.PS0.TabIndex = 296;
            this.PS0.UseVisualStyleBackColor = false;
            // 
            // ES5
            // 
            this.ES5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES5.BackColor = System.Drawing.Color.Aquamarine;
            this.ES5.Enabled = false;
            this.ES5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES5.ForeColor = System.Drawing.Color.Teal;
            this.ES5.Location = new System.Drawing.Point(721, 392);
            this.ES5.Margin = new System.Windows.Forms.Padding(0);
            this.ES5.Name = "ES5";
            this.ES5.Size = new System.Drawing.Size(54, 27);
            this.ES5.TabIndex = 315;
            this.ES5.UseVisualStyleBackColor = false;
            // 
            // ES4
            // 
            this.ES4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES4.BackColor = System.Drawing.Color.Aquamarine;
            this.ES4.Enabled = false;
            this.ES4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES4.ForeColor = System.Drawing.Color.Teal;
            this.ES4.Location = new System.Drawing.Point(652, 392);
            this.ES4.Margin = new System.Windows.Forms.Padding(0);
            this.ES4.Name = "ES4";
            this.ES4.Size = new System.Drawing.Size(54, 27);
            this.ES4.TabIndex = 314;
            this.ES4.UseVisualStyleBackColor = false;
            // 
            // ES9
            // 
            this.ES9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES9.BackColor = System.Drawing.Color.Aquamarine;
            this.ES9.Enabled = false;
            this.ES9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES9.ForeColor = System.Drawing.Color.Teal;
            this.ES9.Location = new System.Drawing.Point(748, 433);
            this.ES9.Margin = new System.Windows.Forms.Padding(0);
            this.ES9.Name = "ES9";
            this.ES9.Size = new System.Drawing.Size(27, 27);
            this.ES9.TabIndex = 313;
            this.ES9.UseVisualStyleBackColor = false;
            // 
            // ES8
            // 
            this.ES8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES8.BackColor = System.Drawing.Color.Aquamarine;
            this.ES8.Enabled = false;
            this.ES8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES8.ForeColor = System.Drawing.Color.Teal;
            this.ES8.Location = new System.Drawing.Point(691, 433);
            this.ES8.Margin = new System.Windows.Forms.Padding(0);
            this.ES8.Name = "ES8";
            this.ES8.Size = new System.Drawing.Size(27, 27);
            this.ES8.TabIndex = 312;
            this.ES8.UseVisualStyleBackColor = false;
            // 
            // ES7
            // 
            this.ES7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES7.BackColor = System.Drawing.Color.Aquamarine;
            this.ES7.Enabled = false;
            this.ES7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES7.ForeColor = System.Drawing.Color.Teal;
            this.ES7.Location = new System.Drawing.Point(637, 433);
            this.ES7.Margin = new System.Windows.Forms.Padding(0);
            this.ES7.Name = "ES7";
            this.ES7.Size = new System.Drawing.Size(27, 27);
            this.ES7.TabIndex = 311;
            this.ES7.UseVisualStyleBackColor = false;
            // 
            // ES6
            // 
            this.ES6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES6.BackColor = System.Drawing.Color.Aquamarine;
            this.ES6.Enabled = false;
            this.ES6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES6.ForeColor = System.Drawing.Color.Teal;
            this.ES6.Location = new System.Drawing.Point(581, 433);
            this.ES6.Margin = new System.Windows.Forms.Padding(0);
            this.ES6.Name = "ES6";
            this.ES6.Size = new System.Drawing.Size(27, 27);
            this.ES6.TabIndex = 310;
            this.ES6.UseVisualStyleBackColor = false;
            // 
            // ES3
            // 
            this.ES3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES3.BackColor = System.Drawing.Color.Aquamarine;
            this.ES3.Enabled = false;
            this.ES3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES3.ForeColor = System.Drawing.Color.Teal;
            this.ES3.Location = new System.Drawing.Point(581, 392);
            this.ES3.Margin = new System.Windows.Forms.Padding(0);
            this.ES3.Name = "ES3";
            this.ES3.Size = new System.Drawing.Size(54, 27);
            this.ES3.TabIndex = 309;
            this.ES3.UseVisualStyleBackColor = false;
            // 
            // ES2
            // 
            this.ES2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES2.BackColor = System.Drawing.Color.Aquamarine;
            this.ES2.Enabled = false;
            this.ES2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES2.ForeColor = System.Drawing.Color.Teal;
            this.ES2.Location = new System.Drawing.Point(696, 352);
            this.ES2.Margin = new System.Windows.Forms.Padding(0);
            this.ES2.Name = "ES2";
            this.ES2.Size = new System.Drawing.Size(79, 27);
            this.ES2.TabIndex = 308;
            this.ES2.UseVisualStyleBackColor = false;
            // 
            // ES1
            // 
            this.ES1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES1.BackColor = System.Drawing.Color.Aquamarine;
            this.ES1.Enabled = false;
            this.ES1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES1.ForeColor = System.Drawing.Color.Teal;
            this.ES1.Location = new System.Drawing.Point(581, 352);
            this.ES1.Margin = new System.Windows.Forms.Padding(0);
            this.ES1.Name = "ES1";
            this.ES1.Size = new System.Drawing.Size(81, 27);
            this.ES1.TabIndex = 307;
            this.ES1.UseVisualStyleBackColor = false;
            // 
            // ES0
            // 
            this.ES0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ES0.BackColor = System.Drawing.Color.Aquamarine;
            this.ES0.Enabled = false;
            this.ES0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ES0.ForeColor = System.Drawing.Color.Teal;
            this.ES0.Location = new System.Drawing.Point(667, 311);
            this.ES0.Margin = new System.Windows.Forms.Padding(0);
            this.ES0.Name = "ES0";
            this.ES0.Size = new System.Drawing.Size(108, 27);
            this.ES0.TabIndex = 306;
            this.ES0.UseVisualStyleBackColor = false;
            // 
            // ErrLabel
            // 
            this.ErrLabel.AutoSize = true;
            this.ErrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ErrLabel.Location = new System.Drawing.Point(303, 349);
            this.ErrLabel.Name = "ErrLabel";
            this.ErrLabel.Size = new System.Drawing.Size(186, 20);
            this.ErrLabel.TabIndex = 296;
            this.ErrLabel.Text = "Ide nem helyezhető hajó!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 504);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 543);
            this.Name = "Form1";
            this.Text = "Torpedó";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label P4;
        private System.Windows.Forms.Label P5;
        private System.Windows.Forms.Label P6;
        private System.Windows.Forms.Label P7;
        private System.Windows.Forms.Label P8;
        private System.Windows.Forms.Label P9;
        private System.Windows.Forms.Label P10;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label PlB;
        private System.Windows.Forms.Label PC;
        private System.Windows.Forms.Label PD;
        private System.Windows.Forms.Label PE;
        private System.Windows.Forms.Label PF;
        private System.Windows.Forms.Label PG;
        private System.Windows.Forms.Label PH;
        private System.Windows.Forms.Label PlI;
        private System.Windows.Forms.Label PJ;
        private System.Windows.Forms.Label PA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.RadioButton radioHorizontal;
        private System.Windows.Forms.RadioButton radioVertical;
        private System.Windows.Forms.Label DirQ;
        private System.Windows.Forms.Label LenQ;
        private System.Windows.Forms.Button button323;
        private System.Windows.Forms.Button button322;
        private System.Windows.Forms.Button button314;
        private System.Windows.Forms.Button button313;
        private System.Windows.Forms.Button button312;
        private System.Windows.Forms.Button button311;
        private System.Windows.Forms.Button button321;
        private System.Windows.Forms.Button button332;
        private System.Windows.Forms.Button button331;
        private System.Windows.Forms.Button button341;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label WinL;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button PS5;
        private System.Windows.Forms.Button PS4;
        private System.Windows.Forms.Button PS9;
        private System.Windows.Forms.Button PS8;
        private System.Windows.Forms.Button PS7;
        private System.Windows.Forms.Button PS6;
        private System.Windows.Forms.Button PS3;
        private System.Windows.Forms.Button PS2;
        private System.Windows.Forms.Button PS1;
        private System.Windows.Forms.Button PS0;
        private System.Windows.Forms.Button ES5;
        private System.Windows.Forms.Button ES4;
        private System.Windows.Forms.Button ES9;
        private System.Windows.Forms.Button ES8;
        private System.Windows.Forms.Button ES7;
        private System.Windows.Forms.Button ES6;
        private System.Windows.Forms.Button ES3;
        private System.Windows.Forms.Button ES2;
        private System.Windows.Forms.Button ES1;
        private System.Windows.Forms.Button ES0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ErrLabel;
    }
}

