using System;

namespace DecoratorPattern.ChristmasTree
{
    // Component
    public abstract class Tree
    {
        public abstract void Display();
    }

    // ConcreteComponent
    public class SimpleChristmasTree : Tree
    {
        public override void Display()
        {
            Console.WriteLine("Звичайна ялинка");
        }
    }

    // Decorator
    public abstract class TreeDecorator : Tree
    {
        protected Tree tree;

        public TreeDecorator(Tree tree)
        {
            this.tree = tree;
        }

        public override void Display()
        {
            if (tree != null)
            {
                tree.Display();
            }
        }
    }

    // ConcreteDecoratorA (Ялинкові прикраси - додає поля)
    public class OrnamentDecorator : TreeDecorator
    {
        private string ornamentType; // Поле за умовою завдання

        public OrnamentDecorator(Tree tree, string ornamentType) : base(tree)
        {
            this.ornamentType = ornamentType;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($" + додані прикраси: {ornamentType}");
        }
    }

    // ConcreteDecoratorB (Гірлянда - додає метод світіння)
    public class GarlandDecorator : TreeDecorator
    {
        public GarlandDecorator(Tree tree) : base(tree)
        {
        }

        public override void Display()
        {
            base.Display();
            Glow();
        }

        // Метод за умовою завдання
        public void Glow()
        {
            Console.WriteLine(" + гірлянда яскраво світиться!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо звичайну ялинку
            Tree myTree = new SimpleChristmasTree();

            // Декоруємо її прикрасами
            myTree = new OrnamentDecorator(myTree, "Скляні кульки та зірка");

            // Декоруємо гірляндою
            myTree = new GarlandDecorator(myTree);

            // Виводимо результат
            myTree.Display();

            Console.ReadKey();
        }
    }
}