using static WinHomeTaskPattern3.Class1;

namespace WinHomeTaskPattern3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            computerCollection = new ComputerCollection();
        }
        private ComputerCollection computerCollection = new ComputerCollection();

        private void button1_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer
            {
                Model = textBox1.Text,
                Processor = textBox2.Text,
            };

            if (int.TryParse(textBox3.Text, out int memoryGB) && int.TryParse(textBox4.Text, out int storageGB))
            {
                computer.MemoryGB = memoryGB;
                computer.StorageGB = storageGB;
            }
            else
            {
                MessageBox.Show("Помилка: Введені дані для пам'яті та зберігання повинні бути цілими числами.");
                ClearInputFields();
                return;
            }

            computer.GraphicsCard = textBox5.Text;

            computerCollection.AddComputer(computer);
            ClearInputFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IComputerIterator iterator = computerCollection.CreateIterator();
            string result = "Характеристика:";

            for (Computer computer = iterator.First(); !iterator.IsDone(); computer = iterator.Next())
            {
                result += $"Модель: {computer.Model}, процесор: {computer.Processor}, оперативна пам'ять: {computer.MemoryGB} GB, пам'ять: {computer.StorageGB} GB, відеокарта: {computer.GraphicsCard}\n";
            }

            textBox6.Text = result;
        }

        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}