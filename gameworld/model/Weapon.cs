namespace gameworld.model;

public class Weapon
{
    private string _name;
    private Type _weaponType;
    private int _damageLevel;

    public Weapon(string name, Type weaponType, int damageLevel)
    {
        _name = name;
        _weaponType = weaponType;
        _damageLevel = damageLevel;
    }

    public string name
    {
        set => _name = value;
    }

    public string getName() => _name;

    public Type weaponType
    {
        set => _weaponType = value;
    }

    public Type getWeaponType() => _weaponType;

    public int getDamageLevel() => _damageLevel;

    public void setDamageLevel(int value) => _damageLevel = value;

    public int Execute()
    {
        return 0;
    }
}