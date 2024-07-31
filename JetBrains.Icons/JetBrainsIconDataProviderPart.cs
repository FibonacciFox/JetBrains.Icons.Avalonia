using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace JetBrains.Icons
{
    public partial class JetBrainsIconDataProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual partial List<JetBrainsIconData> ProvideData(JetBrainsIconKind kind)
        {
            return kind switch
            {
                JetBrainsIconKind.Add => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Add.svg")
                },
                JetBrainsIconKind.AddDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/AddDark.svg")
                },
                JetBrainsIconKind.Ant => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Ant.svg")
                },
                JetBrainsIconKind.AntDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/AntDark.svg")
                },
                JetBrainsIconKind.AutoscrollFromSource => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/AutoscrollFromSource.svg")
                },
                JetBrainsIconKind.AutoscrollFromSourceDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/AutoscrollFromSourceDark.svg")
                },
                JetBrainsIconKind.AutoscrollToSource => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/AutoscrollToSource.svg")
                },
                JetBrainsIconKind.AutoscrollToSourceDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/AutoscrollToSourceDark.svg")
                },
                JetBrainsIconKind.AwsGlue => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/AwsGlue.svg")
                },
                JetBrainsIconKind.AwsGlueDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/AwsGlueDark.svg")
                },
                JetBrainsIconKind.Bookmarks => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Bookmarks.svg")
                },
                JetBrainsIconKind.BookmarksDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/BookmarksDark.svg")
                },
                JetBrainsIconKind.Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Build.svg")
                },
                JetBrainsIconKind.BuildDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/BuildDark.svg")
                },
                JetBrainsIconKind.BuildServerProtocol => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/BuildServerProtocol.svg")
                },
                JetBrainsIconKind.BuildServerProtocolDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/BuildServerProtocolDark.svg")
                },
                JetBrainsIconKind.Changes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Changes.svg")
                },
                JetBrainsIconKind.ChangesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ChangesDark.svg")
                },
                JetBrainsIconKind.Checkmark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Checkmark.svg")
                },
                JetBrainsIconKind.CheckmarkDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CheckmarkDark.svg")
                },
                JetBrainsIconKind.ChevronDown => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronDown.svg")
                },
                JetBrainsIconKind.ChevronDownDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronDownDark.svg")
                },
                JetBrainsIconKind.ChevronDownLarge => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronDownLarge.svg")
                },
                JetBrainsIconKind.ChevronDownLargeDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronDownLargeDark.svg")
                },
                JetBrainsIconKind.ChevronLeft => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronLeft.svg")
                },
                JetBrainsIconKind.ChevronLeftDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronLeftDark.svg")
                },
                JetBrainsIconKind.ChevronRight => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronRight.svg")
                },
                JetBrainsIconKind.ChevronRightDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronRightDark.svg")
                },
                JetBrainsIconKind.ChevronUp => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronUp.svg")
                },
                JetBrainsIconKind.ChevronUpDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronUpDark.svg")
                },
                JetBrainsIconKind.ChevronUpLarge => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronUpLarge.svg")
                },
                JetBrainsIconKind.ChevronUpLargeDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ChevronUpLargeDark.svg")
                },
                JetBrainsIconKind.Close => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Close.svg")
                },
                JetBrainsIconKind.CloseDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CloseDark.svg")
                },
                JetBrainsIconKind.CloseSmall => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CloseSmall.svg")
                },
                JetBrainsIconKind.CloseSmallDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CloseSmallDark.svg")
                },
                JetBrainsIconKind.CloseSmallHovered => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CloseSmallHovered.svg")
                },
                JetBrainsIconKind.CloseSmallHoveredDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CloseSmallHoveredDark.svg")
                },
                JetBrainsIconKind.CMakeToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CMakeToolWindow.svg")
                },
                JetBrainsIconKind.CMakeToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CMakeToolWindowDark.svg")
                },
                JetBrainsIconKind.CollapseAll => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CollapseAll.svg")
                },
                JetBrainsIconKind.CollapseAllDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CollapseAllDark.svg")
                },
                JetBrainsIconKind.Commit => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Commit.svg")
                },
                JetBrainsIconKind.CommitDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CommitDark.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindow.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindowDark.svg")
                },
                JetBrainsIconKind.Copy => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Copy.svg")
                },
                JetBrainsIconKind.CopyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CopyDark.svg")
                },
                JetBrainsIconKind.Coverage => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Coverage.svg")
                },
                JetBrainsIconKind.CoverageDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CoverageDark.svg")
                },
                JetBrainsIconKind.Cut => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Cut.svg")
                },
                JetBrainsIconKind.CutDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/CutDark.svg")
                },
                JetBrainsIconKind.CwmAccess => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CwmAccess.svg")
                },
                JetBrainsIconKind.CwmAccessDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CwmAccessDark.svg")
                },
                JetBrainsIconKind.CwmUsers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CwmUsers.svg")
                },
                JetBrainsIconKind.CwmUsersDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/CwmUsersDark.svg")
                },
                JetBrainsIconKind.DatabaseChanges => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DatabaseChanges.svg")
                },
                JetBrainsIconKind.DatabaseChangesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DatabaseChangesDark.svg")
                },
                JetBrainsIconKind.DataprocToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DataprocToolWindow.svg")
                },
                JetBrainsIconKind.DataprocToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DataprocToolWindowDark.svg")
                },
                JetBrainsIconKind.Dbms => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Dbms.svg")
                },
                JetBrainsIconKind.DbmsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DbmsDark.svg")
                },
                JetBrainsIconKind.Debug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Debug.svg")
                },
                JetBrainsIconKind.DebugDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DebugDark.svg")
                },
                JetBrainsIconKind.Delete => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Delete.svg")
                },
                JetBrainsIconKind.DeleteDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/DeleteDark.svg")
                },
                JetBrainsIconKind.Dependencies => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Dependencies.svg")
                },
                JetBrainsIconKind.DependenciesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DependenciesDark.svg")
                },
                JetBrainsIconKind.Documentation => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Documentation.svg")
                },
                JetBrainsIconKind.DocumentationDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DocumentationDark.svg")
                },
                JetBrainsIconKind.Donate => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Donate.svg")
                },
                JetBrainsIconKind.DonateDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/DonateDark.svg")
                },
                JetBrainsIconKind.Down => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Down.svg")
                },
                JetBrainsIconKind.DownDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/DownDark.svg")
                },
                JetBrainsIconKind.Download => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Download.svg")
                },
                JetBrainsIconKind.DownloadDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/DownloadDark.svg")
                },
                JetBrainsIconKind.Edit => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Edit.svg")
                },
                JetBrainsIconKind.EditDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/EditDark.svg")
                },
                JetBrainsIconKind.Endpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Endpoints.svg")
                },
                JetBrainsIconKind.EndpointsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/EndpointsDark.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ExceptionAnalyzer.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzerDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ExceptionAnalyzerDark.svg")
                },
                JetBrainsIconKind.Exit => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Exit.svg")
                },
                JetBrainsIconKind.ExitDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExitDark.svg")
                },
                JetBrainsIconKind.ExpandAll => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExpandAll.svg")
                },
                JetBrainsIconKind.ExpandAllDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExpandAllDark.svg")
                },
                JetBrainsIconKind.Export => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Export.svg")
                },
                JetBrainsIconKind.ExportDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExportDark.svg")
                },
                JetBrainsIconKind.ExternalLink => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExternalLink.svg")
                },
                JetBrainsIconKind.ExternalLinkDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ExternalLinkDark.svg")
                },
                JetBrainsIconKind.Filter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Filter.svg")
                },
                JetBrainsIconKind.FilterDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/FilterDark.svg")
                },
                JetBrainsIconKind.Find => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Find.svg")
                },
                JetBrainsIconKind.FindDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/FindDark.svg")
                },
                JetBrainsIconKind.FindExternalUsages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/FindExternalUsages.svg")
                },
                JetBrainsIconKind.FindExternalUsagesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/FindExternalUsagesDark.svg")
                },
                JetBrainsIconKind.Gitlab => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Gitlab.svg")
                },
                JetBrainsIconKind.GitlabDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/GitlabDark.svg")
                },
                JetBrainsIconKind.Gradle => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Gradle.svg")
                },
                JetBrainsIconKind.GradleDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/GradleDark.svg")
                },
                JetBrainsIconKind.Groups => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Groups.svg")
                },
                JetBrainsIconKind.GroupsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/GroupsDark.svg")
                },
                JetBrainsIconKind.Help => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Help.svg")
                },
                JetBrainsIconKind.HelpDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/HelpDark.svg")
                },
                JetBrainsIconKind.Hide => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Hide.svg")
                },
                JetBrainsIconKind.HideDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/HideDark.svg")
                },
                JetBrainsIconKind.Hierarchy => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Hierarchy.svg")
                },
                JetBrainsIconKind.HierarchyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/HierarchyDark.svg")
                },
                JetBrainsIconKind.History => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/History.svg")
                },
                JetBrainsIconKind.HistoryDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/HistoryDark.svg")
                },
                JetBrainsIconKind.Hive => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Hive.svg")
                },
                JetBrainsIconKind.HiveDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/HiveDark.svg")
                },
                JetBrainsIconKind.IdeUpdate => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/IdeUpdate.svg")
                },
                JetBrainsIconKind.IdeUpdateDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/IdeUpdateDark.svg")
                },
                JetBrainsIconKind.Import => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Import.svg")
                },
                JetBrainsIconKind.ImportDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ImportDark.svg")
                },
                JetBrainsIconKind.JupyterToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/JupyterToolWindow.svg")
                },
                JetBrainsIconKind.JupyterToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/JupyterToolWindowDark.svg")
                },
                JetBrainsIconKind.Kafka => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Kafka.svg")
                },
                JetBrainsIconKind.KafkaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/KafkaDark.svg")
                },
                JetBrainsIconKind.KotlinToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/KotlinToolWindow.svg")
                },
                JetBrainsIconKind.KotlinToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/KotlinToolWindowDark.svg")
                },
                JetBrainsIconKind.Layout => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Layout.svg")
                },
                JetBrainsIconKind.LayoutDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/LayoutDark.svg")
                },
                JetBrainsIconKind.Learn => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Learn.svg")
                },
                JetBrainsIconKind.LearnDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/LearnDark.svg")
                },
                JetBrainsIconKind.Left => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Left.svg")
                },
                JetBrainsIconKind.LeftDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/LeftDark.svg")
                },
                JetBrainsIconKind.ListFiles => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ListFiles.svg")
                },
                JetBrainsIconKind.ListFilesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ListFilesDark.svg")
                },
                JetBrainsIconKind.Locate => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Locate.svg")
                },
                JetBrainsIconKind.LocateDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/LocateDark.svg")
                },
                JetBrainsIconKind.Locked => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Locked.svg")
                },
                JetBrainsIconKind.LockedDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/LockedDark.svg")
                },
                JetBrainsIconKind.MakefileToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/MakefileToolWindow.svg")
                },
                JetBrainsIconKind.MakefileToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/MakefileToolWindowDark.svg")
                },
                JetBrainsIconKind.Maven => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Maven.svg")
                },
                JetBrainsIconKind.MavenDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/MavenDark.svg")
                },
                JetBrainsIconKind.Messages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Messages.svg")
                },
                JetBrainsIconKind.MessagesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/MessagesDark.svg")
                },
                JetBrainsIconKind.MoreHorizontal => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoreHorizontal.svg")
                },
                JetBrainsIconKind.MoreHorizontalDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoreHorizontalDark.svg")
                },
                JetBrainsIconKind.MoreVertical => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoreVertical.svg")
                },
                JetBrainsIconKind.MoreVerticalDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoreVerticalDark.svg")
                },
                JetBrainsIconKind.MoveDown => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoveDown.svg")
                },
                JetBrainsIconKind.MoveDownDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoveDownDark.svg")
                },
                JetBrainsIconKind.MoveUp => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoveUp.svg")
                },
                JetBrainsIconKind.MoveUpDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/MoveUpDark.svg")
                },
                JetBrainsIconKind.NewUI => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/NewUI.svg")
                },
                JetBrainsIconKind.NewUIDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/NewUIDark.svg")
                },
                JetBrainsIconKind.Notifications => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Notifications.svg")
                },
                JetBrainsIconKind.NotificationsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/NotificationsDark.svg")
                },
                JetBrainsIconKind.Npm => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Npm.svg")
                },
                JetBrainsIconKind.NpmDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/NpmDark.svg")
                },
                JetBrainsIconKind.Open => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Open.svg")
                },
                JetBrainsIconKind.OpenDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/OpenDark.svg")
                },
                JetBrainsIconKind.OpenInToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/OpenInToolWindow.svg")
                },
                JetBrainsIconKind.OpenInToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/OpenInToolWindowDark.svg")
                },
                JetBrainsIconKind.OpenNewTab => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/OpenNewTab.svg")
                },
                JetBrainsIconKind.OpenNewTabDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/OpenNewTabDark.svg")
                },
                JetBrainsIconKind.PackageManager => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PackageManager.svg")
                },
                JetBrainsIconKind.PackageManagerDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PackageManagerDark.svg")
                },
                JetBrainsIconKind.Pagination => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Pagination.svg")
                },
                JetBrainsIconKind.PaginationDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PaginationDark.svg")
                },
                JetBrainsIconKind.Paste => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Paste.svg")
                },
                JetBrainsIconKind.PasteDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PasteDark.svg")
                },
                JetBrainsIconKind.Pin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Pin.svg")
                },
                JetBrainsIconKind.PinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PinDark.svg")
                },
                JetBrainsIconKind.PluginUpdate => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PluginUpdate.svg")
                },
                JetBrainsIconKind.PluginUpdateDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PluginUpdateDark.svg")
                },
                JetBrainsIconKind.PreviewHorizontally => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PreviewHorizontally.svg")
                },
                JetBrainsIconKind.PreviewHorizontallyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PreviewHorizontallyDark.svg")
                },
                JetBrainsIconKind.PreviewVertically => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PreviewVertically.svg")
                },
                JetBrainsIconKind.PreviewVerticallyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PreviewVerticallyDark.svg")
                },
                JetBrainsIconKind.Print => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Print.svg")
                },
                JetBrainsIconKind.PrintDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/PrintDark.svg")
                },
                JetBrainsIconKind.Problems => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Problems.svg")
                },
                JetBrainsIconKind.ProblemsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ProblemsDark.svg")
                },
                JetBrainsIconKind.Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Profiler.svg")
                },
                JetBrainsIconKind.ProfilerDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ProfilerDark.svg")
                },
                JetBrainsIconKind.Project => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Project.svg")
                },
                JetBrainsIconKind.ProjectDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ProjectDark.svg")
                },
                JetBrainsIconKind.ProjectStructure => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectStructure.svg")
                },
                JetBrainsIconKind.ProjectStructureDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectStructureDark.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOff => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectWideAnalysisOff.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOffDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectWideAnalysisOffDark.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOn => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectWideAnalysisOn.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOnDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ProjectWideAnalysisOnDark.svg")
                },
                JetBrainsIconKind.PullRequests => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PullRequests.svg")
                },
                JetBrainsIconKind.PullRequestsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PullRequestsDark.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PythonConsoleToolWindow.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/PythonConsoleToolWindowDark.svg")
                },
                JetBrainsIconKind.Redo => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Redo.svg")
                },
                JetBrainsIconKind.RedoDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RedoDark.svg")
                },
                JetBrainsIconKind.Refresh => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Refresh.svg")
                },
                JetBrainsIconKind.RefreshDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RefreshDark.svg")
                },
                JetBrainsIconKind.Remove => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Remove.svg")
                },
                JetBrainsIconKind.RemoveDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RemoveDark.svg")
                },
                JetBrainsIconKind.Repositories => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Repositories.svg")
                },
                JetBrainsIconKind.RepositoriesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/RepositoriesDark.svg")
                },
                JetBrainsIconKind.Right => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Right.svg")
                },
                JetBrainsIconKind.RightDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RightDark.svg")
                },
                JetBrainsIconKind.Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Run.svg")
                },
                JetBrainsIconKind.RunAnything => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RunAnything.svg")
                },
                JetBrainsIconKind.RunAnythingDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/RunAnythingDark.svg")
                },
                JetBrainsIconKind.RunDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/RunDark.svg")
                },
                JetBrainsIconKind.Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Rust.svg")
                },
                JetBrainsIconKind.RustDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/RustDark.svg")
                },
                JetBrainsIconKind.Save => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Save.svg")
                },
                JetBrainsIconKind.SaveDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SaveDark.svg")
                },
                JetBrainsIconKind.SbtIcon => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SbtIcon.svg")
                },
                JetBrainsIconKind.SbtIconDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SbtIconDark.svg")
                },
                JetBrainsIconKind.SbtShell => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SbtShell.svg")
                },
                JetBrainsIconKind.SbtShellDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SbtShellDark.svg")
                },
                JetBrainsIconKind.SciView => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SciView.svg")
                },
                JetBrainsIconKind.SciViewDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SciViewDark.svg")
                },
                JetBrainsIconKind.ScrollDown => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ScrollDown.svg")
                },
                JetBrainsIconKind.ScrollDownDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ScrollDownDark.svg")
                },
                JetBrainsIconKind.Search => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Search.svg")
                },
                JetBrainsIconKind.SearchDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SearchDark.svg")
                },
                JetBrainsIconKind.Services => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Services.svg")
                },
                JetBrainsIconKind.ServicesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/ServicesDark.svg")
                },
                JetBrainsIconKind.Settings => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Settings.svg")
                },
                JetBrainsIconKind.SettingsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SettingsDark.svg")
                },
                JetBrainsIconKind.SettingSyncDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SettingSyncDark.svg")
                },
                JetBrainsIconKind.Show => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Show.svg")
                },
                JetBrainsIconKind.ShowAsTree => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ShowAsTree.svg")
                },
                JetBrainsIconKind.ShowAsTreeDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ShowAsTreeDark.svg")
                },
                JetBrainsIconKind.ShowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/ShowDark.svg")
                },
                JetBrainsIconKind.SoftWrap => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SoftWrap.svg")
                },
                JetBrainsIconKind.SoftWrapDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SoftWrapDark.svg")
                },
                JetBrainsIconKind.SortAlphabetically => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortAlphabetically.svg")
                },
                JetBrainsIconKind.SortAlphabeticallyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortAlphabeticallyDark.svg")
                },
                JetBrainsIconKind.SortBy => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortBy.svg")
                },
                JetBrainsIconKind.SortByDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByDark.svg")
                },
                JetBrainsIconKind.SortByDuration => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByDuration.svg")
                },
                JetBrainsIconKind.SortByDurationDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByDurationDark.svg")
                },
                JetBrainsIconKind.SortByType => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByType.svg")
                },
                JetBrainsIconKind.SortByTypeDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByTypeDark.svg")
                },
                JetBrainsIconKind.SortByUsage => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByUsage.svg")
                },
                JetBrainsIconKind.SortByUsageDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByUsageDark.svg")
                },
                JetBrainsIconKind.SortByVisibility => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByVisibility.svg")
                },
                JetBrainsIconKind.SortByVisibilityDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SortByVisibilityDark.svg")
                },
                JetBrainsIconKind.SpaceToolWindow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SpaceToolWindow.svg")
                },
                JetBrainsIconKind.SpaceToolWindowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SpaceToolWindowDark.svg")
                },
                JetBrainsIconKind.SplitHorizontally => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SplitHorizontally.svg")
                },
                JetBrainsIconKind.SplitHorizontallyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SplitHorizontallyDark.svg")
                },
                JetBrainsIconKind.SplitVertically => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SplitVertically.svg")
                },
                JetBrainsIconKind.SplitVerticallyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/SplitVerticallyDark.svg")
                },
                JetBrainsIconKind.Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Spring.svg")
                },
                JetBrainsIconKind.SpringDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/SpringDark.svg")
                },
                JetBrainsIconKind.Structure => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Structure.svg")
                },
                JetBrainsIconKind.StructureDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/StructureDark.svg")
                },
                JetBrainsIconKind.Task => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Task.svg")
                },
                JetBrainsIconKind.TaskDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/TaskDark.svg")
                },
                JetBrainsIconKind.Terminal => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Terminal.svg")
                },
                JetBrainsIconKind.TerminalDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/TerminalDark.svg")
                },
                JetBrainsIconKind.Todo => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Todo.svg")
                },
                JetBrainsIconKind.TodoDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/TodoDark.svg")
                },
                JetBrainsIconKind.Transfer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Transfer.svg")
                },
                JetBrainsIconKind.TransferDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/TransferDark.svg")
                },
                JetBrainsIconKind.Undo => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Undo.svg")
                },
                JetBrainsIconKind.UndoDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/UndoDark.svg")
                },
                JetBrainsIconKind.Unknown => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Unknown.svg")
                },
                JetBrainsIconKind.UnknownDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/UnknownDark.svg")
                },
                JetBrainsIconKind.Unlocked => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Unlocked.svg")
                },
                JetBrainsIconKind.UnlockedDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/UnlockedDark.svg")
                },
                JetBrainsIconKind.Up => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Up.svg")
                },
                JetBrainsIconKind.UpDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/UpDark.svg")
                },
                JetBrainsIconKind.Upload => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Upload.svg")
                },
                JetBrainsIconKind.UploadDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/UploadDark.svg")
                },
                JetBrainsIconKind.Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/Vcs.svg")
                },
                JetBrainsIconKind.VcsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/VcsDark.svg")
                },
                JetBrainsIconKind.Web => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Web.svg")
                },
                JetBrainsIconKind.WebDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WebDark.svg")
                },
                JetBrainsIconKind.WebLocator => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WebLocator.svg")
                },
                JetBrainsIconKind.WebLocatorDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WebLocatorDark.svg")
                },
                JetBrainsIconKind.WebServer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WebServer.svg")
                },
                JetBrainsIconKind.WebServerDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WebServerDark.svg")
                },
                JetBrainsIconKind.WindowsMenu => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/WindowsMenu.svg")
                },
                JetBrainsIconKind.WindowsMenuDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/General/WindowsMenuDark.svg")
                },
                JetBrainsIconKind.Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/Writerside.svg")
                },
                JetBrainsIconKind.WritersideDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WritersideDark.svg")
                },
                JetBrainsIconKind.WritersidePreview => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WritersidePreview.svg")
                },
                JetBrainsIconKind.WritersidePreviewDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons/Assets/Icons/ToolWindows/WritersidePreviewDark.svg")
                },
                _ => new List<JetBrainsIconData>()
            };
        }
    }
}
