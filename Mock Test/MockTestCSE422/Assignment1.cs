
class Employee
{

    private string _employeeName;
    private int _age;
    private double _salary;

    public Employee() {}

    public Employee(string employeeName, int age, double salary)
    {
        _employeeName = employeeName;
        _age = age;
        _salary = salary;
    }

    public string EmployeeName {
        get { return this._employeeName; }
        set { this._employeeName = value; }
    }

    public int Age
    {
        get { return this._age; }
        set { this._age = value; }
    }

    public double Salary
    {
        get { return this._salary; }
        set { this._salary = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Employee: " + _employeeName + ", Age: " + _age + ", Salary: $" + _salary);
    }
}
