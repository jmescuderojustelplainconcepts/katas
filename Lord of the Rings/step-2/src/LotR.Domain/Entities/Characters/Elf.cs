using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters;

public class Elf : Character
{
    public string Name { get; private set; }

    public override Alignment Alignment => Alignment.Good;

    public override int BaseStrength => 20;

    public Elf(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Elfs need names");
        }

        Name = name;
    }

    public override int GetStrength()
    {
        return BaseStrength;
    }
}
