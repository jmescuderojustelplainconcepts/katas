using LotR.Domain.Contracts;
using LotR.Domain.Entities.Characters.Base;

namespace LotR.Application.Executors;

public static class FightExecutor
{
    public static int GetWinner(List<IGood> army1, List<IBad> army2)
    {
        var firstArmyStrength = army1.Sum(c => c.GetStrength());
        var secondArmyStrength = army2.Sum(c => c.GetStrength());

        if (firstArmyStrength > secondArmyStrength)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}