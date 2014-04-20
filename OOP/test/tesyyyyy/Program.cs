using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AcademyRPG
{
    public abstract class Character : MovingObject, IControllable
    {
        public string Name { get; private set; }

        public Character(string name, Point position, int owner)
            : base(position, owner)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.Name;
        }
    }
}

namespace AcademyRPG
{
    public class Engine
    {
        public static readonly char[] separators = new char[] { ' ' };

        protected List<WorldObject> allObjects;
        protected List<IControllable> controllables;
        protected List<IResource> resources;
        //protected List<IGatherer> gatherers;
        //protected List<IFighter> fighters;

        public Engine()
        {
            this.allObjects = new List<WorldObject>();
            this.controllables = new List<IControllable>();
            this.resources = new List<IResource>();
            //this.gatherers = new List<IGatherer>();
            //this.fighters = new List<IFighter>();
        }

        public void AddObject(WorldObject obj)
        {
            this.allObjects.Add(obj);

            IControllable objAsControllable = obj as IControllable;
            if (objAsControllable != null)
            {
                this.controllables.Add(objAsControllable);
            }

            IResource objAsResource = obj as IResource;
            if (objAsResource != null)
            {
                this.resources.Add(objAsResource);
            }

            //IGatherer objAsGatherer = obj as IGatherer;
            //if (objAsGatherer != null)
            //{
            //    this.gatherers.Add(objAsGatherer);
            //}

            //IFighter objAsFighter = obj as IFighter;
            //if (objAsFighter != null)
            //{
            //    this.fighters.Add(objAsFighter);
            //}
        }


        private void RemoveDestroyed()
        {
            this.allObjects.RemoveAll(obj => obj.IsDestroyed);
            this.controllables.RemoveAll(obj => obj.IsDestroyed);
            this.resources.RemoveAll(obj => obj.IsDestroyed);
            //this.gatherers.RemoveAll(obj => obj.IsDestroyed);
            //this.fighters.RemoveAll(obj => obj.IsDestroyed);
        }

        public void ExecuteCommand(string command)
        {
            string[] commandWords = command.Split(Engine.separators, StringSplitOptions.RemoveEmptyEntries);

            if (commandWords[0] == "create")
            {
                this.ExecuteCreateObjectCommand(commandWords);
            }
            else
            {
                this.ExecuteControllableCommand(commandWords);
            }

            this.RemoveDestroyed();
        }

        public virtual void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "lumberjack":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Lumberjack(name, position, owner));
                        break;
                    }
                case "guard":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Guard(name, position, owner));
                        break;
                    }
                case "tree":
                    {
                        int size = int.Parse(commandWords[2]);
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Tree(size, position));
                        break;
                    }
            }
        }

        public virtual void ExecuteControllableCommand(string[] commandWords)
        {
            string controllableName = commandWords[0];
            IControllable current = null;

            for (int i = 0; i < this.controllables.Count; i++)
            {
                if (controllableName == this.controllables[i].Name)
                {
                    current = this.controllables[i];
                }
            }

            if (current != null)
            {
                switch (commandWords[1])
                {
                    case "go":
                        {
                            HandleGoCommand(commandWords, current);
                            break;
                        }
                    case "attack":
                        {
                            HandleAttackCommand(current);
                            break;
                        }
                    case "gather":
                        {
                            HandleGatherCommand(current);
                            break;
                        }
                }
            }
        }

        private void HandleGatherCommand(IControllable current)
        {
            var currentAsGatherer = current as IGatherer;
            if (currentAsGatherer != null)
            {
                //List<WorldObject> objectsAtGathererPosition = new List<WorldObject>();
                IResource resource = null;
                foreach (var obj in this.resources)
                {
                    if (obj.Position == current.Position)
                    {
                        resource = obj;
                        break;
                    }
                }

                if (resource != null)
                {
                    HandleGathering(currentAsGatherer, resource);
                }
                else
                {
                    Console.WriteLine("No resource to gather at {0}'s position", current);
                }
            }
            else
            {
                Console.WriteLine("{0} can't do that", current);
            }
        }

        private void HandleAttackCommand(IControllable current)
        {
            var currentAsFighter = current as IFighter;
            if (currentAsFighter != null)
            {
                List<WorldObject> availableTargets = new List<WorldObject>();
                foreach (var obj in this.allObjects)
                {
                    if (obj.Position == current.Position)
                    {
                        availableTargets.Add(obj);
                    }
                }

                int targetIndex = currentAsFighter.GetTargetIndex(availableTargets);
                if (targetIndex != -1)
                {
                    this.HandleBattle(currentAsFighter, availableTargets[targetIndex]);
                }
                else
                {
                    Console.WriteLine("No targets to attack at {0}'s position", current);
                }
            }
            else
            {
                Console.WriteLine("{0} can't do that", current);
            }
        }

        private void HandleGathering(IGatherer gatherer, IResource resource)
        {
            bool gatheringSuccess = gatherer.TryGather(resource);
            if (gatheringSuccess)
            {
                Console.WriteLine("{0} gathered {1} {2} from {3}", gatherer, resource.Quantity, resource.Type, resource);
                resource.HitPoints = 0;
            }


        }

        private void HandleBattle(IFighter attacker, WorldObject defender)
        {
            var defenderAsFighter = defender as IFighter;
            int defenderDefensePoints = 0;
            if (defenderAsFighter != null)
            {
                defenderDefensePoints = defenderAsFighter.DefensePoints;
            }

            int damage = attacker.AttackPoints - defenderDefensePoints;

            if (damage < 0)
            {
                damage = 0;
            }

            if (damage > defender.HitPoints)
            {
                damage = defender.HitPoints;
            }

            defender.HitPoints -= damage;

            Console.WriteLine("{0} attacked {1} and did {2} damage", attacker, defender, damage);
        }

        private void HandleGoCommand(string[] commandWords, IControllable current)
        {
            var currentAsMoving = current as MovingObject;
            currentAsMoving.GoTo(Point.Parse(commandWords[2]));
            Console.WriteLine("{0} is now at position {1}", current, current.Position);
        }
    }
}

