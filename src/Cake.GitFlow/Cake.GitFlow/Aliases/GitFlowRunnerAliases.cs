using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.GitFlow.Aliases
{
    public static class GitFlowRunnerAliases
    {
        [CakeMethodAlias()]
        public static IGitFlowRunner Release (this ICakeContext context, Action<GitFlowRunnerSettings> action = null)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var runner = new GitFlowRunner(context);
            runner.Run(action);
            return runner;
        }
    }
}
