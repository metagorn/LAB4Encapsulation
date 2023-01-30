using System.Drawing.Text;

namespace LAB4Encapsulation
{
    public partial class Form1 : Form
    {
        Classroom classroom;

        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input_name = this.tbname.Text;
            string input_bYear = this.tbyear.Text;
            string input_gpa = this.tbGPA.Text;
            int bYear = Int32.Parse(input_bYear);
            double bGPA = double.Parse(input_gpa);
            Person person = new Person(input_name, bYear, bGPA);
            //this.tbListofPerson.Text += person.getName() + "\r\n";
            //int currentAge = Int32.Parse(this.tbTotal.Text);
            //int newTotalAge = currentAge + person.getAge();
            //this.tbTotal.Text = newTotalAge.ToString();

            this.classroom.addPerson2Class(person);
            this.tbListofPerson.Text =
                classroom.showAllPersoninClass();
            tbTotal.Text =
                classroom.AllageClass();
            tbGPavg.Text =
                classroom.GPavg();
            tbGPmax.Text =
                classroom.GPmax();
            tbGPmin.Text =
                classroom.GPmin();
            tbNamemax.Text =
                classroom.GPANamemax();
            tbNamemin.Text =
                classroom.GPANamemin();

        }

    }
}