using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChain
{
    /// <summary>
    /// 五天以内
    /// </summary>
    public class TD : Node
    {
        public TD(string name)
        {
            Console.WriteLine("准备TM {0}审批环节", name);
        }

        public override Context Audit(Context applyContext)
        {
            if (applyContext.Hour <= 40)
            {
                applyContext.AuditState = 2;
                applyContext.AuditRemark = "技术总监通过申请";
            }
            //else//否则应该交给下一个  TM
            //    applyContext.AuditState = 1;

            else
            {
                if (base.NextNode == null)//没有下一个节点
                {
                    applyContext.AuditState = 3;
                    applyContext.AuditRemark = "技术总监审批未通过";
                }
                else
                {
                    applyContext.AuditState = 1;
                    base.NextNode.Audit(applyContext);
                }
            }
            return applyContext;
        }
    }
}
