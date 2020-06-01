using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Factory
    {
        public static IRace CreateInstance(RaceType raceType)
        {
            switch (raceType)
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                case RaceType.NE:
                    return new NE();
                case RaceType.Undead:
                    return new Undead();

                default:
                    throw new Exception("wrong raceType");

            }
        }

        private static string RaceTypeConfig = ConfigurationManager.AppSettings["RaceTypeConfig"];
        public static IRace CreateInstanceConfig()
        {

            switch ((RaceType)Enum.Parse(typeof(RaceType), RaceTypeConfig))
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                case RaceType.NE:
                    return new NE();
                case RaceType.Undead:
                    return new Undead();
                default:
                    throw new Exception("wrong raceType");

            }
        }


        private static string RaceTypeReflect = ConfigurationManager.AppSettings["RaceTypeReflect"];
        public static IRace CreateInstanceReflect()
        {
            string assemblyName = RaceTypeReflect.Split(',')[0];
            string typeName = RaceTypeReflect.Split(',')[1];
            return (IRace)(Activator.CreateInstance(assemblyName, typeName).Unwrap());
        }

        public enum RaceType
        {
            Human,
            Orc,
            Undead,
            NE
        }
    }

}
