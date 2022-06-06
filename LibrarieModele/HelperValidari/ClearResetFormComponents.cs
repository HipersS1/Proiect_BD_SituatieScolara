using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;


namespace LibrarieModele
{
    public static class ClearResetFormComponents
    {
        /// <summary>
        /// 'Curata' datele introduse din form
        /// </summary>
        /// <param name="form"></param>
        public static void ClearInputs(IEnumerable<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Text = String.Empty;
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;// modificat aici
                }
            }
        }

        /// <summary>
        /// Coloreaza controalele de tip Label in negru
        /// </summary>
        /// <param name="form"></param>
        public static void ResetColors(IEnumerable<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is Label)
                    ((Label)control).ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Pentru a da enable/disable la elemente
        /// </summary>
        /// <param name="controls"></param>
        public static void TurnOnOffComponent(IEnumerable<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = !((TextBox)control).Enabled;
                if (control is ComboBox)
                    ((ComboBox)control).Enabled = !((ComboBox)control).Enabled;
                if (control is Label)
                    ((Label)control).Enabled = !((Label)control).Enabled;
            }
        }

        /// <summary>
        /// Pentru a da enable la elemente
        /// </summary>
        /// <param name="controls"></param>
        public static void TurnOnComponents(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = true;
                if (control is ComboBox)
                    ((ComboBox)control).Enabled = true;
                if (control is Label)
                    ((Label)control).Enabled = true;
            }
        }
        /// <summary>
        /// Pentru a da disable la elemente
        /// </summary>
        /// <param name="controls"></param>
        public static void TurnOffComponents(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Enabled = false;
                if (control is ComboBox)
                    ((ComboBox)control).Enabled = false;
                if (control is Label)
                    ((Label)control).Enabled = false;
            }
        }
    }
}
