using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_for_CD
{
    public partial class Add : Form
    {
        string str;
        
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            

            str = dateTimePicker4.Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Э")
            {
                Name_company.Text = "Эмиссионный договор";
            }
            if (comboBox1.SelectedItem.ToString() == "Ц")
            {
                Name_company.Text = "Договор об оказании услуг депоненту";
            }
            if (comboBox1.SelectedItem.ToString() == "ЭГ")
            {
                Name_company.Text = "Договор на оказание услуг на использования сервиса `Электронное голосование`";
            }
            if (comboBox1.SelectedItem.ToString() == "ИП")
            {
                Name_company.Text = "Договор о корреспондентских отношениях с Инвестиционным Посредником";
            }
            if (comboBox1.SelectedItem.ToString() == "Х")
            {
                Name_company.Text = "Договор об обслуживании хокимията";
            }
            if (comboBox1.SelectedItem.ToString() == "ОЦ")
            {
                Name_company.Text = "Договор на оказание услуг по проведению оценки с АО";
            }
            if (comboBox1.SelectedItem.ToString() == "ИК")
            {
                Name_company.Text = "Корпоративное сопровождение АО";
            }
            if (comboBox1.SelectedItem.ToString() == "К")
            {
                Name_company.Text = "Договор на оказание консультативных услуг с АО";
            }
            if (comboBox1.SelectedItem.ToString() == "ИУ")
            {
                Name_company.Text = "Информационные услуги согласно договору";
            }
            if (comboBox1.SelectedItem.ToString() == "WS")
            {
                Name_company.Text = "Договор на обслуживание веб-сайта с АО";
            }
            if (comboBox1.SelectedItem.ToString() == "ИФ")
            {
                Name_company.Text = "Трехсторонний Контракт на оказание услуг по ведению счета депо ИФ";
            }
            if (comboBox1.SelectedItem.ToString() == "КО")
            {
                Name_company.Text = "Дополнительное соглашение к договору";
            }
            else
            {
                Name_company.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox1.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker5.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
