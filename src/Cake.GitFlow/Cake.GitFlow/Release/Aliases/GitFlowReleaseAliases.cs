using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.GitFlow.Release.Aliases
{
    public static class GitFlowReleaseAliases
    {
        [CakeMethodAlias()]
        public static IGitFlowRunner GitFlowShotGitVersion(
            this ICakeContext context,
            GitFlowRunnerSettings settings)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
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
