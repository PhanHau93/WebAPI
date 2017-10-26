using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace AppGes.Utils
{
    public class Utilidades
    {
        public void HabilitarDeshabilitarTextBox(ControlCollection collection, bool habilitar)
        {
            foreach (Control c in collection)
            {
                if (c.HasChildren)
                {
                    ControlCollection ch = c.Controls;
                    foreach (Control c2 in ch)
                    {
                        if (c.HasChildren)
                        {
                            ControlCollection ch1 = c.Controls;
                            foreach (Control c3 in ch1)
                            {
                                if (c3.HasChildren)
                                {

                                }
                                if (c3 is TextBox)
                                    c3.Enabled = habilitar;
                            }
                        }
                        if (c2 is TextBox)
                            c2.Enabled = habilitar;
                    }
                        if (c is TextBox)
                            c.Enabled = habilitar;
                    }
                
                else if (c is TextBox)
                    c.Enabled = habilitar;
            }
        }
    }
}
