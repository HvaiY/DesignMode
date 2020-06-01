using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CharactorFactory
    {
        private static Dictionary<string, AbstractCharactor> CharactorDictionary = new Dictionary<string, AbstractCharactor>();

        private static object CharactorLock = new object();

        public static AbstractCharactor CreateCharactor(CharactorEnum charactorEnum)
        {
            switch (charactorEnum)
            {
                case CharactorEnum.E:
                    if (!CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))//保证在对象被初始化后，不再进入锁
                    {
                        lock (CharactorLock)//控制多线程的进入
                        {
                            if (!CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))//单个线程判断是否存在
                            {
                                CharactorDictionary.Add(CharactorEnum.E.ToString(), new E());
                            }
                        }
                    }
                    return CharactorDictionary[CharactorEnum.E.ToString()];



                //if (CharactorDictionary.ContainsKey(CharactorEnum.E.ToString()))
                //{
                //    return CharactorDictionary[CharactorEnum.E.ToString()];
                //}
                //else
                //{
                //    E e = new E();
                //    CharactorDictionary.Add(CharactorEnum.E.ToString(), e);
                //    return e;
                //}

                case CharactorEnum.L:
                    return new L();
                case CharactorEnum.N:
                    return new N();
                case CharactorEnum.V:
                    return new V();
                default:
                    throw new Exception("wrong CharactorEnum");
            }
        }



    }

    public enum CharactorEnum
    {
        E,
        L,
        V,
        N
    }

}
