using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatten
{
    public class ReadCommand : BaseCommand
    {
        private BaseReceiver Receiver = null;

        public override void SetReceiver(BaseReceiver receiver)
        {
            Receiver = receiver;
        }

        public override void Execute(Document doc)
        {
            Receiver.Execute(doc);
        }

    }
}
