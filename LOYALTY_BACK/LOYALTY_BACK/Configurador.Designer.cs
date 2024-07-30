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
            // Configurador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_start);
            Controls.Add(label_port_server);
            Controls.Add(tb_port_server);
            Controls.Add(btn_guardar);
            Controls.Add(label_ip_server);
            Controls.Add(tb_ip_server);
            Name = "Configurador";
            Text = "Form1";
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
    }
}
