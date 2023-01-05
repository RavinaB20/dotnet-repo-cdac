namespace Warehouse;

public class Part
{
    public string PartName { get; set; }
    public int PartId { get; set; }

    public override string ToString()
    {
        return "Partname : " + PartName + " Part id : " + PartId;
    }
}