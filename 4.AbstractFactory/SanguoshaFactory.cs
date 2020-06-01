using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SanguoshaFactory : BaseFactory
    {
        #region
        //public Qun CreateQun()
        //{
        //    return new Qun();
        //}
        //public Wu CreateWu()
        //{
        //    return new Wu();
        //}
        //public Shu CreateShu()
        //{
        //    return new Shu();
        //}
        //public Wei CreateWei()
        //{
        //    return new Wei();
        //}
        #endregion

        public override IRace CreateFirst()
        {
            return new Wei();
        }

        public override IRace CreateSecond()
        {
            return new Shu();
        }

        public override IRace CreateThird()
        {
            return new Wu();
        }

        public override IRace CreateFourth()
        {
            return new Qun();
        }
    }
}
