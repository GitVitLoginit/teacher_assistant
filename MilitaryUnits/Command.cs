using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnits
{
    abstract class Command
    {
        protected Receiver receiver;

        // Constructor
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract string Execute();
        public abstract void Undo();
    }

    class ConcreteCommand : Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) :
          base(receiver)
        {
        }

        public override string Execute()
        {
           return receiver.Action();
        }
        public override void Undo()
        {
        }
    }

    class Receiver
    {
        public string Action()
        {
            return " army was queued an order";
        }
    }

    class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            this._command = command;
        }

        public string ExecuteCommand()
        {
           return _command.Execute();
        }
    }

}
