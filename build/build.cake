// ARGUMENTS
var target = Argument("target", "Default");
var slnFile = @"..\src\Cake.GitFlow\Cake.GitFlow.sln";

// TASKS
Task("Restore-NuGet-Packages")
    .Does(() =>
{
    NuGetRestore(slnFile);
});

Task("Build")
    .IsDependentOn("Restore-NuGet-Packages")
    .Does(() =>
{
      MSBuild(slnFile, settings =>
        settings.SetConfiguration("Release"));

});

// TASK TARGETS
Task("Default").IsDependentOn("Build");

// EXECUTION
RunTarget(target);
