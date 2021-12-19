using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MedicineEquipmentControSystem
{
    public partial class AddForm : Form
    {
        public Form addForm;
        public Label name;
        public Label provider;
        public Label count;
        public Label type;
        public TextBox namebox;
        public TextBox providerbox;
        public TextBox countbox;
        public TextBox typebox;
        public Button okay;
        public Button cancel;
        public AddForm()
        {
            InitializeComponent();
            this.name = new Label();
            this.name.Text = "Имя";
            this.provider = new Label();
            this.provider.Text = "Поставщик";
            this.count = new Label();
            this.count.Text = "Количество";
            this.type = new Label();
            this.type.Text = "Тип";
            this.namebox = new TextBox();
            this.providerbox = new TextBox();
            this.countbox = new TextBox();
            this.typebox = new TextBox();
            
            this.okay = new Button();
            this.cancel = new Button();
            this.cancel.Text = "Отмена";
            this.okay.Text = "Добавить";
            this.okay.DialogResult = DialogResult.OK;
            this.cancel.DialogResult = DialogResult.Cancel;
            this.okay.Location = new Point(300, 100);
            this.cancel.Location = new Point(0, 100);
            this.okay.Size = new Size(80, 20);
            this.cancel.Size = new Size(80, 20);
            
            this.name.Location = new Point(0, 0);
            this.provider.Location = new Point(100, 0);
            this.count.Location = new Point(200, 0);
            this.type.Location = new Point(300, 0);
            
            this.namebox.Location = new Point(0, 50);
            this.providerbox.Location = new Point(100, 50);
            this.countbox.Location = new Point(200, 50);
            this.typebox.Location = new Point(300, 50);
                
            this.name.Size = new Size(100, 20);
            this.provider.Size = new Size(100, 20);
            this.count.Size = new Size(100, 20);
            this.type.Size = new Size(100, 20);
            
            this.namebox.Size = new Size(100, 20);
            this.providerbox.Size = new Size(100, 20);
            this.countbox.Size = new Size(100, 20);
            this.typebox.Size = new Size(100, 20);
            
            this.Controls.Add(this.name);
            this.Controls.Add(this.provider);
            this.Controls.Add(this.count);
            this.Controls.Add(this.type);
            
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.providerbox);
            this.Controls.Add(this.countbox);
            this.Controls.Add(this.typebox);
            
            this.Controls.Add(this.okay);
            this.Controls.Add(this.cancel);

        }
    }
}