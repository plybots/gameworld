namespace gameworld.model;

public class Movement: Behaviour
{
    private int _step;

    public int getStep() => _step;

    public void setStep(int value) => _step = value;
    
    public override string Execute()
    {
        return null;
    }
}