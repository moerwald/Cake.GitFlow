#reference "..\..\..\src\Cake.GitFlow\Cake.GitFlow\bin\Debug\netstandard2.0\Cake.GitFlow.dll"
// ARGUMENTS
var target = Argument("target", "Default");
var slnFile = @"..\src\Cake.GitFlow\Cake.GitFlow.sln";

// TASKS

Task("Default")
    .Does(() =>
{
    GitFlowShotGitVersion();
});

/* 
Task("CreateNewRelease")
    .Does(() =>{
        GitFlowNewRelease(new GitFlowReleaseSettings{});


    });
    */

// EXECUTION
RunTarget(target);
