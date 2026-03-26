class Attack : Action
{
    public Attack()
    {
        SetName("Attack");
        SetDamage(10);
    }

    public override void Execute(Character user, Character target)
    {
        Text.TypeText($"{user.GetName()} attacks!");

        int damage = GetDamage() + user.GetBuff() + user.GetBonusDamage();
        target.TakeDamage(damage);

        Text.TypeText($"Dealt {damage} damage.");

        user.ChargeSpecial();
        user.ResetBuff();

        string name = user.GetName();

        if (name.Contains("Hero"))
        {
            user.ChargeSpecial();
        }
    }
}