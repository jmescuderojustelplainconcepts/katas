namespace LotR.Domain.Entities;

public class TheOneRing
{
    public Character? Owner { get; private set; }

    public void SetOwner(Character newOwner)
    {
        Owner?.RemoveTheOneRing();
        newOwner.GiveTheOneRing(this);
        Owner = newOwner;
    }
}
