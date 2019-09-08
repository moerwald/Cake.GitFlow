
namespace Cake.GitFlow
{
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Core.Tooling;
using System;
using System.Collections.Generic;
using System.Text;

    class GitFlowRunner : Tool<GitFlowRunnerSettings>, IGitFlowRunner
    {
        public GitFlowRunner(
            IFileSystem fileSystem,
            ICakeEnvironment environment,
            IProcessRunner processRunner,
            IToolLocator tools)
            :base(fileSystem, environment, processRunner, tools)
        {
        }

        protected override IEnumerable<string> GetToolExecutableNames() => new List<string> { "Git.exe", "git.exe" };

        protected override string GetToolName() => "GitFlow";
    }
}
