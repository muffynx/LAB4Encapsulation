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
        List<double> listOfGPAs = new List<double>();
        List<double> listOfValues = new List<double>();


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input_name = this.tbName.Text;
            string input_year = this.tbBirthYear.Text;
            int iYear = Int32.Parse(input_year);
            double input_gpa = double.Parse(this.tbGPA.Text);

            Person person = new Person(input_name, iYear, input_gpa);
            this.classroom.addPerson2Class(person);
            tbListofPerson.Text = classroom.showAllPersoninClass();


            //display total age of class
            this.tbTotal.Text = "";

            String input = this.tbGPA.Text;
            double gradeValue = double.Parse(input);
            listOfGPAs.Add(gradeValue);


            double highest = listOfGPAs.Max();
            double lowest = listOfGPAs.Min();

            min.Text = lowest.ToString();
            max.Text = highest.ToString();


            listOfValues.Add(gradeValue);


            double sum = listOfValues.Sum();
            double avg = sum / listOfValues.Count;

            tbAVG.Text = avg.ToString();





        }

        private void tbListofPerson_TextChanged(object sender, EventArgs e)
        {

        }
    }
}