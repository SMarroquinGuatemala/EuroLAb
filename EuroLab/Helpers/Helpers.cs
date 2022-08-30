using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroLab.Helpers
{
    public static class Helpers
    {

        public static void DeshabilitaMenuContextual(ContextMenuStrip mnuOpciones)
        {
            foreach (ToolStripItem item in mnuOpciones.Items)
            {
                if (item.GetType().Name == "ToolStripMenuItem")
                {
                    item.Enabled = false;
                }
            }
        }

    }
}
