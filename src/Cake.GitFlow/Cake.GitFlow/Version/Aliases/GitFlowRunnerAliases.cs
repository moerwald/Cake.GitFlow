
namespace Cake.GitFlow.Version.Aliases
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using Cake.GitFlow.Version.Settings;
    using System;

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
            runner.Run(new VersionSettings { Version = true });
            return runner;
        }
    }
}
