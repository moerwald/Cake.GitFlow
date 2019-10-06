
namespace Cake.GitFlow.Release.Workflow
{
    using System;

    public class MergeInformation
    {

        public MergeInformation(
            string newVersion,
            string commitMessageUseForTagging,
            string branchPrefix = "")
        {
            CheckAndAssign(newVersion, nameof(newVersion), s => NewVersion = s);
            CheckAndAssign(commitMessageUseForTagging, nameof(commitMessageUseForTagging),
                s => CommitMessageUseForTagging = s);
            CheckAndAssign(branchPrefix, nameof(branchPrefix),
                s => BranchPrefix = !string.IsNullOrEmpty(s) ? $"{BranchPrefix}/" : s);

            void CheckAndAssign(string str, string paramName, Action<string> action)
            {
                if (string.IsNullOrWhiteSpace(str))
                {
                    throw new ArgumentException("Argument is null or whitespace", paramName);
                }
                action(str);
            }
        }

        public string NewVersion { get; private set; }
        public string BranchPrefix { get; private set; }
        public string CommitMessageUseForTagging { get; private set; }
    }
}
