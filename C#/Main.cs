using System;
using System.Collections.Generic;

namespace ObserverExample
{
    public abstract class Observable
    {
        private List<Observer> observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }

    public class ConcreteObservable : Observable
    {
        private string observableState;
        public string ObservableState
        {
            get { return observableState; }
            set { 
                    observableState = value;
                }
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteObservable observable;

        public ConcreteObserver(
            ConcreteObservable observable, string name)
        {
            this.observable = observable;
            this.name = name;
        }

        public override void Update()
        {
            observerState = observable.ObservableState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                ConcreteObservable s = new ConcreteObservable();
                ConcreteObserver a = new ConcreteObserver(s, "Observer 1");
                ConcreteObserver b = new ConcreteObserver(s, "Observer 2");
                ConcreteObserver c = new ConcreteObserver(s, "Observer 3");

                s.Attach(a);
                s.Attach(b);
                s.Attach(c);

                s.Detach(c);

                s.ObservableState = "LatestState";
                s.Notify();
            }
        }
    }
}
