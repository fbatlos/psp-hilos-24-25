namespace HilosParaTodos;

public class MiHilo
{
    Thread hilo;
    private string text;
    Wrapper<Action> finishEvent;
    
    public MiHilo(string text, Wrapper<Action> finishEvent)
    {
        this.text = text;
        //Con global crea una copia !
        this.finishEvent = finishEvent;
        finishEvent.Value += () => { Console.WriteLine($"Hilo {text}"); };
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        finishEvent.Value.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}
