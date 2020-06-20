using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Pages
{
    /// <summary>
    /// The new bug component class.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Components.ComponentBase" />
    public class NewBugComponent : ComponentBase
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
        /// Gets or sets the nav service.
        /// </summary>
        /// <value>
        /// The nav service.
        /// </value>
        [Inject]
        public NavigationManager NavService { get; set; }

        /// <summary>
        /// Gets or sets the add bug.
        /// </summary>
        /// <value>
        /// The add bug.
        /// </value>
        public Bug AddBug { get; set; } = new Bug();

        /// <summary>
        /// Handles the valid submit.
        /// </summary>
        protected void HandleValidSubmit()
        {
            BugService.AddBug(AddBug);
            NavService.NavigateTo("");
        }
    }
}
