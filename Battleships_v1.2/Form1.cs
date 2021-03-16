using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships_v1._2
{
    public partial class Form1:Form
    {

        //initialization
        byte[,] P = new byte[12, 12];
        byte[,] E = new byte[12, 12];
        public void InitialValue(byte[,] G)
        {
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    if((i == 0) || (i == 11) || (j == 0) || (j == 11))
                    {
                        G[i, j] = 5;
                    }
                    else
                    {
                        G[i, j] = 0;
                    }
                }
            }//fill arrays with water
        }              //done

        public Button[,] PB;
        public Button[,] EB;

        int L;
        byte x;
        byte y;
        byte D = 1;


        private void PButtonPlace()
        {
            PB = new Button[12, 12];
            int horizotal = 3;
            for(int i = 0; i < 12; i++)
            {
                int vertical = 3;
                for(int j = 0; j < 12; j++)
                {
                    PB[i, j] = new Button();
                    PB[i, j].Size = new Size(27, 27);
                    PB[i, j].Tag = i + " " + j;
                    PB[i, j].Location = new Point(horizotal, vertical);
                    PB[i, j].Enabled = false;
                    PB[i, j].Text = " ";
                    PB[i, j].FlatStyle = FlatStyle.Flat;
                    PB[i, j].ForeColor = Color.Black;
                    PB[i, j].TextAlign = ContentAlignment.MiddleCenter;

                    PB[i, j].Click += (s, e) => btn_click(s, e);
                    if((i == 0) || (i == 11) || (j == 0) || (j == 11))
                    {
                    }
                    else
                    {
                        this.Controls.Add(PB[i, j]);
                    }
                    vertical += 27;
                }
                horizotal += 27;
            }
        }                        //done
        public void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] str = btn.Tag.ToString().Split(' ');
            x = Convert.ToByte(str[0]);
            y = Convert.ToByte(str[1]);
            ColorButtons(PB, P);
            btn.BackColor = ColorTranslator.FromHtml("#309D9F");
            this.Controls.Remove(this.ErrLabel);
        }//done

        private void EButtonProp()
        {
            EB = new Button[12, 12];
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    EB[i, j] = new Button();
                    EB[i, j].Size = new Size(27, 27);
                    EB[i, j].Tag = i + " " + j;
                    EB[i, j].Enabled = true;
                    EB[i, j].BackColor = System.Drawing.ColorTranslator.FromHtml("#00CED1");
                    EB[i, j].Text = " ";
                    EB[i, j].FlatStyle = FlatStyle.Flat;
                    EB[i, j].Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    EB[i, j].ForeColor = Color.Black;
                    EB[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    EB[i, j].TabStop = false;              //debug
                    EB[i, j].Click += (s, e) => Ebtn_click(s, e);
                }
            }
        }//done

        private void EButtonPlace()
        {
            int horizotal = this.Width - 72 - 10 * 27;
            for(int i = 0; i < 12; i++)
            {
                int vertical = 3;
                for(int j = 0; j < 12; j++)
                {
                    EB[i, j].Location = new Point(horizotal, vertical);
                    if((i == 0) || (i == 11) || (j == 0) || (j == 11))
                    {
                    }
                    else
                    {
                        this.Controls.Add(EB[i, j]);
                    }
                    vertical += 27;
                }
                horizotal += 27;
            }
        }//done


        public Form1()
        {
            InitializeComponent();
            InitialValue(P);
            InitialValue(E);
            PButtonPlace();
            AIPlace(P, PB);
            ColorButtons(PB, P);
            EButtonProp();
            AIPlace(E, EB);
        }



        int Len = 0;
        bool ok = true;

        Random rand = new Random();

        public void AIPlace(byte[,] H, Button[,] HB)
        {
            int count = 0;
            for(int i = 0; i < 10; i++)
            {
                x = (Byte)(rand.Next(1, 11));
                y = (Byte)(rand.Next(1, 11));
                D = (Byte)(rand.Next(1, 3));
                Len = i;
                Data(H, HB);
                if(ok == false)
                {
                    i--;
                }
                count++;
                if(count > 200)
                {
                    count = 0;
                    DefColor(HB);
                    InitialValue(H);
                    i = 0;
                }
            }
            PlacementCounter = 0;
            Len = -1;
            x = 0;
            y = 0;
        }               //done

        int PlacementCounter = 0;
        public void Data(byte[,] G, Button[,] GB)
        {

            ok = true;
            if(Len == 0)
            {
                L = 4;
            }
            else if((Len == 1) || (Len == 2))
            {
                L = 3;
            }
            else if((Len == 3) || (Len == 4) || (Len == 5))
            {
                L = 2;
            }
            else if((Len <= 9) && (Len > 5))
            {
                L = 1;
            }
            else
            {
                ok = false;
                L = 0;
            }


            int j = 0;
            while((j < L) && (ok == true))
            {
                if(D == 1)
                {
                    if(G[x, y + j] != 0)
                    {
                        ok = false;
                    }
                }
                if(D == 2)
                {
                    if(G[x + j, y] != 0)
                    {
                        ok = false;
                    }
                }
                j++;
            }//can it be placed there?
            if(ok == true)
            {
                for(j = 0; j < L; j++)
                {
                    if(D == 1)
                    {
                        G[x, y + j] = (byte)(20 + Len);
                        G[x + 1, y + j + 1] = 1;
                        G[x + 1, y + j - 1] = 1;
                        G[x - 1, y + j + 1] = 1;
                        G[x - 1, y + j - 1] = 1;
                        G[x, y - 1] = 1;
                        G[x, y + L] = 1;
                        G[x - 1, y] = 1;
                        G[x + 1, y] = 1;
                    }
                    if(D == 2)
                    {
                        G[x + j, y] = (byte)(20 + Len);
                        G[x + j + 1, y + 1] = 1;
                        G[x + j + 1, y - 1] = 1;
                        G[x + j - 1, y + 1] = 1;
                        G[x + j - 1, y - 1] = 1;
                        G[x - 1, y] = 1;
                        G[x + L, y] = 1;
                        G[x, y - 1] = 1;
                        G[x, y + 1] = 1;
                    }
                }
                PlacementCounter++;
            }
        }                 //done

        public void ColorButtons(Button[,] GB, byte[,] G)
        {
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    if((G[i, j] == 0) || (G[i, j] == 1) || (G[i, j] == 5))
                    {
                        GB[i, j].BackColor = System.Drawing.ColorTranslator.FromHtml("#00CED1");
                    }
                    if((G[i, j] / 10 == 2) || (G[i, j] / 2 == 3) || (G[i, j] / 10 == 4))
                    {
                        GB[i, j].BackColor = System.Drawing.ColorTranslator.FromHtml("#92705d");
                    }
                    if((G[i, j] / 10 == 3) || (G[i, j] / 10 == 4) || (G[i, j] == 5))
                    {
                        GB[i, j].Text = "✖";
                    }
                }
            }
        }         //done

        private void btnRand_Click(object sender, EventArgs e)
        {
            DefColor(PB);
            InitialValue(P);
            AIPlace(P, PB);
            ColorButtons(PB, P);
        }    //done



        //custom placement
        private void btnCustom_Click(object sender, EventArgs e)
        {
            DefColor(PB);
            InitialValue(P);

            this.Controls.Remove(this.ErrLabel);

            button341.Enabled = true;
            button331.Enabled = true;
            button332.Enabled = true;
            button321.Enabled = true;
            button322.Enabled = true;
            button323.Enabled = true;
            button311.Enabled = true;
            button312.Enabled = true;
            button313.Enabled = true;
            button314.Enabled = true;
            button341.BackColor = Color.Aquamarine;
            button331.BackColor = Color.Aquamarine;
            button332.BackColor = Color.Aquamarine;
            button321.BackColor = Color.Aquamarine;
            button322.BackColor = Color.Aquamarine;
            button323.BackColor = Color.Aquamarine;
            button311.BackColor = Color.Aquamarine;
            button312.BackColor = Color.Aquamarine;
            button313.BackColor = Color.Aquamarine;
            button314.BackColor = Color.Aquamarine;

            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    PB[i, j].Enabled = true;
                }
            }

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.button323);
            this.Controls.Add(this.button322);
            this.Controls.Add(this.button314);
            this.Controls.Add(this.button313);
            this.Controls.Add(this.button312);
            this.Controls.Add(this.button311);
            this.Controls.Add(this.button321);
            this.Controls.Add(this.button332);
            this.Controls.Add(this.button331);
            this.Controls.Add(this.button341);
            this.Controls.Add(this.radioHorizontal);
            this.Controls.Add(this.radioVertical);
            this.Controls.Add(this.DirQ);
            this.Controls.Add(this.LenQ);
            this.Controls.Add(this.btnCancel);
            this.Controls.Remove(this.btnStart);
            this.Controls.Remove(this.btnRand);
            this.Controls.Remove(this.btnCustom);
        }

        private void Ship_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            this.Controls.Remove(this.ErrLabel);

            Len = Convert.ToInt32(btn.Tag);
            if(Len < 6)
            {
                this.radioHorizontal.Enabled = true;
                this.radioVertical.Enabled = true;
            }
            else
            {
                this.radioHorizontal.Enabled = false;
                this.radioVertical.Enabled = false;
            }
            if(button331.Enabled)
            {
                button331.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button332.Enabled)
            {
                button332.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button321.Enabled)
            {
                button321.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button322.Enabled)
            {
                button322.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button323.Enabled)
            {
                button323.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button311.Enabled)
            {
                button311.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button312.Enabled)
            {
                button312.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button313.Enabled)
            {
                button313.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button314.Enabled)
            {
                button314.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button341.Enabled)
            {
                button341.BackColor = System.Drawing.Color.Aquamarine;
            }
            btn.BackColor = ColorTranslator.FromHtml("#309D9F");
        }
        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(this.ErrLabel);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(radioHorizontal.Checked)
            {
                D = 2;
            }
            if(radioVertical.Checked)
            {
                D = 1;
            }
            Data(P, PB);
            ColorButtons(PB, P);
            if(ok == true)
            {
                switch(Len)
                {
                    case 0:
                        button341.Enabled = false;
                        button341.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 1:
                        button331.Enabled = false;
                        button331.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 2:
                        button332.Enabled = false;
                        button332.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 3:
                        button321.Enabled = false;
                        button321.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 4:
                        button322.Enabled = false;
                        button322.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 5:
                        button323.Enabled = false;
                        button323.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 6:
                        button311.Enabled = false;
                        button311.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 7:
                        button312.Enabled = false;
                        button312.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 8:
                        button313.Enabled = false;
                        button313.BackColor = ColorTranslator.FromHtml("#95AFBB");

                        break;
                    case 9:
                        button314.Enabled = false;
                        button314.BackColor = ColorTranslator.FromHtml("#95AFBB");
                        break;
                }
            }
            else
            {
                this.Controls.Add(this.ErrLabel);
            }

            if(PlacementCounter == 10)
            {
                btnDone.Enabled = true;
            }
            x = 0;
            y = 0;
            Len = -1;
            if(button331.Enabled)
            {
                button331.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button332.Enabled)
            {
                button332.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button321.Enabled)
            {
                button321.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button322.Enabled)
            {
                button322.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button323.Enabled)
            {
                button323.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button311.Enabled)
            {
                button311.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button312.Enabled)
            {
                button312.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button313.Enabled)
            {
                button313.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button314.Enabled)
            {
                button314.BackColor = System.Drawing.Color.Aquamarine;
            }
            if(button341.Enabled)
            {
                button341.BackColor = System.Drawing.Color.Aquamarine;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.btnAdd);
            this.Controls.Remove(this.btnDone);
            this.Controls.Remove(this.btnCancel);
            this.Controls.Remove(this.button323);
            this.Controls.Remove(this.button322);
            this.Controls.Remove(this.button314);
            this.Controls.Remove(this.button313);
            this.Controls.Remove(this.button312);
            this.Controls.Remove(this.button311);
            this.Controls.Remove(this.button321);
            this.Controls.Remove(this.button332);
            this.Controls.Remove(this.button331);
            this.Controls.Remove(this.button341);
            this.Controls.Remove(this.radioHorizontal);
            this.Controls.Remove(this.radioVertical);
            this.Controls.Remove(this.DirQ);
            this.Controls.Remove(this.LenQ);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.btnCustom);
            DefColor(PB);
            InitialValue(P);
            AIPlace(P, PB);
            ColorButtons(PB, P);
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    PB[i, j].Enabled = false;
                }
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(this.btnCancel);
            this.Controls.Remove(this.btnAdd);
            this.Controls.Remove(this.btnDone);
            this.Controls.Remove(this.button323);
            this.Controls.Remove(this.button322);
            this.Controls.Remove(this.button314);
            this.Controls.Remove(this.button313);
            this.Controls.Remove(this.button312);
            this.Controls.Remove(this.button311);
            this.Controls.Remove(this.button321);
            this.Controls.Remove(this.button332);
            this.Controls.Remove(this.button331);
            this.Controls.Remove(this.button341);
            this.Controls.Remove(this.radioHorizontal);
            this.Controls.Remove(this.radioVertical);
            this.Controls.Remove(this.DirQ);
            this.Controls.Remove(this.LenQ);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.btnCustom);
            btnDone.Enabled = false;
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    PB[i, j].Enabled = false;
                }
            }
        }
        //
        ///custom over
        //

        private void btnStart_Click(object sender, EventArgs e)
        {
            EButtonPlace();
            this.btnNewGame.Location = new System.Drawing.Point(330, (this.Width / 2) - (this.btnNewGame.Width / 2));
            this.Controls.Remove(this.btnStart);
            this.Controls.Remove(this.btnRand);
            this.Controls.Remove(this.btnCustom);
            this.Controls.Remove(this.btnCancel);
            this.Controls.Add(this.btnNewGame);
            countE = 0;
            countP = 0;
            for(int i = 0; i < 12; i++)
            {
                P[i, 11] = 5;
                P[i, 0] = 5;
                P[11, i] = 5;
                P[0, i] = 5;
                E[i, 11] = 5;
                E[i, 0] = 5;
                E[11, i] = 5;
                E[0, i] = 5;
            }
            {
                PS0.Location = new Point(30, 30 + 27 * 11);

                PS1.Location = new Point(30, 75 + 27 * 11);
                PS2.Location = new Point(30 + 3 * 27 + 15, 75 + 27 * 11);

                PS3.Location = new Point(30, 120 + 27 * 11);
                PS4.Location = new Point(30 + 2 * 27 + 15, 120 + 27 * 11);
                PS5.Location = new Point(30 + 2 * 27 + 15 + 2 * 27 + 15, 120 + 27 * 11);

                PS6.Location = new Point(30, 165 + 27 * 11);
                PS7.Location = new Point(30 + 27 + 15, 165 + 27 * 11);
                PS8.Location = new Point(30 + 27 + 15 + 27 + 15, 165 + 27 * 11);
                PS9.Location = new Point(30 + 27 + 15 + 27 + 15 + 27 + 15, 165 + 27 * 11);


                ES0.Location = new Point(this.Width - 45 - 4 * 27, 30 + 27 * 11);

                ES1.Location = new Point(this.Width - 45 - 3 * 27, 75 + 27 * 11);
                ES2.Location = new Point(this.Width - 45 - 3 * 27 - 15 - 3 * 27, 75 + 27 * 11);

                ES3.Location = new Point(this.Width - 45 - 2 * 27, 120 + 27 * 11);
                ES4.Location = new Point(this.Width - 45 - 2 * 27 - 15 - 2 * 27, 120 + 27 * 11);
                ES5.Location = new Point(this.Width - 45 - 2 * 27 - 15 - 2 * 27 - 15 - 2 * 27, 120 + 27 * 11);

                ES6.Location = new Point(this.Width - 45 - 1 * 27, 165 + 27 * 11);
                ES7.Location = new Point(this.Width - 45 - 1 * 27 - 15 - 27, 165 + 27 * 11);
                ES8.Location = new Point(this.Width - 45 - 1 * 27 - 15 - 27 - 15 - 27, 165 + 27 * 11);
                ES9.Location = new Point(this.Width - 45 - 1 * 27 - 15 - 27 - 15 - 27 - 15 - 27, 165 + 27 * 11);

                this.Controls.Add(PS0);
                this.Controls.Add(PS1);
                this.Controls.Add(PS2);
                this.Controls.Add(PS3);
                this.Controls.Add(PS4);
                this.Controls.Add(PS5);
                this.Controls.Add(PS6);
                this.Controls.Add(PS7);
                this.Controls.Add(PS8);
                this.Controls.Add(PS9);

                this.Controls.Add(ES0);
                this.Controls.Add(ES1);
                this.Controls.Add(ES2);
                this.Controls.Add(ES3);
                this.Controls.Add(ES4);
                this.Controls.Add(ES5);
                this.Controls.Add(ES6);
                this.Controls.Add(ES7);
                this.Controls.Add(ES8);
                this.Controls.Add(ES9);

            }  //add sunk indicators 
        }


        public void DefColor(Button[,] GB)
        {
            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    GB[i, j].BackColor = System.Drawing.ColorTranslator.FromHtml("#00CED1");
                    GB[i, j].Text = " ";
                }
            }
        }

        //
        ///placement over
        //




        //
        //shooting
        //


        byte[] PI = new byte[6] { 4, 3, 3, 2, 2, 2 };
        byte countE = 0;
        byte countP = 0;

        public void Ebtn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string[] str = btn.Tag.ToString().Split(' ');
            x = Convert.ToByte(str[0]);
            y = Convert.ToByte(str[1]);


            if((E[x, y] == 0) || (E[x, y] == 1))
            {
                EB[x, y].Text = "✖";
                E[x, y] = 5;
                AIShot();
            }                                                        //if water
            else if(E[x, y] / 10 == 2)
            {
                EB[x, y].BackColor = System.Drawing.ColorTranslator.FromHtml("#92705d");
                E[x, y] += 10;
                switch(E[x, y] % 10)
                {
                    case 0:
                        PI[0]--;
                        break;
                    case 1:
                        PI[1]--;
                        break;
                    case 2:
                        PI[2]--;
                        break;
                    case 3:
                        PI[3]--;
                        break;
                    case 4:
                        PI[4]--;
                        break;
                    case 5:
                        PI[5]--;
                        break;
                    case 6:
                        countE++;
                        E[x + 1, y] = 5;
                        E[x - 1, y] = 5;
                        E[x, y + 1] = 5;
                        E[x, y - 1] = 5;

                        EB[x + 1, y].Text = "✖";
                        EB[x - 1, y].Text = "✖";
                        EB[x, y + 1].Text = "✖";
                        EB[x, y - 1].Text = "✖";

                        EB[x + 1, y].Enabled = false;
                        EB[x - 1, y].Enabled = false;
                        EB[x, y + 1].Enabled = false;
                        EB[x, y - 1].Enabled = false;
                        ES6.BackColor = Color.Gray;

                        break;
                    case 7:
                        countE++;
                        E[x + 1, y] = 5;
                        E[x - 1, y] = 5;
                        E[x, y + 1] = 5;
                        E[x, y - 1] = 5;

                        EB[x + 1, y].Text = "✖";
                        EB[x - 1, y].Text = "✖";
                        EB[x, y + 1].Text = "✖";
                        EB[x, y - 1].Text = "✖";

                        EB[x + 1, y].Enabled = false;
                        EB[x - 1, y].Enabled = false;
                        EB[x, y + 1].Enabled = false;
                        EB[x, y - 1].Enabled = false;
                        ES7.BackColor = Color.Gray;

                        break;
                    case 8:
                        countE++;
                        E[x + 1, y] = 5;
                        E[x - 1, y] = 5;
                        E[x, y + 1] = 5;
                        E[x, y - 1] = 5;

                        EB[x + 1, y].Text = "✖";
                        EB[x - 1, y].Text = "✖";
                        EB[x, y + 1].Text = "✖";
                        EB[x, y - 1].Text = "✖";

                        EB[x + 1, y].Enabled = false;
                        EB[x - 1, y].Enabled = false;
                        EB[x, y + 1].Enabled = false;
                        EB[x, y - 1].Enabled = false;
                        ES8.BackColor = Color.Gray;

                        break;
                    case 9:
                        countE++;
                        E[x + 1, y] = 5;
                        E[x - 1, y] = 5;
                        E[x, y + 1] = 5;
                        E[x, y - 1] = 5;

                        EB[x + 1, y].Text = "✖";
                        EB[x - 1, y].Text = "✖";
                        EB[x, y + 1].Text = "✖";
                        EB[x, y - 1].Text = "✖";

                        EB[x + 1, y].Enabled = false;
                        EB[x - 1, y].Enabled = false;
                        EB[x, y + 1].Enabled = false;
                        EB[x, y - 1].Enabled = false;
                        ES9.BackColor = Color.Gray;

                        break;
                }

                {
                    E[x + 1, y + 1] = 5;
                    E[x + 1, y - 1] = 5;
                    E[x - 1, y + 1] = 5;
                    E[x - 1, y - 1] = 5;
                    EB[x + 1, y + 1].Text = "✖";
                    EB[x + 1, y - 1].Text = "✖";
                    EB[x - 1, y + 1].Text = "✖";
                    EB[x - 1, y - 1].Text = "✖";
                    EB[x + 1, y + 1].Enabled = false;
                    EB[x + 1, y - 1].Enabled = false;
                    EB[x - 1, y + 1].Enabled = false;
                    EB[x - 1, y - 1].Enabled = false;

                }//corner x

                int K = E[x, y] % 10;
                if((K >= 0) && (K <= 5) && (PI[K] == 0))
                {
                    switch(K)
                    {
                        case 0:
                            ES0.BackColor = Color.Gray;
                            break;
                        case 1:
                            ES1.BackColor = Color.Gray;
                            break;
                        case 2:
                            ES2.BackColor = Color.Gray;
                            break;
                        case 3:
                            ES3.BackColor = Color.Gray;
                            break;
                        case 4:
                            ES4.BackColor = Color.Gray;
                            break;
                        case 5:
                            ES5.BackColor = Color.Gray;
                            break;
                    }
                    E[x, y] += 10;
                    int j = 1;
                    countE++;
                    while(E[x + j, y] / 10 == 3)
                    {
                        E[x + j, y] += 10;
                        j++;
                    } //to the right

                    E[x + j, y] = 5;
                    EB[x + j, y].Text = "✖";
                    EB[x + j, y].Enabled = false;
                    j = 1;


                    while(E[x - j, y] / 10 == 3)
                    {
                        E[x - j, y] += 10;
                        j++;
                    } //to the left

                    E[x - j, y] = 5;
                    EB[x - j, y].Text = "✖";
                    EB[x - j, y].Enabled = false;
                    j = 1;


                    while(E[x, y + j] / 10 == 3)
                    {
                        E[x, y + j] += 10;
                        j++;
                    }//down

                    E[x, y + j] = 5;
                    EB[x, y + j].Text = "✖";
                    EB[x, y + j].Enabled = false;
                    j = 1;


                    while(E[x, y - j] / 10 == 3)
                    {
                        E[x, y - j] += 10;
                        j++;
                    }//up

                    E[x, y - j] = 5;
                    EB[x, y - j].Text = "✖";
                    EB[x, y - j].Enabled = false;
                    j = 1;
                }//if sunk

            }                                                                  //if ship
            EB[x, y].Enabled = false;

            if(countE == 10)
            {
                for(int i = 0; i < 12; i++)
                {
                    for(int j = 0; j < 12; j++)
                    {
                        EB[i, j].Enabled = false;
                    }
                }
                WinL.Text = "Ön nyert!";
                this.WinL.Location = new System.Drawing.Point((this.Width / 2) - 68, 240);
                this.btnQuit.Location = new System.Drawing.Point((this.Width / 2) - (this.btnQuit.Width / 2) - 14, 300);
                this.btnNewGame.Location = new System.Drawing.Point((this.Width / 2) - (this.btnNewGame.Width / 2) - 14, 270);
                this.Controls.Add(WinL);
                this.Controls.Add(btnQuit);
            }   //win screen
        }




        byte[] EI = new byte[6] { 4, 3, 3, 2, 2, 2 };
        bool ok1 = true;
        byte x1;
        byte y1;
        short v = 0;
        short h = 0;
        public void AIShot()
        {
            v = 0;
            h = 0;

            do
            {
                ok = false;

                if(ok1 == false)
                {
                    v = 0;
                    h = 0;
                    byte r = (byte)(rand.Next(1, 5));
                    switch(r)
                    {
                        case 1:
                            h = 1;
                            if(x1 == 10)
                            {
                                h = -1;
                            }
                            break;  //right
                        case 2:
                            h = -1;
                            if(x1 == 1)
                            {
                                h = 1;
                            }
                            break;  //left
                        case 3:
                            v = -1;
                            if(y1 == 1)
                            {
                                h = 1;
                            }

                            break;  //up
                        case 4:
                            v = 1;
                            if(y1 == 10)
                            {
                                h = -1;
                            }
                            break;  //down
                    }

                    if((P[x1 + h, y1 + v] == 0) || (P[x1 + h, y1 + v] == 1))
                    {
                        PB[x1 + h, y1 + v].Text = "✖";
                        P[x1 + h, y1 + v] = 5;
                        ok = true;
                    }                                                                //if water
                    else if((P[x1 + h, y1 + v] == 5) || (P[x1 + h, y1 + v] / 10 == 3) || (P[x1 + h, y1 + v] / 10 == 4))
                    {
                        ok = false;
                    }                     //if already shot
                    else if(P[x1 + h, y1 + v] / 10 == 2)
                    {
                        while(P[x1 + h, y1 + v] / 10 == 2)
                        {
                            ok = false;
                            PB[x1 + h, y1 + v].Text = "✖";
                            P[x1 + h, y1 + v] += 10;
                            switch(P[x1 + h, y1 + v] % 10)
                            {
                                case 0:
                                    EI[0]--;
                                    break;
                                case 1:
                                    EI[1]--;
                                    break;
                                case 2:
                                    EI[2]--;
                                    break;
                                case 3:
                                    EI[3]--;
                                    break;
                                case 4:
                                    EI[4]--;
                                    break;
                                case 5:
                                    EI[5]--;
                                    break;
                            }
                            {
                                P[x1 + h + 1, y1 + v + 1] = 5;
                                P[x1 + h + 1, y1 + v - 1] = 5;
                                P[x1 + h - 1, y1 + v + 1] = 5;
                                P[x1 + h - 1, y1 + v - 1] = 5;
                                PB[x1 + h + 1, y1 + v + 1].Text = "✖";
                                PB[x1 + h + 1, y1 + v - 1].Text = "✖";
                                PB[x1 + h - 1, y1 + v + 1].Text = "✖";
                                PB[x1 + h - 1, y1 + v - 1].Text = "✖";
                            }  //corner x

                            int K = P[x1 + h, y1 + v] % 10;
                            if((K >= 0) && (K <= 5) && (EI[K] == 0))
                            {
                                switch(K)
                                {
                                    case 0:
                                        PS0.BackColor = Color.Gray;
                                        break;
                                    case 1:
                                        PS1.BackColor = Color.Gray;
                                        break;
                                    case 2:
                                        PS2.BackColor = Color.Gray;
                                        break;
                                    case 3:
                                        PS3.BackColor = Color.Gray;
                                        break;
                                    case 4:
                                        PS4.BackColor = Color.Gray;
                                        break;
                                    case 5:
                                        PS5.BackColor = Color.Gray;
                                        break;
                                }
                                ok1 = true;
                                ok = false;
                                P[x1 + h, y1 + v] += 10;
                                int j = 1;
                                countP++;
                                while(P[x1 + h + j, y1 + v] / 10 == 3)
                                {
                                    P[x1 + h + j, y1 + v] += 10;
                                    j++;
                                } //to the right

                                P[x1 + h + j, y1 + v] = 5;
                                PB[x1 + h + j, y1 + v].Text = "✖";
                                j = 1;


                                while(P[x1 + h - j, y1 + v] / 10 == 3)
                                {
                                    P[x1 + h - j, y1 + v] += 10;
                                    j++;
                                } //to the left

                                P[x1 + h - j, y1 + v] = 5;
                                PB[x1 + h - j, y1 + v].Text = "✖";
                                j = 1;


                                while(P[x1 + h, y1 + v + j] / 10 == 3)
                                {
                                    P[x1 + h, y1 + v + j] += 10;
                                    j++;
                                }//down

                                P[x1 + h, y1 + v + j] = 5;
                                PB[x1 + h, y1 + v + j].Text = "✖";
                                j = 1;


                                while(P[x1 + h, y1 + v - j] / 10 == 3)
                                {
                                    P[x1 + h, y1 + v - j] += 10;
                                    j++;
                                }//up

                                P[x1 + h, y1 + v - j] = 5;
                                PB[x1 + h, y1 + v - j].Text = "✖";
                                j = 1;
                            }                                                    //if sunk

                            if(v > 0)
                            {
                                v++;
                            }
                            else if(v < 0)
                            {
                                v--;
                            }
                            else if(h > 0)
                            {
                                h++;
                            }
                            else if(h < 0)
                            {
                                h--;
                            }

                        }
                        if((P[x1 + h, y1 + v] == 0) || (P[x1 + h, y1 + v] == 1))
                        {
                            PB[x1 + h, y1 + v].Text = "✖";
                            P[x1 + h, y1 + v] = 5;
                            ok = true;
                        }                                                        //if water
                        else if((P[x1 + h, y1 + v] == 5) || (P[x1 + h, y1 + v] / 10 == 3) || (P[x1 + h, y1 + v] / 10 == 4))
                        {
                            ok = false;
                        }                     //if already shot
                    }                                                                                    //if ship

                }
                else if(ok == false)
                {
                    x1 = (Byte)(rand.Next(1, 11));
                    y1 = (Byte)(rand.Next(1, 11));
                    if((P[x1, y1] == 0) || (P[x1, y1] == 1))
                    {
                        PB[x1, y1].Text = "✖";
                        P[x1, y1] = 5;
                        ok = true;
                    }                                                        //if water
                    else if((P[x1, y1] == 5) || (P[x1, y1] / 10 == 3) || (P[x1, y1] / 10 == 4))
                    {
                        ok = false;
                    }                     //if already shot
                    else if(P[x1, y1] / 10 == 2)
                    {
                        ok1 = false;
                        PB[x1, y1].Text = "✖";
                        P[x1, y1] += 10;
                        switch(P[x1, y1] % 10)
                        {
                            case 0:
                                EI[0]--;
                                break;
                            case 1:
                                EI[1]--;
                                break;
                            case 2:
                                EI[2]--;
                                break;
                            case 3:
                                EI[3]--;
                                break;
                            case 4:
                                EI[4]--;
                                break;
                            case 5:
                                EI[5]--;
                                break;
                            case 6:
                                countP++;
                                ok1 = true;
                                ok = false;
                                P[x1, y1] += 10;
                                P[x1 + 1, y1] = 5;
                                P[x1 - 1, y1] = 5;
                                P[x1, y1 + 1] = 5;
                                P[x1, y1 - 1] = 5;

                                PB[x1 + 1, y1].Text = "✖";
                                PB[x1 - 1, y1].Text = "✖";
                                PB[x1, y1 + 1].Text = "✖";
                                PB[x1, y1 - 1].Text = "✖";
                                PS6.BackColor = Color.Gray;
                                break;
                            case 7:
                                P[x1, y1] += 10;
                                countP++;
                                ok1 = true;
                                ok = false;
                                P[x1 + 1, y1] = 5;
                                P[x1 - 1, y1] = 5;
                                P[x1, y1 + 1] = 5;
                                P[x1, y1 - 1] = 5;

                                PB[x1 + 1, y1].Text = "✖";
                                PB[x1 - 1, y1].Text = "✖";
                                PB[x1, y1 + 1].Text = "✖";
                                PB[x1, y1 - 1].Text = "✖";
                                PS7.BackColor = Color.Gray;
                                break;
                            case 8:
                                P[x1, y1] += 10;
                                countP++;
                                ok1 = true;
                                ok = false;
                                P[x1 + 1, y1] = 5;
                                P[x1 - 1, y1] = 5;
                                P[x1, y1 + 1] = 5;
                                P[x1, y1 - 1] = 5;

                                PB[x1 + 1, y1].Text = "✖";
                                PB[x1 - 1, y1].Text = "✖";
                                PB[x1, y1 + 1].Text = "✖";
                                PB[x1, y1 - 1].Text = "✖";
                                PS8.BackColor = Color.Gray;
                                break;
                            case 9:
                                P[x1, y1] += 10;
                                countP++;
                                ok1 = true;
                                ok = false;
                                P[x1 + 1, y1] = 5;
                                P[x1 - 1, y1] = 5;
                                P[x1, y1 + 1] = 5;
                                P[x1, y1 - 1] = 5;

                                PB[x1 + 1, y1].Text = "✖";
                                PB[x1 - 1, y1].Text = "✖";
                                PB[x1, y1 + 1].Text = "✖";
                                PB[x1, y1 - 1].Text = "✖";
                                PS9.BackColor = Color.Gray;
                                break;
                        }

                        {
                            P[x1 + 1, y1 + 1] = 5;
                            P[x1 + 1, y1 - 1] = 5;
                            P[x1 - 1, y1 + 1] = 5;
                            P[x1 - 1, y1 - 1] = 5;
                            PB[x1 + 1, y1 + 1].Text = "✖";
                            PB[x1 + 1, y1 - 1].Text = "✖";
                            PB[x1 - 1, y1 + 1].Text = "✖";
                            PB[x1 - 1, y1 - 1].Text = "✖";

                        }  //corner x
                    }                                                                    //if ship
                }
                if(countP == 10)
                {
                    for(int i = 0; i < 12; i++)
                    {
                        for(int j = 0; j < 12; j++)
                        {
                            EB[i, j].Enabled = false;
                        }
                    }
                    ok = true;
                    ok1 = true;
                    this.WinL.Location = new System.Drawing.Point((this.Width / 2) - /*(this.WinL.Width / 2) -*/ 85, 240);
                    this.btnQuit.Location = new System.Drawing.Point((this.Width / 2) - (this.btnQuit.Width / 2) - 14, 300);
                    this.btnNewGame.Location = new System.Drawing.Point((this.Width / 2) - (this.btnNewGame.Width / 2) - 14, 270);
                    this.WinL.Text = "Ön vesztett!";
                    this.Controls.Add(WinL);
                    this.Controls.Add(btnQuit);
                }  //win screen
            } while((ok == false));

        }//ok is false if rand is already shot, ok1 is false, if rand is ship

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            v = 0;
            h = 0;
            x1 = 0;
            y1 = 0;
            ok = true;
            ok1 = true;

            for(int i = 0; i < 12; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    if((i == 0) || (i == 11) || (j == 0) || (j == 11))
                    {
                    }
                    else
                    {
                        this.Controls.Remove(EB[i, j]);
                    }
                }
            }
            EI[0] = 4;
            EI[1] = 3;
            EI[2] = 3;
            EI[3] = 2;
            EI[4] = 2;
            EI[5] = 2;
            PI[0] = 4;
            PI[1] = 3;
            PI[2] = 3;
            PI[3] = 2;
            PI[4] = 2;
            PI[5] = 2;

            {
                PS0.BackColor = Color.Aquamarine;
                PS1.BackColor = Color.Aquamarine;
                PS2.BackColor = Color.Aquamarine;
                PS3.BackColor = Color.Aquamarine;
                PS4.BackColor = Color.Aquamarine;
                PS5.BackColor = Color.Aquamarine;
                PS6.BackColor = Color.Aquamarine;
                PS7.BackColor = Color.Aquamarine;
                PS8.BackColor = Color.Aquamarine;
                PS9.BackColor = Color.Aquamarine;


                ES0.BackColor = Color.Aquamarine;
                ES1.BackColor = Color.Aquamarine;
                ES2.BackColor = Color.Aquamarine;
                ES3.BackColor = Color.Aquamarine;
                ES4.BackColor = Color.Aquamarine;
                ES5.BackColor = Color.Aquamarine;
                ES6.BackColor = Color.Aquamarine;
                ES7.BackColor = Color.Aquamarine;
                ES8.BackColor = Color.Aquamarine;
                ES9.BackColor = Color.Aquamarine;

                this.Controls.Remove(PS0);
                this.Controls.Remove(PS1);
                this.Controls.Remove(PS2);
                this.Controls.Remove(PS3);
                this.Controls.Remove(PS4);
                this.Controls.Remove(PS5);
                this.Controls.Remove(PS6);
                this.Controls.Remove(PS7);
                this.Controls.Remove(PS8);
                this.Controls.Remove(PS9);

                this.Controls.Remove(ES0);
                this.Controls.Remove(ES1);
                this.Controls.Remove(ES2);
                this.Controls.Remove(ES3);
                this.Controls.Remove(ES4);
                this.Controls.Remove(ES5);
                this.Controls.Remove(ES6);
                this.Controls.Remove(ES8);
                this.Controls.Remove(ES7);
                this.Controls.Remove(ES9);

            }  //remove, reset sunk indicator

            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.btnCustom);
            this.Controls.Remove(this.btnNewGame);
            this.Controls.Remove(WinL);
            this.Controls.Remove(btnQuit);
            InitialValue(P);
            InitialValue(E);
            DefColor(PB);
            AIPlace(P, PB);  //debug
            ColorButtons(PB, P);
            EButtonProp();
            AIPlace(E, EB);

        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
