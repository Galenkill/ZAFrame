using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton;
using Krypton.Docking;
using Krypton.Toolkit;

namespace ZAFrame.Common.UI
{
    public partial class MainForm : Form
    {
        KryptonDockingManager dockManager = new KryptonDockingManager();
        KryptonManager kManager = new KryptonManager();

        const string PATH_WORKSPACE = "Workspace";
        const string PATH_CONTROL = "Control";
        Color _stripBackColor = Color.FromArgb(99, 108, 135);
        Color _menustripBackColor = Color.FromArgb(0xa1, 0xa3, 0xa6);
        public MainForm()
        {
            InitializeComponent();
            kManager.GlobalPaletteMode = PaletteModeManager.Office365SilverLightMode;
            kManager.GlobalApplyToolstrips = true;

        }
    }
}
