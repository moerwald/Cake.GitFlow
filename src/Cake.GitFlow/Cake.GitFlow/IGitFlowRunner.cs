
namespace Cake.GitFlow
{
    using System;

    /// <summary>
    /// Defines commands that will run from the Cake script
    /// </summary>
    public interface IGitFlowRunner
    {
        IGitFlowRunner Run(Action<GitFlowRunnerSettings> configure = null);
        IGitFlowRunner Run(GitFlowRunnerSettings settings);
    }
}
