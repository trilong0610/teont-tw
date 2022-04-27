namespace AutoAirdrop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_tw_start = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btn_tw_stop = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.group_radio_like = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_url_post = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_num_thread = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tw_sleep_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tw_sleep_to = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tw_profile_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tw_profile_to = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_tw_all_profile = new System.Windows.Forms.RadioButton();
            this.txt_tw_url_dic_brave = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.txt_from_profile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_to_profile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.group_radio_like.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxLog, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1576, 737);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 731);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Twitter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_tw_start);
            this.flowLayoutPanel1.Controls.Add(this.btn_scan);
            this.flowLayoutPanel1.Controls.Add(this.btn_tw_stop);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 634);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 65);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_tw_start
            // 
            this.btn_tw_start.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_tw_start.Location = new System.Drawing.Point(3, 3);
            this.btn_tw_start.Name = "btn_tw_start";
            this.btn_tw_start.Size = new System.Drawing.Size(229, 55);
            this.btn_tw_start.TabIndex = 0;
            this.btn_tw_start.Text = "Bắt đầu";
            this.btn_tw_start.UseVisualStyleBackColor = false;
            this.btn_tw_start.Click += new System.EventHandler(this.btn_tw_start_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(238, 3);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(208, 55);
            this.btn_scan.TabIndex = 2;
            this.btn_scan.Text = "Scan";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btn_tw_stop
            // 
            this.btn_tw_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tw_stop.BackColor = System.Drawing.Color.Red;
            this.btn_tw_stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_tw_stop.Location = new System.Drawing.Point(452, 3);
            this.btn_tw_stop.Name = "btn_tw_stop";
            this.btn_tw_stop.Size = new System.Drawing.Size(250, 55);
            this.btn_tw_stop.TabIndex = 1;
            this.btn_tw_stop.Text = "Dừng";
            this.btn_tw_stop.UseVisualStyleBackColor = false;
            this.btn_tw_stop.Click += new System.EventHandler(this.btn_tw_stop_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.group_radio_like, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(768, 372);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // group_radio_like
            // 
            this.group_radio_like.Controls.Add(this.txt_to_profile);
            this.group_radio_like.Controls.Add(this.label11);
            this.group_radio_like.Controls.Add(this.txt_from_profile);
            this.group_radio_like.Controls.Add(this.label10);
            this.group_radio_like.Controls.Add(this.label9);
            this.group_radio_like.Controls.Add(this.txt_url_post);
            this.group_radio_like.Controls.Add(this.label8);
            this.group_radio_like.Controls.Add(this.txt_num_thread);
            this.group_radio_like.Controls.Add(this.label7);
            this.group_radio_like.Controls.Add(this.flowLayoutPanel2);
            this.group_radio_like.Controls.Add(this.rb_tw_all_profile);
            this.group_radio_like.Controls.Add(this.txt_tw_url_dic_brave);
            this.group_radio_like.Controls.Add(this.radioButton2);
            this.group_radio_like.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_radio_like.Location = new System.Drawing.Point(3, 3);
            this.group_radio_like.Name = "group_radio_like";
            this.group_radio_like.Size = new System.Drawing.Size(762, 366);
            this.group_radio_like.TabIndex = 4;
            this.group_radio_like.TabStop = false;
            this.group_radio_like.Text = "Lướt NewFeed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Url Post";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_url_post
            // 
            this.txt_url_post.Location = new System.Drawing.Point(94, 47);
            this.txt_url_post.Name = "txt_url_post";
            this.txt_url_post.Size = new System.Drawing.Size(609, 22);
            this.txt_url_post.TabIndex = 11;
            this.txt_url_post.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "PATH brave";
            // 
            // txt_num_thread
            // 
            this.txt_num_thread.Location = new System.Drawing.Point(211, 97);
            this.txt_num_thread.Name = "txt_num_thread";
            this.txt_num_thread.Size = new System.Drawing.Size(79, 22);
            this.txt_num_thread.TabIndex = 9;
            this.txt_num_thread.TextChanged += new System.EventHandler(this.txt_num_profile_in_dic_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số luồng: ";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Enabled = false;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 161);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(756, 202);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_tw_sleep_from);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tw_sleep_to);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian nghỉ giữa các lần cuộn";
            // 
            // txt_tw_sleep_from
            // 
            this.txt_tw_sleep_from.Location = new System.Drawing.Point(37, 32);
            this.txt_tw_sleep_from.Name = "txt_tw_sleep_from";
            this.txt_tw_sleep_from.Size = new System.Drawing.Size(143, 22);
            this.txt_tw_sleep_from.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "(second)";
            // 
            // txt_tw_sleep_to
            // 
            this.txt_tw_sleep_to.Location = new System.Drawing.Point(223, 32);
            this.txt_tw_sleep_to.Name = "txt_tw_sleep_to";
            this.txt_tw_sleep_to.Size = new System.Drawing.Size(143, 22);
            this.txt_tw_sleep_to.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đến";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Từ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tw_profile_from);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_tw_profile_to);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian chạy cho mỗi profile";
            // 
            // txt_tw_profile_from
            // 
            this.txt_tw_profile_from.Location = new System.Drawing.Point(37, 32);
            this.txt_tw_profile_from.Name = "txt_tw_profile_from";
            this.txt_tw_profile_from.Size = new System.Drawing.Size(143, 22);
            this.txt_tw_profile_from.TabIndex = 1;
            this.txt_tw_profile_from.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "(second)";
            // 
            // txt_tw_profile_to
            // 
            this.txt_tw_profile_to.Location = new System.Drawing.Point(223, 32);
            this.txt_tw_profile_to.Name = "txt_tw_profile_to";
            this.txt_tw_profile_to.Size = new System.Drawing.Size(143, 22);
            this.txt_tw_profile_to.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Từ";
            // 
            // rb_tw_all_profile
            // 
            this.rb_tw_all_profile.AutoSize = true;
            this.rb_tw_all_profile.Checked = true;
            this.rb_tw_all_profile.Location = new System.Drawing.Point(9, 98);
            this.rb_tw_all_profile.Name = "rb_tw_all_profile";
            this.rb_tw_all_profile.Size = new System.Drawing.Size(106, 20);
            this.rb_tw_all_profile.TabIndex = 2;
            this.rb_tw_all_profile.TabStop = true;
            this.rb_tw_all_profile.Text = "Tất cả profile";
            this.rb_tw_all_profile.UseVisualStyleBackColor = true;
            // 
            // txt_tw_url_dic_brave
            // 
            this.txt_tw_url_dic_brave.Location = new System.Drawing.Point(94, 19);
            this.txt_tw_url_dic_brave.Name = "txt_tw_url_dic_brave";
            this.txt_tw_url_dic_brave.Size = new System.Drawing.Size(609, 22);
            this.txt_tw_url_dic_brave.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(9, 124);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Tùy chọn profile";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(791, 3);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(782, 731);
            this.richTextBoxLog.TabIndex = 3;
            this.richTextBoxLog.Text = "";
            // 
            // txt_from_profile
            // 
            this.txt_from_profile.Location = new System.Drawing.Point(211, 122);
            this.txt_from_profile.Name = "txt_from_profile";
            this.txt_from_profile.Size = new System.Drawing.Size(79, 22);
            this.txt_from_profile.TabIndex = 14;
            this.txt_from_profile.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Từ: ";
            // 
            // txt_to_profile
            // 
            this.txt_to_profile.Location = new System.Drawing.Point(381, 121);
            this.txt_to_profile.Name = "txt_to_profile";
            this.txt_to_profile.Size = new System.Drawing.Size(79, 22);
            this.txt_to_profile.TabIndex = 16;
            this.txt_to_profile.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Đến: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.group_radio_like.ResumeLayout(false);
            this.group_radio_like.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox group_radio_like;
        private System.Windows.Forms.RadioButton rb_tw_all_profile;
        private System.Windows.Forms.TextBox txt_tw_url_dic_brave;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_tw_start;
        private System.Windows.Forms.Button btn_tw_stop;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tw_sleep_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tw_sleep_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tw_profile_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tw_profile_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_num_thread;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_url_post;
        private System.Windows.Forms.TextBox txt_to_profile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_from_profile;
        private System.Windows.Forms.Label label10;
    }
}

