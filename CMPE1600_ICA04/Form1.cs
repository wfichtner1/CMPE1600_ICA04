using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600_ICA04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UI_AddButton_Click(object sender, EventArgs e)
        {
            UI_ListBox.Items.Add(UI_InputBox.Text);
            UI_ListBox.SelectedIndex = 0;
            UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();
            UI_InputBox.Clear();
            UI_InputBox.Focus();
            UI_TrackBar.SetRange(0, UI_ListBox.Items.Count-1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UI_ListBox.SelectedIndex = UI_TrackBar.Value;
            UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();
        }

        private void UI_DeleteButton_Click(object sender, EventArgs e)
        {
            UI_ListBox.Items.RemoveAt(UI_ListBox.SelectedIndex);
        }
    }
}
