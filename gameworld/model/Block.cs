namespace gameworld.model;

public class Block
{
    private int _x;
    private int _y;
    private bool _transparent;

    public Block(int x, int y, bool transparent)
    {
        _x = x;
        _y = y;
        _transparent = transparent;
    }

    public Block()
    {
    }

    public int x
    {
        set => _x = value;
    }

    public int getX() => _x;

    public int y
    {
        set => _y = value;
    }

    public int getY() => _y;

    public bool getTransparent() => _transparent;

    public void setTransparent(bool value) => _transparent = value;
}