using FluentOptionals;
using System;

namespace Cake.GitFlow.Release.Settings
{
    public class CreateNewReleaseBranch : GitFlowReleaseSettings
    {
        /// <summary>
        /// Creates a new release branch. After release branch creation <paramref name="actionToPerformAfterReleaseBranchWasCreated"/>
        /// is invoked, if valid reference. Based on <paramref name="closeAndMergeReleaseBranch"/> the release branch
        /// is merged and closed (if set to true), otherwise no further actions are performed after the release
        /// branch was created.
        /// </summary>
        /// <param name="actionToPerformAfterReleaseBranchWasCreated"></param>
        /// <param name="closeAndMergeReleaseBranch"></param>
        public CreateNewReleaseBranch(
            Optional<Action> actionToPerformAfterReleaseBranchWasCreated,
            bool closeAndMergeReleaseBranch)
        {
            if (actionToPerformAfterReleaseBranchWasCreated is null)
            {
                throw new ArgumentNullException(nameof(actionToPerformAfterReleaseBranchWasCreated));
            }

            ReleaseBranchBehaviour.CreateNewReleaseBranch = true;
            ReleaseBranchBehaviour.AutomaticallyMergeReleaseBranch = closeAndMergeReleaseBranch;
            actionToPerformAfterReleaseBranchWasCreated.IfSome(h => ReleaseBranchBehaviour.ActionToPerformOnReleaseBranch = h);
            
        }
    }
}