namespace AcademyRPG
{
    public class EngineAdditionalObjects : Engine
    {
        public override void ExecuteCreateObjectCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "knight":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Knight(name, position, owner));
                        break;
                    }
                case "house":
                    {
                        Point position = Point.Parse(commandWords[2]);
                        int owner = int.Parse(commandWords[3]);
                        this.AddObject(new House(position, owner));
                        break;
                    }
                case "giant":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Giant(name, position));
                        break;
                    }
                case "rock":
                    {
                        int hitPoints = int.Parse(commandWords[2]);
                        Point position = Point.Parse(commandWords[3]);
                        this.AddObject(new Rock(hitPoints, position));
                        break;
                    }
                case "ninja":
                    {
                        string name = commandWords[2];
                        Point position = Point.Parse(commandWords[3]);
                        int owner = int.Parse(commandWords[4]);
                        this.AddObject(new Ninja(name, position, owner));
                        break;
                    }
                default:
                    base.ExecuteCreateObjectCommand(commandWords);
                    break;
            }
        }
    }
}

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private const int initialGiantHitPoints = 200;
        private const int initialGiantDefensePoints = 80;
        private const int initialGiantAttackPoints = 150;
        private const int additionalAttackPointsFromGathering = 100;
        private const int neutralOwner = 0;
        private bool gatheredOnce;
        private int giantattackPoints;
        public Giant(string name, Point position)
            : base(name, position, neutralOwner)
        {
            this.HitPoints = initialGiantHitPoints;
            this.AttackPoints = initialGiantAttackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return giantattackPoints;
            }
            set
            {
                this.giantattackPoints += value;
            }
        }

        public int DefensePoints
        {
            get { return initialGiantDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone && gatheredOnce == false)
            {
                gatheredOnce = true;
                this.AttackPoints = additionalAttackPointsFromGathering;
                return true;
            }

            return false;
        }
    }
}

namespace AcademyRPG
{
    public class Guard : Character, IFighter
    {
        public Guard(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 100;
        }

        public int AttackPoints
        {
            get { return 50; }
        }

