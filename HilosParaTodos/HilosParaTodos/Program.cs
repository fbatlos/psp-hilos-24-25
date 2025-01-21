using HilosParaTodos;

//MyEvents.finalizar = () => { Console.WriteLine("Suscriptor A"); };
//MyEvents.finalizar += () => { Console.WriteLine("Suscriptor B"); };

FinishEvent finishEvent = new FinishEvent();

Wrapper<Action> finishEvent2 = new Wrapper<Action>(() => { });

MiHilo t1 = new MiHilo("x", finishEvent2);
MiHilo t2 = new MiHilo("y", finishEvent2);

finishEvent.FinishAction += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();
