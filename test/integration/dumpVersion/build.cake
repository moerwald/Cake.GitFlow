#reference "..\..\src\Cake.GitFlow\Cake.GitFlow\bin\Debug\netstandard2.0\Cake.GitFlow.dll"
// ARGUMENTS
var target = Argument("target", "Default");
var newGitTagVersion = Argument("newGitTagVersion", null);

// TASKS

Task("Default")
    .Does(() =>
{
    GitFlowShotGitVersion();
});

Task("MergeDevBranchToMasterAndCreateGitTag")
    .Does(() =>{
        GitFlowNewRelease(
            new MergeDevBranchToMaster
            {
                NewVersion = newGitTagVersion
            });
    });

// EXECUTION
RunTarget(target);
