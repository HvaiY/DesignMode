using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// subject
    /// </summary>
    public class Baby
    {
        public void Cry()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "Cry");
            new Father().Roar();
            new Mother().Whisper();
            new Mouse().Hide();
            new Cat().Run();

            new Dog().Bark();


        }




        private List<IObserver> ObserverList = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            ObserverList.Add(observer);
        }

        public void NewCry()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "NewCry");
            if (ObserverList != null && ObserverList.Count() > 0)
            {
                foreach (IObserver observer in ObserverList)
                {
                    //observer.Notify();
                    new Action(observer.Notify).BeginInvoke(null, null);
                }
            }
        }


        public event Action BabyCryHandler;

        public void CryEvent()
        {
            Console.WriteLine("{0} {1}", this.GetType(), "CryEvent");

            if (BabyCryHandler != null)
            {
                //BabyCryHandler();
                BabyCryHandler.Invoke();
            }
        }


    }
}
