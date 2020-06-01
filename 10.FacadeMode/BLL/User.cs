using FacadeMode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    /// <summary>
    /// 用户系统
    /// </summary>
    public class User : IUser
    {
        public bool Check(int userId)
        {
            Console.WriteLine("当前用户是可以购买的");
            return true;
        }
    }
}
