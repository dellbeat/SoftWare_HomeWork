namespace MovieTicketSolder
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesList = new System.Windows.Forms.TreeView();
            this.MovieInfo = new System.Windows.Forms.GroupBox();
            this.SelectPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectActTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectActor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectType = new System.Windows.Forms.Label();
            this.lebel3 = new System.Windows.Forms.Label();
            this.MoviePic = new System.Windows.Forms.PictureBox();
            this.SelectDirector = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectMovieName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieListShowed = new System.Windows.Forms.TabControl();
            this.ShowMovieListTab = new System.Windows.Forms.TabPage();
            this.OperationMenu = new System.Windows.Forms.MenuStrip();
            this.销售选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadList = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketSolder = new System.Windows.Forms.GroupBox();
            this.NormalTicket = new System.Windows.Forms.RadioButton();
            this.StuTicket = new System.Windows.Forms.RadioButton();
            this.FreeTickets = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.StuPrice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendPerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FinalPrice = new System.Windows.Forms.Label();
            this.SeatViewContent = new System.Windows.Forms.TabControl();
            this.SeatPage = new System.Windows.Forms.TabPage();
            this.MovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).BeginInit();
            this.MovieListShowed.SuspendLayout();
            this.ShowMovieListTab.SuspendLayout();
            this.OperationMenu.SuspendLayout();
            this.TicketSolder.SuspendLayout();
            this.SeatViewContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesList
            // 
            this.MoviesList.Location = new System.Drawing.Point(6, 6);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(158, 442);
            this.MoviesList.TabIndex = 1;
            this.MoviesList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MoviesList_AfterSelect);
            // 
            // MovieInfo
            // 
            this.MovieInfo.Controls.Add(this.SelectPrice);
            this.MovieInfo.Controls.Add(this.label8);
            this.MovieInfo.Controls.Add(this.SelectActTime);
            this.MovieInfo.Controls.Add(this.label6);
            this.MovieInfo.Controls.Add(this.SelectActor);
            this.MovieInfo.Controls.Add(this.label4);
            this.MovieInfo.Controls.Add(this.SelectType);
            this.MovieInfo.Controls.Add(this.lebel3);
            this.MovieInfo.Controls.Add(this.MoviePic);
            this.MovieInfo.Controls.Add(this.SelectDirector);
            this.MovieInfo.Controls.Add(this.label2);
            this.MovieInfo.Controls.Add(this.SelectMovieName);
            this.MovieInfo.Controls.Add(this.label1);
            this.MovieInfo.Location = new System.Drawing.Point(197, 28);
            this.MovieInfo.Name = "MovieInfo";
            this.MovieInfo.Size = new System.Drawing.Size(464, 229);
            this.MovieInfo.TabIndex = 2;
            this.MovieInfo.TabStop = false;
            this.MovieInfo.Text = "电影信息";
            // 
            // SelectPrice
            // 
            this.SelectPrice.BackColor = System.Drawing.SystemColors.Control;
            this.SelectPrice.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectPrice.Location = new System.Drawing.Point(270, 188);
            this.SelectPrice.Name = "SelectPrice";
            this.SelectPrice.Size = new System.Drawing.Size(156, 21);
            this.SelectPrice.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(206, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "票价：";
            // 
            // SelectActTime
            // 
            this.SelectActTime.BackColor = System.Drawing.SystemColors.Control;
            this.SelectActTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectActTime.Location = new System.Drawing.Point(270, 155);
            this.SelectActTime.Name = "SelectActTime";
            this.SelectActTime.Size = new System.Drawing.Size(156, 21);
            this.SelectActTime.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(174, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "放映时间：";
            // 
            // SelectActor
            // 
            this.SelectActor.BackColor = System.Drawing.SystemColors.Control;
            this.SelectActor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectActor.Location = new System.Drawing.Point(270, 52);
            this.SelectActor.Name = "SelectActor";
            this.SelectActor.Size = new System.Drawing.Size(156, 21);
            this.SelectActor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(206, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "主演：";
            // 
            // SelectType
            // 
            this.SelectType.BackColor = System.Drawing.SystemColors.Control;
            this.SelectType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectType.Location = new System.Drawing.Point(270, 122);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(156, 21);
            this.SelectType.TabIndex = 6;
            // 
            // lebel3
            // 
            this.lebel3.AutoSize = true;
            this.lebel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lebel3.Location = new System.Drawing.Point(206, 122);
            this.lebel3.Name = "lebel3";
            this.lebel3.Size = new System.Drawing.Size(58, 21);
            this.lebel3.TabIndex = 5;
            this.lebel3.Text = "类型：";
            // 
            // MoviePic
            // 
            this.MoviePic.InitialImage = null;
            this.MoviePic.Location = new System.Drawing.Point(17, 20);
            this.MoviePic.Name = "MoviePic";
            this.MoviePic.Size = new System.Drawing.Size(135, 189);
            this.MoviePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePic.TabIndex = 4;
            this.MoviePic.TabStop = false;
            // 
            // SelectDirector
            // 
            this.SelectDirector.BackColor = System.Drawing.SystemColors.Control;
            this.SelectDirector.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectDirector.Location = new System.Drawing.Point(270, 88);
            this.SelectDirector.Name = "SelectDirector";
            this.SelectDirector.Size = new System.Drawing.Size(156, 21);
            this.SelectDirector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(206, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "导演：";
            // 
            // SelectMovieName
            // 
            this.SelectMovieName.BackColor = System.Drawing.SystemColors.Control;
            this.SelectMovieName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectMovieName.Location = new System.Drawing.Point(270, 20);
            this.SelectMovieName.Name = "SelectMovieName";
            this.SelectMovieName.Size = new System.Drawing.Size(156, 21);
            this.SelectMovieName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "电影名：";
            // 
            // MovieListShowed
            // 
            this.MovieListShowed.Controls.Add(this.ShowMovieListTab);
            this.MovieListShowed.Location = new System.Drawing.Point(12, 28);
            this.MovieListShowed.Name = "MovieListShowed";
            this.MovieListShowed.SelectedIndex = 0;
            this.MovieListShowed.Size = new System.Drawing.Size(179, 481);
            this.MovieListShowed.TabIndex = 3;
            // 
            // ShowMovieListTab
            // 
            this.ShowMovieListTab.Controls.Add(this.MoviesList);
            this.ShowMovieListTab.Location = new System.Drawing.Point(4, 22);
            this.ShowMovieListTab.Name = "ShowMovieListTab";
            this.ShowMovieListTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShowMovieListTab.Size = new System.Drawing.Size(171, 455);
            this.ShowMovieListTab.TabIndex = 0;
            this.ShowMovieListTab.Text = "放映列表";
            this.ShowMovieListTab.UseVisualStyleBackColor = true;
            // 
            // OperationMenu
            // 
            this.OperationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售选项ToolStripMenuItem});
            this.OperationMenu.Location = new System.Drawing.Point(0, 0);
            this.OperationMenu.Name = "OperationMenu";
            this.OperationMenu.Size = new System.Drawing.Size(888, 25);
            this.OperationMenu.TabIndex = 4;
            this.OperationMenu.Text = "menuStrip1";
            // 
            // 销售选项ToolStripMenuItem
            // 
            this.销售选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadList});
            this.销售选项ToolStripMenuItem.Name = "销售选项ToolStripMenuItem";
            this.销售选项ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售选项ToolStripMenuItem.Text = "销售选项";
            // 
            // LoadList
            // 
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(152, 22);
            this.LoadList.Text = "加载放映列表";
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // TicketSolder
            // 
            this.TicketSolder.Controls.Add(this.FinalPrice);
            this.TicketSolder.Controls.Add(this.label7);
            this.TicketSolder.Controls.Add(this.SendPerName);
            this.TicketSolder.Controls.Add(this.StuPrice);
            this.TicketSolder.Controls.Add(this.FreeTickets);
            this.TicketSolder.Controls.Add(this.StuTicket);
            this.TicketSolder.Controls.Add(this.NormalTicket);
            this.TicketSolder.Controls.Add(this.label3);
            this.TicketSolder.Controls.Add(this.label5);
            this.TicketSolder.Location = new System.Drawing.Point(678, 126);
            this.TicketSolder.Name = "TicketSolder";
            this.TicketSolder.Size = new System.Drawing.Size(188, 131);
            this.TicketSolder.TabIndex = 5;
            this.TicketSolder.TabStop = false;
            this.TicketSolder.Text = "售票区";
            // 
            // NormalTicket
            // 
            this.NormalTicket.AutoSize = true;
            this.NormalTicket.Location = new System.Drawing.Point(6, 20);
            this.NormalTicket.Name = "NormalTicket";
            this.NormalTicket.Size = new System.Drawing.Size(59, 16);
            this.NormalTicket.TabIndex = 0;
            this.NormalTicket.TabStop = true;
            this.NormalTicket.Text = "普通票";
            this.NormalTicket.UseVisualStyleBackColor = true;
            this.NormalTicket.CheckedChanged += new System.EventHandler(this.NormalTicket_CheckedChanged);
            // 
            // StuTicket
            // 
            this.StuTicket.AutoSize = true;
            this.StuTicket.Location = new System.Drawing.Point(71, 20);
            this.StuTicket.Name = "StuTicket";
            this.StuTicket.Size = new System.Drawing.Size(59, 16);
            this.StuTicket.TabIndex = 1;
            this.StuTicket.TabStop = true;
            this.StuTicket.Text = "学生票";
            this.StuTicket.UseVisualStyleBackColor = true;
            this.StuTicket.CheckedChanged += new System.EventHandler(this.StuTicket_CheckedChanged);
            // 
            // FreeTickets
            // 
            this.FreeTickets.AutoSize = true;
            this.FreeTickets.Location = new System.Drawing.Point(136, 20);
            this.FreeTickets.Name = "FreeTickets";
            this.FreeTickets.Size = new System.Drawing.Size(47, 16);
            this.FreeTickets.TabIndex = 2;
            this.FreeTickets.TabStop = true;
            this.FreeTickets.Text = "赠票";
            this.FreeTickets.UseVisualStyleBackColor = true;
            this.FreeTickets.CheckedChanged += new System.EventHandler(this.FreeTickets_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "学生折扣：";
            // 
            // StuPrice
            // 
            this.StuPrice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StuPrice.Enabled = false;
            this.StuPrice.FormattingEnabled = true;
            this.StuPrice.Items.AddRange(new object[] {
            "5折",
            "6折",
            "7折",
            "8折",
            "9折"});
            this.StuPrice.Location = new System.Drawing.Point(71, 40);
            this.StuPrice.Name = "StuPrice";
            this.StuPrice.Size = new System.Drawing.Size(94, 20);
            this.StuPrice.TabIndex = 4;
            this.StuPrice.TextChanged += new System.EventHandler(this.StuPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "赠票人：";
            // 
            // SendPerName
            // 
            this.SendPerName.Enabled = false;
            this.SendPerName.Location = new System.Drawing.Point(71, 69);
            this.SendPerName.Name = "SendPerName";
            this.SendPerName.Size = new System.Drawing.Size(94, 21);
            this.SendPerName.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "实际票价：";
            // 
            // FinalPrice
            // 
            this.FinalPrice.ForeColor = System.Drawing.Color.Red;
            this.FinalPrice.Location = new System.Drawing.Point(75, 102);
            this.FinalPrice.Name = "FinalPrice";
            this.FinalPrice.Size = new System.Drawing.Size(90, 12);
            this.FinalPrice.TabIndex = 8;
            // 
            // SeatViewContent
            // 
            this.SeatViewContent.Controls.Add(this.SeatPage);
            this.SeatViewContent.Location = new System.Drawing.Point(197, 263);
            this.SeatViewContent.Name = "SeatViewContent";
            this.SeatViewContent.SelectedIndex = 0;
            this.SeatViewContent.Size = new System.Drawing.Size(669, 246);
            this.SeatViewContent.TabIndex = 6;
            // 
            // SeatPage
            // 
            this.SeatPage.AutoScroll = true;
            this.SeatPage.Location = new System.Drawing.Point(4, 22);
            this.SeatPage.Name = "SeatPage";
            this.SeatPage.Padding = new System.Windows.Forms.Padding(3);
            this.SeatPage.Size = new System.Drawing.Size(661, 220);
            this.SeatPage.TabIndex = 0;
            this.SeatPage.Text = "座位表";
            this.SeatPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 522);
            this.Controls.Add(this.SeatViewContent);
            this.Controls.Add(this.TicketSolder);
            this.Controls.Add(this.MovieListShowed);
            this.Controls.Add(this.MovieInfo);
            this.Controls.Add(this.OperationMenu);
            this.MainMenuStrip = this.OperationMenu;
            this.Name = "MainForm";
            this.Text = "售票系统主窗口";
            this.MovieInfo.ResumeLayout(false);
            this.MovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePic)).EndInit();
            this.MovieListShowed.ResumeLayout(false);
            this.ShowMovieListTab.ResumeLayout(false);
            this.OperationMenu.ResumeLayout(false);
            this.OperationMenu.PerformLayout();
            this.TicketSolder.ResumeLayout(false);
            this.TicketSolder.PerformLayout();
            this.SeatViewContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView MoviesList;
        private System.Windows.Forms.GroupBox MovieInfo;
        private System.Windows.Forms.Label SelectDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MoviePic;
        private System.Windows.Forms.Label SelectType;
        private System.Windows.Forms.Label lebel3;
        private System.Windows.Forms.Label SelectActTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SelectActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelectPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl MovieListShowed;
        private System.Windows.Forms.TabPage ShowMovieListTab;
        private System.Windows.Forms.MenuStrip OperationMenu;
        private System.Windows.Forms.ToolStripMenuItem 销售选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadList;
        private System.Windows.Forms.GroupBox TicketSolder;
        private System.Windows.Forms.RadioButton FreeTickets;
        private System.Windows.Forms.RadioButton StuTicket;
        private System.Windows.Forms.RadioButton NormalTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StuPrice;
        private System.Windows.Forms.TextBox SendPerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label FinalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl SeatViewContent;
        private System.Windows.Forms.TabPage SeatPage;
    }
}

