using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class My_form : Form
    {
        public My_form()
        {
            InitializeComponent();
        }

        private void Run_Bottun_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                double a, b, c, h;
                a = Convert.ToDouble(TXTA.Text);
                b = Convert.ToDouble(TXTB.Text);
                c = Convert.ToDouble(TXTC.Text);
                h = Convert.ToDouble(TXTH.Text);
                Triangle triangle = new Triangle(a, b, c, h);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Высота h");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(triangle.outputH());
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Plosad()));
                if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("Существует"); }
                else listView1.Items[5].SubItems.Add("Не существует");
                listView1.Items[6].SubItems.Add(triangle.TriangleType);

                if (triangle.TriangleType == "Равносторонний")
                {
                    pictureBox1.Image = Properties.Resources.l4;
                }
                else if (triangle.TriangleType == "Равнобедренный")
                {
                    pictureBox1.Image = Properties.Resources.ravnb;
                }
                else if (triangle.TriangleType == "Разносторонний")
                {
                    pictureBox1.Image = Properties.Resources.image001;
                }
                else if (triangle.TriangleType == "Ломанная")
                {
                    pictureBox1.Image = Properties.Resources.lomanaja;
                }
            }
            catch
            {

                listView1.Items.Add("Напиши A, B, C и H");
            }
            



        }

      
    }
}
