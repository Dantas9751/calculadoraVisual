

namespace calculadoraVisual
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
            btn8 = new Button();
            txtVisor = new TextBox();
            btn9 = new Button();
            btn7 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnBinario = new Button();
            btnFatorial = new Button();
            btnSeno = new Button();
            btnCosseno = new Button();
            btnTangente = new Button();
            btn0 = new Button();
            btnPonto = new Button();
            btnIgual = new Button();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // btn8
            // 
            btn8.BackgroundImage = Properties.Resources.botao_8;
            btn8.BackgroundImageLayout = ImageLayout.Stretch;
            btn8.Cursor = Cursors.Hand;
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 1F);
            btn8.Location = new Point(82, 219);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 64);
            btn8.TabIndex = 0;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumero_Click;
            // 
            // txtVisor
            // 
            txtVisor.BackColor = Color.WhiteSmoke;
            txtVisor.BorderStyle = BorderStyle.FixedSingle;
            txtVisor.Enabled = false;
            txtVisor.Font = new Font("Segoe UI", 12F);
            txtVisor.ForeColor = SystemColors.Info;
            txtVisor.Location = new Point(12, 50);
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.Size = new Size(204, 29);
            txtVisor.TabIndex = 1;
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn9
            // 
            btn9.BackgroundImage = Properties.Resources.botao_9;
            btn9.BackgroundImageLayout = ImageLayout.Stretch;
            btn9.Cursor = Cursors.Hand;
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 1F);
            btn9.Location = new Point(152, 219);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 64);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumero_Click;
            // 
            // btn7
            // 
            btn7.BackgroundImage = Properties.Resources.botao_7;
            btn7.BackgroundImageLayout = ImageLayout.Stretch;
            btn7.Cursor = Cursors.Hand;
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 1F);
            btn7.Location = new Point(12, 219);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 64);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumero_Click;
            // 
            // btn3
            // 
            btn3.BackgroundImage = Properties.Resources.botao_3;
            btn3.BackgroundImageLayout = ImageLayout.Stretch;
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 1F);
            btn3.Location = new Point(152, 85);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 64);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.TextAlign = ContentAlignment.MiddleLeft;
            btn3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumero_Click;
            // 
            // btn2
            // 
            btn2.BackgroundImage = Properties.Resources.botao_2;
            btn2.BackgroundImageLayout = ImageLayout.Stretch;
            btn2.Cursor = Cursors.Hand;
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 1F);
            btn2.Location = new Point(82, 85);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 64);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumero_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.BackgroundImage = Properties.Resources.botao_1;
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.Cursor = Cursors.Hand;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 1F);
            btn1.Location = new Point(12, 85);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 64);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNumero_Click;
            // 
            // btn6
            // 
            btn6.BackgroundImage = Properties.Resources.botao_6;
            btn6.BackgroundImageLayout = ImageLayout.Stretch;
            btn6.Cursor = Cursors.Hand;
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Microsoft Sans Serif", 1F);
            btn6.ForeColor = Color.White;
            btn6.Location = new Point(152, 151);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 64);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumero_Click;
            // 
            // btn5
            // 
            btn5.BackgroundImage = Properties.Resources.botao_5;
            btn5.BackgroundImageLayout = ImageLayout.Stretch;
            btn5.Cursor = Cursors.Hand;
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 1F);
            btn5.Location = new Point(82, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 64);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumero_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDarkDark;
            btn4.BackgroundImage = Properties.Resources.botao_4;
            btn4.BackgroundImageLayout = ImageLayout.Stretch;
            btn4.Cursor = Cursors.Hand;
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 1F);
            btn4.Location = new Point(12, 152);
            btn4.Margin = new Padding(0);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 64);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNumero_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.BackgroundImage = Properties.Resources.pixil_frame_0__11_;
            btnAdicao.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicao.Cursor = Cursors.Hand;
            btnAdicao.FlatAppearance.BorderSize = 0;
            btnAdicao.FlatStyle = FlatStyle.Flat;
            btnAdicao.Font = new Font("Segoe UI", 1F);
            btnAdicao.Location = new Point(222, 152);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(40, 40);
            btnAdicao.TabIndex = 10;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackgroundImage = Properties.Resources.pixil_frame_0__12_;
            btnSubtracao.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubtracao.Cursor = Cursors.Hand;
            btnSubtracao.FlatAppearance.BorderSize = 0;
            btnSubtracao.FlatStyle = FlatStyle.Flat;
            btnSubtracao.Font = new Font("Segoe UI", 1F);
            btnSubtracao.Location = new Point(222, 198);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(40, 40);
            btnSubtracao.TabIndex = 11;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackgroundImage = Properties.Resources.pixil_frame_0__14_;
            btnMultiplicacao.BackgroundImageLayout = ImageLayout.Stretch;
            btnMultiplicacao.Cursor = Cursors.Hand;
            btnMultiplicacao.FlatAppearance.BorderSize = 0;
            btnMultiplicacao.FlatStyle = FlatStyle.Flat;
            btnMultiplicacao.Font = new Font("Segoe UI", 1F);
            btnMultiplicacao.Location = new Point(222, 290);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(40, 40);
            btnMultiplicacao.TabIndex = 12;
            btnMultiplicacao.Text = "*";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackgroundImage = Properties.Resources.pixil_frame_0__13_;
            btnDivisao.BackgroundImageLayout = ImageLayout.Stretch;
            btnDivisao.Cursor = Cursors.Hand;
            btnDivisao.FlatAppearance.BorderSize = 0;
            btnDivisao.FlatStyle = FlatStyle.Flat;
            btnDivisao.Font = new Font("Segoe UI", 1F);
            btnDivisao.Location = new Point(222, 244);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(40, 40);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnBinario
            // 
            btnBinario.BackgroundImage = Properties.Resources.pixil_frame_0__9_;
            btnBinario.BackgroundImageLayout = ImageLayout.Stretch;
            btnBinario.Cursor = Cursors.Hand;
            btnBinario.FlatAppearance.BorderSize = 0;
            btnBinario.FlatStyle = FlatStyle.Flat;
            btnBinario.Font = new Font("Segoe UI", 1F);
            btnBinario.Location = new Point(348, 85);
            btnBinario.Name = "btnBinario";
            btnBinario.Size = new Size(50, 50);
            btnBinario.TabIndex = 14;
            btnBinario.Text = "Binario";
            btnBinario.UseVisualStyleBackColor = true;
            btnBinario.Click += btnBinario_Click;
            // 
            // btnFatorial
            // 
            btnFatorial.BackgroundImage = Properties.Resources.pixil_frame_0__10_;
            btnFatorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnFatorial.Cursor = Cursors.Hand;
            btnFatorial.FlatAppearance.BorderSize = 0;
            btnFatorial.FlatStyle = FlatStyle.Flat;
            btnFatorial.Font = new Font("Segoe UI", 1F);
            btnFatorial.Location = new Point(292, 85);
            btnFatorial.Name = "btnFatorial";
            btnFatorial.Size = new Size(50, 50);
            btnFatorial.TabIndex = 15;
            btnFatorial.Text = "Fatorial";
            btnFatorial.UseVisualStyleBackColor = true;
            btnFatorial.Click += btnFatorial_Click;
            // 
            // btnSeno
            // 
            btnSeno.BackgroundImage = Properties.Resources.pixil_frame_0__6_;
            btnSeno.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeno.Cursor = Cursors.Hand;
            btnSeno.FlatAppearance.BorderSize = 0;
            btnSeno.FlatStyle = FlatStyle.Flat;
            btnSeno.Font = new Font("Segoe UI", 1F);
            btnSeno.Location = new Point(292, 141);
            btnSeno.Name = "btnSeno";
            btnSeno.Size = new Size(50, 50);
            btnSeno.TabIndex = 16;
            btnSeno.Text = "Seno";
            btnSeno.UseVisualStyleBackColor = true;
            btnSeno.Click += btnSeno_Click;
            // 
            // btnCosseno
            // 
            btnCosseno.BackgroundImage = Properties.Resources.pixil_frame_0__7_;
            btnCosseno.BackgroundImageLayout = ImageLayout.Stretch;
            btnCosseno.Cursor = Cursors.Hand;
            btnCosseno.FlatAppearance.BorderSize = 0;
            btnCosseno.FlatStyle = FlatStyle.Flat;
            btnCosseno.Font = new Font("Segoe UI", 1F);
            btnCosseno.Location = new Point(348, 197);
            btnCosseno.Name = "btnCosseno";
            btnCosseno.Size = new Size(50, 50);
            btnCosseno.TabIndex = 17;
            btnCosseno.Text = "Cosseno";
            btnCosseno.UseVisualStyleBackColor = true;
            btnCosseno.Click += btnCosseno_Click;
            // 
            // btnTangente
            // 
            btnTangente.BackgroundImage = Properties.Resources.pixil_frame_0__8_;
            btnTangente.BackgroundImageLayout = ImageLayout.Stretch;
            btnTangente.Cursor = Cursors.Hand;
            btnTangente.FlatAppearance.BorderSize = 0;
            btnTangente.FlatStyle = FlatStyle.Flat;
            btnTangente.Font = new Font("Segoe UI", 1F);
            btnTangente.Location = new Point(348, 141);
            btnTangente.Name = "btnTangente";
            btnTangente.Size = new Size(50, 50);
            btnTangente.TabIndex = 18;
            btnTangente.Text = "Tangente";
            btnTangente.UseVisualStyleBackColor = true;
            btnTangente.Click += btnTangente_Click;
            // 
            // btn0
            // 
            btn0.BackgroundImage = Properties.Resources.botao_0;
            btn0.BackgroundImageLayout = ImageLayout.Stretch;
            btn0.Cursor = Cursors.Hand;
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 1F);
            btn0.Location = new Point(82, 289);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 64);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumero_Click;
            // 
            // btnPonto
            // 
            btnPonto.BackgroundImage = Properties.Resources.pixil_frame_0__2_1;
            btnPonto.BackgroundImageLayout = ImageLayout.Stretch;
            btnPonto.Cursor = Cursors.Hand;
            btnPonto.FlatAppearance.BorderSize = 0;
            btnPonto.FlatStyle = FlatStyle.Flat;
            btnPonto.Font = new Font("Segoe UI", 1F);
            btnPonto.Location = new Point(12, 289);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(64, 64);
            btnPonto.TabIndex = 20;
            btnPonto.Text = ",";
            btnPonto.UseVisualStyleBackColor = true;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackgroundImage = Properties.Resources.pixil_frame_0;
            btnIgual.BackgroundImageLayout = ImageLayout.Stretch;
            btnIgual.Cursor = Cursors.Hand;
            btnIgual.FlatAppearance.BorderSize = 0;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI", 1F);
            btnIgual.Location = new Point(152, 289);
            btnIgual.Margin = new Padding(0);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(64, 64);
            btnIgual.TabIndex = 21;
            btnIgual.Text = "=";
            btnIgual.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnApagar
            // 
            btnApagar.BackgroundImage = Properties.Resources.pixil_frame_0__5_;
            btnApagar.BackgroundImageLayout = ImageLayout.Stretch;
            btnApagar.Cursor = Cursors.Hand;
            btnApagar.FlatAppearance.BorderSize = 0;
            btnApagar.FlatStyle = FlatStyle.Flat;
            btnApagar.Font = new Font("Segoe UI", 1F);
            btnApagar.Location = new Point(222, 85);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(64, 64);
            btnApagar.TabIndex = 22;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pixil_frame_0__4_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(484, 461);
            Controls.Add(btnApagar);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btn0);
            Controls.Add(btnTangente);
            Controls.Add(btnCosseno);
            Controls.Add(btnSeno);
            Controls.Add(btnFatorial);
            Controls.Add(btnBinario);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn7);
            Controls.Add(btn9);
            Controls.Add(txtVisor);
            Controls.Add(btn8);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Calculator++";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn8;
        private TextBox txtVisor;
        private Button btn9;
        private Button btn7;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnBinario;
        private Button btnFatorial;
        private Button btnSeno;
        private Button btnCosseno;
        private Button btnTangente;
        private Button btn0;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnApagar;
    }
    }
