using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.PathConstruction;

[GitHubActions(
    "publish",
    GitHubActionsImage.WindowsLatest,
    OnPushTags = ["*"],
    ImportSecrets = new[] { nameof(NuGetApiKey) },
    InvokedTargets = new[] { nameof(Compile) }
)]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution]
    readonly Solution Solution;
    Project Project => Solution.AllProjects.FirstOrDefault(o => o.Name == "CTPFuture.Net");

    [Parameter]
    [Secret]
    readonly string NuGetApiKey;
    GitHubActions GitHubActions => GitHubActions.Instance;
    Target Clean =>
        _ =>
            _.Before(Restore)
                .Executes(() =>
                {
                    DotNetTasks.DotNetClean(s => s.SetProject(Project));
                });

    Target Restore =>
        _ =>
            _.Executes(() =>
            {
                DotNetTasks.DotNetRestore(s => s.SetProjectFile(Project));
            });

    Target Compile =>
        _ =>
            _.DependsOn(Restore)
                .Executes(() =>
                {
                    if (IsServerBuild && GitHubActions.Instance.RefType.Equals("tag", StringComparison.OrdinalIgnoreCase))
                    {
                        var tag = GitHubActions.Instance.Ref;
                        var version = tag.Substring(tag.LastIndexOf('/') + 1);
                        var outDir = Project.Directory / "bin" / Configuration;
                        outDir.CreateOrCleanDirectory();
                        DotNetTasks.DotNetBuild(s =>
                            s.SetProjectFile(Project)
                                .SetConfiguration(Configuration)
                                .SetOutputDirectory(outDir)
                                .SetProperty("Version", version)
                        );

                        var nupkg = outDir.GlobFiles("*.nupkg").First();
                        DotNetTasks.DotNetNuGetPush(s =>
                            s.SetTargetPath(nupkg).SetSource("https://api.nuget.org/v3/index.json").SetApiKey(NuGetApiKey)
                        );
                    }
                    else
                    {
                        DotNetTasks.DotNetBuild(s => s.SetProjectFile(Project).SetConfiguration(Configuration));
                    }
                });

}
