using LotR.Application.Executors;
using LotR.Application.Test.Builders;
using LotR.Domain.Entities;
using Xunit;

namespace LotR.Application.Test.Executors;

public class SomeOfTheseTestsMayChange
{
    private Character frodo = CharacterBuilder.BuildHobbit("Frodo");
    private Character frodoWithTheOneRing = CharacterBuilder.BuildHobbit("Frodo").WithTheOneRing();
    private Character aragorn = CharacterBuilder.BuildHuman("Aragorn");
    private Character aragornWithTheOneRing = CharacterBuilder.BuildHuman("Aragorn").WithTheOneRing();
    private Character legolas = CharacterBuilder.BuildElf("Legolas");
    private Character orc1 = CharacterBuilder.BuildOrc();
    private Character orc2 = CharacterBuilder.BuildOrc();
    private Character orc3 = CharacterBuilder.BuildOrc();
    private Character orc4 = CharacterBuilder.BuildOrc();
    private Character troll1 = CharacterBuilder.BuildTroll();
    private Character troll2 = CharacterBuilder.BuildTroll();
    private Character troll3 = CharacterBuilder.BuildTroll();

    [Fact]
    public void T01_LetsSayWeHadSeveralOneRings()
    {
        // This test won't make sense because The One Ring shold be unique
        var army1 = new List<Character> { frodoWithTheOneRing, aragornWithTheOneRing, legolas };
        var army2 = new List<Character> { orc1, orc2, orc3, orc4, troll1, troll2 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }

    [Fact]
    public void T02_WaitCanWeReallyHaveSeveralOneRings()
    {
        // This test will change to ensure The One Ring shold is unique
        var merry = CharacterBuilder.BuildHobbit("Merry").WithTheOneRing();
        var pippin = CharacterBuilder.BuildHobbit("Pippi").WithTheOneRing();

        Assert.NotNull(merry.TheOneRing);
        Assert.NotNull(pippin.TheOneRing);
    }

    [Fact]
    public void T03_OrWeCanMakeAMixOfAlignmentsInEachArmy()
    {
        // This test will throw exception because you can't mix different alignment in the same army
        var army1 = new List<Character> { frodoWithTheOneRing, legolas, orc1, orc2 };
        var army2 = new List<Character> { aragorn, orc3, orc4, troll1, troll2 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }
}