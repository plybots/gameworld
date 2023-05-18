namespace gameworld.model;

public class GameWorld
{
    private List<Agent> _agents = new List<Agent>();
    private readonly Obstacle _obstacle;

    public GameWorld(Obstacle obstacle)
    {
        _obstacle = obstacle;
    }

    public List<Agent> agents
    {
        set => _agents = value;
    }

    public List<Agent> getAgents() => _agents;

    public Obstacle getObstacle() => _obstacle;

    public void AddAgent(Agent agent)
    {
        _agents.Add(agent);
    }

    public void RemoveAgent(Agent agent)
    {
        _agents.Remove(agent);
    }

    public List<Agent> RetrieveAgents(Behaviour pwr)
    {
        List<Agent> agents = new List<Agent>();
        foreach (Agent agent in _agents)
        {
            if (agent.getPower().Equals(pwr))
            {
                agents.Add(agent);
            }
        }

        return agents;
    }

    public void Load()
    {
        
    }

    public string BuildScene()
    {
        string scene = "Scene: ";
        foreach (Agent agent in _agents)
        {
            scene += $"Agent {agent.getId()} at ({agent.getPosX()},{agent.getPosY()}), ";
        }
        scene += $"Obstacle state: {_obstacle.getState()}";

        return scene;
    }
}