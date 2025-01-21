namespace HilosParaTodos;

public class FinishEvent
{
    //envolver una accion
    //publicos PascalCase
    public Action FinishAction { get; set; }

    public FinishEvent()
    {
        FinishAction = () => {  };
    }
}