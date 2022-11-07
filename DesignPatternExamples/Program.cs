using DesignPatternExamples.Strategy;
using DesignPatternExamples.Strategy.CharacterTypes;
using DesignPatternExamples.Strategy.WeaponBehaviors;

namespace DesignPatternExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character warrior = new Warrior();
            warrior.fight();
            Console.WriteLine("Warrior's sword is broken");
            warrior.SetWeapon(new AxeBehavior());
            warrior.fight();

        }
    }
}