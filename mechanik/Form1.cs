namespace mechanik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;
            Console.WriteLine(number);

            int count = 0;
            count++;
            count--;

            string result = "cześć";
            result += "i znowu wietnam";
            output.Text = result;
            result = "wartość wynosi: " + count;
            result = "";

            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
