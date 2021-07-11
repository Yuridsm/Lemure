using System;

namespace lemure.OOP.AbstractClass
{
    public abstract class SO
    {
        public Guid Identifier { 
            get
            {
                return Guid.NewGuid();
            }
        }
        public string Name { get; set; }
        public SO(Guid guid)
        {
            FindSO(guid);
        }

        public abstract void FindSO(Guid guid);
    }

    public class Linux : SO
    {
        public Linux(Guid guid, string name) : base(guid)
        {
            this.Name = name;
        }

        public override void FindSO(Guid guid)
        {
            Console.WriteLine($"You are searching SO by Guid {this.Identifier}\n");
        }

        public void Info()
        {
            Console.WriteLine($"Guid: {this.Identifier}");
            Console.WriteLine($"Name: {this.Name}\n");
        }
    }

    public class TestSO
    {
        public static void GetInfo()
        {
            Linux l = new Linux(Guid.NewGuid(), "Ubuntu");
            l.Info();
        }
    }
}