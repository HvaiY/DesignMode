using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterShow
{
    /// <summary>
    /// 1 适配器模式是干什么的
    /// 2 类适配器和对象适配器
    /// 3 工作中的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家来到.net高级班公开课程,欢迎大家加入公开课交流群 464769264");
            ISqlHelper sqlHelper = new SqlserverHelper();
            sqlHelper.Add();
            sqlHelper.Delete();
            sqlHelper.Update();
            sqlHelper.Search();


            ISqlHelper mysqlHelper = new MysqlHelper();
            mysqlHelper.Add();
            mysqlHelper.Delete();
            mysqlHelper.Update();
            mysqlHelper.Search();


            //MyLucene myLucene = new MyLucene();


            ISqlHelper myLuceneAdapter = new MyLuceneAdapter();
            myLuceneAdapter.Add();
            myLuceneAdapter.Delete();
            myLuceneAdapter.Search();
            myLuceneAdapter.Update();




            Xiaomi xiaomi = new Xiaomi();
            //xiaomi.Call();
            //xiaomi.Message();

            Dageda dageda = new Dageda();
            PhoneAdapter phoneAdapter = new PhoneAdapter(dageda);

            PhoneAdapter phoneAdapterXiaomi = new PhoneAdapter(xiaomi);

            phoneAdapter.Call();
            phoneAdapter.Message();


            //dageda.Call();
            //dageda.Message();



            Console.Read();
        }
    }
}
