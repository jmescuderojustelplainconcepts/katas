using LotR.Domain.Entities;
using LotR.Domain.Enums;

namespace LotR.Application.Test.Builders;

internal static class CharacterBuilder
{
    public static Character BuildElf(string name)
    {
        return new Character(name, Race.Elf);
    }

    public static Character BuildHobbit(string name)
    {
        return new Character(name, Race.Hobbit);
    }

    public static Character BuildHuman(string name)
    {
        return new Character(name, Race.Human);
    }

    public static Character BuildOrc()
    {
        return new Character(null, Race.Orc);
    }

    public static Character BuildTroll()
    {
        return new Character(null, Race.Troll);
    }

    public static Character WithTheOneRing(this Character character)
    {
        var theOneRing = new TheOneRing();
        theOneRing.SetOwner(character);
        return character;
    }
}
