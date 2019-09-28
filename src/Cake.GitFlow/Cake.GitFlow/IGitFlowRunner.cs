
namespace Cake.GitFlow
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Defines commands that will run from the Cake script
    /// </summary>
    public interface IGitFlowRunner
    {
        IGitFlowRunner Run(Action<GitFlowRunnerSettings> configure = null);
        IGitFlowRunner Run(GitFlowRunnerSettings settings);
        IGitFlowRunner Run(IEnumerable<string> args);
    }
}
