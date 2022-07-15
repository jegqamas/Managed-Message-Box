/* This file is part of Managed Message Box
   A message box component with advanced capacities

   Copyright © Ala Ibrahim Hadid 2013

   This program is free software: you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMB;

namespace ManagedMessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagedMessageBox.ShowMessage("This is a simple info message", "Info message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagedMessageBoxResult res = ManagedMessageBox.ShowMessage("This is an info message with some buttons and the check box", "Info message",
                    new string[] { "&OK", "&Button 1", "Button 2" }, 0, ManagedMessageBoxIcon.Info, true, true,
                    "Check box of the message");

            ManagedMessageBox.ShowMessage("You clicked '" + res.ClickedButton + "' button and the check box value is '" +
                    res.Checked.ToString() + "'", "Result !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagedMessageBoxResult res = ManagedMessageBox.ShowCustomMessage("This is a customized info message with some buttons and the check box", "Info message",
                new Font("Arial", 11, FontStyle.Bold | FontStyle.Italic), Color.White, Color.Gray,
                   new string[] { "&OK", "&Button 1", "Button 2" }, 0, null, Properties.Resources.Baloon, true, true,
                   "Check box of the message");

            ManagedMessageBox.ShowMessage("You clicked '" + res.ClickedButton + "' button and the check box value is '" +
                    res.Checked.ToString() + "'", "Result !");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagedMessageBoxResult res = ManagedMessageBox.ShowQuestionMessage("This is a simple question message, do you like Managed Message Box ?", "Simple question message");

            ManagedMessageBox.ShowMessage("Your answer is " + res.ClickedButton, "Result !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagedMessageBox.ShowWarningMessage("This is a simple warning message", "Warning message");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagedMessageBox.ShowErrorMessage("This is a simple error message", "Error message");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManagedMessageBoxResult res = ManagedMessageBox.ShowMessage("This is a save message, like: do you want to save your work first ?", "Save message",
               ManagedMessageBoxButtons.SaveDontsaveCancel, 1, ManagedMessageBoxIcon.Save);

            ManagedMessageBox.ShowMessage("You clicked '" + res.ClickedButton + "' button.", "Result !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManagedMessageBoxResult res = ManagedMessageBox.ShowMessage("This is an info message with some buttons and the check box", "Info message",
                 new string[] { "&OK", "&Button 1", "Button 2" }, 0, new Control[] { new TextBox(), new TrackBar() },
                 ManagedMessageBoxIcon.Info, true, true, "Check box of the message");

            ManagedMessageBox.ShowMessage("You clicked '" + res.ClickedButton + "' button and the check box value is '" +
                    res.Checked.ToString() + "'", "Result !");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text file|*.txt";
            if (op.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                ManagedMessageBox.ShowMessage(System.IO.File.ReadAllText(op.FileName), "Huge message !");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ManagedMessageBox.ShowMessage("Managed Message Box version " +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version + "\n" +
   "A message box component with advanced capacities\n\n" +

   "Copyright © Ala Ibrahim Hadid 2013\n\n" +

   "This program is free software: you can redistribute it and/or modify\n" +
   "it under the terms of the GNU General Public License as published by\n" +
   "the Free Software Foundation, either version 3 of the License, or\n" +
   "(at your option) any later version.\n\n" +

   "This program is distributed in the hope that it will be useful,\n" +
   "but WITHOUT ANY WARRANTY; without even the implied warranty of\n" +
   "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n" +
   "GNU General Public License for more details.\n\n" +

   "You should have received a copy of the GNU General Public License\n" +
   "along with this program.  If not, see <http://www.gnu.org/licenses/>.", "About");
        }
    }
}
