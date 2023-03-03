using LotR.Domain.Contracts;
using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters;

public class Dwarf : Character, IGood
{
    public string Name { get; private set; }

    public override Alignment Alignment => Alignment.Good;

    public override int BaseStrength => 20;

    public Dwarf(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Dwarfs need names");
        }

        Name = name;
    }

    public override int GetStrength()
    {
        return BaseStrength;
    }
}
