using FluentOptionals;
using System;

namespace Cake.GitFlow.Release.Settings
{
    public class MergeDevBranchToMaster : GitFlowReleaseSettings
    {
        /// <summary>
        /// Merges develop branch to master branch. BEFORE merging <see cref="actionToPerformBeforeMerge"/>
        /// is invoked.
        /// </summary>
        public MergeDevBranchToMaster(Optional<Action> actionToPerformBeforeMerge)
        {
            if (actionToPerformBeforeMerge is null)
            {
                throw new ArgumentNullException(nameof(actionToPerformBeforeMerge));
            }

            ReleaseBranchBehaviour.AutomaticallyMergeReleaseBranch = false;
            actionToPerformBeforeMerge.IfSome(h => ReleaseBranchBehaviour.ActionToPerformOnReleaseBranch = h);
            ReleaseBranchBehaviour.CreateNewReleaseBranch = false;
        }
    }
}
