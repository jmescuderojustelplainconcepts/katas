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
}