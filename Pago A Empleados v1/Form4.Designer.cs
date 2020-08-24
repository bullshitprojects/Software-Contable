namespace ModernGUI_V3
{
    partial class Form4
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
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deducciones = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAguinaldoNoGravado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAguinaldoGravado = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMontoGravado = new System.Windows.Forms.TextBox();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.txtIsss = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.semestre2 = new System.Windows.Forms.Panel();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.deducciones.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.semestre2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 43);
            this.panel2.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label13.Location = new System.Drawing.Point(384, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(272, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "Para Cálculo de Constancia";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(924, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.deducciones);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.semestre2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(1, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1003, 458);
            this.panel4.TabIndex = 36;
            // 
            // deducciones
            // 
            this.deducciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deducciones.Controls.Add(this.label22);
            this.deducciones.Controls.Add(this.txtAguinaldoNoGravado);
            this.deducciones.Controls.Add(this.label15);
            this.deducciones.Controls.Add(this.label20);
            this.deducciones.Controls.Add(this.txtAguinaldoGravado);
            this.deducciones.Controls.Add(this.label19);
            this.deducciones.Controls.Add(this.txtSalario);
            this.deducciones.Controls.Add(this.label14);
            this.deducciones.Controls.Add(this.txtMontoGravado);
            this.deducciones.Controls.Add(this.txtRenta);
            this.deducciones.Controls.Add(this.label16);
            this.deducciones.Controls.Add(this.label18);
            this.deducciones.Controls.Add(this.txtAfp);
            this.deducciones.Controls.Add(this.txtIsss);
            this.deducciones.Location = new System.Drawing.Point(632, 169);
            this.deducciones.Margin = new System.Windows.Forms.Padding(2);
            this.deducciones.Name = "deducciones";
            this.deducciones.Size = new System.Drawing.Size(276, 284);
            this.deducciones.TabIndex = 40;
            this.deducciones.Visible = false;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(2, 122);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(194, 20);
            this.label22.TabIndex = 30;
            this.label22.Text = "- Aguinaldo No Gravado:";
            // 
            // txtAguinaldoNoGravado
            // 
            this.txtAguinaldoNoGravado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAguinaldoNoGravado.Enabled = false;
            this.txtAguinaldoNoGravado.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAguinaldoNoGravado.Location = new System.Drawing.Point(199, 119);
            this.txtAguinaldoNoGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtAguinaldoNoGravado.Name = "txtAguinaldoNoGravado";
            this.txtAguinaldoNoGravado.Size = new System.Drawing.Size(68, 25);
            this.txtAguinaldoNoGravado.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(90, 227);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Monto Renta:";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 159);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(173, 20);
            this.label20.TabIndex = 27;
            this.label20.Text = "+ Aguinaldo Gravado:";
            // 
            // txtAguinaldoGravado
            // 
            this.txtAguinaldoGravado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAguinaldoGravado.Enabled = false;
            this.txtAguinaldoGravado.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAguinaldoGravado.Location = new System.Drawing.Point(199, 156);
            this.txtAguinaldoGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtAguinaldoGravado.Name = "txtAguinaldoGravado";
            this.txtAguinaldoGravado.Size = new System.Drawing.Size(68, 25);
            this.txtAguinaldoGravado.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(96, 17);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "Total Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSalario.Enabled = false;
            this.txtSalario.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(198, 14);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(68, 25);
            this.txtSalario.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(66, 195);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Monto Gravado:";
            // 
            // txtMontoGravado
            // 
            this.txtMontoGravado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMontoGravado.Enabled = false;
            this.txtMontoGravado.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoGravado.Location = new System.Drawing.Point(200, 192);
            this.txtMontoGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoGravado.Name = "txtMontoGravado";
            this.txtMontoGravado.Size = new System.Drawing.Size(68, 25);
            this.txtMontoGravado.TabIndex = 22;
            // 
            // txtRenta
            // 
            this.txtRenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRenta.Enabled = false;
            this.txtRenta.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenta.Location = new System.Drawing.Point(200, 224);
            this.txtRenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(68, 25);
            this.txtRenta.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(109, 89);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "- Total ISSS:";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(108, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "- Total AFP:";
            // 
            // txtAfp
            // 
            this.txtAfp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAfp.Enabled = false;
            this.txtAfp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfp.Location = new System.Drawing.Point(198, 50);
            this.txtAfp.Margin = new System.Windows.Forms.Padding(2);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Size = new System.Drawing.Size(68, 25);
            this.txtAfp.TabIndex = 14;
            // 
            // txtIsss
            // 
            this.txtIsss.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIsss.Enabled = false;
            this.txtIsss.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsss.Location = new System.Drawing.Point(198, 86);
            this.txtIsss.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsss.Name = "txtIsss";
            this.txtIsss.Size = new System.Drawing.Size(68, 25);
            this.txtIsss.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.btnLimpiar);
            this.panel6.Controls.Add(this.txt13);
            this.panel6.Controls.Add(this.btnCalcular);
            this.panel6.Location = new System.Drawing.Point(688, 29);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(214, 136);
            this.panel6.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 16);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Aguinaldo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(13, 102);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 29);
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // txt13
            // 
            this.txt13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt13.Location = new System.Drawing.Point(111, 13);
            this.txt13.Margin = new System.Windows.Forms.Padding(2);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(90, 25);
            this.txt13.TabIndex = 24;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Location = new System.Drawing.Point(13, 56);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(192, 29);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Cálcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.txt7);
            this.panel5.Controls.Add(this.txt6);
            this.panel5.Controls.Add(this.txt8);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txt5);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(283, 29);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 136);
            this.panel5.TabIndex = 33;
            // 
            // txt7
            // 
            this.txt7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt7.Location = new System.Drawing.Point(82, 76);
            this.txt7.Margin = new System.Windows.Forms.Padding(2);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(90, 25);
            this.txt7.TabIndex = 27;
            // 
            // txt6
            // 
            this.txt6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt6.Location = new System.Drawing.Point(82, 44);
            this.txt6.Margin = new System.Windows.Forms.Padding(2);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(90, 25);
            this.txt6.TabIndex = 26;
            // 
            // txt8
            // 
            this.txt8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt8.Location = new System.Drawing.Point(82, 108);
            this.txt8.Margin = new System.Windows.Forms.Padding(2);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(90, 25);
            this.txt8.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Junio:";
            // 
            // txt5
            // 
            this.txt5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(82, 10);
            this.txt5.Margin = new System.Windows.Forms.Padding(2);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(90, 25);
            this.txt5.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Agosto:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Julio:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Mayo:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(83, 169);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 287);
            this.panel1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 278);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.Visible = false;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(91, 7);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(166, 18);
            this.label21.TabIndex = 34;
            this.label21.Text = "Salario Mensual Bruto";
            // 
            // semestre2
            // 
            this.semestre2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semestre2.BackColor = System.Drawing.SystemColors.Window;
            this.semestre2.Controls.Add(this.txt11);
            this.semestre2.Controls.Add(this.txt10);
            this.semestre2.Controls.Add(this.label6);
            this.semestre2.Controls.Add(this.label7);
            this.semestre2.Controls.Add(this.txt12);
            this.semestre2.Controls.Add(this.label8);
            this.semestre2.Controls.Add(this.label10);
            this.semestre2.Controls.Add(this.txt9);
            this.semestre2.Location = new System.Drawing.Point(470, 29);
            this.semestre2.Margin = new System.Windows.Forms.Padding(2);
            this.semestre2.Name = "semestre2";
            this.semestre2.Size = new System.Drawing.Size(214, 136);
            this.semestre2.TabIndex = 32;
            // 
            // txt11
            // 
            this.txt11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt11.Location = new System.Drawing.Point(111, 78);
            this.txt11.Margin = new System.Windows.Forms.Padding(2);
            this.txt11.Name = "txt11";
            this.txt11.Size = new System.Drawing.Size(90, 25);
            this.txt11.TabIndex = 27;
            // 
            // txt10
            // 
            this.txt10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt10.Location = new System.Drawing.Point(111, 43);
            this.txt10.Margin = new System.Windows.Forms.Padding(2);
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(90, 25);
            this.txt10.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Diciembre:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Octubre:";
            // 
            // txt12
            // 
            this.txt12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt12.Location = new System.Drawing.Point(111, 108);
            this.txt12.Margin = new System.Windows.Forms.Padding(2);
            this.txt12.Name = "txt12";
            this.txt12.Size = new System.Drawing.Size(90, 25);
            this.txt12.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Noviembre:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Septiembre:";
            // 
            // txt9
            // 
            this.txt9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt9.Location = new System.Drawing.Point(111, 10);
            this.txt9.Margin = new System.Windows.Forms.Padding(2);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(90, 25);
            this.txt9.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.txt4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt2);
            this.panel3.Controls.Add(this.txt1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(94, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 136);
            this.panel3.TabIndex = 29;
            // 
            // txt4
            // 
            this.txt4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(75, 109);
            this.txt4.Margin = new System.Windows.Forms.Padding(2);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(90, 25);
            this.txt4.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Abril:";
            // 
            // txt2
            // 
            this.txt2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(75, 45);
            this.txt2.Margin = new System.Windows.Forms.Padding(2);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(90, 25);
            this.txt2.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(75, 11);
            this.txt1.Margin = new System.Windows.Forms.Padding(2);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(90, 25);
            this.txt1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Marzo:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enero:";
            // 
            // txt3
            // 
            this.txt3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(75, 76);
            this.txt3.Margin = new System.Windows.Forms.Padding(2);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(90, 25);
            this.txt3.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Febrero:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 498);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.deducciones.ResumeLayout(false);
            this.deducciones.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.semestre2.ResumeLayout(false);
            this.semestre2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel semestre2;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.Panel deducciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoGravado;
        private System.Windows.Forms.TextBox txtRenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAfp;
        private System.Windows.Forms.TextBox txtIsss;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAguinaldoGravado;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAguinaldoNoGravado;
    }
}