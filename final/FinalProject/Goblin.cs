class Goblin : Character
{
    public Goblin()
    {
        SetName("Goblin");
        SetDesc("A sneaky little creature");

        SetMaxHP(60);
        SetHealth(60);

        SetSpecialMax(2);
    }

    public override void PerformAction()
    {
        if (CanUseSpecial())
        {
            Text.TypeText("Goblin uses his Super!");
            ResetSpecial();
        }
        else
        {
            Text.TypeText("Goblin attacks!");
            ChargeSpecial();
        }
    }
}