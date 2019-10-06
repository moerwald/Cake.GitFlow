
namespace Cake.GitFlow.Release.Aliases
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using Cake.GitFlow.Release.Settings;
    using System;
using  Cake.GitFlow.Release.Workflow;

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

            var runner = new GitFlowRunner(context);

            switch (settings)
            {
                case MergeDevBranchToMaster mergeToMaser:
                    var wf = new MergeDevBranchToMasterBranch(
                        runner,
                        new MergeInformation(settings.NewVersion, "", branchPrefix: settings.BranchPrefix),
                        context.Log);
                    wf.MergeDevBranchToMaster();
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
            return runner;
        }
    }
}
