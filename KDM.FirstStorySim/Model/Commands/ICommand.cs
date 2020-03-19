using System;
using System.Collections.Generic;
using System.Text;

namespace KDM.FirstStorySim.Model.Commands
{
    public interface ICommand<T>
    {
        void ExecuteAction(T target);

        void Undo();
    }
}
