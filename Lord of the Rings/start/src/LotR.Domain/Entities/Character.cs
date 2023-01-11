using LotR.Domain.Enums;

namespace LotR.Domain.Entities;

public class Character
{
    public string? Name { get; private set; }
    public Race Race { get; private set; }
    public Alignment Alignment { get; private set; }
    public TheOneRing? TheOneRing { get; private set; }

    public Character(string? name, Race race)
    {
        if (race is Race.Orc or Race.Troll && !string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Trolls and Orcs do not have names");
        }
        if (race is Race.Elf or Race.Human or Race.Hobbit && string.IsNullOrEmpty(name))
        {
            throw new InvalidOperationException("Elfs, Humans and Hobbits need names");
        }
        Name = name;
        Race = race;
        Alignment = race is Race.Elf or Race.Human or Race.Hobbit ? Alignment.Good : Alignment.Bad;
    }

    public int GetStrength()
    {
        switch (Race)
        {
            case Race.Elf:
                return 20;
            case Race.Human:
                var baseHumanStrength = 10;
                if (TheOneRing is not null)
                {
                    return baseHumanStrength * 4;
                }
                return baseHumanStrength;

            case Race.Hobbit:
                var baseHobbitStrength = 5;
                if (TheOneRing is not null)
                {
                    return baseHobbitStrength * 10;
                }
                return baseHobbitStrength;

            case Race.Orc:
                return 10;

            case Race.Troll:
                return 8;

            default:
                throw new InvalidDataException(nameof(Race));
        }
    }

    public void GiveTheOneRing(TheOneRing theOneRing)
    {
        if (Race is Race.Orc or Race.Troll)
        {
            throw new InvalidOperationException("Trolls and Orcs are too silly to have The One Ring");
        }

        if (TheOneRing is not null)
        {
            throw new InvalidOperationException("Characters can only have one The One Ring");
        }

        TheOneRing = theOneRing;
    }

    public void RemoveTheOneRing()
    {
        TheOneRing = null;
    }
}