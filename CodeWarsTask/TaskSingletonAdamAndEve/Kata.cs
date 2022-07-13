using System;

namespace CodeWars.KataSingletonAdamAndEve
{
    public class Kata
    {
        public sealed class Adam : Male
        {
            private static Adam m_adam;

            public static Adam GetInstance()
            {
                if (m_adam == null) { m_adam = new Adam(); }
                return m_adam;
            }

            private Adam() : base("Adam")
            {

            }
        }

        public sealed class Eve : Female
        {
            private static Eve m_eve;

            public static Eve GetInstance(Adam adam)
            {
                if (adam == null) { throw new ArgumentNullException(); }
                if (m_eve == null) { m_eve = new Eve(); }
                return m_eve;
            }

            private Eve() : base("Eve")
            {

            }

        }

        public class Male : Human
        {
            public Male(string name, Female eve, Male adam) : base(name, eve, adam)
            {
            }

            protected Male(string name) : base(name)
            {
            }

            protected Male()
            {

            }
        }

        public class Female : Human
        {
            public Female(string name, Female eve, Male adam) : base(name, eve, adam)
            {
            }

            protected Female(string name) : base(name)
            {
            }

            protected Female()
            {

            }

        }

        public abstract class Human
        {
            public string Name;
            public Male Father;
            public Female Mother;

            public Human(string name, Female eve, Male adam)
            {
                if (eve == null || adam == null) { throw new ArgumentNullException(); }
                Name = name;
                Mother = eve;
                Father = adam;
            }

            protected Human(string name)
            {
                Name = name;
            }

            protected Human()
            {

            }
        }
    }
}