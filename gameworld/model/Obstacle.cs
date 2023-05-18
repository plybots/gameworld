namespace gameworld.model;

public class Obstacle
{
    private List<Block> _blocks;
    private bool _state;

    public Obstacle(List<Block> blocks, bool state)
    {
        _blocks = blocks;
        _state = state;
    }

    public Obstacle()
    {
    }

    public List<Block> blocks
    {
        set => _blocks = value;
    }

    public List<Block> getBlocks() => _blocks;

    public bool getState() => _state;

    public void setState(bool value) => _state = value;

    public void AddBlock(Block block)
    {
        _blocks.Add(block);
    }
}