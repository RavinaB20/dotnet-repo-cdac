using System.Collections.Generic;

List<Object> allObjects = new List<Object>();
allObjects.Add(12);
allObjects.Add(true);
allObjects.Add(new { id=15, title="abc"});
allObjects.Add(new { id=2, title="def"});
allObjects.Add(new { id=12, title="hij"});
allObjects.Add(new { id=6, title="klm"});
allObjects.Add(new { id=9, title="nopsds"});

foreach(object o in allObjects){
    Console.WriteLine(o);
}