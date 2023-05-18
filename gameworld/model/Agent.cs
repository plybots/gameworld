namespace gameworld.model;

public class Agent
{
    private int _id;
    private int _posX;
    private int _posY;
    private Behaviour _power;
    private List<Weapon> _weapons;
    private int _startLevel;

    public Agent(int id, int posX, int posY, Behaviour power)
    {
        _id = id;
        _posX = posX;
        _posY = posY;
        _power = power;
    }

    public int getId() => _id;

    public void setId(int value) => _id = value;

    public int getPosX() => _posX;

    public int getPosY() => _posY;

    public Behaviour getPower() => _power;

    public void setPower(Behaviour value) => _power = value;

    public List<Weapon> getWeapons() => _weapons;

    public int getStartLevel() => _startLevel;

    public string Trigger()
    {
        return $"Agent {_id} triggered. Position: ({_posX}, {_posY}). Behaviour: {_power.GetType().Name} has been triggered";
    }

    public string Attack()
    {
        return $"Agent {_id} triggered. Position: ({_posX}, {_posY}). Behaviour: {_power.GetType().Name} is set to attack";
    }

    public bool CollectWeapon(Weapon weapon)
    {
        return !_weapons.Contains(weapon);
    }
}