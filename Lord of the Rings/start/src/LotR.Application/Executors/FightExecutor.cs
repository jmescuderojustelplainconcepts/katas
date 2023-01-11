using LotR.Domain.Entities;

namespace LotR.Application.Executors;

public static class FightExecutor
{
    public static int GetWinner(List<Character> army1, List<Character> army2)
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