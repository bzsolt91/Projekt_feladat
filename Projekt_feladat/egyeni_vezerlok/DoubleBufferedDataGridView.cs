using System.Reflection;
using System.Windows.Forms;

namespace Projekt_feladat.egyeni_vezerlok
{

    // villódzás mentes datagridview
    public class DoubleBufferedDataGridView : DataGridView
    {
        public DoubleBufferedDataGridView()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                null, this, new object[] { true });

            this.EnableHeadersVisualStyles = false;
        }
    }
}
