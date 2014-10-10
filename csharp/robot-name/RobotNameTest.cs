using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

[TestFixture]
public class RobotNameTest
{
    private Robot robot;

    [SetUp]
    public void Setup()
    {
        robot = new Robot();
    }

    [Test]
    public void Robot_has_a_name()
    {
        StringAssert.IsMatch(@"[A-Z]{2}\d{3}", robot.Name);
    }

    [Test]
    public void Name_is_the_same_each_time()
    {
        Assert.That(robot.Name, Is.EqualTo(robot.Name));
    }

    [Test]
    public void Different_robots_have_different_names()
    {
        var robot2 = new Robot();
        Assert.That(robot.Name, Is.Not.EqualTo(robot2.Name));
    }

	[Test]
    public void Can_reset_the_name()
    {
        var originalName = robot.Name;
        robot.FactoryReset();
        Assert.That(robot.Name, Is.Not.EqualTo(originalName));
    }

	[Test]
	public void Robot_names_are_unique()
	{
		var robots = new List<Robot>();
		for (int i = 0; i < 20; i++)
		{
			robots.Add(new Robot());
		}
		foreach (var r in robots)
		{
			Debug.Print(r.Name);
		}
	}
}