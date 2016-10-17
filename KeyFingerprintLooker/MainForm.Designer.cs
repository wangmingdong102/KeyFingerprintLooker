﻿/*
 * 由SharpDevelop创建。
 * 用户： imknown
 * 日期: 2015/12/3 周四
 * 时间: 上午 11:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace KeyFingerprintLooker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.keystore_file_path_txt = new System.Windows.Forms.TextBox();
			this.auto_fetch_keystore_file_path_btn = new System.Windows.Forms.Button();
			this.browse_keystore_file_path_btn = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.xamarin_first_chk = new System.Windows.Forms.CheckBox();
			this.auto_fetch_keytool_file_path_btn = new System.Windows.Forms.Button();
			this.keytool_file_path_lbl = new System.Windows.Forms.Label();
			this.browse_keytool_file_path_btn = new System.Windows.Forms.Button();
			this.keytool_file_path_txt = new System.Windows.Forms.TextBox();
			this.keystore_file_path_lbl = new System.Windows.Forms.Label();
			this.password_lbl = new System.Windows.Forms.Label();
			this.keystore_file_type_release_rdbtn = new System.Windows.Forms.RadioButton();
			this.keystore_file_type_debug_rdbtn = new System.Windows.Forms.RadioButton();
			this.password_txt = new System.Windows.Forms.TextBox();
			this.colon_for_split_chk = new System.Windows.Forms.CheckBox();
			this.SHA1_txt = new System.Windows.Forms.TextBox();
			this.sha1_lbl = new System.Windows.Forms.Label();
			this.copy_SHA1_btn = new System.Windows.Forms.Button();
			this.operation_log_txt = new System.Windows.Forms.TextBox();
			this.get_fingerprint_btn = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.MD5_txt = new System.Windows.Forms.TextBox();
			this.copy_MD5_btn = new System.Windows.Forms.Button();
			this.md5_lbl = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.not_wrap_content_chk = new System.Windows.Forms.CheckBox();
			this.about_txt = new System.Windows.Forms.Label();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.alias_selector_cmb = new System.Windows.Forms.ComboBox();
			this.caps_chk = new System.Windows.Forms.CheckBox();
			this.alias_counter_lbl = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// keystore_file_path_txt
			// 
			this.keystore_file_path_txt.AllowDrop = true;
			this.keystore_file_path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.keystore_file_path_txt.Location = new System.Drawing.Point(157, 55);
			this.keystore_file_path_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.keystore_file_path_txt.Name = "keystore_file_path_txt";
			this.keystore_file_path_txt.Size = new System.Drawing.Size(397, 25);
			this.keystore_file_path_txt.TabIndex = 1;
			this.keystore_file_path_txt.Text = "请指定密钥文件或APK路径, 支持拖拽";
			this.keystore_file_path_txt.TextChanged += new System.EventHandler(this.Keystore_file_path_txtTextChanged);
			this.keystore_file_path_txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.Keystore_file_path_txtDragDrop);
			this.keystore_file_path_txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
			// 
			// auto_fetch_keystore_file_path_btn
			// 
			this.auto_fetch_keystore_file_path_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.auto_fetch_keystore_file_path_btn.Location = new System.Drawing.Point(562, 54);
			this.auto_fetch_keystore_file_path_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.auto_fetch_keystore_file_path_btn.Name = "auto_fetch_keystore_file_path_btn";
			this.auto_fetch_keystore_file_path_btn.Size = new System.Drawing.Size(90, 28);
			this.auto_fetch_keystore_file_path_btn.TabIndex = 5;
			this.auto_fetch_keystore_file_path_btn.Text = "自动寻找";
			this.auto_fetch_keystore_file_path_btn.UseVisualStyleBackColor = true;
			this.auto_fetch_keystore_file_path_btn.Click += new System.EventHandler(this.Button1Click);
			// 
			// browse_keystore_file_path_btn
			// 
			this.browse_keystore_file_path_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browse_keystore_file_path_btn.Location = new System.Drawing.Point(660, 54);
			this.browse_keystore_file_path_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.browse_keystore_file_path_btn.Name = "browse_keystore_file_path_btn";
			this.browse_keystore_file_path_btn.Size = new System.Drawing.Size(90, 28);
			this.browse_keystore_file_path_btn.TabIndex = 6;
			this.browse_keystore_file_path_btn.Text = "浏览...";
			this.browse_keystore_file_path_btn.UseVisualStyleBackColor = true;
			this.browse_keystore_file_path_btn.Click += new System.EventHandler(this.Button2Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.xamarin_first_chk);
			this.groupBox2.Controls.Add(this.auto_fetch_keytool_file_path_btn);
			this.groupBox2.Controls.Add(this.keytool_file_path_lbl);
			this.groupBox2.Controls.Add(this.browse_keytool_file_path_btn);
			this.groupBox2.Controls.Add(this.keytool_file_path_txt);
			this.groupBox2.Controls.Add(this.keystore_file_path_lbl);
			this.groupBox2.Controls.Add(this.password_lbl);
			this.groupBox2.Controls.Add(this.keystore_file_type_release_rdbtn);
			this.groupBox2.Controls.Add(this.keystore_file_type_debug_rdbtn);
			this.groupBox2.Controls.Add(this.password_txt);
			this.groupBox2.Controls.Add(this.keystore_file_path_txt);
			this.groupBox2.Controls.Add(this.browse_keystore_file_path_btn);
			this.groupBox2.Controls.Add(this.auto_fetch_keystore_file_path_btn);
			this.groupBox2.Location = new System.Drawing.Point(13, 12);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox2.Size = new System.Drawing.Size(758, 159);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "源";
			// 
			// xamarin_first_chk
			// 
			this.xamarin_first_chk.Checked = true;
			this.xamarin_first_chk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.xamarin_first_chk.Location = new System.Drawing.Point(157, 86);
			this.xamarin_first_chk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.xamarin_first_chk.Name = "xamarin_first_chk";
			this.xamarin_first_chk.Size = new System.Drawing.Size(378, 26);
			this.xamarin_first_chk.TabIndex = 20;
			this.xamarin_first_chk.Text = "优先查找 Xamarin Debug Key";
			this.xamarin_first_chk.UseVisualStyleBackColor = true;
			// 
			// auto_fetch_keytool_file_path_btn
			// 
			this.auto_fetch_keytool_file_path_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.auto_fetch_keytool_file_path_btn.Location = new System.Drawing.Point(562, 23);
			this.auto_fetch_keytool_file_path_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.auto_fetch_keytool_file_path_btn.Name = "auto_fetch_keytool_file_path_btn";
			this.auto_fetch_keytool_file_path_btn.Size = new System.Drawing.Size(90, 28);
			this.auto_fetch_keytool_file_path_btn.TabIndex = 3;
			this.auto_fetch_keytool_file_path_btn.Text = "自动寻找";
			this.auto_fetch_keytool_file_path_btn.UseVisualStyleBackColor = true;
			this.auto_fetch_keytool_file_path_btn.Click += new System.EventHandler(this.Button4Click);
			// 
			// keytool_file_path_lbl
			// 
			this.keytool_file_path_lbl.Location = new System.Drawing.Point(8, 18);
			this.keytool_file_path_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.keytool_file_path_lbl.Name = "keytool_file_path_lbl";
			this.keytool_file_path_lbl.Size = new System.Drawing.Size(141, 36);
			this.keytool_file_path_lbl.TabIndex = 23;
			this.keytool_file_path_lbl.Text = "keytool.exe 地址";
			this.keytool_file_path_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// browse_keytool_file_path_btn
			// 
			this.browse_keytool_file_path_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.browse_keytool_file_path_btn.Location = new System.Drawing.Point(660, 23);
			this.browse_keytool_file_path_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.browse_keytool_file_path_btn.Name = "browse_keytool_file_path_btn";
			this.browse_keytool_file_path_btn.Size = new System.Drawing.Size(90, 28);
			this.browse_keytool_file_path_btn.TabIndex = 4;
			this.browse_keytool_file_path_btn.Text = "浏览...";
			this.browse_keytool_file_path_btn.UseVisualStyleBackColor = true;
			this.browse_keytool_file_path_btn.Click += new System.EventHandler(this.Button8Click);
			// 
			// keytool_file_path_txt
			// 
			this.keytool_file_path_txt.AllowDrop = true;
			this.keytool_file_path_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.keytool_file_path_txt.Location = new System.Drawing.Point(157, 24);
			this.keytool_file_path_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.keytool_file_path_txt.Name = "keytool_file_path_txt";
			this.keytool_file_path_txt.Size = new System.Drawing.Size(397, 25);
			this.keytool_file_path_txt.TabIndex = 0;
			this.keytool_file_path_txt.Text = "请指定 keytool.exe 路径, 支持拖拽";
			this.keytool_file_path_txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.keytool_file_path_txtDragDrop);
			this.keytool_file_path_txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_DragEnter);
			// 
			// keystore_file_path_lbl
			// 
			this.keystore_file_path_lbl.Location = new System.Drawing.Point(8, 49);
			this.keystore_file_path_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.keystore_file_path_lbl.Name = "keystore_file_path_lbl";
			this.keystore_file_path_lbl.Size = new System.Drawing.Size(141, 36);
			this.keystore_file_path_lbl.TabIndex = 21;
			this.keystore_file_path_lbl.Text = "密钥或APK地址";
			this.keystore_file_path_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// password_lbl
			// 
			this.password_lbl.Location = new System.Drawing.Point(8, 112);
			this.password_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.password_lbl.Name = "password_lbl";
			this.password_lbl.Size = new System.Drawing.Size(141, 36);
			this.password_lbl.TabIndex = 20;
			this.password_lbl.Text = "密钥密码";
			this.password_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// keystore_file_type_release_rdbtn
			// 
			this.keystore_file_type_release_rdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.keystore_file_type_release_rdbtn.Location = new System.Drawing.Point(660, 112);
			this.keystore_file_type_release_rdbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.keystore_file_type_release_rdbtn.Name = "keystore_file_type_release_rdbtn";
			this.keystore_file_type_release_rdbtn.Size = new System.Drawing.Size(90, 38);
			this.keystore_file_type_release_rdbtn.TabIndex = 8;
			this.keystore_file_type_release_rdbtn.Text = "Release";
			this.keystore_file_type_release_rdbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.keystore_file_type_release_rdbtn.UseVisualStyleBackColor = true;
			this.keystore_file_type_release_rdbtn.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
			// 
			// keystore_file_type_debug_rdbtn
			// 
			this.keystore_file_type_debug_rdbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.keystore_file_type_debug_rdbtn.Checked = true;
			this.keystore_file_type_debug_rdbtn.Location = new System.Drawing.Point(562, 112);
			this.keystore_file_type_debug_rdbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.keystore_file_type_debug_rdbtn.Name = "keystore_file_type_debug_rdbtn";
			this.keystore_file_type_debug_rdbtn.Size = new System.Drawing.Size(90, 38);
			this.keystore_file_type_debug_rdbtn.TabIndex = 7;
			this.keystore_file_type_debug_rdbtn.TabStop = true;
			this.keystore_file_type_debug_rdbtn.Text = "Debug";
			this.keystore_file_type_debug_rdbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.keystore_file_type_debug_rdbtn.UseVisualStyleBackColor = true;
			this.keystore_file_type_debug_rdbtn.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
			// 
			// password_txt
			// 
			this.password_txt.AllowDrop = true;
			this.password_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.password_txt.Location = new System.Drawing.Point(157, 118);
			this.password_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.password_txt.Name = "password_txt";
			this.password_txt.ReadOnly = true;
			this.password_txt.Size = new System.Drawing.Size(397, 25);
			this.password_txt.TabIndex = 2;
			this.password_txt.Text = "android";
			this.password_txt.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// colon_for_split_chk
			// 
			this.colon_for_split_chk.Checked = true;
			this.colon_for_split_chk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.colon_for_split_chk.Location = new System.Drawing.Point(155, 119);
			this.colon_for_split_chk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.colon_for_split_chk.Name = "colon_for_split_chk";
			this.colon_for_split_chk.Size = new System.Drawing.Size(135, 26);
			this.colon_for_split_chk.TabIndex = 6;
			this.colon_for_split_chk.Text = "冒号分隔";
			this.colon_for_split_chk.UseVisualStyleBackColor = true;
			this.colon_for_split_chk.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// SHA1_txt
			// 
			this.SHA1_txt.AllowDrop = true;
			this.SHA1_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.SHA1_txt.Location = new System.Drawing.Point(155, 88);
			this.SHA1_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SHA1_txt.Name = "SHA1_txt";
			this.SHA1_txt.ReadOnly = true;
			this.SHA1_txt.Size = new System.Drawing.Size(397, 25);
			this.SHA1_txt.TabIndex = 8;
			// 
			// sha1_lbl
			// 
			this.sha1_lbl.Location = new System.Drawing.Point(6, 82);
			this.sha1_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.sha1_lbl.Name = "sha1_lbl";
			this.sha1_lbl.Size = new System.Drawing.Size(141, 36);
			this.sha1_lbl.TabIndex = 5;
			this.sha1_lbl.Text = "SHA1";
			this.sha1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// copy_SHA1_btn
			// 
			this.copy_SHA1_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copy_SHA1_btn.Location = new System.Drawing.Point(560, 86);
			this.copy_SHA1_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.copy_SHA1_btn.Name = "copy_SHA1_btn";
			this.copy_SHA1_btn.Size = new System.Drawing.Size(190, 28);
			this.copy_SHA1_btn.TabIndex = 10;
			this.copy_SHA1_btn.Text = "复制";
			this.copy_SHA1_btn.UseVisualStyleBackColor = true;
			this.copy_SHA1_btn.Click += new System.EventHandler(this.Button5Click);
			// 
			// operation_log_txt
			// 
			this.operation_log_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.operation_log_txt.Location = new System.Drawing.Point(8, 151);
			this.operation_log_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.operation_log_txt.Multiline = true;
			this.operation_log_txt.Name = "operation_log_txt";
			this.operation_log_txt.ReadOnly = true;
			this.operation_log_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.operation_log_txt.Size = new System.Drawing.Size(742, 215);
			this.operation_log_txt.TabIndex = 13;
			this.operation_log_txt.Text = "\r\n无日志";
			// 
			// get_fingerprint_btn
			// 
			this.get_fingerprint_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.get_fingerprint_btn.Location = new System.Drawing.Point(560, 24);
			this.get_fingerprint_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.get_fingerprint_btn.Name = "get_fingerprint_btn";
			this.get_fingerprint_btn.Size = new System.Drawing.Size(190, 28);
			this.get_fingerprint_btn.TabIndex = 9;
			this.get_fingerprint_btn.Text = "计算指纹";
			this.get_fingerprint_btn.UseVisualStyleBackColor = true;
			this.get_fingerprint_btn.Click += new System.EventHandler(this.Button3Click);
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button6.Location = new System.Drawing.Point(657, 372);
			this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(93, 28);
			this.button6.TabIndex = 11;
			this.button6.Text = "清空";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// MD5_txt
			// 
			this.MD5_txt.AllowDrop = true;
			this.MD5_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.MD5_txt.Location = new System.Drawing.Point(155, 57);
			this.MD5_txt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MD5_txt.Name = "MD5_txt";
			this.MD5_txt.ReadOnly = true;
			this.MD5_txt.Size = new System.Drawing.Size(397, 25);
			this.MD5_txt.TabIndex = 15;
			// 
			// copy_MD5_btn
			// 
			this.copy_MD5_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.copy_MD5_btn.Location = new System.Drawing.Point(560, 55);
			this.copy_MD5_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.copy_MD5_btn.Name = "copy_MD5_btn";
			this.copy_MD5_btn.Size = new System.Drawing.Size(190, 28);
			this.copy_MD5_btn.TabIndex = 16;
			this.copy_MD5_btn.Text = "复制";
			this.copy_MD5_btn.UseVisualStyleBackColor = true;
			this.copy_MD5_btn.Click += new System.EventHandler(this.Button7Click);
			// 
			// md5_lbl
			// 
			this.md5_lbl.Location = new System.Drawing.Point(6, 51);
			this.md5_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.md5_lbl.Name = "md5_lbl";
			this.md5_lbl.Size = new System.Drawing.Size(141, 36);
			this.md5_lbl.TabIndex = 14;
			this.md5_lbl.Text = "MD5";
			this.md5_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.not_wrap_content_chk);
			this.groupBox1.Controls.Add(this.about_txt);
			this.groupBox1.Controls.Add(this.checkBox4);
			this.groupBox1.Controls.Add(this.alias_selector_cmb);
			this.groupBox1.Controls.Add(this.caps_chk);
			this.groupBox1.Controls.Add(this.alias_counter_lbl);
			this.groupBox1.Controls.Add(this.md5_lbl);
			this.groupBox1.Controls.Add(this.copy_MD5_btn);
			this.groupBox1.Controls.Add(this.MD5_txt);
			this.groupBox1.Controls.Add(this.button6);
			this.groupBox1.Controls.Add(this.get_fingerprint_btn);
			this.groupBox1.Controls.Add(this.operation_log_txt);
			this.groupBox1.Controls.Add(this.copy_SHA1_btn);
			this.groupBox1.Controls.Add(this.sha1_lbl);
			this.groupBox1.Controls.Add(this.SHA1_txt);
			this.groupBox1.Controls.Add(this.colon_for_split_chk);
			this.groupBox1.Location = new System.Drawing.Point(13, 177);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.groupBox1.Size = new System.Drawing.Size(756, 406);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "结果";
			// 
			// not_wrap_content_chk
			// 
			this.not_wrap_content_chk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.not_wrap_content_chk.Checked = true;
			this.not_wrap_content_chk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.not_wrap_content_chk.Location = new System.Drawing.Point(532, 374);
			this.not_wrap_content_chk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.not_wrap_content_chk.Name = "not_wrap_content_chk";
			this.not_wrap_content_chk.Size = new System.Drawing.Size(117, 26);
			this.not_wrap_content_chk.TabIndex = 25;
			this.not_wrap_content_chk.Text = "自动换行";
			this.not_wrap_content_chk.UseVisualStyleBackColor = true;
			this.not_wrap_content_chk.CheckedChanged += new System.EventHandler(this.Not_wrap_content_chkCheckedChanged);
			// 
			// about_txt
			// 
			this.about_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.about_txt.Location = new System.Drawing.Point(8, 373);
			this.about_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.about_txt.Name = "about_txt";
			this.about_txt.Size = new System.Drawing.Size(179, 26);
			this.about_txt.TabIndex = 24;
			this.about_txt.Text = "0.3 beta";
			this.about_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBox4
			// 
			this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox4.Checked = true;
			this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox4.Location = new System.Drawing.Point(336, 374);
			this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(188, 26);
			this.checkBox4.TabIndex = 19;
			this.checkBox4.Text = "重新计算后, 清空日志";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// alias_selector_cmb
			// 
			this.alias_selector_cmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.alias_selector_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.alias_selector_cmb.Enabled = false;
			this.alias_selector_cmb.FormattingEnabled = true;
			this.alias_selector_cmb.Location = new System.Drawing.Point(155, 24);
			this.alias_selector_cmb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.alias_selector_cmb.Name = "alias_selector_cmb";
			this.alias_selector_cmb.Size = new System.Drawing.Size(397, 27);
			this.alias_selector_cmb.TabIndex = 18;
			this.alias_selector_cmb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// caps_chk
			// 
			this.caps_chk.Checked = true;
			this.caps_chk.CheckState = System.Windows.Forms.CheckState.Checked;
			this.caps_chk.Location = new System.Drawing.Point(298, 119);
			this.caps_chk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.caps_chk.Name = "caps_chk";
			this.caps_chk.Size = new System.Drawing.Size(149, 26);
			this.caps_chk.TabIndex = 17;
			this.caps_chk.Text = "字母大写";
			this.caps_chk.UseVisualStyleBackColor = true;
			this.caps_chk.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// alias_counter_lbl
			// 
			this.alias_counter_lbl.Location = new System.Drawing.Point(6, 18);
			this.alias_counter_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.alias_counter_lbl.Name = "alias_counter_lbl";
			this.alias_counter_lbl.Size = new System.Drawing.Size(141, 36);
			this.alias_counter_lbl.TabIndex = 14;
			this.alias_counter_lbl.Text = "无别名";
			this.alias_counter_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 595);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(800, 634);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "密钥指纹获取器";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox not_wrap_content_chk;
		private System.Windows.Forms.Label about_txt;
		private System.Windows.Forms.CheckBox xamarin_first_chk;
		private System.Windows.Forms.Button browse_keytool_file_path_btn;
		private System.Windows.Forms.Button auto_fetch_keytool_file_path_btn;
		private System.Windows.Forms.Label keystore_file_path_lbl;
		private System.Windows.Forms.TextBox keytool_file_path_txt;
		private System.Windows.Forms.Label keytool_file_path_lbl;
		private System.Windows.Forms.Label password_lbl;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Label alias_counter_lbl;
		private System.Windows.Forms.ComboBox alias_selector_cmb;
		private System.Windows.Forms.RadioButton keystore_file_type_debug_rdbtn;
		private System.Windows.Forms.RadioButton keystore_file_type_release_rdbtn;
		private System.Windows.Forms.TextBox password_txt;
		private System.Windows.Forms.CheckBox caps_chk;
		private System.Windows.Forms.TextBox MD5_txt;
		private System.Windows.Forms.Button copy_MD5_btn;
		private System.Windows.Forms.Label md5_lbl;
		private System.Windows.Forms.TextBox operation_log_txt;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button copy_SHA1_btn;
		private System.Windows.Forms.TextBox SHA1_txt;
		private System.Windows.Forms.CheckBox colon_for_split_chk;
		private System.Windows.Forms.Label sha1_lbl;
		private System.Windows.Forms.Button get_fingerprint_btn;
		private System.Windows.Forms.Button browse_keystore_file_path_btn;
		private System.Windows.Forms.Button auto_fetch_keystore_file_path_btn;
		private System.Windows.Forms.TextBox keystore_file_path_txt;
	}
}
