namespace RCollection;

public class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(){
        this.Id = 1;
        this.Name = "Ravina";
        this.Salary = 980000;
    }

    public Employee(int id,string name, double salary){
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return "Id = "+Id+ " Name = "+Name+ " Salary = "+Salary;
    }

/*
    public bool Equals(Employee newEmp)
    {
        if(this.Id > newEmp.Id)
            return 1;
        else if(this.Id < newEmp.Id)
            return -1;
        else 
            return 0;
    }
    */

}