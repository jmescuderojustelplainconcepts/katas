using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters;

public class Human : CharacterThatCanTakeTheOneRing
{
    public string Name { get; private set; }
    public override Alignment Alignment => Alignment.Good;
    public override int BaseStrength => 10;
    public override int TheOneRingMultiplier => 4;

    public Human(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Humans need names");
        }

        Name = name;
    }

    public override int GetStrength()
    {
        return BaseStrength * (HasTheOneRing ? TheOneRingMultiplier : 1);
    }
}
