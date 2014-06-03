using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace NoteBox
{
	/// <summary>
	/// NoteForm ��ժҪ˵����
	/// </summary>
	public class NoteForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		private int screenWidth;//��Ļ���
		private int screenHeight;//��Ļ�߶�
		private bool finished=false;//�Ƿ���ȫ��ʾ��ʾ����

		public NoteForm()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//

			screenHeight = Screen.PrimaryScreen.Bounds.Height;
			screenWidth = Screen.PrimaryScreen.Bounds.Width;
			//������ʾ������������Ļ����ʾ����֮��
			Location = new Point(screenWidth-Width, screenHeight);
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(124, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "��ʾ";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 39);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(268, 50);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "�𾴵��û���\r\n    ������ʹ�õ�����ǵ���������뵽΢��˾ע���Ϊ�����û����Ի��΢��Ĺٷ�֧�֡�";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(104, 96);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "֪����";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// NoteForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(292, 126);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "NoteForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "NoteForm";
			this.TopMost = true;
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnOK;

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (!finished)//�����ʾ����û����ȫ��ʾ
			{
				//�����ʾ���ڵ�����������ʾ���ڵĸ߶�֮�ʹ�����Ļ�߶�
				if (Location.Y + Height >= screenHeight)
				{
					Location = new Point(Location.X, Location.Y - 20);
				}
			}
			else//�����ʾ�����Ѿ��������ʾ�����ҵ����ȷ����ť
			{
				//�����ʾ����û����ȫ����Ļ����ʧ
				if (Location.Y < screenHeight)
				{
					Location = new Point(Location.X, Location.Y + 20);
				}
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			//�����������ʾ���Ա�����ʾ�ؼ��Ƴ���Ļ����ʾ����
			finished = true;
		}
	}
}
