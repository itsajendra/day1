internal class Program
{
    public interface GovtRules
    {
        public double EmployeePF();
        public string LeaveDetails();
        public double gratuityAmount();
    }
    public class TCS : GovtRules
    {
        long empid;
        string name;
        string dept;
        string desg;
        double basicSalary;
        float numServiceYear;
        public TCS(long empid, string name, string dept, string desg, double basicSalary, float numServiceYear)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.numServiceYear = numServiceYear;
        }
        public double EmployeePF()
        {
            return (0.12+0.0833+0.0367)*basicSalary;
        }
        public string LeaveDetails()
        {
            return "12:Casual_Leave 12:Sick_Leave 10:Previlage_Leave";
        }
        public double gratuityAmount()
        {
            if(numServiceYear>20)
            {
                return 3*basicSalary;
            }
            else if(numServiceYear>10)
            {
                return 2*basicSalary;
            }
            else if(numServiceYear>5)
            {
                return basicSalary;
            }
            else return 0;
        }
        public void printdata()
        {
            Console.WriteLine($"{empid} {name} {dept} {desg} {basicSalary} {numServiceYear}");
            Console.WriteLine($"{EmployeePF()} {LeaveDetails()} {gratuityAmount()}");
        }
    }
    public class WellsFargo : GovtRules
    {
        long empid;
        string name;
        string dept;
        string desg;
        double basicSalary;
        float numServiceYear;
        public WellsFargo(long empid, string name, string dept, string desg, double basicSalary, float numServiceYear)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.numServiceYear = numServiceYear;
        }
        public double EmployeePF()
        {
            return (0.12+0.12)*basicSalary;
        }
        public string LeaveDetails()
        {
            return "24:Casual_Leave 5:Sick_Leave 5:Previlage_Leave";
        }
        public double gratuityAmount()
        {
            return 0;
        }
        public void printdata()
        {
            Console.WriteLine($"{empid} {name} {dept} {desg} {basicSalary} {numServiceYear}");
            Console.WriteLine($"{EmployeePF()} {LeaveDetails()} {gratuityAmount()}");
        }
    }
    private static void Main(string[] args)
    {
        TCS tcsEmployee =new TCS(123,"Shubham","CSE","Analyst",1750000,4);
        WellsFargo wfEmployee = new WellsFargo(321,"Atul","EEE","SDE",1150000,8);
        tcsEmployee.printdata();
        wfEmployee.printdata();
    }
}