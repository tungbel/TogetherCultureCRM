using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TogetherCultureCRM.Navigation_Control
{
    public class NavigationManager
    {
        // Fields for managing button state, form transition, and random values
        private Button _currentButton; // Keeps track of the currently active button
        private Form _activeForm; // Holds the current child form being displayed within the main menu

        // Activates the clicked button and applies a specific style
        public void ActivateButton(object senderButton, Panel buttonPanel, Color activeColor)
        {
            if (senderButton != null && senderButton is Button btn)
            {
                // Ensure that the button sender is not null
                if (_currentButton != btn)
                {
                    // Check if the clicked button is different from the current one
                    ResetButtons(buttonPanel);
                    _currentButton = btn;
                    _currentButton.BackColor = activeColor;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Poppins", 8.8F, FontStyle.Regular);
                }
            }
        }

        // Resets the style of all buttons in a panel
        public void ResetButtons(Panel buttonPanel)
        {
            foreach (Control control in buttonPanel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(17, 29, 39);
                    button.ForeColor = Color.Gainsboro;
                    button.Font = new Font("Poppins", 7.8F, FontStyle.Regular);
                }
            }
        }

        // Opens a child form inside a parent form
        public void OpenChildForm(Form parentForm, Form childForm, Panel displayPanel)
        {
            if (_activeForm != null)
            {
                _activeForm.Close();
            }

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            displayPanel.Controls.Clear(); // Clear previous content in the panel
            displayPanel.Controls.Add(childForm);
            displayPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Load a default child form
        public void LoadDefaultChildForm(Form parentForm, Form defaultForm, Button defaultButton, Panel displayPanel, Panel buttonPanel, Color activeColor)
        {
            ActivateButton(defaultButton, buttonPanel, activeColor);
            OpenChildForm(parentForm, defaultForm, displayPanel);
        }
    }
}
