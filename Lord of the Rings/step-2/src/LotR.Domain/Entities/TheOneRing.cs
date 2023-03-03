using LotR.Domain.Entities.Characters.Base;

namespace LotR.Domain.Entities;

public class TheOneRing
{
    private static TheOneRing? _instance;

    private TheOneRing()
    {
    }

    public static TheOneRing GetInstance()
    {
        if (_instance is null)
        {
            _instance = new TheOneRing();
        }
        return _instance;
    }
    public CharacterThatCanTakeTheOneRing? Owner { get; private set; }

    public void SetOwner(CharacterThatCanTakeTheOneRing newOwner)
    {
        Owner?.RemoveTheOneRing();
        newOwner.GiveTheOneRing(this);
        Owner = newOwner;
    }
}
