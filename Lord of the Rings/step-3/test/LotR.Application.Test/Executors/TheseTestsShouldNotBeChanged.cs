using LotR.Application.Executors;
using LotR.Application.Test.Builders;
using LotR.Domain.Contracts;
using LotR.Domain.Entities.Characters;
using LotR.Domain.Entities.Characters.Base;
using Xunit;

namespace LotR.Application.Test.Executors;

public class TheseTestsShouldNotBeChanged
{
    private Hobbit frodo = CharacterBuilder.BuildHobbit("Frodo");
    private Hobbit frodoWithTheOneRing = (Hobbit)CharacterBuilder.BuildHobbit("Frodo").WithTheOneRing();
    private Human aragorn = CharacterBuilder.BuildHuman("Aragorn");
    private Elf legolas = CharacterBuilder.BuildElf("Legolas");
    private Orc orc1 = CharacterBuilder.BuildOrc();
    private Orc orc2 = CharacterBuilder.BuildOrc();
    private Orc orc3 = CharacterBuilder.BuildOrc();
    private Orc orc4 = CharacterBuilder.BuildOrc();
    private Troll troll1 = CharacterBuilder.BuildTroll();
    private Troll troll2 = CharacterBuilder.BuildTroll();
    private Troll troll3 = CharacterBuilder.BuildTroll();

    [Fact]
    public void T01_WhenFrodoHasTheOneRingWverythingIsEasier()
    {
        var army1 = new List<IGood> { frodoWithTheOneRing, aragorn };
        var army2 = new List<IBad> { orc1, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }

    [Fact]
    public void T02_ThingsGetComplicatedWhenFrodoLosesTheOneRing()
    {
        var army1 = new List<IGood> { frodo, aragorn };
        var army2 = new List<IBad> { orc1, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 2);
    }

    [Fact]
    public void T03_ButYouCanAlwaysRelyOnLegolasToFixThings()
    {
        var army1 = new List<IGood> { frodo, aragorn, legolas };
        var army2 = new List<IBad> { orc1, orc2, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }

    [Fact]
    public void T04_AlthoughTHereIsLittleYouCanDoAgainstAllTheBadOnes()
    {
        var army1 = new List<IGood> { frodo, aragorn, legolas };
        var army2 = new List<IBad> { orc1, orc2, orc3, orc4, troll1, troll2, troll3 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 2);
    }

    [Fact]
    public void T06_AndIfDurinAndDwalinComeToHelp()
    {
        var durin = CharacterBuilder.BuildDwarf("Durin");
        var dwalin = CharacterBuilder.BuildDwarf("Dwalin");
        var army1 = new List<IGood> { frodo, aragorn, legolas, durin, dwalin };
        var army2 = new List<IBad> { orc1, orc2, orc3, orc4, troll1, troll2, troll3 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }
}