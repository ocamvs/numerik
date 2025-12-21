using numerik.mod;
using System.Xml.Linq;

namespace numerik
{
    public partial class MainF : Form
    {
        int x  = 0;
        int y = 0;
        const int between = 15;
        const int hPanel = 10;
        List<Button> list = new List<Button>();
        int resC = 0;
        public MainF()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //list.Add(new Button());
            
            //list[list.Count - 1].Size = new Size(30, 10);
            //if(list.Count > 1)
            //{
            //    list[list.Count - 1].Location = new Point(x, list[list.Count - 2].Location.Y + list[list.Count - 2].Height + between);
            //}
            //else
            //{
            //    list[list.Count - 1].Location = new Point(x, y);
            //}
            

            //int r = random.Next(255);
            //int g = random.Next(255);
            //int b = random.Next(255);

            //list[list.Count - 1].BackColor = Color.FromArgb(r, g, b);
            //list[list.Count - 1].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //list[list.Count - 1].Click += buttonIs_Click;
            //panel1.Controls.Add(list[list.Count - 1]); 
            //y += between;  
        }
        private void Panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            int y = e.Delta;
            if (e.Delta > 0)
            {
                if (list[0].Location.Y == 0) {
                    return;
                }
                else if(list[0].Location.Y + e.Delta > 0)
                {
                    y = list[0].Location.Y * -1;
                }
            }
            else
            {
                //if (list[list.Count - 1].Location.Y  + list[list.Count - 1].Size.Height <= panel1.Size.Height)
                if ((list.Count * hPanel) + (between * (list.Count - 1))<= panel1.Size.Height || list[list.Count - 1].Location.Y + list[list.Count - 1].Height == panel1.Height)
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
        private void buttonIs_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show(button.Parent.ToString());
        }
    }
    public class Rendering
    {
        public Dto report {  get; set; }
        public int carriageX { get; set; } = 0;
        public int carriageY { get; set; } = 0;
        private void Deployment(Dto dtp)
        {
            Crovel crovel = new Crovel(report, carriageX, carriageY);
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
}
