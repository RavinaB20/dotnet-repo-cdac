namespace BOL;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class Student{

    [Required]
    public int Rollno{ get; set;}

    public string Name{ get; set;}

    public string Course{ get; set;}

    public int Contactno { get; set; }
    public Student():this(101, "Ravina","PGDAC", 12345){
    }

    public Student(int rollno, string name, string course, int contactno){
        this.Rollno = rollno;
        this.Name = name;
        this.Course = course;
        this.Contactno=contactno;
    }

}