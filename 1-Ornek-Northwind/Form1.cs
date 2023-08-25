using _1_Ornek_Northwind.AppDbContext;
using _1_Ornek_Northwind.Models;

namespace _1_Ornek_Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbContext=new NorthwindContext();
        }
        NorthwindContext dbContext;
        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> employees = dbContext.Employees.ToList();
            lBoxCalisanGetir.Items.Clear();
            foreach (Employee employee in employees)
            {
                lBoxCalisanGetir.Items.Add($"{employee.EmployeeId} {employee.FirstName} {employee.LastName}");
            }
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sefa";
            employee.LastName = "Attila";

            dbContext.Employees.Add(employee); //ekledim ama yazmadım rame ekledim
            dbContext.SaveChanges(); //burda database ye yansıtıyorum
        }
    }
}