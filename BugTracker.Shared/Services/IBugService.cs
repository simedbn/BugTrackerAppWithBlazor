using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Shared.Services
{
    public interface IBugService
    {
        List<Bug> GetBugs();

        void AddBug(Bug newBug);
    }
}
