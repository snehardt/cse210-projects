class Skeleton : Character
{
    public Skeleton()
    {
        SetName("Skeleton");
        SetDesc("An undead warrior");

        SetMaxHP(80);
        SetHealth(80);

        SetSpecialMax(4);
    }

    public override void PerformAction()
    {
        if (CanUseSpecial())
        {
            Text.TypeText("Skeleton uses his Super!");
            ResetSpecial();
        }
        else
        {
            Text.TypeText("Skeleton uses magic!");
            ChargeSpecial();
        }
    }
}