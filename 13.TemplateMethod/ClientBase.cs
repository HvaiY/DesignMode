using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class ClientBase
    {
        /// <summary>
        /// 模板方法
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        public void ShowInfo(string account, string password)
        {
            if (CheckAccount(account, password))//验证账户
            {
                if (!IsSecret(account))
                {
                    double amount = GetAmount();//查询余额
                    double interest = GetInterest();//计算利息
                    Show(account, amount, interest);//展示数据
                }
                else
                {
                    Console.WriteLine("这里是保密账户，不允许查询");
                }
            }
            else
            {
                Console.WriteLine("账户信息错误！");
            }
        }

        public virtual bool IsSecret(string account)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckAccount(string account, string password)
        {
            return account.Equals("Adam") && password.Equals("9527");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetAmount()
        {
            return 10240000;
        }

        /// <summary>
        /// 计算利息
        /// </summary>
        /// <returns></returns>
        public abstract double GetInterest();

        public virtual void Show(string account, double amount, double interest)
        {
            Console.WriteLine("{0}  拥有{1}￥,利息为{2}", account, amount, interest);
        }

    }
}
