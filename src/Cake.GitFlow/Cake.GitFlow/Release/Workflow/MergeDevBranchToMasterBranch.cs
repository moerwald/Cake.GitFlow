
namespace Cake.GitFlow.Release.Workflow
{
    using System.Collections.Generic;

    internal class MergeDevBranchToMasterBranch
    {
        public MergeDevBranchToMasterBranch(IGitFlowRunner runner, IFetchNextVersion fetchVersion)
        {
            // Param checks
            if (runner is null) { throw new System.ArgumentNullException(nameof(runner)); }
            if (fetchVersion is null) { throw new System.ArgumentNullException(nameof(fetchVersion)); }

            Runner = runner;
            FetchVersion = fetchVersion;
        }


        /// <summary>
        /// Needed to fire git commands
        /// </summary>
        public IGitFlowRunner Runner { get; }

        /// <summary>
        /// Needed to get next version to GIT tag creation
        /// </summary>
        public IFetchNextVersion FetchVersion { get; }

        public string Version { get; private set; }

        public void CalculateVersion() => Version = FetchVersion.GetNextVersion();

        public void MergeDevBranchToMaster()
        {
            Runner.Run(new List<string> { "checkout develop" });
            Runner.Run(new List<string> { "pull" });

            Runner.Run(new List<string> { "checkout master" });
            Runner.Run(new List<string> { "pull" });
            Runner.Run(new List<string> { "merge develop" });

            // TODO: Check if we can inject commit message to git tag -a
            Runner.Run(new List<string> { $"tag {FetchVersion.GetNextVersion()}" });
        }
    }

}