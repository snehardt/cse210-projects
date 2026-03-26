abstract class Character
{
    private int _health;
    private int _maxHealth;
    private int _buffDamage;
    private int _specialCharge;
    private int _specialMax;
    private string _name;
    private string _desc;

    private int _bonusDamage;

    public abstract void PerformAction();

    public int GetHealth()
    {
        return _health;
    }

    public int GetMaxHP()
    {
        return _maxHealth;
    }

    public string GetCharacter()
    {
        return _name + ", " + _desc;
    }

    public int GetSpecialMax()
    {
        return _specialMax;
    }

    public int GetBuff()
    {
        return _buffDamage;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDesc(string desc)
    {
        _desc = desc;
    }
    
    public void SetMaxHP(int maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void SetHealth(int health)
    {
        _health = health;
    }

    public void SetBuff(int amount)
    {
        _buffDamage = amount;
    }

    public string GetName()
    {
        return _name;
    }

    public int TakeDamage(int damage)
    {
        _health -= damage;

        if (_health < 0)
        {
            _health = 0;
        }

        return _health;
    }

    public int Heal(int heal)
    {
        _health += heal;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        return _health;
    }

    public void IncreaseMaxHP(int amount)
    {
        _maxHealth += amount;
    }

    public void SetSpecialMax(int max)
    {
        _specialMax = max;
    }

    public int GetSpecialCharge()
    {
        return _specialCharge;
    }

    public void ChargeSpecial()
    {
        _specialCharge++;
    }

    public bool CanUseSpecial()
    {
        return _specialCharge >= _specialMax;
    }

    public void ResetSpecial()
    {
        _specialCharge -= 3;
    }

    public void ResetBuff()
    {
        _buffDamage = 0;
    }

    public void IncreaseDamage(int amount)
    {
        _bonusDamage += amount;
    }

    public int GetBonusDamage()
    {
        return _bonusDamage;
    }
}
