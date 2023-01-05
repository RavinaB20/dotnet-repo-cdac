namespace Warehouse;

public class Part: IComparable
{
    public string PartName { get; set; }
    public int PartId { get; set; }

    public override string ToString()
    {
        return "Partname : " + PartName + " Part id : " + PartId;
    }

    public int Equals(Part newPart)
    {
        if(this.PartId > newPart.PartId)
            return 1;
        else if(this.PartId < newPart.PartId)
            return -1;
        else return 0;

    }

}
