using gameworld.model;

class Program
{
    static void Main(string[] args)
    {
        Behaviour movementBehaviour = new Movement();
        Behaviour consumptionBehaviour = new Consumption();
        
        Agent agent1 = new Agent(1, 1, 3, movementBehaviour);
        Agent agent2 = new Agent(2, 0, 2, consumptionBehaviour);
        
        Console.WriteLine(agent1.Trigger());
        Console.WriteLine(agent2.Trigger());
        
        GameWorld gameWorld = new GameWorld(new Obstacle());
        gameWorld.AddAgent(agent1);
        gameWorld.AddAgent(agent2);
        
        List<Agent> agentsWithMovement = gameWorld.RetrieveAgents(movementBehaviour);
        Console.WriteLine("Agents found: "+ agentsWithMovement.Count);
        foreach (Agent agent in agentsWithMovement)
        {
            Console.WriteLine($"Agent ID: {agent.getId()}");
            Console.WriteLine($"Agent Position: ({agent.getPosX()}, {agent.getPosY()})");
            Console.WriteLine($"Agent Behaviour: {agent.getPower().GetType().Name}");
            Console.WriteLine();
        }
        
        string scene = gameWorld.BuildScene();
        Console.WriteLine(scene);
    }
}