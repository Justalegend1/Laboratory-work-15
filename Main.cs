using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Laboratory_work_15
{
    public partial class MainForm :Form
    {
        string fileName = "Temperature.bin";
        public MainForm()
        {
            InitializeComponent();
            LoadFromFile();
        }

        private void LoadFromFile()
        {
            try
            {
                listBox1.Items.Clear();

                FileStream f2 = new FileStream(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();

                while (f2.Position < f2.Length)
                {
                    AverageTemp d = (AverageTemp)bf.Deserialize(f2); // восстановление объекта
                    if (!d.Deleted)
                        listBox1.Items.Add(d);
                }
                f2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при открытии файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteFromFileByIndex(int indexForDelete)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            int count = 0;
            int index = 0;
            int deletedCount = 0;
            while (stream.Position < stream.Length)
            {
                long startPosition = stream.Position;
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    deletedCount++;
                else
                {
                    if (index == indexForDelete)
                    {
                        obj.Deleted = true;
                        stream.Position = startPosition;
                        bf.Serialize(stream, obj); // сохранение объекта  в потоке f
                        deletedCount++;
                    }
                    index++;
                }

                count++;
            }

            if (deletedCount > count / 2)
            {
                FileStream temp = new FileStream("Temp.bin", FileMode.Create);
                stream.Position = 0;

                while (stream.Position < stream.Length)
                {
                    AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                    if (!obj.Deleted)
                        bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                }
                temp.Close();
                stream.Close();

                File.Delete(fileName);
                File.Move("Temp.bin", fileName);
                File.Delete("Temp.bin");
            }

            stream.Close();
        }
        private void DeleteFromFileByKey(int key)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            int count = 0;
            int index = 0;
            int deletedCount = 0;
            while (stream.Position < stream.Length)
            {
                long startPosition = stream.Position;
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    deletedCount++;
                else
                {
                    if (obj.NumDay == key)
                    {
                        obj.Deleted = true;
                        stream.Position = startPosition;
                        bf.Serialize(stream, obj); // сохранение объекта  в потоке f
                        deletedCount++;
                    }
                    index++;
                }

                count++;
            }

            if (deletedCount > count / 2)
            {
                FileStream temp = new FileStream("Temp.bin", FileMode.Create);
                stream.Position = 0;

                while (stream.Position < stream.Length)
                {
                    AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                    if (!obj.Deleted)
                        bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                }
                temp.Close();
                stream.Close();

                File.Delete(fileName);
                File.Move("Temp.bin", fileName);
                File.Delete("Temp.bin");
            }
            else
                MessageBox.Show("Запись с указанным ключом не найдена.", "Редактирование по ключу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            stream.Close();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void EditByIndex(int index)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            AverageTemp obj = null;
            int count = 0;
            long position = 0;

            while (stream.Position < stream.Length)
            {
                position = stream.Position;
                obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (listBox1.SelectedIndex == count)
                    break;

                count++;
            }

            EditForm editForm = new EditForm(obj);

            DialogResult dr = editForm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                stream.Position = position;
                bf.Serialize(stream, editForm.AverageTemp); // сохранение объекта  в потоке
                listBox1.Items[index] = editForm.AverageTemp;
            }
            stream.Close();
        }
        private void EditByKey(int key)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            AverageTemp obj = null;
            int index = 0;
            long position = 0;

            while (stream.Position < stream.Length)
            {

                position = stream.Position;
                obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (obj.Deleted)
                    continue;

                if (obj.NumDay == key)
                    break;

                index++;
            }

            if (index < listBox1.Items.Count)
            {
                EditForm editForm = new EditForm(obj);

                DialogResult dr = editForm.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    stream.Position = position;
                    bf.Serialize(stream, editForm.AverageTemp); // сохранение объекта  в потоке
                    listBox1.Items[index] = editForm.AverageTemp;
                }
            }
            else
                MessageBox.Show("Запись с указанным ключом не найдена.", "Редактирование по ключу", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            stream.Close();
        }
        private void AveragetemperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double average = GetAverageTemperature();

            MessageBox.Show(string.Format("Средняя температура: {0:0.00}", average));
        }
        private double GetAverageTemperature()
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            double average = 0, sum = 0;
            int count = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp d = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                sum = sum + d.Temperature;
                count++;
            }
            stream.Close();

            if (count != 0)
                average = sum / count;
            return average;
        }
        private void FindDaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int distance = GetDistance();

            MessageBox.Show(string.Format("Отрезок: {0:0 day}", distance));
        }
        private int GetDistance()
        {
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            int startDay = -1, finishDay = -1, count = 0;

            while (stream.Position < stream.Length)
            {
                AverageTemp readData = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (readData.Temperature < 0)
                {
                    if (startDay == -1)
                        startDay = count;

                    if (count >= startDay)
                        finishDay = count;
                }
                count++;
            }
            stream.Close();

            int distance = 0;
            if (finishDay > startDay)
                distance = finishDay - startDay - 1;
            return distance;
        }
        private void AddToEndOfFile(AverageTemp averageTemp)
        {
            FileStream f1 = new FileStream(fileName, FileMode.OpenOrCreate);
            f1.Position = f1.Length;
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f1, averageTemp); // сохранение объекта  в потоке f
            f1.Close();
        }
        private void JoinEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(editForm.AverageTemp);
                AddToEndOfFile(editForm.AverageTemp);
            }
        }
        private void AddToBeginOfFile(AverageTemp averageTemp)// Добавление в начало
        {
            FileStream temp = new FileStream("Temp.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(temp, averageTemp);

            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            stream.Position = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта
                if (!obj.Deleted)
                    bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
            }
            stream.Close();
            temp.Close();

            File.Delete(fileName);
            File.Move("Temp.bin", fileName);
            File.Delete("Temp.bin");

        }
        private void JoinBeginningToolStripMenuItem_Click(object sender, EventArgs e)//Добавить в начало
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(0, editForm.AverageTemp);
                AddToBeginOfFile(editForm.AverageTemp);
            }
        }
        private void AddToFileByIndex(AverageTemp averageTemp, int index)// Добавление в заданную позицию
        {
            FileStream temp = new FileStream("Temp.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();



            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate);
            stream.Position = 0;
            int count = 0;
            while (stream.Position < stream.Length)
            {
                AverageTemp obj = (AverageTemp)bf.Deserialize(stream); // восстановление объекта

                if (count == index - 1)
                    bf.Serialize(temp, averageTemp);

                if (!obj.Deleted)
                {
                    bf.Serialize(temp, obj); // сохранение объекта  в потоке f 
                    count++;
                }

            }
            stream.Close();
            temp.Close();

            File.Delete(fileName);
            File.Move("Temp.bin", fileName);
            File.Delete("Temp.bin");
        }
        private void JoinBeforeCurrentToolStripMenuItem_Click(object sender, EventArgs e)//Добавить перед текущим
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать элемент в списке.");
                return;
            }

            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, editForm.AverageTemp);
                AddToFileByIndex(editForm.AverageTemp, listBox1.SelectedIndex);
            }
        }
        private void DeletItToolStripMenuItem1_Click(object sender, EventArgs e)//Удаление выбранного
        {
            if (listBox1.SelectedIndex < 0)
                return;

            DeleteFromFileByIndex(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void DeleteKeyToolStripMenuItem1_Click(object sender, EventArgs e)//Удаление по ключу
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                DeleteFromFileByKey(editForm.Key);
                LoadFromFile();
            }
        }
        private void JoinItToolStripMenuItem_Click(object sender, EventArgs e)//Добавить 
        {
            if (listBox1.SelectedIndex < 0)
                return;
            EditByIndex(listBox1.SelectedIndex);
        }
        private void ChangeKeyToolStripMenuItem_Click(object sender, EventArgs e)//изменить по ключу
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                EditByKey(editForm.Key);
                LoadFromFile();
            }
        }
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)//открыть файл
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "bin";
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.FileName = fileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }
        private void CreateFileToolStripMenuItem_Click(object sender, EventArgs e)//Создать файл
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = fileName;
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.CheckFileExists = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }
        private void EditToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            bool isNotListEmpty = listBox1.Items.Count != 0;
            ChangeToolStripMenuItem.Enabled = isNotListEmpty;
            DeleteToolStripMenuItem.Enabled = isNotListEmpty;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void OperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void JoinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "bin";
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.FileName = fileName;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }

        private void CreateFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = fileName;
            openFileDialog.Filter = "*.bin|*.bin";
            openFileDialog.CheckFileExists = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                LoadFromFile();
            }
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JoinBeginningToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(0, editForm.AverageTemp);
                AddToBeginOfFile(editForm.AverageTemp);
            }
        }

        private void JoinBeforeCurrentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Необходимо выбрать элемент в списке.");
                return;
            }

            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, editForm.AverageTemp);
                AddToFileByIndex(editForm.AverageTemp, listBox1.SelectedIndex);
            }
        }

        private void JoinEndToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(editForm.AverageTemp);
                AddToEndOfFile(editForm.AverageTemp);
            }
        }

        private void ChangeKeyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                EditByKey(editForm.Key);
                LoadFromFile();
            }
        }

        private void JoinItToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            EditByIndex(listBox1.SelectedIndex);
        }

        private void DeleteKeyToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            InputKeyForm editForm = new InputKeyForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                DeleteFromFileByKey(editForm.Key);
                LoadFromFile();
            }
        }

        private void DeletItToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;

            DeleteFromFileByIndex(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void AverageTemperatureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double average = GetAverageTemperature();

            MessageBox.Show(string.Format("Средняя температура: {0:0.00}", average));
        }

        private void FindDaysToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int distance = GetDistance();

            MessageBox.Show(string.Format("Отрезок: {0:0 day}", distance));
        }
    }
}
