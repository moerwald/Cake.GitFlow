using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.GitFlow.Aliases
{
    public static class GitFlowRunnerAliases
    {
        [CakeMethodAlias()]
        public static IGitFlowRunner GitFlowShotGitVersion(
            this ICakeContext context)
        {
            if (context is null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var runner = new GitFlowRunner(context);
            runner.Run(new GitFlowRunnerSettings { Version = true });
            return runner;
        }
    }
}
