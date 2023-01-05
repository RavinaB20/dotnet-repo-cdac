using System.Collections.Generic;
using Warehouse;
using RCollection;

Player p1 = new Player("Sachin", 230, 40, 45);
Player p2 = new Player("MsDhoni", 500, 34, 36);
Player p3 = new Player("Virat", 450, 67, 32);
Player p4 = new Player("Rohit", 270, 35, 31);

List<Player> indianPlayer = new List<Player>();
indianPlayer.Add(p1);
indianPlayer.Add(p2);
indianPlayer.Add(p3);
indianPlayer.Add(p4);

indianPlayer.Sort();

foreach(Player p in indianPlayer){
    Console.WriteLine("Name : "+p.name+" Runs : "+p.runs);
}

/*
List<Employee> allEmps = new List<Employee>();
allEmps.Add(new Employee(101,"Ravina", 340000));
allEmps.Add(new Employee(95,"prav", 56000));
allEmps.Add(new Employee(200,"Srishti", 23000));
allEmps.Add(new Employee(67,"Pooja", 54500));
allEmps.Add(new Employee(145,"Niharika", 76000));

Console.WriteLine("Showing all Employees : ");
foreach(Employee emp in allEmps){
    Console.WriteLine(emp);
}
EmpComparer ec = new EmpComparer();
allEmps.Sort(ec);

Console.WriteLine("\nShowing all Employees after sort : ");
foreach(Employee emp in allEmps){
    Console.WriteLine(emp);
}
*/
/*
List<Part> allParts = new List<Part>();
allParts.Add(new Part(){PartName="door", PartId=123});
allParts.Add(new Part(){PartName="wheels", PartId=345});
allParts.Add(new Part(){PartName="bush", PartId=1345});
allParts.Add(new Part(){PartName="tyre", PartId=6453});
allParts.Add(new Part(){PartName="disk", PartId=1343});

Console.WriteLine("Showing all parts : ");
foreach(Part part in allParts){
    Console.WriteLine(part);
}

Console.WriteLine("\nShowing all parts after sorting: ");
foreach(Part part in allParts){
    Console.WriteLine(part);
}

Stack<Part> assembly = new Stack<Part>();
assembly.Push(new Part(){PartName="door", PartId=1211});
assembly.Push(new Part(){PartName="window", PartId=2344});
assembly.Push(new Part(){PartName="curtain", PartId=6554});
assembly.Push(new Part(){PartName="tiles", PartId=4544});

Console.WriteLine("Display all stack values : ");
foreach(Part part in assembly){
    Console.WriteLine(part);
}

assembly.Pop();
Console.WriteLine("Display all stack values after popping 1 value : ");
foreach(Part part in assembly){
    Console.WriteLine(part);
}

Console.WriteLine("Showing peek value : "+assembly.Peek());

Queue<Part> tray = new Queue<Part>();
tray.Enqueue(new Part(){PartName="door", PartId=71111});
tray.Enqueue(new Part(){PartName="window", PartId=22222});
tray.Enqueue(new Part(){PartName="curtain", PartId=6554});
tray.Enqueue(new Part(){PartName="tiles", PartId=4544});

Console.WriteLine("\nShowing all queue elements : ");
foreach(Part part in tray){
    Console.WriteLine(part);
}

tray.Dequeue();
Console.WriteLine("\nShowing all queue elements after dequeue : ");
foreach(Part part in tray){
    Console.WriteLine(part);
}

Dictionary<string, Part> todaysAllPart = new Dictionary<string, Part>();
todaysAllPart.Add("main",new Part(){PartName="door", PartId=23455});
todaysAllPart.Add("top",new Part(){PartName="window", PartId=76543});
todaysAllPart.Add("bottom",new Part(){PartName="tap", PartId=23456});
todaysAllPart.Add("center",new Part(){PartName="table", PartId=43433});

Part thePart = todaysAllPart["main"];
Console.WriteLine("Showing dictionary main part : "+thePart);
*/

