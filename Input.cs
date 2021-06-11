using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_15
{
    public partial class InputKeyForm : Form
    {
        public InputKeyForm()
        {
            InitializeComponent();//инициализирует все компоненты
        }

        public int Key
        {
            get
            {
                return int.Parse(textBox1.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)//ключ
        {

        }

        private void InputKeyForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)//окей
        {
            int result = 0;
            if (int.TryParse(textBox1.Text, out result))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Ключ должен быть целым числом. Повторите ввод.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnCancel_Click(object sender, EventArgs e)//отмена
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox1.Text, out result))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Ключ должен быть целым числом. Повторите ввод.", "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
