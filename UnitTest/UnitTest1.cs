using System.Windows.Input;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //Tests if a space is within reach of the test space
        public void IsSpaceWithinReach()
        {
            //Starts with instantiating a test space
            Space space = new Space("Space");
            //Adds a new area to boundry.
            space.AddEdge("New Space", new Space("New Space"));
            //tests if the new area is a valid space to find.
            Space test = space.FollowEdge("New Space");
            Assert.That(test, Is.Not.Null);
        }

        [TestCase("Wrong","Correct")]
        [TestCase("correct", "Correct")]
        [TestCase("", "Correct")]
        public void IsSpaceOutOfReach(string wrongspace, string correctspace)
        {
            //Starts with instantiating a new test space
            Space space = new Space("New Space");
            //tests if the an invalid area is a valid space to find.
            Space test = space.FollowEdge(wrongspace);
            Assert.That(test, Is.Null);
        }
        [Test]
        public void IsContextCorrect() {
            Context context = new Context(new Space("new"));
            Assert.That(context.GetCurrent(), Is.Not.Null);
        }
        [TestFixture]
        class CommandGo : BaseCommand
        {
            // forsøger at udføre GoCommand med givet context, command og parametre, ellers returner
            Context context = new Context(new Space("Test"));
            string[] parameters = new string[] { null };

            [Test]
            public void Execute()
            {
                //Hvis koden opdager at ingen parametre er givet vil koden angive en warning.
                if (GuardEq(parameters, 1))
                {
                    Assert.Warn("Der er ikke nogen parameter givet.");
                    return;
                }
                //Da testen er lavet til at fejle skal vores test fortælle os om hvorvidt den fejl-besked eksisterer.
               var test = Assert.Throws<ArgumentNullException>(() => context.Transition(parameters[0]));
                Assert.That(test.Message, Is.Not.Null);

            }

        }
        [TestFixture]
        class CommandGo2 : BaseCommand
        {
            // forsøger at udføre GoCommand med givet context, command og parametre, ellers returner
            Context context = new Context(new Space("Test"));
            string[] parameters = new string[1];

            [Test]
            [TestCase("")]
            [TestCase(null)]
            public void Execute(string? parameter)
            {
                parameters[0] = parameter;
                //Hvis koden opdager at ingen parametre er givet vil koden angive en warning.
                if (GuardEq(parameters, 1))
                {
                    Assert.Warn("Der er ikke nogen parameter givet.");
                    return;
                }

                //Da testen er lavet til at fejle skal vores test fortælle os om hvorvidt den fejl-besked eksisterer.
                if (parameters[0] == "")
                {
                    Assert.Warn("Du skal give en valid område");
                    return;
                }
                var test = Assert.Catch(()=>context.Transition(parameters[0]));
                Assert.That(test.Message, Is.Not.Null);

            }

        }

    }
}
