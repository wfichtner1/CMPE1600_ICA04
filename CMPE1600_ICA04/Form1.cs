using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            //Adds item from input box into list
            UI_ListBox.Items.Add(UI_InputBox.Text);
            //sets selected item to most recent input
            UI_ListBox.SelectedIndex = UI_ListBox.Items.Count - 1;
            //sets the selected item as label below box
            UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();
            //clears input box and puts focus on it
            UI_InputBox.Clear();
            UI_InputBox.Focus();
            //ensures the track bar is constrained to the size of the list box
            if (UI_ListBox.Items.Count == 0)
            {
                UI_TrackBar.SetRange(0, 0);
            }
            else
                UI_TrackBar.SetRange(0, UI_ListBox.Items.Count-1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //as the trackbar scrolls, changes the selected item
            //and sets the label below the box
            UI_ListBox.SelectedIndex = UI_TrackBar.Value;
            UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();

        }

        private void UI_DeleteButton_Click(object sender, EventArgs e)
        {
            //removes items from listbox and ensures trackbar is still
            //constrained to the new size of the box
            UI_ListBox.Items.RemoveAt(UI_ListBox.SelectedIndex);
            //the clear command intercepts an error where the selectedindex
            //would try to grab items at 0 count
            if (UI_ListBox.Items.Count == 0)
            {
                UI_TrackBar.SetRange(0, 0);
                UI_ListBox.Items.Clear();
            }
            else
            {
                //keeps the selected item on the latest user inputted item when item is deleted
                UI_TrackBar.SetRange(0, UI_ListBox.Items.Count - 1);
                UI_ListBox.SelectedIndex = UI_ListBox.Items.Count - 1;
            }
        }

        private void UI_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //makes the label under the text box read as the selected item
            if (UI_ListBox.SelectedIndex != -1)
                UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();
            
        }

        //Opens a text file and reads each line into the list box
        //also sets the name of the form as the opened file
        private void UI_LoadFileButton_Click(object sender, EventArgs e)
        {
            string input = null;           
            StreamReader srInputFile;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Text = openFileDialog1.SafeFileName;
                try
                {
                    //Reads each line in the file and outputs it into the ListBox
                    srInputFile = new StreamReader(openFileDialog1.SafeFileName);               
                    while ((input = srInputFile.ReadLine()) != null)
                    {
                        UI_ListBox.Items.Add(input);                       
                    }
                    srInputFile.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ICA4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Does the same things as the add button
                UI_ListBox.SelectedIndex = UI_ListBox.Items.Count - 1;
                UI_ListLabel.Text = UI_ListBox.SelectedItem.ToString();
                UI_InputBox.Clear();
                UI_InputBox.Focus();
                if (UI_ListBox.Items.Count == 0)
                {
                    UI_TrackBar.SetRange(0, 0);
                }
                else
                    UI_TrackBar.SetRange(0, UI_ListBox.Items.Count - 1);
            }
  
        }

        private void UI_SaveFileButton_Click(object sender, EventArgs e)
        {
            //Takes contents of ListBox and saves them into text file
            StreamWriter swOutputFile;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    swOutputFile = new StreamWriter(saveFileDialog1.FileName);
                    //Goes through strings in List box and writes them into text file
                    foreach (string n in UI_ListBox.Items)
                    {
                        swOutputFile.WriteLine(n);
                    }
                    swOutputFile.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ICA4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Text = "ICA4";
            }
        }
    }
}
