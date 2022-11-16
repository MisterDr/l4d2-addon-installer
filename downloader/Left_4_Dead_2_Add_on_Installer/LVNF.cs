using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    public class LVNF : ListView
    {
        public LVNF()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            SetStyle(ControlStyles.EnableNotifyMessage, value: true);
        }

        protected override void OnNotifyMessage(Message m)
        {
            if (m.Msg != 20)
            {
                base.OnNotifyMessage(m);
            }
        }
    }
}
