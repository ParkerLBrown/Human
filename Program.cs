using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human humanOne = new Human("Chris");
            Human humanTwo = new Human("Sean");
            Console.Write($"{humanOne.Name}'s stats:\nHealth: {humanOne.Health}\nStrength: {humanOne.Strength}\nHealth: {humanOne.Intelligence}\nStrength: {humanOne.Dexterity}\n\n");
            Console.Write($"{humanTwo.Name}'s stats:\nHealth: {humanTwo.Health}\nStrength: {humanTwo.Strength}\nHealth: {humanTwo.Intelligence}\nStrength: {humanTwo.Dexterity}\n\n");
            humanOne.Attack(humanTwo);
            Console.WriteLine($"{humanOne.Name} attacked {humanTwo.Name}. {humanTwo.Name} lost {humanOne.Strength*5} HP.");
            Console.Write($"{humanTwo.Name}'s stats:\nHealth: {humanTwo.Health}\nStrength: {humanTwo.Strength}\nHealth: {humanTwo.Intelligence}\nStrength: {humanTwo.Dexterity}\n\n");
            humanTwo.Attack(humanOne);
            Console.WriteLine($"{humanTwo.Name} attacked {humanOne.Name}. {humanOne.Name} lost {humanTwo.Strength*5} HP.");
            Console.Write($"{humanOne.Name}'s stats:\nHealth: {humanOne.Health}\nStrength: {humanOne.Strength}\nHealth: {humanOne.Intelligence}\nStrength: {humanOne.Dexterity}\n\n");
        }
    }
}
