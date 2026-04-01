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

// https://coddy.tech/courses/c_fundamentals?utm_source=gc&utm_medium=PmaxG&utm_campaign=23053737566&utm_content=6612693163&utm_term=&gad_source=1&gad_campaignid=23057765164&gbraid=0AAAAA9_1T8qNc8vdaXLz-ru9fT8JjNB-5&gclid=CjwKCAjwhLPOBhBiEiwA8_wJHPAqxcbWjInCVhKuOaxIWHiEO-q-2kIdraf10JQfffMXjZ6b6YYQ4hoC2C4QAvD_BwE