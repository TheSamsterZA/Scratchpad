using System.Windows.Forms;

namespace OverrideButtonImageDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            customButton.Refresh();
        }
    }
}
