using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Student s1 = new Student{ Rollno=102, Name="kishori", Course="PGDBDA", Contactno=98765 };
Student s2 = new Student{ Rollno=103, Name="swati", Course="PGDITISS", Contactno=93465 };
Student s3 = new Student{ Rollno=104, Name="sameer", Course="PGDAC", Contactno=45765 };
Student s4 = new Student{ Rollno=105, Name="pravin", Course="PGDAC", Contactno=87765 };

List<Student> students = new List<Student>();

students.Add(s1);
students.Add(s2);
students.Add(s3);
students.Add(s4);

try{
    bool exit=false;
    string fileName=@"D:\DotNet\Day5\FileOperations\studentfile.json";
    do{
        Console.WriteLine("\n********MENU*********");
        Console.WriteLine("1. Store in file");
        Console.WriteLine("2. Retrive from file");
        Console.WriteLine("3. Exit");
        Console.WriteLine("Enter your choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice){
            case 1:
                var options = new JsonSerializerOptions();
                var studentJson = JsonSerializer.Serialize<List<Student>>(students,options);
                File.WriteAllText(fileName,studentJson);
                break;
            case 2:
                string jsonString = File.ReadAllText(fileName);
                List<Student> jsonStudent = JsonSerializer.Deserialize<List<Student>>(jsonString);
                Console.WriteLine("\n Data from JSON file : ");
                foreach(Student stud in jsonStudent){
                    Console.WriteLine($"{stud.Rollno} : {stud.Name}");
                }
                break;
            case 3:
                exit=true;
                break;
            default:
                Console.WriteLine("Plz enter correct choice ..");
                break;
        }
    }while(exit != true);
        

}
catch(Exception ex){

}
finally{
    
}