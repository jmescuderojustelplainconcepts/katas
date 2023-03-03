using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters;

public class Troll : Character
{
    public override Alignment Alignment => Alignment.Bad;
    public override int BaseStrength => 8;
    public override int GetStrength()
    {
        return BaseStrength;
    }
}
