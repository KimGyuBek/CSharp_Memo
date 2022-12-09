using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1 : Form
    {
        MemoEntities entities = new MemoEntities();
        int selectedMemoId;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            listBox_member.DataSource = entities.Member.ToList();
            listBox_member.DisplayMember = "name";
        }

        private void btn_addMemo_Click(object sender, EventArgs e)
        {
            string contents = "메모가 추가되었습니다.";
            Member member = listBox_member.SelectedItem as Member;

            try
            {
                entities.Memo.Add(new Memo
                {
                    createdTime = DateTime.Now,
                    updateTime = DateTime.Now,
                    content = contents,
                    Member = member
                });
                entities.SaveChanges();
                MessageBox.Show("메모 추가 완료");
            } catch
            {
                MessageBox.Show("메모 추가 오류");
            } finally
            {
                loadData();
            }
        }

        private void listBox_member_SelectedIndexChanged(object sender, EventArgs e)
        {
            Member member = listBox_member.SelectedItem as Member;
            int memberId = member.id;

            var result = (from m in entities.Memo
                          where m.userId == memberId
                          select m).ToList();

            listBox_memo.DataSource = result;
            listBox_memo.DisplayMember = "content";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Memo memo = listBox_memo.SelectedItem as Memo;
            string content = textBox1.Text;
            selectedMemoId = memo.id;

            Memo selected = entities.Memo.First(m => m.id == memo.id);
            
            selected.content = content;
            entities.SaveChanges();

            loadData();
        }

        private void listBox_memo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = (listBox_memo.SelectedItem as Memo).content;
        }
    }
}
