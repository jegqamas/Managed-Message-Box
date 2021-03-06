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
using System.Drawing;
using System.Windows.Forms;
namespace MMB
{
    /*Implement the simple error message methods*/
    public sealed partial class ManagedMessageBox
    {
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="messageText">The message text to show</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(string messageText)
        {
            return ShowMessage(null, messageText, " ", ManagedMessageBoxButtons.OK, 0, null,
            ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="ParentWindow">The parent window that should handle the managed message box window</param>
        /// <param name="messageText">The message text to show</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(IWin32Window ParentWindow, string messageText)
        {
            return ShowMessage(ParentWindow, messageText, " ", ManagedMessageBoxButtons.OK, 0, null,
             ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(string messageText, string messageCaption)
        {
            return ShowMessage(null, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, null,
          ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="ParentWindow">The parent window that should handle the managed message box window</param>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(IWin32Window ParentWindow, string messageText, string messageCaption)
        {
            return ShowMessage(ParentWindow, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, null,
             ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="showCheckBox">Indicate whether to show the check box or not</param>
        /// <param name="checkBoxValue">The default check box value if the check box is enabled (showCheckBox = true).</param>
        /// <param name="checkBoxText">The check box text if the check box is enabled (showCheckBox = true).</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(string messageText, string messageCaption,
            bool showCheckBox, bool checkBoxValue, string checkBoxText)
        {
            return ShowMessage(null, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, null,
           ManagedMessageBoxIcon.Error, showCheckBox, checkBoxValue, checkBoxText, _rightToLeft);
        }
        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="ParentWindow">The parent window that should handle the managed message box window</param>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="showCheckBox">Indicate whether to show the check box or not</param>
        /// <param name="checkBoxValue">The default check box value if the check box is enabled (showCheckBox = true).</param>
        /// <param name="checkBoxText">The check box text if the check box is enabled (showCheckBox = true).</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(IWin32Window ParentWindow, string messageText, string messageCaption,
            bool showCheckBox, bool checkBoxValue, string checkBoxText)
        {
            return ShowMessage(ParentWindow, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, null,
           ManagedMessageBoxIcon.Error, showCheckBox, checkBoxValue, checkBoxText, _rightToLeft);
        }
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="controls">More control to add long side with buttons. The controls you may add will not effect the result
        /// , The result is for buttons and the check box only. This can be null to add no control.</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(string messageText, string messageCaption, Control[] controls)
        {
            return ShowMessage(null, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, controls,
                ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show simple error message
        /// </summary>
        /// <param name="ParentWindow">The parent window that should handle the managed message box window</param>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="controls">More control to add long side with buttons. The controls you may add will not effect the result
        /// , The result is for buttons and the check box only. This can be null to add no control.</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(IWin32Window ParentWindow, string messageText, string messageCaption,
            Control[] controls)
        {
            return ShowMessage(ParentWindow, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, controls,
                ManagedMessageBoxIcon.Error, false, false, "", _rightToLeft);
        }
        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="controls">More control to add long side with buttons. The controls you may add will not effect the result
        /// , The result is for buttons and the check box only. This can be null to add no control.</param>
        /// <param name="showCheckBox">Indicate whether to show the check box or not</param>
        /// <param name="checkBoxValue">The default check box value if the check box is enabled (showCheckBox = true).</param>
        /// <param name="checkBoxText">The check box text if the check box is enabled (showCheckBox = true).</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(string messageText, string messageCaption,
          Control[] controls, bool showCheckBox, bool checkBoxValue, string checkBoxText)
        {
            return ShowMessage(null, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, controls,
                ManagedMessageBoxIcon.Error, showCheckBox, checkBoxValue, checkBoxText, _rightToLeft);
        }

        /*Full*/
        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="ParentWindow">The parent window that should handle the managed message box window</param>
        /// <param name="messageText">The message text to show</param>
        /// <param name="messageCaption">The message caption (title of the managed message box window)</param>
        /// <param name="controls">More control to add long side with buttons. The controls you may add will not effect the result
        /// , The result is for buttons and the check box only. This can be null to add no control.</param>
        /// <param name="showCheckBox">Indicate whether to show the check box or not</param>
        /// <param name="checkBoxValue">The default check box value if the check box is enabled (showCheckBox = true).</param>
        /// <param name="checkBoxText">The check box text if the check box is enabled (showCheckBox = true).</param>
        /// <returns><see cref="MMB.ManagedMessageBoxResult"/> object, will always tell that the first button is clicked and the check box result</returns>
        public static ManagedMessageBoxResult ShowErrorMessage(IWin32Window ParentWindow, string messageText, string messageCaption,
             Control[] controls, bool showCheckBox, bool checkBoxValue, string checkBoxText)
        {
            return ShowMessage(ParentWindow, messageText, messageCaption, ManagedMessageBoxButtons.OK, 0, controls,
                ManagedMessageBoxIcon.Error, showCheckBox, checkBoxValue, checkBoxText, _rightToLeft);
        }
    }
}
