using System.Collections.Generic;
using Warehouse;

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