        public int DefensePoints
        {
            get { return 20; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

namespace AcademyRPG
{
    public class House : StaticObject
    {
        private const int initialHouseHitPoints = 500;
        public House(Point position, int owner)
            : base(position, owner)
        {
            this.HitPoints = initialHouseHitPoints;
        }
    }
}

namespace AcademyRPG
{
    public interface ICollectable
    {
    }
}

namespace AcademyRPG
{
    public interface ICollector
    {
        void Method();
    }
}

namespace AcademyRPG
{
    public interface IControllable : IWorldObject
    {
        string Name
        {
            get;
        }
    }
}

namespace AcademyRPG
{
    public interface IWorldObject
    {
        bool IsDestroyed
        {
            get;
        }

        int HitPoints
        {
            get;
            set;
        }

        Point Position
        {
            get;
        }
    }
}

namespace AcademyRPG
{
    public interface IFighter : IControllable
    {
        int AttackPoints
        {
            get;
        }

        int DefensePoints
        {
            get;
        }

        int GetTargetIndex(List<WorldObject> availableTargets);
    }
}

namespace AcademyRPG
{
    public interface IGatherer : IControllable
    {
        bool TryGather(IResource resource);
    }
}

namespace AcademyRPG
{
    public interface INameable
    {
    }
}

namespace AcademyRPG
{
}

namespace AcademyRPG
{
    public interface IResource : IWorldObject
    {
        int Quantity
        {
            get;
        }

        ResourceType Type
        {
            get;
        }
    }
}

namespace AcademyRPG
{
}

namespace AcademyRPG
{
    public class Knight : Character, IFighter
    {
        private const int initialKnightHitPoints = 100;
        private const int initialKnightAttackPoints = 100;
        private const int initialKnightDefensePoints = 100;
        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = initialKnightHitPoints;
        }

        public int AttackPoints
        {
            get { return initialKnightAttackPoints; }
        }

        public int DefensePoints
        {
            get { return initialKnightDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

namespace AcademyRPG
{
    public class Lumberjack : Character, IGatherer
    {
        public Lumberjack(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 50;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                return true;
            }

            return false;
        }
    }
}

namespace AcademyRPG
{
    public abstract class MovingObject : WorldObject
    {
        public MovingObject(Point position, int owner)
            : base(position, owner)
        {
        }

        public void GoTo(Point destination)
        {
            this.Position = destination;
        }
    }
}

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private const int initialNinjaHitPoints = 1;
        private const int invulnerableNinjaDefensePoints = int.MaxValue;
        private const int initialNinjaAttackPoints = 0;
        private const int stoneQuantityModifier = 2;
        private int ninjaAttackPoints;

        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = initialNinjaHitPoints;
            this.AttackPoints = initialNinjaAttackPoints;
        }

        public int AttackPoints
        {
            get
            {
                return ninjaAttackPoints;
            }
            set
            {
                this.ninjaAttackPoints += value;
            }
        }

        public int DefensePoints
        {
            get { return invulnerableNinjaDefensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int highestHitPointsLocation = 0;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].HitPoints > highestHitPointsLocation &&
                    availableTargets[i].Owner != this.Owner &&
                    availableTargets[i].Owner != 0)
                {
                    highestHitPointsLocation = i;
                    return highestHitPointsLocation;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints = resource.Quantity * stoneQuantityModifier;
                return true;
            }
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints = resource.Quantity;
                return true;
            }

            return false;
        }
    }
}

namespace AcademyRPG
{
    public struct Point
    {
        public readonly int X;

        public readonly int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(string xString, string yString)
        {
            this.X = int.Parse(xString);
            this.Y = int.Parse(yString);
        }

        public override int GetHashCode()
        {
            return this.X * 7 + this.Y;
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", this.X, this.Y);
        }

        public static Point Parse(string pointString)
        {
            string coordinatesPairString = pointString.Substring(1, pointString.Length - 2);
            string[] coordinates = coordinatesPairString.Split(',');
            return new Point(coordinates[0], coordinates[1]);
        }
    }
}

namespace AcademyRPG
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new Engine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}

namespace AcademyRPG
{
    public enum ResourceType
    {
        Lumber,
        Stone,
        Gold,
    }
}

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        private const int quantityModifier = 2;
        private int quantity;
        public Rock(int hitPoints, Point position)
            : base(position)
        {
            this.HitPoints = hitPoints;
            this.Quantity = this.HitPoints / quantityModifier;
        }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Stone;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                this.quantity = value;
            }
        }
    }
}

namespace AcademyRPG
{
    public abstract class StaticObject : WorldObject
    {
        public StaticObject(Point position, int owner = 0)
            : base(position, owner)
        {
        }
    }
}

namespace AcademyRPG
{
    public class Tree : StaticObject, IResource
    {
        protected int Size { get; private set; }

        public ResourceType Type
        {
            get
            {
                return ResourceType.Lumber;
            }
        }

        public int Quantity
        {
            get
            {
                return this.Size;
            }
        }

        public Tree(int size, Point position)
            : base(position)
        {
            this.Size = size;
            this.HitPoints = size;
        }
    }
}

namespace AcademyRPG
{
    public abstract class WorldObject : IWorldObject
    {
        public int HitPoints { get; set; }

        public int Owner { get; private set; }

        public Point Position { get; protected set; }

        public bool IsDestroyed
        {
            get
            {
                return this.HitPoints <= 0;
            }
        }

        public WorldObject(Point position, int owner)
        {
            this.Position = position;
            this.Owner = owner;
            this.HitPoints = 0;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
