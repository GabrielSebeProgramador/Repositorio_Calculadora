
using System;

namespace Calculadora_completo_
{
    partial class frmCalculo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblcalculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHistorico
            // 
            this.txtHistorico.BackColor = System.Drawing.Color.Black;
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHistorico.Location = new System.Drawing.Point(12, 37);
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(356, 29);
            this.txtHistorico.TabIndex = 0;
            this.txtHistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Black;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResultado.Location = new System.Drawing.Point(12, 72);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(356, 41);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(12, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(67, 57);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(85, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 57);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(158, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 57);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(12, 195);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 57);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(85, 195);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 57);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(158, 195);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 57);
            this.btn6.TabIndex = 2;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(12, 258);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 57);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(85, 258);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 57);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(158, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 57);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.Black;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVirgula.Location = new System.Drawing.Point(158, 321);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(67, 57);
            this.btnVirgula.TabIndex = 2;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(12, 321);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(140, 57);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.ClicouBotao_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(244, 132);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 57);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.Black;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackspace.Location = new System.Drawing.Point(317, 132);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(51, 57);
            this.btnBackspace.TabIndex = 2;
            this.btnBackspace.Text = "<---";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Black;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSoma.Location = new System.Drawing.Point(244, 195);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(51, 57);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Black;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSub.Location = new System.Drawing.Point(317, 195);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(51, 57);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Black;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMulti.Location = new System.Drawing.Point(244, 258);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(51, 57);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "x";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Black;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDiv.Location = new System.Drawing.Point(317, 258);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(51, 57);
            this.btnDiv.TabIndex = 2;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.Black;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRaiz.Location = new System.Drawing.Point(244, 321);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(51, 57);
            this.btnRaiz.TabIndex = 2;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Black;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIgual.Location = new System.Drawing.Point(317, 321);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(51, 57);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblcalculo
            // 
            this.lblcalculo.AutoSize = true;
            this.lblcalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcalculo.Location = new System.Drawing.Point(80, 9);
            this.lblcalculo.Name = "lblcalculo";
            this.lblcalculo.Size = new System.Drawing.Size(188, 29);
            this.lblcalculo.TabIndex = 3;
            this.lblcalculo.Text = "CALCULADORA";
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.lblcalculo);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtHistorico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            backspace();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            FunçãoSoma();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FunçãoSubtrair();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            FunçãoMulti();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FunçãoDiv();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            FunçãoIgual();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            FunçãoRaiz();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblcalculo;
    }
}

