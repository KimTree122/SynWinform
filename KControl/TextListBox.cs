using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KControl
{


    public partial class TextListBox : TextBox
    {

        private bool systemSetText = false;
        private bool ActiveDrop { get; set; }

        private ListBox listBox = new ListBox();
        private ToolStripControlHost controlHost;
        private ToolStripDropDown dropDown;
        private List<string> strlist;
        public Action onPressEnter;


        public TextListBox()
        {
            listBox.KeyDown += (s, e) =>
            {
                if (e.KeyData == Keys.Enter) SetTextAndValue();
            };

            listBox.DoubleClick += (s, e) =>
            {
                if (listBox.Items.Count > 0) SetTextAndValue();
            };

            controlHost = new ToolStripControlHost(listBox);
            controlHost.AutoSize = false;
            dropDown = new ToolStripDropDown();
            dropDown.Items.Add(controlHost);
            dropDown.AutoClose = false;
            listBox.Dock = DockStyle.Fill;
            this.Tag = 0;

            this.TextChanged += TextList_TextChanged;
            this.KeyDown += TextList_KeyDown;
            this.LostFocus += (s, e) => { if (!dropDown.Focused) dropDown.Close(); };

            //onPressEnter = () => { SendKeys.Send("{tab}"); };

        }

        private void TextList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (listBox.SelectedIndex == listBox.Items.Count - 1)
                {
                    listBox.SelectedIndex = 0;
                }
                else if (listBox.SelectedIndex < listBox.Items.Count - 1)
                {
                    listBox.SelectedIndex += 1;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (listBox.SelectedIndex == 0)
                {
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }
                else if (listBox.SelectedIndex <= listBox.Items.Count - 1)
                {
                    listBox.SelectedIndex -= 1;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SetTextAndValue();
            }
        }

        private void SetTextAndValue()
        {
            if (listBox.Items.Count == 0) return;

            string seltext = listBox.SelectedItem.ToString();
            string[] strs = seltext.Split('-');
            systemSetText = true;
            this.Text = strs[0];
            this.Tag = strs[strs.Count() - 1];
            systemSetText = false;
            this.SelectionStart = this.Text.Length;
            dropDown.Close();
        }

        public void BindData(List<string> list)
        {
            strlist = list;
        }

        private void TextList_TextChanged(object sender, EventArgs e)
        {
            if (!this.Focused) return;
            if (this.Text.Trim().Length == 0) { dropDown.Close(); return; }
            if (!systemSetText)
            {
                setFilter(this.Text);
            }
        }

        private void showDropDown(int count)
        {
            listBox.ItemHeight = this.Height;
            listBox.Font = this.Font;
            controlHost.Width = this.Width;
            controlHost.Height = calcHeightSimple(count);
            dropDown.Show(this, -2, this.Height - 3);
        }

        private int calcHeightSimple(int count)
        {
            if (count > 5)
            {
                return listBox.ItemHeight * 5;
            }
            else
            {
                return listBox.ItemHeight * (count + 1);
            }
        }

        private void setFilter(string text)
        {
            listBox.Items.Clear();
            var v = strlist.Where(e => e.Contains(text));
            foreach (var item in v)
            {
                listBox.Items.Add(item);
            }
            if (v.Count() > 0)
            {
                listBox.SelectedIndex = 0;
                showDropDown(v.Count());
            }
            else
            {
                dropDown.Close();
            }
        }
    }
}
