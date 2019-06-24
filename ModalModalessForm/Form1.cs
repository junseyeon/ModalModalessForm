using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModalModalessForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "종료합니다";
            Application.ExitThread();
        }

        private void ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void ShowModal()
        {
            this.statusMessage.Text = "모달 창을 띄웁니다";
            FormModal m = new FormModal();
            m.Title = "모달 창 띄우기";
            m.ShowDialog();
        }

        private void BtmModal_Click(object sender, EventArgs e)
        {
            ShowModal();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            ShowModaless();
        }

        private void ShowModaless()
        {
            this.statusMessage.Text = "모달리스창을 띄웁니다";
            FormModaless m = new FormModaless();
            m.Title = "모달리스창";
            m.Show();
        }

        private void ModalessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModaless();
        }

        private void 이프로그림은ModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은.. (Modal)";
            FormAbout m = new FormAbout();
            m.Title = "이프로그램은... (Modal)";
            m.ShowDialog();
        }

        private void 이프로그램은ModalessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.statusMessage.Text = "이 프로그램은.. (Modaless)";
            FormAbout m = new FormAbout();
            m.Title = "이프로그램은... (Modaless)";
            m.Show();
        }
    }
}
