using gameworld.model;
using Type = gameworld.model.Type;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gameworld.tests;

[TestClass]
public class AgentTestCase
{
    [TestMethod]
    public void TestAgentCollectWeapon()
    {
        Weapon weapon1 = new Weapon("Shotgun", Type.Shotgun, 10);
        Weapon weapon2 = new Weapon("Rifle", Type.Rifle, 15);
        Agent agent = new Agent(1, 0, 0, new Movement());
        agent.getWeapons().Add(weapon1);
        Assert.IsFalse(agent.CollectWeapon(weapon1));
        Assert.IsTrue(agent.CollectWeapon(weapon2));
        Assert.AreEqual(2, agent.getWeapons().Count);
    }
}