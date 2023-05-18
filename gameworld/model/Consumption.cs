namespace gameworld.model;

public class Consumption : Behaviour
{
    private float _resources;

    private float getResources() => _resources;

    private void setResources(float value) => _resources = value;

    public override string Execute()
    {
        return null;
    }
}