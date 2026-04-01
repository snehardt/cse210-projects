abstract class Action
{
    private string _name;
    private int _damage;

    public string GetName()
    {
        return _name;
    }

    public int GetDamage()
    {
        return _damage;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDamage(int damage)
    {
        _damage = damage;
    }
    
    public abstract void Execute(Character user, Character target);
}