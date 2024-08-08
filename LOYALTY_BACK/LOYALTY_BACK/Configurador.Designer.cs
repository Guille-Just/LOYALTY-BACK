namespace LOYALTY_BACK
{
    partial class Configurador
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
            tb_ip_server = new TextBox();
            label_ip_server = new Label();
            btn_guardar = new Button();
            label_port_server = new Label();
            tb_port_server = new TextBox();
            btn_start = new Button();
            button1 = new Button();
            label1 = new Label();
            tb_fid_id = new TextBox();
            label2 = new Label();
            tb_ruta_ticket = new TextBox();
            groupBox1 = new GroupBox();
            label_puerto_concentrador = new Label();
            tb_port_concentrador = new TextBox();
            label_ip_concentrador = new Label();
            tb_ip_concentrador = new TextBox();
            label_ruta_concentrador = new Label();
            tb_ruta_concentrador_ticket = new TextBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tb_ip_server
            // 
            tb_ip_server.Location = new Point(102, 16);
            tb_ip_server.Name = "tb_ip_server";
            tb_ip_server.Size = new Size(100, 23);
            tb_ip_server.TabIndex = 0;
            tb_ip_server.Text = "localhost";
            // 
            // label_ip_server
            // 
            label_ip_server.AutoSize = true;
            label_ip_server.Location = new Point(12, 19);
            label_ip_server.Name = "label_ip_server";
            label_ip_server.Size = new Size(59, 15);
            label_ip_server.TabIndex = 1;
            label_ip_server.Text = "SERVER IP";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(590, 16);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 23);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // label_port_server
            // 
            label_port_server.AutoSize = true;
            label_port_server.Location = new Point(12, 48);
            label_port_server.Name = "label_port_server";
            label_port_server.Size = new Size(77, 15);
            label_port_server.TabIndex = 4;
            label_port_server.Text = "SERVER PORT";
            // 
            // tb_port_server
            // 
            tb_port_server.Location = new Point(102, 45);
            tb_port_server.Name = "tb_port_server";
            tb_port_server.Size = new Size(100, 23);
            tb_port_server.TabIndex = 3;
            tb_port_server.Text = "3000";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(671, 16);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(117, 23);
            btn_start.TabIndex = 5;
            btn_start.Text = "Iniciar";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 81);
            button1.Name = "button1";
            button1.Size = new Size(213, 23);
            button1.TabIndex = 6;
            button1.Text = "test: insert ticket";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_test_subir_ticket_a_bd;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 58);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 10;
            label1.Text = "fidelizacion_id";
            // 
            // tb_fid_id
            // 
            tb_fid_id.Location = new Point(128, 55);
            tb_fid_id.Name = "tb_fid_id";
            tb_fid_id.Size = new Size(100, 23);
            tb_fid_id.TabIndex = 9;
            tb_fid_id.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 29);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 8;
            label2.Text = "ruta local del ticket";
            // 
            // tb_ruta_ticket
            // 
            tb_ruta_ticket.Location = new Point(128, 26);
            tb_ruta_ticket.Name = "tb_ruta_ticket";
            tb_ruta_ticket.Size = new Size(100, 23);
            tb_ruta_ticket.TabIndex = 7;
            tb_ruta_ticket.Text = "C:\\reportdocumento.pdf";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_fid_id);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tb_ruta_ticket);
            groupBox1.Location = new Point(543, 320);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(245, 118);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "zona testing";
            // 
            // label_puerto_concentrador
            // 
            label_puerto_concentrador.AutoSize = true;
            label_puerto_concentrador.Location = new Point(12, 54);
            label_puerto_concentrador.Name = "label_puerto_concentrador";
            label_puerto_concentrador.Size = new Size(42, 15);
            label_puerto_concentrador.TabIndex = 15;
            label_puerto_concentrador.Text = "Puerto";
            // 
            // tb_port_concentrador
            // 
            tb_port_concentrador.Location = new Point(102, 51);
            tb_port_concentrador.Name = "tb_port_concentrador";
            tb_port_concentrador.Size = new Size(100, 23);
            tb_port_concentrador.TabIndex = 14;
            tb_port_concentrador.Text = "8080";
            // 
            // label_ip_concentrador
            // 
            label_ip_concentrador.AutoSize = true;
            label_ip_concentrador.Location = new Point(12, 25);
            label_ip_concentrador.Name = "label_ip_concentrador";
            label_ip_concentrador.Size = new Size(17, 15);
            label_ip_concentrador.TabIndex = 13;
            label_ip_concentrador.Text = "IP";
            // 
            // tb_ip_concentrador
            // 
            tb_ip_concentrador.Location = new Point(102, 22);
            tb_ip_concentrador.Name = "tb_ip_concentrador";
            tb_ip_concentrador.Size = new Size(100, 23);
            tb_ip_concentrador.TabIndex = 12;
            tb_ip_concentrador.Text = "localhost";
            // 
            // label_ruta_concentrador
            // 
            label_ruta_concentrador.AutoSize = true;
            label_ruta_concentrador.Location = new Point(12, 83);
            label_ruta_concentrador.Name = "label_ruta_concentrador";
            label_ruta_concentrador.Size = new Size(67, 15);
            label_ruta_concentrador.TabIndex = 17;
            label_ruta_concentrador.Text = "Ruta-Ticket";
            // 
            // tb_ruta_concentrador_ticket
            // 
            tb_ruta_concentrador_ticket.Location = new Point(102, 80);
            tb_ruta_concentrador_ticket.Name = "tb_ruta_concentrador_ticket";
            tb_ruta_concentrador_ticket.Size = new Size(100, 23);
            tb_ruta_concentrador_ticket.TabIndex = 16;
            tb_ruta_concentrador_ticket.Text = "sim_ticket";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_ip_concentrador);
            groupBox2.Controls.Add(label_ruta_concentrador);
            groupBox2.Controls.Add(label_ip_concentrador);
            groupBox2.Controls.Add(tb_ruta_concentrador_ticket);
            groupBox2.Controls.Add(tb_port_concentrador);
            groupBox2.Controls.Add(label_puerto_concentrador);
            groupBox2.Location = new Point(12, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 123);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conexión a concentrador";
            // 
            // Configurador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(btn_start);
            Controls.Add(label_port_server);
            Controls.Add(tb_port_server);
            Controls.Add(btn_guardar);
            Controls.Add(label_ip_server);
            Controls.Add(tb_ip_server);
            Controls.Add(groupBox1);
            Name = "Configurador";
            Text = "Loyalty server";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_ip_server;
        private Label label_ip_server;
        private Button btn_guardar;
        private Label label_port_server;
        private TextBox tb_port_server;
        private Button btn_start;
        private Button button1;
        private Label label1;
        private TextBox tb_fid_id;
        private Label label2;
        private TextBox tb_ruta_ticket;
        private GroupBox groupBox1;
        private Label label_puerto_concentrador;
        private TextBox tb_port_concentrador;
        private Label label_ip_concentrador;
        private TextBox tb_ip_concentrador;
        private Label label_ruta_concentrador;
        private TextBox tb_ruta_concentrador_ticket;
        private GroupBox groupBox2;
    }
}
