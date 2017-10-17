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
            this.button1 = new System.Windows.Forms.Button();
            this.MoviesList = new System.Windows.Forms.TreeView();
            this.MovieInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectMovieName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectDirector = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectType = new System.Windows.Forms.Label();
            this.lebel3 = new System.Windows.Forms.Label();
            this.SelectActor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectActTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(760, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoviesList
            // 
            this.MoviesList.Location = new System.Drawing.Point(12, 49);
            this.MoviesList.Name = "MoviesList";
            this.MoviesList.Size = new System.Drawing.Size(158, 366);
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
            this.MovieInfo.Controls.Add(this.pictureBox1);
            this.MovieInfo.Controls.Add(this.SelectDirector);
            this.MovieInfo.Controls.Add(this.label2);
            this.MovieInfo.Controls.Add(this.SelectMovieName);
            this.MovieInfo.Controls.Add(this.label1);
            this.MovieInfo.Location = new System.Drawing.Point(190, 40);
            this.MovieInfo.Name = "MovieInfo";
            this.MovieInfo.Size = new System.Drawing.Size(464, 229);
            this.MovieInfo.TabIndex = 2;
            this.MovieInfo.TabStop = false;
            this.MovieInfo.Text = "电影信息";
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
            // SelectMovieName
            // 
            this.SelectMovieName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectMovieName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectMovieName.Location = new System.Drawing.Point(270, 20);
            this.SelectMovieName.Name = "SelectMovieName";
            this.SelectMovieName.Size = new System.Drawing.Size(156, 21);
            this.SelectMovieName.TabIndex = 1;
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
            // SelectDirector
            // 
            this.SelectDirector.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SelectDirector.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectDirector.Location = new System.Drawing.Point(270, 88);
            this.SelectDirector.Name = "SelectDirector";
            this.SelectDirector.Size = new System.Drawing.Size(156, 21);
            this.SelectDirector.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 189);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SelectType
            // 
            this.SelectType.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // SelectActor
            // 
            this.SelectActor.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // SelectActTime
            // 
            this.SelectActTime.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // SelectPrice
            // 
            this.SelectPrice.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 496);
            this.Controls.Add(this.MovieInfo);
            this.Controls.Add(this.MoviesList);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "售票系统主窗口";
            this.MovieInfo.ResumeLayout(false);
            this.MovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView MoviesList;
        private System.Windows.Forms.GroupBox MovieInfo;
        private System.Windows.Forms.Label SelectDirector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SelectMovieName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SelectType;
        private System.Windows.Forms.Label lebel3;
        private System.Windows.Forms.Label SelectActTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SelectActor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SelectPrice;
        private System.Windows.Forms.Label label8;
    }
}

