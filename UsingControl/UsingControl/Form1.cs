using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingControl
{
    public partial class MainForm : Form
    {
        Random random = new Random(37);
        public MainForm()
        {
            InitializeComponent();

            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }
        void TreeToList() {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes)
                TreeToList(node);
        }
        void TreeToList(TreeNode Node) {
            lvDummy.Items.Add(new ListViewItem(new string[] {
                Node.Text, Node.FullPath.Count(f => f=='\\').ToString()
            }));
            foreach (TreeNode node in Node.Nodes) {
                TreeToList(node);
            }
        }


        private void GrpFont_Enter(object sender, EventArgs e)
        {

        }

        private void IbIFont_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
                cboFont.Items.Add(font.Name);
        }

        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0) return; // cboFont에서 선택한 항목이 없으면 메소드 종료
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
                style |= FontStyle.Bold;
            if (chkItalic.Checked)
                style |= FontStyle.Italic;

            txtSampleText.Font =  //txtSampleText의 Font 프로버티를 앞에서 만든 style로 수정
                new Font((string)cboFont.SelectedItem, 10, style);
        }




        private void CboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void TxtSampleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modal Form";
            frm.Width = 300;
            frm.Height = 100;
            frm.BackColor = Color.Red;
            frm.ShowDialog(); //Modal창을 띄웁니다.
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Text = "Modaless Form"; // 창 제목
            frm.Width = 300;
            frm.Height = 300;
            frm.BackColor = Color.Green;
            frm.Show(); //Modaless창을 띄웁니다.
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Text", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //      내용              창 제목            버튼?                 경고창 아이콘
        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null) {
                MessageBox.Show("선택된 노드가 없습니다.", "TreeView Test",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }
    }
}
