using System;

namespace WorkflowEngine
{
    public interface IWorkflowInterface
    {
        void ApplyGriptape();
        void AttachingTrucksWithHardwareToDeck();
        void WheelsAndBearings();
    }

    public class WorkFlowEngine : IWorkflowInterface
    {
        public void ApplyGriptape()
        {
            Console.WriteLine("We will now apply the griptape to the deck");
        }

        public void AttachingTrucksWithHardwareToDeck()
        {
            Console.WriteLine("Now attach the trucks to the deck using the eights pieces of hardware");
        }

        public void WheelsAndBearings()
        {
            Console.WriteLine("We can now push the bearings into the wheels and attach them to the trucks");
        }
         public void SkateBoard()
        {
            Console.WriteLine("Rip it!!!");
        }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            WorkFlowEngine deckBuild = new WorkFlowEngine();

            deckBuild.ApplyGriptape();
            deckBuild.AttachingTrucksWithHardwareToDeck();
            deckBuild.WheelsAndBearings();

            deckBuild.SkateBoard();
        }
    }
}

//Apply Griptape
//Trucks and Hardware
//wheels and bearings
