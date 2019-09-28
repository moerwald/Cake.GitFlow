
namespace Cake.GitFlow
{
    using Cake.Core;
    using Cake.Core.Diagnostics;
    using Cake.Core.IO;
    using Cake.Core.Tooling;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GitFlowRunner : Tool<GitFlowRunnerSettings>, IGitFlowRunner
    {
        private readonly ICakeContext context;
        private readonly ICakeLog log;

        public GitFlowRunner(ICakeContext context)
            :base(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.log = context.Log;
        }

        protected override IEnumerable<string> GetToolExecutableNames() => new List<string> { "Git.exe", "git.exe" };

        protected override string GetToolName() => "GitFlow";

        protected static ProcessArgumentBuilder GetSettingsArguments (GitFlowRunnerSettings settings)
        {
            var args = new ProcessArgumentBuilder();
            settings?.Evaluate(args);
            return args;
        }

        public IGitFlowRunner Run(Action<GitFlowRunnerSettings> configure = null)
        {
            var settings = new GitFlowRunnerSettings();
            configure?.Invoke(settings);
            return Run(settings);
        }

        public IGitFlowRunner Run(GitFlowRunnerSettings settings)
        {
            var args = GetSettingsArguments(settings);
            Run(settings, args);
            return this;
        }

        public IGitFlowRunner Run(IEnumerable<string> args)
        {
             var pab = new ProcessArgumentBuilder ();
             args.Select(a => pab.Append(a));
             
             Run(new GitFlowRunnerSettings(), pab);
             return this;
        }
    }
}
