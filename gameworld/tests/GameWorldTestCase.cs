namespace gameworld.tests;
using gameworld.model;
using Type = gameworld.model.Type;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GameWorldTestCase
{
    [TestMethod]
    public void TestBuildScene()
    {
        Agent agent1 = new Agent(1, 0, 0, new Movement());
        Agent agent2 = new Agent(2, 10, 5, new Consumption());
        Obstacle obstacle = new Obstacle(new List<Block>(), false);
        GameWorld gameWorld = new GameWorld(obstacle);
        gameWorld.AddAgent(agent1);
        gameWorld.AddAgent(agent2);
        string expectedScene = "Scene: Agent 1 at (0,0), Agent 2 at (10,5), Obstacle state: False";
        string actualScene = gameWorld.BuildScene();
        Assert.AreEqual(expectedScene, actualScene);
    }
}