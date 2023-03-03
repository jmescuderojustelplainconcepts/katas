using LotR.Domain.Enums;

namespace LotR.Domain.Entities.Characters.Base;

public abstract class Character
{
    public abstract Alignment Alignment { get; }
    public abstract int BaseStrength { get; }

    public abstract int GetStrength();    
}