class Magic : Action
{
    public Magic()
    {
        SetName("Magic");
        SetDamage(15);
    }

    public override void Execute(Character user, Character target)
    {
        Text.TypeText("Choose Magic Type:");
        Text.TypeText("1. Buff");
        Text.TypeText("2. Heal");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Text.TypeText($"{user.GetName()} focuses magical energy...");
            Text.TypeText("Next attack will do +5 damage!");

            int buffAmount = 5 + user.GetBonusDamage();
            user.SetBuff(buffAmount);
            user.ChargeSpecial();

        }
        else if (choice == "2")
        {
            int healAmount = 15 + user.GetBonusDamage();
            user.Heal(healAmount);

            Text.TypeText($"You restore your strength and recover {healAmount} HP");
        }
        else
        {
            Text.TypeText("Invalid choice. Turn wasted.");
        }
    }
}