using numerik.mod;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace numerik
{
    public partial class MainF : Form
    {
        //Rendering pan;
        List<Line> lines = new List<Line>();
        public MainF()
        {
            InitializeComponent();
        }
        void ReportingPoint()
        {
            ModalPanel panel = new ModalPanel();
            panel.Location = new Point(0, 0);
            this.Controls.Add(panel);
        }
        private void button1_Click(object sender, EventArgs e)
        {
 
        }
       
        
        private void buttonIs_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Parent.ToString());
        }
    }
    public class Rendering
    {
        public Rendering(Dto dto)
        {
            report = dto;
            Deployment(report, carriageX);
        }
        private Dto report;
        public int carriageX { get; private set; } = 0;
        public int carriageY { get; private set; } = 0;
        private const int indentation = 20;
        private void Deployment(Dto dtp, int x)
        {
            Crovel crovel = new Crovel(report, carriageX, carriageY);
            foreach (var item in report.item)
            {
                Deployment(dtp, x + indentation);
            }
        }
    }
    public class Crovel
    {
        Dto content;
        Panel panel;
        List<Button> buttons;

        bool resLeft = false;
        bool resRight = false;

        int carriageX = 0;
        const int beetwin = 5;
        public Crovel(Dto report, int carriageX, int carriageY)
        {
            content = report;
            panel = new Panel();
            panel.Location = new Point(carriageX,carriageY);
            TitleBut(content.GetName());
        }

        Button SetBut(string name)
        {
            var but = new Button();
            but.Text = name;
            buttons.Add(but);
            carriageX += but.Size.Height + beetwin;
            return but;
        }
        void TitleBut(string name)
        {
            var b = SetBut(name);
            
            b.MouseDown += new MouseEventHandler(TitleClick);
            //b.MouseUp += new MouseEventHandler(TitleClick);
        }
        void AddBut()
        {
            SetBut("+").Click += AddClick;
        }
        void DelBut()
        {
            SetBut("-").Click += DeleteClick;
        }

        private void TitleClick(object? sender, MouseEventArgs e)
        {
            Enter.targetReport = this;
            if(e.Button == MouseButtons.Left)
            {
                Disclosure();
            }
            else if (e.Button == MouseButtons.Right)
            {
                GetProperty();
            }
        }
        private void AddClick(object? sender, EventArgs e)
        {
            Change change = new Change();
            if(change.ShowDialog() == DialogResult.OK)
            {
                //запись в бд
                //добавление в список нового dto
            }
        }
        private void DeleteClick(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¬ы точно хотите удалить ", "ѕодтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                //удаление с бд
                //удаление этого dto хз как
                
            }
        }

        private void Disclosure()
        {
            //запрос в бд списка 
            //присваивание в Dto.item полученого списка
        }
        private void GetProperty()
        {
            
            //формирование модальной панели
            //запись в нее свойства
        }
    }
    
    public abstract class LinePanel
    {
        protected Panel target = new Panel();
        protected int targetHeight = 0;
        protected int targetWidht = 0;
        protected List<Control> item = new List<Control>();

        protected int carriageY = 0;
        protected const int beetwin = 10;
        public LinePanel(int wadth, int heigth)
        {
            targetHeight = heigth;
            targetWidht = wadth;
        }
        public LinePanel(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                if (control.Size.Width > targetWidht)
                {
                    targetWidht = control.Size.Width;
                }
                targetHeight += control.Size.Height + beetwin;
                Add(control);
            }
            targetHeight-=beetwin;
            
        }

        public virtual void Paint(Control control, int x, int y)
        {
            //(Form)control.Controls.Add(new Button());
            target.Size = new Size(targetWidht, targetHeight);
            target.Location = new Point(x, y);
            control.Controls.Add(target);
            target.MouseWheel += MouseWheel;
        }
        public virtual void Add(Control control)
        {
            control.Location = new Point(0, carriageY);
            carriageY += control.Height + beetwin;
            item.Add(control);
            target.Controls.Add(control);
        }
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            var list = item;
            int y = e.Delta;
            if (e.Delta > 0)
            {
                if (list[0].Location.Y == 0)
                {
                    return;
                }
                else if (list[0].Location.Y + e.Delta > 0)
                {
                    y = list[0].Location.Y * -1;
                }
            }
            else
            {
                //if (list[list.Count - 1].Location.Y  + list[list.Count - 1].Size.Height <= panel1.Size.Height)
                if ((list.Count * hPanel) + (between * (list.Count - 1)) <= panel1.Size.Height || list[list.Count - 1].Location.Y + list[list.Count - 1].Height == panel1.Height)
                {
                    return;
                }
                else if (list[list.Count - 1].Location.Y + list[list.Count - 1].Size.Height + e.Delta < panel1.Size.Height)
                {
                    y = (list[list.Count - 1].Location.Y - (list[list.Count - 1].Location.Y - (list[list.Count - 1].Location.Y - panel1.Height) - list[list.Count - 1].Height)) * -1;
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                list[i].Location = new Point(list[i].Location.X, list[i].Location.Y + y);
            }
        }
    }

    public class ModalPanel : LinePanel
    {
        public ModalPanel(int wadth, int heigth) : base(wadth, heigth){}
        public override void Paint(Control control, int x, int y)
        {
            target.Size = new Size(targetWidht, targetHeight);
            target.Location = new Point(x, y);
            control.Controls.Add(target);
            control.Controls.SetChildIndex(target, 0);
        }
    }
}
