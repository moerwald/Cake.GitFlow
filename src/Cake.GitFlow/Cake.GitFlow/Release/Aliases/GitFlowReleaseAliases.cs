using Cake.Core;
using Cake.Core.Annotations;
using Cake.GitFlow.Release.Settings;
using System;

namespace Cake.GitFlow.Release.Aliases
{
    public static class GitFlowReleaseAliases
    {
        [CakeMethodAlias()]
        public static IGitFlowRunner GitFlowShotGitVersion(
            this ICakeContext context,
            GitFlowReleaseSettings settings)
        {
            // Param null checks
            if (context is null) { throw new ArgumentNullException(nameof(context)); }
            if (settings is null) { throw new ArgumentNullException(nameof(settings)); }



            switch (settings)
            {
                case MergeDevBranchToMaster mergeToMaser:
                    // Todo:
                    break;
                case CreateNewReleaseBranch newReleaseBranch:
                    // Todo:

                    break;
            }


            // Todo: Create new release branch, if needed
            //       Get highest tag
            //       Call custom action
            //       Perform merge based on Gitflow


            // Remove below line just needed for CI to check if we still compile
            return new GitFlowRunner(context);
        }
    }
}
