using DesignPatterns.Behavioural.Iterator.Phases;

namespace DesignPatterns.Behavioural.PhaseIterator;

public class Program
{
    public static void Main()
    {
        var phasesCollection = new Aggregate();
        phasesCollection[0] = "Phase 1";
        phasesCollection[1] = "Phase 2";
        phasesCollection[2] = "Phase 3";
        phasesCollection[3] = "Phase 4";
        phasesCollection[4] = "Phase 5";

        var iterator = phasesCollection.GetIterator();
        for (string s = iterator.FirstItem; iterator.IsReady == false; s = iterator.NextItem)
            Console.WriteLine(s);
    }
}
