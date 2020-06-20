using BugTracker.Shared;
using BugTracker.Shared.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Components
{
    /// <summary>
    /// The bug list component class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
    public class BugListComponent : ComponentBase
    {
        /// <summary>
        /// Gets or sets the bug service.
        /// </summary>
        /// <value>
        /// The bug service.
        /// </value>
        [Inject]
        public IBugService BugService { get; set; }

        /// <summary>
        /// Gets or sets the bugs.
        /// </summary>
        /// <value>
        /// The bugs.
        /// </value>
        public List<Bug> Bugs { get; set; }

        /// <summary>
        /// Method invoked when the component is ready to start, having received its
        /// initial parameters from its parent in the render tree.
        /// </summary>
        protected override void OnInitialized()
        {
            Bugs = BugService.GetBugs().OrderBy(x => x.Priority).ToList();
        }
    }
}
