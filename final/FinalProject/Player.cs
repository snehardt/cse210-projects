class Player : Character
{
    public Player()
    {
        SetName("Hero");
        SetDesc("The brave player");

        SetMaxHP(100);
        SetHealth(100);

        SetSpecialMax(3);
    }

    public override void PerformAction()
    {
        Text.TypeText("Player attacks!");

        ChargeSpecial();
    }

}