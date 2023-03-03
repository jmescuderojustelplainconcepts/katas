using LotR.Domain.Contracts;
using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters;

public class Hobbit : CharacterThatCanTakeTheOneRing, IGood
{
    public string Name { get; private set; }
    public override Alignment Alignment => Alignment.Good;
    public override int BaseStrength => 5;
    public override int TheOneRingMultiplier => 10;

    public Hobbit(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Hobbits need names");
        }

        Name = name;
    }

    public override int GetStrength()
    {
        return BaseStrength * (HasTheOneRing ? TheOneRingMultiplier : 1);
    }
}
