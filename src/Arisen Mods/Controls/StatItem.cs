using DevExpress.XtraEditors;

namespace ArisenMods.Controls
{
    public partial class StatItem : XtraUserControl
    {
        public string Title
        {
            get => LabelTitle.Text;
            set => LabelTitle.Text = value;
        }

        public string Value
        {
            get => LabelValue.Text;
            set => LabelValue.Text = value;
        }

        public StatItem()
        {
            InitializeComponent();
            LabelTitle.Text = Title;
            LabelValue.Text = Value;
        }
    }
}