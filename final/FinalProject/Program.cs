using System;

class Program
{
    static void Main(string[] args)
    {
        Character player = new Player();

        int floor = 0;
        bool playing = true;
        int coins = 0;

        Text.TypeText("You enter a dark dungeon in search of treasure...");
        Text.TypeText("The air is cold, and something is watching you...");
        Text.WaitForEnter();

        while (player.GetHealth() > 0 && playing)
        {
            floor++;
            
            bool isBossFloor = (floor % 5 == 0);

            Console.Clear();
            Console.WriteLine();
            Text.TypeText($"--- Floor {floor} ---");
            Text.TypeText("You move deeper into the dungeon...");
            Text.WaitForEnter();

            if (floor == 1)
            {
                Text.TypeText("Attacking does 10 damage, and charges special +2");
                Text.TypeText("Magic can either buff your next attack +5, or heal you for +15");
                Text.TypeText("Special does +25 damage, +10 healing");
            }

            int enemyCount;

            if (isBossFloor)
            {
                enemyCount = 1;
            }
            else
            {
                enemyCount = floor;
            }

            if (isBossFloor)
            {
                Console.WriteLine();
                Text.TypeText("You feel a powerful presence ahead...");
                Text.WaitForEnter();
            }

            for (int i = 0; i < enemyCount; i++)
            {
                Character enemy;

                if (isBossFloor)
                {
                    enemy = new Skeleton();

                    enemy.SetMaxHP(enemy.GetMaxHP() + 50);
                    enemy.SetHealth(enemy.GetMaxHP());
                    enemy.SetSpecialMax(2);

                    Console.WriteLine();
                    Text.TypeText($"A BOSS {enemy.GetCharacter()} appears!");
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        enemy = new Goblin();
                    }
                    else
                    {
                        enemy = new Skeleton();
                    }

                    Console.WriteLine();
                    Text.TypeText($"A {enemy.GetName()} appears!");
                }

                while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
                {
                    Console.WriteLine();
                    Text.TypeText("-------------------");
                    Text.TypeText($"Player HP: {player.GetHealth()}");
                    Text.TypeText($"Enemy HP: {enemy.GetHealth()}");
                    Text.TypeText($"Special Charge: {player.GetSpecialCharge()} / {player.GetSpecialMax()}");

                    Console.WriteLine();
                    Text.TypeText("Choose Action:");
                    Text.TypeText("1. Attack");
                    Text.TypeText("2. Magic");
                    Text.TypeText("3. Special");

                    string choice = Console.ReadLine();

                    Action action;

                    if (choice == "1")
                    {
                        action = new Attack();
                    }
                    else if (choice == "2")
                    {
                        action = new Magic();
                    }
                    else if (choice == "3")
                    {
                        if (!player.CanUseSpecial())
                        {
                            Text.TypeText($"Special not ready! ({player.GetSpecialCharge()}/{player.GetSpecialMax()})");
                            continue;
                        }

                        action = new Special();
                    }
                    else
                    {
                        Text.TypeText("Invalid choice. You lose your turn.");
                        action = new Attack();
                    }

                    Console.Clear();
                    action.Execute(player, enemy);

                    if (enemy.GetHealth() <= 0)
                    {
                        Console.WriteLine();
                        if (isBossFloor)
                        {
                            coins += 20;

                            Text.TypeText($"The boss {enemy.GetName()} has been defeated!");
                            Text.TypeText($"You gained 20 coins! Total: {coins}");
                        }
                        else
                        {
                            coins += 5;

                            Text.TypeText($"The {enemy.GetName()} collapses.");
                            Text.TypeText($"You found 5 coins! Total: {coins}");
                        }
                        Text.WaitForEnter();
                        break;
                    }

                    Console.WriteLine();
                    Text.TypeText("Enemy's turn...");
                    

                    Action enemyAction;

                    if (enemy.CanUseSpecial())
                    {
                        enemyAction = new Special();
                    }
                    else
                    {
                        enemyAction = new Attack();
                    }

                    enemyAction.Execute(enemy, player);

                    if (player.GetHealth() <= 0)
                    {
                        Console.WriteLine();
                        Text.TypeText("You were defeated...");
                        Text.WaitForEnter();
                        break;
                    }
                }

                if (player.GetHealth() <= 0)
                {
                    break;
                }
            }

            if (player.GetHealth() <= 0)
            {
                break;
            }
            if (floor % 5 == 0)
            {
                Text.TypeText("You defeated a powerful boss!");

                player.IncreaseDamage(2);
                player.IncreaseMaxHP(10);

                Text.TypeText("Your power surges!");
                Text.TypeText("Healing and buffs are stronger!");
                Text.WaitForEnter();
            }

            if (coins >= 100)
            {
                Console.Clear();
                Console.WriteLine();
                Text.TypeText("You have collected enough treasure!");
                Text.TypeText("You escape the dungeon rich!");
                Text.TypeText("You win!");
                Text.WaitForEnter();
                break;
            }

            Console.Clear();
            Console.WriteLine();
            Text.TypeText($"You cleared floor {floor}!");
            Text.TypeText($"Coins collected: {coins}");

            player.IncreaseMaxHP(5);
            player.IncreaseDamage(1);

            Text.TypeText("You feel stronger.");
            Text.TypeText("+5 Max HP");

            player.SetHealth(player.GetMaxHP());

            Text.TypeText("You take a moment to rest...");
            Text.TypeText("Your health is fully restored.");

            Console.WriteLine();
            Text.TypeText("Continue deeper? (y/n)");
            string input = Console.ReadLine();
            Console.Clear();

            if (input.ToLower() != "y")
            {
                playing = false;
            }
        }
        if (coins < 100)
        {
            Console.WriteLine();
            Text.TypeText($"You leave the dungeon with {coins} coins.");
            Text.TypeText("A wise choice... for now.");
        }
    }
}