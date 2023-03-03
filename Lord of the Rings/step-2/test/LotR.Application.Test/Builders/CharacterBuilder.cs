using LotR.Domain.Entities;
using LotR.Domain.Entities.Characters;
using LotR.Domain.Entities.Characters.Base;
using LotR.Domain.Enums;

namespace LotR.Application.Test.Builders;

internal static class CharacterBuilder
{
    public static Elf BuildElf(string name)
    {
        return new Elf(name);
    }

    public static Hobbit BuildHobbit(string name)
    {
        return new Hobbit(name);
    }

    public static Human BuildHuman(string name)
    {
        return new Human(name);
    }

    public static Dwarf BuildDwarf(string name)
    {
        return new Dwarf(name);
    }

    public static Orc BuildOrc()
    {
        return new Orc();
    }

    public static Troll BuildTroll()
    {
        return new Troll();
    }

    public static CharacterThatCanTakeTheOneRing WithTheOneRing(this CharacterThatCanTakeTheOneRing character)
    {
        var theOneRing = TheOneRing.GetInstance();
        theOneRing.SetOwner(character);
        return character;
    }
}
