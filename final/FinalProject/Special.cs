class Special : Action
{
    public Special()
    {
        SetName("Special");
        SetDamage(25);
    }

    public override void Execute(Character user, Character target)
    {
        if (!user.CanUseSpecial())
        {
            Text.TypeText("Special is not ready yet!");
            return;
        }

        Text.TypeText($"{user.GetName()} uses SPECIAL!");

        string name = user.GetName();

        if (name.Contains("Hero"))
        {
            int damage = GetDamage() + user.GetBuff() + user.GetBonusDamage();
            target.TakeDamage(damage);
            user.Heal(10);

            Text.TypeText("Hero strikes hard and heals for 10 HP!");
        }
        else if (name.Contains("Goblin"))
        {
            int damage = 15;
            target.TakeDamage(damage);

            Text.TypeText("Goblin performs a quick flurry attack!");
        }
        else if (name.Contains("Skeleton"))
        {
            int damage = 20;
            target.TakeDamage(damage);

            Text.TypeText("Skeleton unleashes bone magic!");
        }

        user.ResetSpecial();
        user.ResetBuff();
    }
}