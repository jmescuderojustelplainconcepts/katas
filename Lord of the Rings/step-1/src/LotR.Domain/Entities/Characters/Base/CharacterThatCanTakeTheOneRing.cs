namespace LotR.Domain.Entities.Characters.Base;

public abstract class CharacterThatCanTakeTheOneRing : Character
{
    public TheOneRing? TheOneRing { get; private set; }
    public bool HasTheOneRing => TheOneRing is not null;
    public abstract int TheOneRingMultiplier { get; }

    public void GiveTheOneRing(TheOneRing theOneRing)
    {
        TheOneRing = theOneRing;
    }

    public void RemoveTheOneRing()
    {
        TheOneRing = null;
    }
}
