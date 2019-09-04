using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FakeBSOD
{
    public partial class BSOD : Form
    {
        private string BSOD_Content = "A problem has been detected and windows has been shut down to prevent damage to your computer.\n\n" +
            "DRIVER_IRQL_NOT_LESS_OR_EQUAL\n\n" +
            "If this is the first time you've seen this stop error screen.\n" +
            "restart your computer. If this screen appears again, follow these steps:\n\n" +
            "Check to make sure any new hardware or software is properly installed.\n" +
            "If this is a new installation, ask your hardware or software manufacturer for any windows updates you might need.\n\n" +
            "If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing.\n" +
            "If you need to use safe mode to remove or disable components, restart your computer, press F8 to select Advantage Startup Options, and then select Safe Mode.\n\n" +
            "Technical information:\n\n" +
            "*** STOP: 0x00000000D1 (0x00000000C, 0x000000002, 0x000000000, 0xF86B5A89)\n\n" +
            "*** gv3.sys - Address F86B5A89 base at F86B5000, DateStamp 3dd991eb\n\n" +
            "Beginning dump of physical memory\nPhysical memory dump complete.\n" +
            "Contact your system administrator or technical support group for further assistance.";

        public BSOD()
        {
            InitializeComponent();
        }

        private void BSOD_Load(object sender, EventArgs e)
        {
            Cursor.Hide(); // hide cursor
            BSOD_Text.Text = BSOD_Content; // put the text on the screen
        }

        private void BSOD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Debugger.IsAttached) { e.Cancel = true; } // makes debugging easier
        }
    }
}
