using LotR.Application.Executors;
using LotR.Application.Test.Builders;
using LotR.Domain.Entities.Characters.Base;
using Xunit;

namespace LotR.Application.Test.Executors;

public class SomeOfTheseTestsMayChange
{
    [Fact]
    public void T02_WaitCanWeReallyHaveSeveralOneRings()
    {
        // This test will change to ensure The One Ring shold is unique
        var merry = CharacterBuilder.BuildHobbit("Merry").WithTheOneRing();
        var pippin = CharacterBuilder.BuildHobbit("Pippi").WithTheOneRing();

        Assert.Null(merry.TheOneRing);
        Assert.NotNull(pippin.TheOneRing);
    }

    [Fact]
    public void T03_OrWeCanMakeAMixOfAlignmentsInEachArmy()
    {
        // This test will throw exception because you can't mix different alignment in the same army
        var frodoWithTheOneRing = CharacterBuilder.BuildHobbit("Frodo").WithTheOneRing();
        var aragorn = CharacterBuilder.BuildHuman("Aragorn");
        var legolas = CharacterBuilder.BuildElf("Legolas");
        var orc1 = CharacterBuilder.BuildOrc();
        var orc2 = CharacterBuilder.BuildOrc();
        var orc3 = CharacterBuilder.BuildOrc();
        var orc4 = CharacterBuilder.BuildOrc();
        var troll1 = CharacterBuilder.BuildTroll();
        var troll2 = CharacterBuilder.BuildTroll();

        var army1 = new List<Character> { frodoWithTheOneRing, legolas, orc1, orc2 };
        var army2 = new List<Character> { aragorn, orc3, orc4, troll1, troll2 };

        var winner = FightExecutor.GetWinner(army1, army2);

        Assert.True(winner == 1);
    }
}