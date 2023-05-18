namespace gameworld.model;

public abstract class Behaviour
{
    private bool _state;

    public bool getState() => _state;

    public void setState(bool value) => _state = value;

    public abstract string Execute();
}