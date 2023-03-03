using LotR.Domain.Entities.Characters.Base;

namespace LotR.Domain.Entities;

public class TheOneRing
{
    public CharacterThatCanTakeTheOneRing? Owner { get; private set; }

    public void SetOwner(CharacterThatCanTakeTheOneRing newOwner)
    {
        Owner?.RemoveTheOneRing();
        newOwner.GiveTheOneRing(this);
        Owner = newOwner;
    }
}
