using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 聊天中介
    /// </summary>
    public class ChatMediator
    {
        public List<Student> StundentList = new List<Student>();

        public ChatMediator(List<Student> studentList)
        {
            StundentList = studentList;
        }

        public void SendMessage(Student from, string text)
        {
            foreach (Student student in StundentList.Where(s => !s.Name.Equals(from.Name)))
            {
                student.ReceiveMessage(text);
            }
        }

        //会很复杂
    }
}
