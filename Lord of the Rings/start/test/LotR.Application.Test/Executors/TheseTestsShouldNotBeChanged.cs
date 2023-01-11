using LotR.Application.Executors;
using LotR.Application.Test.Builders;
using LotR.Domain.Entities;
using Xunit;

namespace LotR.Application.Test.Executors;

public class TheseTestsShouldNotBeChanged
{
    private Character frodo = CharacterBuilder.BuildHobbit("Frodo");
    private Character frodoWithTheOneRing = CharacterBuilder.BuildHobbit("Frodo").WithTheOneRing();
    private Character aragorn = CharacterBuilder.BuildHuman("Aragorn");
    private Character legolas = CharacterBuilder.BuildElf("Legolas");
    private Character orc1 = CharacterBuilder.BuildOrc();
    private Character orc2 = CharacterBuilder.BuildOrc();
    private Character orc3 = CharacterBuilder.BuildOrc();
    private Character orc4 = CharacterBuilder.BuildOrc();
    private Character troll1 = CharacterBuilder.BuildTroll();
    private Character troll2 = CharacterBuilder.BuildTroll();
    private Character troll3 = CharacterBuilder.BuildTroll();

    [Fact]
    public void T01_WhenFrodoHasTheOneRingWverythingIsEasier()
    {
        var army1 = new List<Character> { frodoWithTheOneRing, aragorn };
        var army2 = new List<Character> { orc1, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }

    [Fact]
    public void T02_ThingsGetComplicatedWhenFrodoLosesTheOneRing()
    {
        var army1 = new List<Character> { frodo, aragorn };
        var army2 = new List<Character> { orc1, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 2);
    }

    [Fact]
    public void T03_ButYouCanAlwaysRelyOnLegolasToFixThings()
    {
        var army1 = new List<Character> { frodo, aragorn, legolas };
        var army2 = new List<Character> { orc1, orc2, troll1 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }

    [Fact]
    public void T04_AlthoughTHereIsLittleYouCanDoAgainstAllTheBadOnes()
    {
        var army1 = new List<Character> { frodo, aragorn, legolas };
        var army2 = new List<Character> { orc1, orc2, orc3, orc4, troll1, troll2, troll3 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 2);
    }

    [Fact]
    public void T05_HaveYouEverWonderedWhichOnesAreStronger()
    {
        var army1 = new List<Character> { orc1, orc2, orc3, orc4 };
        var army2 = new List<Character> { troll1, troll2, troll3 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }
}