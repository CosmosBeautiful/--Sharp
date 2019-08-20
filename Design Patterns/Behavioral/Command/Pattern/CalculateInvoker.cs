using System.Collections.Generic;

namespace Command
{
    class CalculateInvoker
    {
        private List<Command> commandsList = new List<Command>();
        private int itemCurrentCommand = 0;

        public void StoreCommand(Command command)
        {
            commandsList.Add(command);
        }

        public void ExecuteCommand()
        {
            commandsList[itemCurrentCommand].Execute();
            itemCurrentCommand++;
        }

        public void Undo(int levelsUndo)
        {
            for (int i = 0; i < levelsUndo; i++)
            {
                if (itemCurrentCommand > 0)
                {
                    itemCurrentCommand--;
                    commandsList[itemCurrentCommand].UnExecute();
                }
            }
        }

        public void Redo(int levelRedo)
        {
            for (int i = 0; i < levelRedo; i++)
            {
                if ( itemCurrentCommand < (commandsList.Count - 1) )
                {
                    commandsList[itemCurrentCommand].Execute();
                    itemCurrentCommand++;
                }
            }
        }

    }
}
