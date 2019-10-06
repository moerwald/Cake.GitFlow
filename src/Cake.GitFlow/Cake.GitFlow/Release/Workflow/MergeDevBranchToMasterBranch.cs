
namespace Cake.GitFlow.Release.Workflow
{
    using Cake.Core.Diagnostics;
    using System.Collections.Generic;

    internal class MergeDevBranchToMasterBranch
    {
        public MergeDevBranchToMasterBranch(
            IGitFlowRunner runner,
            MergeInformation mergeInformation,
            ICakeLog log)
        {
            // Param checks
            Runner = runner ?? throw new System.ArgumentNullException(nameof(runner));
            MergeInformation = mergeInformation ?? throw new System.ArgumentNullException(nameof(mergeInformation));
            Log = log ?? throw new System.ArgumentNullException(nameof(log));
        }


        /// <summary>
        /// Needed to fire git commands
        /// </summary>
        public IGitFlowRunner Runner { get; }
        public MergeInformation MergeInformation { get; }
        public ICakeLog Log { get; }
        public string Version { get; private set; }

        public void MergeDevBranchToMaster()
        {
            Mwd.Exceptions.Boundary.CatchAll(() =>
            {
                var branchPrefix = MergeInformation.BranchPrefix;
                Log.Debug($"Checking out {branchPrefix}develop branch");
                Runner.Run(new List<string> { $"checkout {branchPrefix}develop" });

                Runner.Run(new List<string> { "pull" });

                Log.Debug($"Checking out {branchPrefix}master branch");
                Runner.Run(new List<string> { $"checkout {branchPrefix}master" });
                Runner.Run(new List<string> { "pull" });
                Log.Debug($"Merging {branchPrefix}develop in {branchPrefix}master branch");
                Runner.Run(new List<string> { $"merge {branchPrefix}develop" });

                // TODO: Check if we can inject commit message to git tag -a
                Runner.Run(new List<string> { $"tag {MergeInformation.NewVersion}" });
            }, ex => { });
        }
    }

}