
namespace Cake.GitFlow.Release.Settings
{
    using System;

    public class ReleaseBranchBehaviour
    {
        public bool CreateNewReleaseBranch { get; set; } = false;
        public bool AutomaticallyMergeReleaseBranch { get; set; } = true;
        public Action ActionToPerformOnReleaseBranch { get; set; } = DoNothing;
        public static void DoNothing() { }
    }
}
