using System.Collections.Generic;
using Warehouse;

List<Part> allParts = new List<Part>();
allParts.Add(new Part(){PartName="door", PartId=123});
allParts.Add(new Part(){PartName="wheels", PartId=345});
allParts.Add(new Part(){PartName="bush", PartId=1345});
allParts.Add(new Part(){PartName="tyre", PartId=6453});
allParts.Add(new Part(){PartName="disk", PartId=1343});

foreach(Part part in allParts){
    Console.WriteLine(part);
}
