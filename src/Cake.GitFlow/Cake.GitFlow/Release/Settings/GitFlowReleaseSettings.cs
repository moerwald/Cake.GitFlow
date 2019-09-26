using Cake.Core.Tooling;

namespace Cake.GitFlow.Release.Settings
{
    /// <summary>
    /// Settings for creating a new GitFlow release. Supported settings are:
    /// - Create a new release branch, where the name of the release branch follows the syntax
    ///   release_Major.Minor.Bugfix. Per default the minor version gets increased based on the
    ///   latest tag. The user may decide to increase other digits.
    /// - Create a new release WITHOUT creating a new release branch. Which means that the development
    ///   branch is directly merged to the master branch. Afterwards a tag with Major.Minor.Bugfix is created.
    /// - Settings a tag prefix.
    /// </summary>
    public abstract class GitFlowReleaseSettings : ToolSettings
    {
        public VersionIncrement VersionDigitToIncrement { get; set; } = new VersionIncrement();

        protected ReleaseBranchBehaviour ReleaseBranchBehaviour { get; set; } = new ReleaseBranchBehaviour();

        public string TagPrefix { get; set; } = string.Empty;
    }
}
