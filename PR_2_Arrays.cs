using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PR_2_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1. Сумма элементов массива
        private void btnTask1Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtTask1Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 10)
                {
                    MessageBox.Show("введите ровно 10 чисел", "ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = int.Parse(parts[i]);
                }

                int sum = 0;
                foreach (int num in array)
                {
                    sum += num;
                }

                lblTask1Result.Text = $"Массив: [{string.Join(", ", array)}]\nСумма элементов: {sum}";
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректные целые числа!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //2. Поиск максимума и минимума
        private void btnTask2Generate_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtTask2Size.Text);

                if (n <= 0)
                {
                    MessageBox.Show("размер массива должен быть положительным числом", "ошибка",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Random rand = new Random();
                int[] array = new int[n];

                for (int i = 0; i < n; i++)
                {
                    array[i] = rand.Next(1, 101);
                }

                int max = array[0];
                int min = array[0];
                int maxIndex = 0;
                int minIndex = 0;

                for (int i = 1; i < n; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        maxIndex = i;
                    }
                    if (array[i] < min)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }

                lblTask2Array.Text = $"Массив: [{string.Join(", ", array)}]";
                lblTask2Result.Text = $"Максимум: {max} (индекс {maxIndex})\nМинимум: {min} (индекс {minIndex})";
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректное целое число", "ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Подсчет четных и нечетных 
        private void btnTask3Calculate_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int[] array = new int[15];

            for (int i = 0; i < 15; i++)
            {
                array[i] = rand.Next(10, 51);
            }

            int evenCount = 0;
            int oddCount = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            lblTask3Array.Text = $"Массив: [{string.Join(", ", array)}]";
            lblTask3Result.Text = $"Четных чисел: {evenCount}\nНечетных чисел: {oddCount}";
        }

        //4. Реверс массива
        private void btnTask4Reverse_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtTask4Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 5)
                { MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] original = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    original[i] = int.Parse(parts[i]);
                }

                // массив с обратным порядком
                int[] reversed = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    reversed[i] = original[4 - i];
                }

                // изменение текущего массива 
                int[] inPlace = (int[])original.Clone();
                int left = 0;
                int right = inPlace.Length - 1;
                while (left < right)
                {
                    int temp = inPlace[left];
                    inPlace[left] = inPlace[right];
                    inPlace[right] = temp;
                    left++;
                    right--;
                }

                lblTask4Result.Text = $"Исходный массив: [{string.Join(", ", original)}]\n" +
                                     $"Реверс (новый массив): [{string.Join(", ", reversed)}]\n" +
                                     $"Реверс (in-place): [{string.Join(", ", inPlace)}]";
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректные целые числа", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5. Сдвиг элементов вправо
        private void btnTask5Shift_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtTask5Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 0)
                {
                    MessageBox.Show("введите хотя бы одно число", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] array = new int[parts.Length];
                for (int i = 0; i < parts.Length; i++)
                {
                    array[i] = int.Parse(parts[i]);
                }

                // циклический сдвиг вправо на одну позицию
                if (array.Length > 1)
                {
                    int lastElement = array[array.Length - 1];
                    for (int i = array.Length - 1; i > 0; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[0] = lastElement;
                }

                lblTask5Result.Text = $"Результат: [{string.Join(", ", array)}]";
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректные целые числа", "ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //6. Подсчет дубликатов
        private void btnTask6Count_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = txtTask6Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 10)
                {
                    MessageBox.Show("введите ровно 10 чисел", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int[] array = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    array[i] = int.Parse(parts[i]);
                }
                bool[] counted = new bool[10];
                for (int i = 0; i < 10; i++)
                {
                    counted[i] = false;
                }

                List<string> results = new List<string>();

                for (int i = 0; i < 10; i++)
                {
                    // если уже подсчитывали это число, пропускаем
                    if (counted[i])
                        continue;

                    int count = 1;
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (array[j] == array[i])
                        {
                            count++;
                            counted[j] = true; 
                        }
                    }

                    counted[i] = true;
                    results.Add($"Число {array[i]} встречается {count} раз");
                }

                lblTask6Result.Text = string.Join("\n", results);
            }
            catch (FormatException)
            {
                MessageBox.Show("введите корректные целые числа", "ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
