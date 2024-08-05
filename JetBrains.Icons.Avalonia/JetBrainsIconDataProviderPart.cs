using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Icons.Avalonia;

namespace JetBrains.Icons.Avalonia
{
    public partial class JetBrainsIconDataProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual partial List<JetBrainsIconData> ProvideData(JetBrainsIconKind kind)
        {
            return kind switch
            {
                JetBrainsIconKind.AddFile_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/AddFile_Actions.svg")
                },
                JetBrainsIconKind.AddFileDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/AddFileDark_Actions.svg")
                },
                JetBrainsIconKind.СodeAssistantClass_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantClass_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantClassDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantClassDark_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantClassExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantClassExtension_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantClassExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantClassExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMacro_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMacro_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMacroDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMacroDark_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMember_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMember_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMemberDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMemberDark_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMemberOptional_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMemberOptional_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantMemberOptionalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantMemberOptionalDark_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantNamespace_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantNamespace_Cidr.svg")
                },
                JetBrainsIconKind.СodeAssistantNamespaceDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СodeAssistantNamespaceDark_Cidr.svg")
                },
                JetBrainsIconKind.СoreDumpDebug_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СoreDumpDebug_Cidr.svg")
                },
                JetBrainsIconKind.СoreDumpDebugDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/СoreDumpDebugDark_Cidr.svg")
                },
                JetBrainsIconKind.AbstractBean_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/AbstractBean_Spring.svg")
                },
                JetBrainsIconKind.AbstractBeanDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/AbstractBeanDark_Spring.svg")
                },
                JetBrainsIconKind.AbstractClassKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AbstractClassKotlin.svg")
                },
                JetBrainsIconKind.AbstractClassKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AbstractClassKotlinDark.svg")
                },
                JetBrainsIconKind.AbstractClassObjectScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractClassObjectScala.svg")
                },
                JetBrainsIconKind.AbstractClassObjectScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractClassObjectScalaDark.svg")
                },
                JetBrainsIconKind.AbstractClassScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractClassScala.svg")
                },
                JetBrainsIconKind.AbstractClassScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractClassScalaDark.svg")
                },
                JetBrainsIconKind.AbstractConst_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractConst_Rust.svg")
                },
                JetBrainsIconKind.AbstractConstDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractConstDark_Rust.svg")
                },
                JetBrainsIconKind.AbstractException_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AbstractException_Nodes.svg")
                },
                JetBrainsIconKind.AbstractExceptionDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AbstractExceptionDark_Nodes.svg")
                },
                JetBrainsIconKind.AbstractExtensionFunction_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AbstractExtensionFunction_Kotlin.svg")
                },
                JetBrainsIconKind.AbstractExtensionFunctionDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AbstractExtensionFunctionDark_Kotlin.svg")
                },
                JetBrainsIconKind.AbstractFieldVariable_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractFieldVariable_Scala.svg")
                },
                JetBrainsIconKind.AbstractFieldVariable1_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractFieldVariable1_Scala.svg")
                },
                JetBrainsIconKind.AbstractFieldVariable1Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractFieldVariable1Dark_Scala.svg")
                },
                JetBrainsIconKind.AbstractFieldVariableDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractFieldVariableDark_Scala.svg")
                },
                JetBrainsIconKind.AbstractFunction_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractFunction_Rust.svg")
                },
                JetBrainsIconKind.AbstractFunctionDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractFunctionDark_Rust.svg")
                },
                JetBrainsIconKind.AbstractMethod_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractMethod_Rust.svg")
                },
                JetBrainsIconKind.AbstractMethodDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractMethodDark_Rust.svg")
                },
                JetBrainsIconKind.AbstractTypeAlias_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractTypeAlias_Rust.svg")
                },
                JetBrainsIconKind.AbstractTypeAlias_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractTypeAlias_Scala.svg")
                },
                JetBrainsIconKind.AbstractTypeAliasDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/AbstractTypeAliasDark_Rust.svg")
                },
                JetBrainsIconKind.AbstractTypeAliasDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AbstractTypeAliasDark_Scala.svg")
                },
                JetBrainsIconKind.AccessMethod_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/AccessMethod_Database.svg")
                },
                JetBrainsIconKind.AccessMethodDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/AccessMethodDark_Database.svg")
                },
                JetBrainsIconKind.ActionMethod_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ActionMethod_Ruby.svg")
                },
                JetBrainsIconKind.ActionMethod14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ActionMethod@14x14_Ruby.svg")
                },
                JetBrainsIconKind.ActionMethod14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ActionMethod@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.ActionMethodDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ActionMethodDark_Ruby.svg")
                },
                JetBrainsIconKind.ActionQualifiedNames_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ActionQualifiedNames_Cidr.svg")
                },
                JetBrainsIconKind.ActionQualifiedNamesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ActionQualifiedNamesDark_Cidr.svg")
                },
                JetBrainsIconKind.ActionScript_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/ActionScript_FilesNodes.svg")
                },
                JetBrainsIconKind.ActionScriptDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/ActionScriptDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Actual_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Actual_Kotlin.svg")
                },
                JetBrainsIconKind.ActualDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ActualDark_Kotlin.svg")
                },
                JetBrainsIconKind.ActualZoom_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ActualZoom_Image.svg")
                },
                JetBrainsIconKind.ActualZoomDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ActualZoomDark_Image.svg")
                },
                JetBrainsIconKind.AdapterScript_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/AdapterScript_Database.svg")
                },
                JetBrainsIconKind.AdapterScriptDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/AdapterScriptDark_Database.svg")
                },
                JetBrainsIconKind.Add_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Add_General.svg")
                },
                JetBrainsIconKind.AddBookmarksList => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/AddBookmarksList.svg")
                },
                JetBrainsIconKind.AddBookmarksListDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/AddBookmarksListDark.svg")
                },
                JetBrainsIconKind.AddClause_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AddClause_Scala.svg")
                },
                JetBrainsIconKind.AddClauseDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/AddClauseDark_Scala.svg")
                },
                JetBrainsIconKind.AddDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/AddDark_General.svg")
                },
                JetBrainsIconKind.AddEmoji_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/AddEmoji_Vcs.svg")
                },
                JetBrainsIconKind.AddEmojiDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/AddEmojiDark_Vcs.svg")
                },
                JetBrainsIconKind.AddExecutable_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddExecutable_Cidr.svg")
                },
                JetBrainsIconKind.AddExecutableDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddExecutableDark_Cidr.svg")
                },
                JetBrainsIconKind.AddLibrary_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddLibrary_Cidr.svg")
                },
                JetBrainsIconKind.AddLibraryDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddLibraryDark_Cidr.svg")
                },
                JetBrainsIconKind.AddModifier_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/AddModifier_Aqua.svg")
                },
                JetBrainsIconKind.AddModifierDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/AddModifierDark_Aqua.svg")
                },
                JetBrainsIconKind.AddTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddTest_Cidr.svg")
                },
                JetBrainsIconKind.AddTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AddTestDark_Cidr.svg")
                },
                JetBrainsIconKind.AddTypeSignature14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AddTypeSignature@14x14_Ruby.svg")
                },
                JetBrainsIconKind.AddTypeSignature14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AddTypeSignature@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.Aggregate_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Aggregate_Database.svg")
                },
                JetBrainsIconKind.AggregateDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/AggregateDark_Database.svg")
                },
                JetBrainsIconKind.Alias_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Alias_Nodes.svg")
                },
                JetBrainsIconKind.AliasDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AliasDark_Nodes.svg")
                },
                JetBrainsIconKind.AliasFactory_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AliasFactory_Ruby.svg")
                },
                JetBrainsIconKind.AliasFactoryDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AliasFactoryDark_Ruby.svg")
                },
                JetBrainsIconKind.AliasSequence_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AliasSequence_Ruby.svg")
                },
                JetBrainsIconKind.AliasSequenceDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AliasSequenceDark_Ruby.svg")
                },
                JetBrainsIconKind.Android_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Android_Kotlin.svg")
                },
                JetBrainsIconKind.AndroidDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AndroidDark_Kotlin.svg")
                },
                JetBrainsIconKind.AndroidDevice_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AndroidDevice_Cidr.svg")
                },
                JetBrainsIconKind.AndroidDeviceDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AndroidDeviceDark_Cidr.svg")
                },
                JetBrainsIconKind.AngularJS_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/AngularJS_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.AngularJSDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/AngularJSDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Annotation_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Annotation_Nodes.svg")
                },
                JetBrainsIconKind.AnnotationDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AnnotationDark_Nodes.svg")
                },
                JetBrainsIconKind.AnnotationFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AnnotationFolder_Nodes.svg")
                },
                JetBrainsIconKind.AnnotationFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/AnnotationFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.AnnotationKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AnnotationKotlin.svg")
                },
                JetBrainsIconKind.AnnotationKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/AnnotationKotlinDark.svg")
                },
                JetBrainsIconKind.Ant_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Ant_ToolWindows.svg")
                },
                JetBrainsIconKind.Ant20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Ant@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Ant20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Ant@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.AntDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/AntDark_ToolWindows.svg")
                },
                JetBrainsIconKind.AnyType_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/AnyType_FilesNodes.svg")
                },
                JetBrainsIconKind.AnyType14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AnyType@14x14_Ruby.svg")
                },
                JetBrainsIconKind.AnyType14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AnyType@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.AnyTypeDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/AnyTypeDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Apache_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Apache_Providers.svg")
                },
                JetBrainsIconKind.ApacheDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApacheDark_Providers.svg")
                },
                JetBrainsIconKind.ApacheDerby_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApacheDerby_Providers.svg")
                },
                JetBrainsIconKind.ApacheDerbyDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApacheDerbyDark_Providers.svg")
                },
                JetBrainsIconKind.ApacheIgnite_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApacheIgnite_Providers.svg")
                },
                JetBrainsIconKind.ApacheIgniteDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApacheIgniteDark_Providers.svg")
                },
                JetBrainsIconKind.ApachePhoenix_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApachePhoenix_Providers.svg")
                },
                JetBrainsIconKind.ApachePhoenixDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ApachePhoenixDark_Providers.svg")
                },
                JetBrainsIconKind.Api_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Api_FilesNodes.svg")
                },
                JetBrainsIconKind.ApiDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/ApiDark_FilesNodes.svg")
                },
                JetBrainsIconKind.AppCodeProject_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AppCodeProject_Cidr.svg")
                },
                JetBrainsIconKind.AppCodeProjectDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AppCodeProjectDark_Cidr.svg")
                },
                JetBrainsIconKind.AppCodeWorkspace_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AppCodeWorkspace_Cidr.svg")
                },
                JetBrainsIconKind.AppCodeWorkspaceDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AppCodeWorkspaceDark_Cidr.svg")
                },
                JetBrainsIconKind.AppEngineMark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/AppEngineMark_GoLang.svg")
                },
                JetBrainsIconKind.AppEngineMarkDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/AppEngineMarkDark_GoLang.svg")
                },
                JetBrainsIconKind.Application_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Application_Cidr.svg")
                },
                JetBrainsIconKind.Application_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Application_RunDebug.svg")
                },
                JetBrainsIconKind.ApplicationDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ApplicationDark_Cidr.svg")
                },
                JetBrainsIconKind.ApplicationDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/ApplicationDark_RunDebug.svg")
                },
                JetBrainsIconKind.ApplicationExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ApplicationExtension_Cidr.svg")
                },
                JetBrainsIconKind.ApplicationExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ApplicationExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.ApplicationRemote_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/ApplicationRemote_RunDebug.svg")
                },
                JetBrainsIconKind.ApplicationRemoteDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/ApplicationRemoteDark_RunDebug.svg")
                },
                JetBrainsIconKind.ApplyNotConflicts_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflicts_Vcs.svg")
                },
                JetBrainsIconKind.ApplyNotConflictsDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflictsDark_Vcs.svg")
                },
                JetBrainsIconKind.ApplyNotConflictsLeft_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflictsLeft_Vcs.svg")
                },
                JetBrainsIconKind.ApplyNotConflictsLeftDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflictsLeftDark_Vcs.svg")
                },
                JetBrainsIconKind.ApplyNotConflictsRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflictsRight_Vcs.svg")
                },
                JetBrainsIconKind.ApplyNotConflictsRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ApplyNotConflictsRightDark_Vcs.svg")
                },
                JetBrainsIconKind.Archive_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Archive_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ArchiveDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ArchiveDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.AreaLabel_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/AreaLabel_Cssselector.svg")
                },
                JetBrainsIconKind.AreaLabel14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/AreaLabel@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.AreaLabel14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/AreaLabel@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.AreaLabelDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/AreaLabelDark_Cssselector.svg")
                },
                JetBrainsIconKind.Argument_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Argument_Database.svg")
                },
                JetBrainsIconKind.ArgumentDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ArgumentDark_Database.svg")
                },
                JetBrainsIconKind.Arrow14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Arrow@14x14_Vcs.svg")
                },
                JetBrainsIconKind.Arrow14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Arrow@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.ArrowLeftDown14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowLeftDown@14x14_Vcs.svg")
                },
                JetBrainsIconKind.ArrowLeftDown14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowLeftDown@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.ArrowLeftRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowLeftRight_Vcs.svg")
                },
                JetBrainsIconKind.ArrowLeftRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowLeftRightDark_Vcs.svg")
                },
                JetBrainsIconKind.ArrowRight14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowRight@14x14_Vcs.svg")
                },
                JetBrainsIconKind.ArrowRight14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowRight@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.ArrowRightDown14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowRightDown@14x14_Vcs.svg")
                },
                JetBrainsIconKind.ArrowRightDown14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/ArrowRightDown@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.Asm_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Asm_Cidr.svg")
                },
                JetBrainsIconKind.AsmDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AsmDark_Cidr.svg")
                },
                JetBrainsIconKind.AspectJ_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/AspectJ_FilesNodes.svg")
                },
                JetBrainsIconKind.AspectJDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/AspectJDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Assets_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Assets_Cidr.svg")
                },
                JetBrainsIconKind.AssetsDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AssetsDark_Cidr.svg")
                },
                JetBrainsIconKind.AssocColumn_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AssocColumn_Ruby.svg")
                },
                JetBrainsIconKind.AssocColumnDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/AssocColumnDark_Ruby.svg")
                },
                JetBrainsIconKind.AssocFile14_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AssocFile@14x14_Cidr.svg")
                },
                JetBrainsIconKind.AssocFile14Dark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AssocFile@14x14Dark_Cidr.svg")
                },
                JetBrainsIconKind.Athena_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Athena_Providers.svg")
                },
                JetBrainsIconKind.AthenaDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/AthenaDark_Providers.svg")
                },
                JetBrainsIconKind.AttachToProcess_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/AttachToProcess_Run.svg")
                },
                JetBrainsIconKind.AttachToProcessDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/AttachToProcessDark_Run.svg")
                },
                JetBrainsIconKind.AutoReload_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AutoReload_Cidr.svg")
                },
                JetBrainsIconKind.AutoReloadDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/AutoReloadDark_Cidr.svg")
                },
                JetBrainsIconKind.AutoscrollFromSource_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/AutoscrollFromSource_General.svg")
                },
                JetBrainsIconKind.AutoscrollFromSourceDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/AutoscrollFromSourceDark_General.svg")
                },
                JetBrainsIconKind.AutoscrollToSource_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/AutoscrollToSource_General.svg")
                },
                JetBrainsIconKind.AutoscrollToSourceDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/AutoscrollToSourceDark_General.svg")
                },
                JetBrainsIconKind.AwsGlue_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/AwsGlue_ToolWindows.svg")
                },
                JetBrainsIconKind.AwsGlue20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/AwsGlue@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.AwsGlue20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/AwsGlue@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.AwsGlueDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/AwsGlueDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Azure_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Azure_Providers.svg")
                },
                JetBrainsIconKind.AzureDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/AzureDark_Providers.svg")
                },
                JetBrainsIconKind.BackTrace_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/BackTrace_Profiler.svg")
                },
                JetBrainsIconKind.BackTraceDark_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/BackTraceDark_Profiler.svg")
                },
                JetBrainsIconKind.BigQuery_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/BigQuery_Providers.svg")
                },
                JetBrainsIconKind.BigQueryDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/BigQueryDark_Providers.svg")
                },
                JetBrainsIconKind.BinaryData_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/BinaryData_Database.svg")
                },
                JetBrainsIconKind.BinaryDataDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/BinaryDataDark_Database.svg")
                },
                JetBrainsIconKind.Block_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Block_Ruby.svg")
                },
                JetBrainsIconKind.BlockBreakpoint14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/BlockBreakpoint@14x14_Ruby.svg")
                },
                JetBrainsIconKind.BlockBreakpoint14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/BlockBreakpoint@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.BlockDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/BlockDark_Ruby.svg")
                },
                JetBrainsIconKind.BlueKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/BlueKey_Database.svg")
                },
                JetBrainsIconKind.BlueKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/BlueKeyDark_Database.svg")
                },
                JetBrainsIconKind.Body_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Body_Database.svg")
                },
                JetBrainsIconKind.BodyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/BodyDark_Database.svg")
                },
                JetBrainsIconKind.Bookmark_Bookmarks => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/Bookmark_Bookmarks.svg")
                },
                JetBrainsIconKind.Bookmark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Bookmark_Gutter.svg")
                },
                JetBrainsIconKind.BookmarkDark_Bookmarks => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/BookmarkDark_Bookmarks.svg")
                },
                JetBrainsIconKind.BookmarkDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/BookmarkDark_Gutter.svg")
                },
                JetBrainsIconKind.Bookmarks_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Bookmarks_ToolWindows.svg")
                },
                JetBrainsIconKind.Bookmarks20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Bookmarks@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Bookmarks20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Bookmarks@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.BookmarksDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/BookmarksDark_ToolWindows.svg")
                },
                JetBrainsIconKind.BookmarksList => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/BookmarksList.svg")
                },
                JetBrainsIconKind.BookmarksListDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/BookmarksListDark.svg")
                },
                JetBrainsIconKind.BoostTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/BoostTest_Cidr.svg")
                },
                JetBrainsIconKind.BoostTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/BoostTestDark_Cidr.svg")
                },
                JetBrainsIconKind.Branch_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Branch_Vcs.svg")
                },
                JetBrainsIconKind.BranchDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/BranchDark_Vcs.svg")
                },
                JetBrainsIconKind.Breakpoint_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/Breakpoint_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointException_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointException_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointExceptionDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointExceptionDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointExceptionDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointExceptionDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointExceptionDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointExceptionDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointField_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointField_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMuted_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMuted_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMutedDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMutedDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMutedDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMutedDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMutedDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMutedDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMutedDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMutedDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldMutedDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldMutedDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendentDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendentDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendentDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendentDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendentValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendentValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldUnsuspendentValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldUnsuspendentValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointFieldValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointFieldValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointInvalid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointInvalid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointInvalidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointInvalidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointLambda_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointLambda_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointLambdaDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointLambdaDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethod_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethod_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMuted_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMuted_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMutedDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMutedDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMutedDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMutedDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMutedDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMutedDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMutedDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMutedDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodMutedDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodMutedDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendentDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendentDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendentDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendentDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendentValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendentValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodUnsuspendentValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodUnsuspendentValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMethodValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMethodValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMuted_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMuted_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMutedDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMutedDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMutedDependent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMutedDependent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMutedDependentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMutedDependentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMutedDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMutedDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointMutedDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointMutedDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointObsolete_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointObsolete_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointObsoleteDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointObsoleteDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendent_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendent_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendentDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendentDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendentDisabled_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendentDisabled_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendentDisabledDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendentDisabledDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendentValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendentValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointUnsuspendentValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointUnsuspendentValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointValid_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointValid_Breakpoints.svg")
                },
                JetBrainsIconKind.BreakpointValidDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/BreakpointValidDark_Breakpoints.svg")
                },
                JetBrainsIconKind.Browse_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Browse_Inline.svg")
                },
                JetBrainsIconKind.BrowseDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/BrowseDark_Inline.svg")
                },
                JetBrainsIconKind.Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/Build.svg")
                },
                JetBrainsIconKind.Build_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Build_ToolWindows.svg")
                },
                JetBrainsIconKind.Build20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Build@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Build20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Build@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildAutoReloadChanges_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/BuildAutoReloadChanges_Actions.svg")
                },
                JetBrainsIconKind.BuildAutoReloadChangesDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/BuildAutoReloadChangesDark_Actions.svg")
                },
                JetBrainsIconKind.BuildDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/BuildDark.svg")
                },
                JetBrainsIconKind.BuildDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/BuildDark_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildServerProtocol_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocol_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocol_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/BuildServerProtocol_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildServerProtocol20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/BuildServerProtocol@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildServerProtocol20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/BuildServerProtocol@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildServerProtocol6464_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocol64@64x64_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocol6464Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocol64@64x64Dark_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocolDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocolDark_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocolDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/BuildServerProtocolDark_ToolWindows.svg")
                },
                JetBrainsIconKind.BuildServerProtocolLoadChanges_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocolLoadChanges_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocolLoadChangesDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocolLoadChangesDark_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocolTarget_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocolTarget_Scala.svg")
                },
                JetBrainsIconKind.BuildServerProtocolTargetDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/BuildServerProtocolTargetDark_Scala.svg")
                },
                JetBrainsIconKind.BundleRunAnything_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/BundleRunAnything_Ruby.svg")
                },
                JetBrainsIconKind.BundleRunAnythingDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/BundleRunAnythingDark_Ruby.svg")
                },
                JetBrainsIconKind.C_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/C_Cidr.svg")
                },
                JetBrainsIconKind.CAndCPlusPlus_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CAndC++_EduTools.svg")
                },
                JetBrainsIconKind.CAndCPlusPlusDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CAndC++Dark_EduTools.svg")
                },
                JetBrainsIconKind.CargoGenerate_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoGenerate_Rust.svg")
                },
                JetBrainsIconKind.CargoGenerateDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoGenerateDark_Rust.svg")
                },
                JetBrainsIconKind.CargoLock_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoLock_Rust.svg")
                },
                JetBrainsIconKind.CargoLockDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoLockDark_Rust.svg")
                },
                JetBrainsIconKind.CargoProject_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoProject_Rust.svg")
                },
                JetBrainsIconKind.CargoProjectDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/CargoProjectDark_Rust.svg")
                },
                JetBrainsIconKind.Cassandra_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Cassandra_Providers.svg")
                },
                JetBrainsIconKind.CassandraDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/CassandraDark_Providers.svg")
                },
                JetBrainsIconKind.CassandraFileType_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CassandraFileType_Database.svg")
                },
                JetBrainsIconKind.CassandraFileTypeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CassandraFileTypeDark_Database.svg")
                },
                JetBrainsIconKind.CatchTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CatchTest_Cidr.svg")
                },
                JetBrainsIconKind.CatchTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CatchTestDark_Cidr.svg")
                },
                JetBrainsIconKind.CDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CDark_Cidr.svg")
                },
                JetBrainsIconKind.Changelist_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Changelist_Vcs.svg")
                },
                JetBrainsIconKind.ChangelistDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangelistDark_Vcs.svg")
                },
                JetBrainsIconKind.Changes_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Changes_ToolWindows.svg")
                },
                JetBrainsIconKind.Changes_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Changes_Vcs.svg")
                },
                JetBrainsIconKind.Changes20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Changes@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Changes20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Changes@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ChangesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/ChangesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ChangesDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangesDark_Vcs.svg")
                },
                JetBrainsIconKind.ChangesPush12_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangesPush@12x12_Vcs.svg")
                },
                JetBrainsIconKind.ChangesPush12Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangesPush@12x12Dark_Vcs.svg")
                },
                JetBrainsIconKind.ChangesUpdate12_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangesUpdate@12x12_Vcs.svg")
                },
                JetBrainsIconKind.ChangesUpdate12Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/ChangesUpdate@12x12Dark_Vcs.svg")
                },
                JetBrainsIconKind.Channel_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Channel_Ruby.svg")
                },
                JetBrainsIconKind.ChannelDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ChannelDark_Ruby.svg")
                },
                JetBrainsIconKind.ChannelGutter14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ChannelGutter@14x14_Ruby.svg")
                },
                JetBrainsIconKind.ChannelGutter14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ChannelGutter@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.CheckConstraint_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CheckConstraint_Database.svg")
                },
                JetBrainsIconKind.CheckConstraintDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CheckConstraintDark_Database.svg")
                },
                JetBrainsIconKind.Checkio24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Checkio@24x24_EduTools.svg")
                },
                JetBrainsIconKind.Checkio24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Checkio@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.CheckiOJS_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CheckiOJS_EduTools.svg")
                },
                JetBrainsIconKind.CheckiOJSDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CheckiOJSDark_EduTools.svg")
                },
                JetBrainsIconKind.CheckiOPY_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CheckiOPY_EduTools.svg")
                },
                JetBrainsIconKind.CheckiOPYDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CheckiOPYDark_EduTools.svg")
                },
                JetBrainsIconKind.Checkmark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Checkmark_EduTools.svg")
                },
                JetBrainsIconKind.Checkmark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Checkmark_General.svg")
                },
                JetBrainsIconKind.Checkmark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Checkmark_Vcs.svg")
                },
                JetBrainsIconKind.CheckmarkDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CheckmarkDark_EduTools.svg")
                },
                JetBrainsIconKind.CheckmarkDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CheckmarkDark_General.svg")
                },
                JetBrainsIconKind.CheckmarkDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CheckmarkDark_Vcs.svg")
                },
                JetBrainsIconKind.ChefCookbook_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ChefCookbook_Ruby.svg")
                },
                JetBrainsIconKind.ChefCookbookDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ChefCookbookDark_Ruby.svg")
                },
                JetBrainsIconKind.CherryPick_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CherryPick_Vcs.svg")
                },
                JetBrainsIconKind.CherryPickDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CherryPickDark_Vcs.svg")
                },
                JetBrainsIconKind.Chessboard_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/Chessboard_Image.svg")
                },
                JetBrainsIconKind.ChessboardDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ChessboardDark_Image.svg")
                },
                JetBrainsIconKind.ChevronDown_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronDown_General.svg")
                },
                JetBrainsIconKind.ChevronDownDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronDownDark_General.svg")
                },
                JetBrainsIconKind.ChevronDownLarge_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronDownLarge_General.svg")
                },
                JetBrainsIconKind.ChevronDownLargeDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronDownLargeDark_General.svg")
                },
                JetBrainsIconKind.ChevronLeft_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronLeft_General.svg")
                },
                JetBrainsIconKind.ChevronLeftDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronLeftDark_General.svg")
                },
                JetBrainsIconKind.ChevronRight_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronRight_General.svg")
                },
                JetBrainsIconKind.ChevronRightDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronRightDark_General.svg")
                },
                JetBrainsIconKind.ChevronUp_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronUp_General.svg")
                },
                JetBrainsIconKind.ChevronUpDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronUpDark_General.svg")
                },
                JetBrainsIconKind.ChevronUpLarge_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronUpLarge_General.svg")
                },
                JetBrainsIconKind.ChevronUpLargeDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ChevronUpLargeDark_General.svg")
                },
                JetBrainsIconKind.Class_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Class_Nodes.svg")
                },
                JetBrainsIconKind.ClassAbstract_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassAbstract_Nodes.svg")
                },
                JetBrainsIconKind.ClassAbstractDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassAbstractDark_Nodes.svg")
                },
                JetBrainsIconKind.ClassAnonymous_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassAnonymous_Nodes.svg")
                },
                JetBrainsIconKind.ClassAnonymousDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassAnonymousDark_Nodes.svg")
                },
                JetBrainsIconKind.ClassCompanion_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassCompanion_Scala.svg")
                },
                JetBrainsIconKind.ClassCompanionDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassCompanionDark_Scala.svg")
                },
                JetBrainsIconKind.ClassCompanionSwapped_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassCompanionSwapped_Scala.svg")
                },
                JetBrainsIconKind.ClassCompanionSwappedDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassCompanionSwappedDark_Scala.svg")
                },
                JetBrainsIconKind.ClassCpp_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ClassCpp_Cidr.svg")
                },
                JetBrainsIconKind.ClassCppDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ClassCppDark_Cidr.svg")
                },
                JetBrainsIconKind.ClassDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassDark_Nodes.svg")
                },
                JetBrainsIconKind.ClassInitializer_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassInitializer_Nodes.svg")
                },
                JetBrainsIconKind.ClassInitializerDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ClassInitializerDark_Nodes.svg")
                },
                JetBrainsIconKind.ClassInitializerKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ClassInitializerKotlin.svg")
                },
                JetBrainsIconKind.ClassInitializerKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ClassInitializerKotlinDark.svg")
                },
                JetBrainsIconKind.ClassKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ClassKotlin.svg")
                },
                JetBrainsIconKind.ClassKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ClassKotlinDark.svg")
                },
                JetBrainsIconKind.ClassObjectScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassObjectScala.svg")
                },
                JetBrainsIconKind.ClassObjectScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassObjectScalaDark.svg")
                },
                JetBrainsIconKind.ClassReadOnly_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/ClassReadOnly_PHP.svg")
                },
                JetBrainsIconKind.ClassReadOnlyDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/ClassReadOnlyDark_PHP.svg")
                },
                JetBrainsIconKind.ClassScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassScala.svg")
                },
                JetBrainsIconKind.ClassScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ClassScalaDark.svg")
                },
                JetBrainsIconKind.ClearCash_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/ClearCash_Aqua.svg")
                },
                JetBrainsIconKind.ClearCashDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/ClearCashDark_Aqua.svg")
                },
                JetBrainsIconKind.ClickHouse_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ClickHouse_Providers.svg")
                },
                JetBrainsIconKind.ClickHouseDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ClickHouseDark_Providers.svg")
                },
                JetBrainsIconKind.Close_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Close_General.svg")
                },
                JetBrainsIconKind.Close_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Close_Windows.svg")
                },
                JetBrainsIconKind.CloseDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CloseDark_General.svg")
                },
                JetBrainsIconKind.CloseDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CloseDark_Windows.svg")
                },
                JetBrainsIconKind.CloseInactive_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CloseInactive_Windows.svg")
                },
                JetBrainsIconKind.CloseInactiveDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CloseInactiveDark_Windows.svg")
                },
                JetBrainsIconKind.CloseSmall_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CloseSmall_General.svg")
                },
                JetBrainsIconKind.CloseSmall_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CloseSmall_Windows.svg")
                },
                JetBrainsIconKind.CloseSmallDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CloseSmallDark_General.svg")
                },
                JetBrainsIconKind.CloseSmallDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CloseSmallDark_Windows.svg")
                },
                JetBrainsIconKind.CloseSmallHovered_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CloseSmallHovered_General.svg")
                },
                JetBrainsIconKind.CloseSmallHoveredDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CloseSmallHoveredDark_General.svg")
                },
                JetBrainsIconKind.CMake_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMake_Cidr.svg")
                },
                JetBrainsIconKind.CMakeDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeDebug_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeDebug_Cidr.svg")
                },
                JetBrainsIconKind.CMakeDebugDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeDebugDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeFunction_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeFunction_Cidr.svg")
                },
                JetBrainsIconKind.CMakeFunctionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeFunctionDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeLoadChanges_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeLoadChanges_Cidr.svg")
                },
                JetBrainsIconKind.CMakeLoadChangesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeLoadChangesDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeMacro_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeMacro_Cidr.svg")
                },
                JetBrainsIconKind.CMakeMacroDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeMacroDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeModificator_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeModificator_Cidr.svg")
                },
                JetBrainsIconKind.CMakeModificatorDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeModificatorDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeTargetExecutable_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeTargetExecutable_Cidr.svg")
                },
                JetBrainsIconKind.CMakeTargetExecutableDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CMakeTargetExecutableDark_Cidr.svg")
                },
                JetBrainsIconKind.CMakeToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CMakeToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.CMakeToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CMakeToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.CMakeToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CMakeToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.CMakeToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CMakeToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.CockroachDB_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/CockroachDB_Providers.svg")
                },
                JetBrainsIconKind.CockroachDBDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/CockroachDBDark_Providers.svg")
                },
                JetBrainsIconKind.CocoaPods_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CocoaPods_Cidr.svg")
                },
                JetBrainsIconKind.CocoaPodsDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CocoaPodsDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantActor_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantActor_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantActorDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantActorDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantActorExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantActorExtension_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantActorExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantActorExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnum_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnum_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnumConst_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnumConst_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnumConstDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnumConstDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnumDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnumDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnumExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnumExtension_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantEnumExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantEnumExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantField_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantField_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFieldDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFieldDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFieldOptional_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFieldOptional_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFieldOptionalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFieldOptionalDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFunction_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFunction_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFunctionAbstract_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFunctionAbstract_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFunctionAbstractDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFunctionAbstractDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantFunctionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantFunctionDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantGlobal_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantGlobal_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantGlobalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantGlobalDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantLocal_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantLocal_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantLocalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantLocalDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantMemberAbstract_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantMemberAbstract_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantMemberAbstractDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantMemberAbstractDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantOperator_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantOperator_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantOperatorDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantOperatorDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantParameter_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantParameter_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantParameterDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantParameterDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantProperty_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantProperty_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantPropertyDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantPropertyDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantPropertyOptional_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantPropertyOptional_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantPropertyOptionalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantPropertyOptionalDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantProtocol_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantProtocol_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantProtocolDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantProtocolDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantProtocolExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantProtocolExtension_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantProtocolExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantProtocolExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantStruct_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantStruct_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantStructDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantStructDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantStructExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantStructExtension_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantStructExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantStructExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantType_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantType_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantTypeDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantTypeDark_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantUnion_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantUnion_Cidr.svg")
                },
                JetBrainsIconKind.CodeAssistantUnionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CodeAssistantUnionDark_Cidr.svg")
                },
                JetBrainsIconKind.Codeforces24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Codeforces@24x24_EduTools.svg")
                },
                JetBrainsIconKind.Codeforces24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Codeforces@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.Collapse_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Collapse_Inline.svg")
                },
                JetBrainsIconKind.Collapse_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Collapse_Windows.svg")
                },
                JetBrainsIconKind.CollapseAll_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CollapseAll_General.svg")
                },
                JetBrainsIconKind.CollapseAllDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CollapseAllDark_General.svg")
                },
                JetBrainsIconKind.CollapseDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/CollapseDark_Inline.svg")
                },
                JetBrainsIconKind.CollapseDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/CollapseDark_Windows.svg")
                },
                JetBrainsIconKind.CollapseNode_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/CollapseNode_Profiler.svg")
                },
                JetBrainsIconKind.CollapseNodeDark_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/CollapseNodeDark_Profiler.svg")
                },
                JetBrainsIconKind.Collation_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Collation_Database.svg")
                },
                JetBrainsIconKind.CollationDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollationDark_Database.svg")
                },
                JetBrainsIconKind.Collection_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Collection_Database.svg")
                },
                JetBrainsIconKind.CollectionDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollectionDark_Database.svg")
                },
                JetBrainsIconKind.CollectionKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollectionKey_Database.svg")
                },
                JetBrainsIconKind.CollectionKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollectionKeyDark_Database.svg")
                },
                JetBrainsIconKind.CollectionType_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollectionType_Database.svg")
                },
                JetBrainsIconKind.CollectionTypeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CollectionTypeDark_Database.svg")
                },
                JetBrainsIconKind.ColorPicker_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ColorPicker_Image.svg")
                },
                JetBrainsIconKind.ColorPickerDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ColorPickerDark_Image.svg")
                },
                JetBrainsIconKind.Colors_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Colors_Gutter.svg")
                },
                JetBrainsIconKind.ColorsDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/ColorsDark_Gutter.svg")
                },
                JetBrainsIconKind.Column_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Column_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKey_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyDark_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyDot_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyDot_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyDotDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyDotDark_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyDotIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyDotIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyDotIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyDotIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnBlueKeyIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnBlueKeyIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnDark_Database.svg")
                },
                JetBrainsIconKind.ColumnDot_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnDot_Database.svg")
                },
                JetBrainsIconKind.ColumnDotDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnDotDark_Database.svg")
                },
                JetBrainsIconKind.ColumnDotIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnDotIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnDotIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnDotIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKey_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyDot_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyDot_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyDotDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyDotDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyDotIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyDotIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyDotIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyDotIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldBlueKeyIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldBlueKeyIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKey_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyDot_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyDot_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyDotDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyDotDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyDotIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyDotIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyDotIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyDotIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnGoldKeyIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnGoldKeyIndexDark_Database.svg")
                },
                JetBrainsIconKind.ColumnIndex_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnIndex_Database.svg")
                },
                JetBrainsIconKind.ColumnIndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ColumnIndexDark_Database.svg")
                },
                JetBrainsIconKind.CommandQueue_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/CommandQueue_Python.svg")
                },
                JetBrainsIconKind.CommandQueueDark_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/CommandQueueDark_Python.svg")
                },
                JetBrainsIconKind.Comment_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Comment_Vcs.svg")
                },
                JetBrainsIconKind.CommentDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentDark_Vcs.svg")
                },
                JetBrainsIconKind.CommentRead_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentRead_Vcs.svg")
                },
                JetBrainsIconKind.CommentReadDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentReadDark_Vcs.svg")
                },
                JetBrainsIconKind.CommentRegular_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentRegular_Vcs.svg")
                },
                JetBrainsIconKind.CommentRegularDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentRegularDark_Vcs.svg")
                },
                JetBrainsIconKind.CommentResolved_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentResolved_Vcs.svg")
                },
                JetBrainsIconKind.CommentResolvedDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentResolvedDark_Vcs.svg")
                },
                JetBrainsIconKind.CommentTask_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommentTask_EduTools.svg")
                },
                JetBrainsIconKind.CommentTaskDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommentTaskDark_EduTools.svg")
                },
                JetBrainsIconKind.CommentUnread_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentUnread_Vcs.svg")
                },
                JetBrainsIconKind.CommentUnreadDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentUnreadDark_Vcs.svg")
                },
                JetBrainsIconKind.CommentUnresolved_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentUnresolved_Vcs.svg")
                },
                JetBrainsIconKind.CommentUnresolvedDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/CommentUnresolvedDark_Vcs.svg")
                },
                JetBrainsIconKind.Commit_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Commit_Database.svg")
                },
                JetBrainsIconKind.Commit_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Commit_ToolWindows.svg")
                },
                JetBrainsIconKind.Commit_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Commit_Vcs.svg")
                },
                JetBrainsIconKind.Commit20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Commit@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Commit20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Commit@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.CommitDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/CommitDark_Database.svg")
                },
                JetBrainsIconKind.CommitDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/CommitDark_ToolWindows.svg")
                },
                JetBrainsIconKind.CommitDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CommitDark_Vcs.svg")
                },
                JetBrainsIconKind.CommunityCourses24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommunityCourses@24x24_EduTools.svg")
                },
                JetBrainsIconKind.CommunityCourses24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommunityCourses@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.CommunityCourses24V2_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommunityCourses@24x24_v2_EduTools.svg")
                },
                JetBrainsIconKind.CommunityCourses24V2Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/CommunityCourses@24x24_v2Dark_EduTools.svg")
                },
                JetBrainsIconKind.CompactEmptyPackages_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/CompactEmptyPackages_ObjectBrowser.svg")
                },
                JetBrainsIconKind.CompactEmptyPackagesDark_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/CompactEmptyPackagesDark_ObjectBrowser.svg")
                },
                JetBrainsIconKind.Compare3LeftMiddle_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3LeftMiddle_Vcs.svg")
                },
                JetBrainsIconKind.Compare3LeftMiddleDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3LeftMiddleDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare3LeftRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3LeftRight_Vcs.svg")
                },
                JetBrainsIconKind.Compare3LeftRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3LeftRightDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare3MiddleRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3MiddleRight_Vcs.svg")
                },
                JetBrainsIconKind.Compare3MiddleRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare3MiddleRightDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftBottom_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftBottom_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftBottomDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftBottomDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftMiddle_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftMiddle_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftMiddleDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftMiddleDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftRight_Vcs.svg")
                },
                JetBrainsIconKind.Compare4LeftRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4LeftRightDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4MiddleBottom_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4MiddleBottom_Vcs.svg")
                },
                JetBrainsIconKind.Compare4MiddleBottomDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4MiddleBottomDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4MiddleRight_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4MiddleRight_Vcs.svg")
                },
                JetBrainsIconKind.Compare4MiddleRightDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4MiddleRightDark_Vcs.svg")
                },
                JetBrainsIconKind.Compare4RightBottom_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4RightBottom_Vcs.svg")
                },
                JetBrainsIconKind.Compare4RightBottomDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Compare4RightBottomDark_Vcs.svg")
                },
                JetBrainsIconKind.CompilationDatabaseLoadChanges_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CompilationDatabaseLoadChanges_Cidr.svg")
                },
                JetBrainsIconKind.CompilationDatabaseLoadChangesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CompilationDatabaseLoadChangesDark_Cidr.svg")
                },
                JetBrainsIconKind.CompileServer_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/CompileServer_Scala.svg")
                },
                JetBrainsIconKind.CompileServerDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/CompileServerDark_Scala.svg")
                },
                JetBrainsIconKind.Compound_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Compound_RunDebug.svg")
                },
                JetBrainsIconKind.CompoundDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/CompoundDark_RunDebug.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagram_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/ConcurrencyDiagram_Python.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramDark_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/ConcurrencyDiagramDark_Python.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindow_ToolWindows.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ConcurrencyDiagramToolwindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ConcurrencyDiagramToolwindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Conflict_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/Conflict_SettingSync.svg")
                },
                JetBrainsIconKind.ConflictDark_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/ConflictDark_SettingSync.svg")
                },
                JetBrainsIconKind.Connector_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Connector_Database.svg")
                },
                JetBrainsIconKind.ConnectorDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ConnectorDark_Database.svg")
                },
                JetBrainsIconKind.Console_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Console_Kotlin.svg")
                },
                JetBrainsIconKind.ConsoleDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ConsoleDark_Kotlin.svg")
                },
                JetBrainsIconKind.ConsoleRun_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ConsoleRun_Database.svg")
                },
                JetBrainsIconKind.ConsoleRunDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ConsoleRunDark_Database.svg")
                },
                JetBrainsIconKind.ConsoleShowPlan_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ConsoleShowPlan_Database.svg")
                },
                JetBrainsIconKind.ConsoleShowPlanDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ConsoleShowPlanDark_Database.svg")
                },
                JetBrainsIconKind.Const_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Const_Rust.svg")
                },
                JetBrainsIconKind.Constant_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Constant_Nodes.svg")
                },
                JetBrainsIconKind.ConstantDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ConstantDark_Nodes.svg")
                },
                JetBrainsIconKind.ConstDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/ConstDark_Rust.svg")
                },
                JetBrainsIconKind.ConstraintMappings_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ConstraintMappings_Spring.svg")
                },
                JetBrainsIconKind.ConstraintMappingsDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ConstraintMappingsDark_Spring.svg")
                },
                JetBrainsIconKind.Constraints_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Constraints_Spring.svg")
                },
                JetBrainsIconKind.ConstraintsDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ConstraintsDark_Spring.svg")
                },
                JetBrainsIconKind.ConstraintValidator_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ConstraintValidator_Spring.svg")
                },
                JetBrainsIconKind.ConstraintValidatorDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ConstraintValidatorDark_Spring.svg")
                },
                JetBrainsIconKind.Controller_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Controller_Nodes.svg")
                },
                JetBrainsIconKind.ControllerDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ControllerDark_Nodes.svg")
                },
                JetBrainsIconKind.ControllerFolder_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerFolder_Ruby.svg")
                },
                JetBrainsIconKind.ControllerFolderDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerFolderDark_Ruby.svg")
                },
                JetBrainsIconKind.ControllerNode_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerNode_Ruby.svg")
                },
                JetBrainsIconKind.ControllerNode14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerNode@14x14_Ruby.svg")
                },
                JetBrainsIconKind.ControllerNode14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerNode@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.ControllerNodeDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ControllerNodeDark_Ruby.svg")
                },
                JetBrainsIconKind.Copy_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Copy_General.svg")
                },
                JetBrainsIconKind.Copy_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Copy_Inline.svg")
                },
                JetBrainsIconKind.CopyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CopyDark_General.svg")
                },
                JetBrainsIconKind.CopyDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/CopyDark_Inline.svg")
                },
                JetBrainsIconKind.CopyOfFolder_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/CopyOfFolder_FilesNodes.svg")
                },
                JetBrainsIconKind.CopyOfFolderDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/CopyOfFolderDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Couchbase_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Couchbase_Providers.svg")
                },
                JetBrainsIconKind.CouchbaseDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/CouchbaseDark_Providers.svg")
                },
                JetBrainsIconKind.Coursera24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Coursera@24x24_EduTools.svg")
                },
                JetBrainsIconKind.Coursera24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Coursera@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.Coverage_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Coverage_ToolWindows.svg")
                },
                JetBrainsIconKind.Coverage20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Coverage@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Coverage20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Coverage@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.CoverageDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/CoverageDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Cpp_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Cpp_Cidr.svg")
                },
                JetBrainsIconKind.CppDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CppDark_Cidr.svg")
                },
                JetBrainsIconKind.CPU_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/CPU_GoLang.svg")
                },
                JetBrainsIconKind.CPUDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/CPUDark_GoLang.svg")
                },
                JetBrainsIconKind.Css_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Css_Cssselector.svg")
                },
                JetBrainsIconKind.Css_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Css_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Css14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Css@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.Css14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Css@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.CssDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/CssDark_Cssselector.svg")
                },
                JetBrainsIconKind.CssDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/CssDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.CTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CTest_Cidr.svg")
                },
                JetBrainsIconKind.CTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CTestDark_Cidr.svg")
                },
                JetBrainsIconKind.Cu_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Cu_Cidr.svg")
                },
                JetBrainsIconKind.Cucumber_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Cucumber_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.CucumberDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/CucumberDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Cuda_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Cuda_Cidr.svg")
                },
                JetBrainsIconKind.CudaDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CudaDark_Cidr.svg")
                },
                JetBrainsIconKind.CuDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CuDark_Cidr.svg")
                },
                JetBrainsIconKind.Cuh_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Cuh_Cidr.svg")
                },
                JetBrainsIconKind.CuhDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CuhDark_Cidr.svg")
                },
                JetBrainsIconKind.CurrentBranch_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CurrentBranch_Vcs.svg")
                },
                JetBrainsIconKind.CurrentBranchDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CurrentBranchDark_Vcs.svg")
                },
                JetBrainsIconKind.CurrentBranchFavorite_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CurrentBranchFavorite_Vcs.svg")
                },
                JetBrainsIconKind.CurrentBranchFavoriteDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/CurrentBranchFavoriteDark_Vcs.svg")
                },
                JetBrainsIconKind.CustomGdbRunConfiguration_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CustomGdbRunConfiguration_Cidr.svg")
                },
                JetBrainsIconKind.CustomGdbRunConfigurationDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/CustomGdbRunConfigurationDark_Cidr.svg")
                },
                JetBrainsIconKind.Cut_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Cut_General.svg")
                },
                JetBrainsIconKind.CutDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/CutDark_General.svg")
                },
                JetBrainsIconKind.CwmAccess_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmAccess_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmAccess20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmAccess@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmAccess20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmAccess@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmAccessDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmAccessDark_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmDisableCall_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmDisableCall_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmDisableCallDark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmDisableCallDark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmEnableCall_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmEnableCall_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmEnableCallDark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmEnableCallDark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificator_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificator_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificator14_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificator@14x14_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificator14Dark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificator@14x14Dark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificator20_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificator@20x20_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificator20Dark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificator@20x20Dark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmIconModificatorDark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmIconModificatorDark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmInvite_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmInvite_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmInviteDark_CodeWithMe => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/CodeWithMe/CwmInviteDark_CodeWithMe.svg")
                },
                JetBrainsIconKind.CwmUsers_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmUsers_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmUsers20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmUsers@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmUsers20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmUsers@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.CwmUsersDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/CwmUsersDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DarkTheme_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/DarkTheme_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.DarkThemeDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/DarkThemeDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.DarkThemeSelected_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/DarkThemeSelected_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.DarkThemeSelectedDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/DarkThemeSelectedDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.DataAttribute_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/DataAttribute_Cssselector.svg")
                },
                JetBrainsIconKind.DataAttribute14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/DataAttribute@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.DataAttribute14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/DataAttribute@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.DataAttributeDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/DataAttributeDark_Cssselector.svg")
                },
                JetBrainsIconKind.Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Database.svg")
                },
                JetBrainsIconKind.DatabaseChanges_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DatabaseChanges_ToolWindows.svg")
                },
                JetBrainsIconKind.DatabaseChanges20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DatabaseChanges@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.DatabaseChanges20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DatabaseChanges@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DatabaseChangesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DatabaseChangesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DatabaseDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DatabaseDark.svg")
                },
                JetBrainsIconKind.DatabaseLink => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DatabaseLink.svg")
                },
                JetBrainsIconKind.DatabaseLinkDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DatabaseLinkDark.svg")
                },
                JetBrainsIconKind.DatabaseObjectsGroup => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DatabaseObjectsGroup.svg")
                },
                JetBrainsIconKind.DatabaseObjectsGroupDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DatabaseObjectsGroupDark.svg")
                },
                JetBrainsIconKind.DataColumn_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/DataColumn_Nodes.svg")
                },
                JetBrainsIconKind.DataColumnDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/DataColumnDark_Nodes.svg")
                },
                JetBrainsIconKind.DataFile_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DataFile_Database.svg")
                },
                JetBrainsIconKind.DataFileDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DataFileDark_Database.svg")
                },
                JetBrainsIconKind.DataprocToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/DataprocToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.DataprocToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/DataprocToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.DataprocToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/DataprocToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DataprocToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/DataprocToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DataSchema_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DataSchema_Database.svg")
                },
                JetBrainsIconKind.DataSchema_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/DataSchema_Editor.svg")
                },
                JetBrainsIconKind.DataSchemaDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DataSchemaDark_Database.svg")
                },
                JetBrainsIconKind.DataSchemaDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/DataSchemaDark_Editor.svg")
                },
                JetBrainsIconKind.Db2_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Db2_Providers.svg")
                },
                JetBrainsIconKind.Db2Dark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Db2Dark_Providers.svg")
                },
                JetBrainsIconKind.DbHash_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/DbHash_Ruby.svg")
                },
                JetBrainsIconKind.DbHashDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/DbHashDark_Ruby.svg")
                },
                JetBrainsIconKind.Dbms_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dbms_ToolWindows.svg")
                },
                JetBrainsIconKind.Dbms20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dbms@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Dbms20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dbms@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DbmsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DbmsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Debug_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Debug_Run.svg")
                },
                JetBrainsIconKind.Debug_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Debug_ToolWindows.svg")
                },
                JetBrainsIconKind.Debug20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Debug@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Debug20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Debug@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DebugDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/DebugDark_Run.svg")
                },
                JetBrainsIconKind.DebugDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DebugDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DebugListenOff_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOff_Php.svg")
                },
                JetBrainsIconKind.DebugListenOff20_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOff@20x20_Php.svg")
                },
                JetBrainsIconKind.DebugListenOff20Dark_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOff@20x20Dark_Php.svg")
                },
                JetBrainsIconKind.DebugListenOffDark_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOffDark_Php.svg")
                },
                JetBrainsIconKind.DebugListenOn_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOn_Php.svg")
                },
                JetBrainsIconKind.DebugListenOn20_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOn@20x20_Php.svg")
                },
                JetBrainsIconKind.DebugListenOn20Dark_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOn@20x20Dark_Php.svg")
                },
                JetBrainsIconKind.DebugListenOnDark_Php => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Php/DebugListenOnDark_Php.svg")
                },
                JetBrainsIconKind.DefaultConstraint_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DefaultConstraint_Database.svg")
                },
                JetBrainsIconKind.DefaultConstraintDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/DefaultConstraintDark_Database.svg")
                },
                JetBrainsIconKind.Delete_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Delete_General.svg")
                },
                JetBrainsIconKind.DeleteDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/DeleteDark_General.svg")
                },
                JetBrainsIconKind.Dependencies_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dependencies_ToolWindows.svg")
                },
                JetBrainsIconKind.Dependencies20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dependencies@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Dependencies20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Dependencies@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DependenciesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DependenciesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DependencyAnalyzer_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/DependencyAnalyzer_Build.svg")
                },
                JetBrainsIconKind.DependencyAnalyzerDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/DependencyAnalyzerDark_Build.svg")
                },
                JetBrainsIconKind.Desktop_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Desktop_Nodes.svg")
                },
                JetBrainsIconKind.DesktopDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/DesktopDark_Nodes.svg")
                },
                JetBrainsIconKind.DevTools_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/DevTools_Aqua.svg")
                },
                JetBrainsIconKind.DevToolsDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/DevToolsDark_Aqua.svg")
                },
                JetBrainsIconKind.Diagram_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Diagram_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.DiagramDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/DiagramDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Diff_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Diff_Vcs.svg")
                },
                JetBrainsIconKind.DiffDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/DiffDark_Vcs.svg")
                },
                JetBrainsIconKind.DisableEditing_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/DisableEditing_Vcs.svg")
                },
                JetBrainsIconKind.DisableEditingDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/DisableEditingDark_Vcs.svg")
                },
                JetBrainsIconKind.Dislike_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/Dislike_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.DislikeDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/DislikeDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.DislikeDimmed_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/DislikeDimmed_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.DislikeDimmedDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/DislikeDimmedDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.DislikeSelected_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/DislikeSelected_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.DislikeSelectedDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/DislikeSelectedDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.Docker_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Docker_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.DockerDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/DockerDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.DocTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/DocTest_Cidr.svg")
                },
                JetBrainsIconKind.DocTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/DocTestDark_Cidr.svg")
                },
                JetBrainsIconKind.Documentation_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Documentation_ToolWindows.svg")
                },
                JetBrainsIconKind.Documentation20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Documentation@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Documentation20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Documentation@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DocumentationDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/DocumentationDark_ToolWindows.svg")
                },
                JetBrainsIconKind.DocumentDB_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/DocumentDB_Providers.svg")
                },
                JetBrainsIconKind.DocumentDBDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/DocumentDBDark_Providers.svg")
                },
                JetBrainsIconKind.Donate_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Donate_ToolWindows.svg")
                },
                JetBrainsIconKind.Donate20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Donate@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Donate20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Donate@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.DonateDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/DonateDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Down_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Down_General.svg")
                },
                JetBrainsIconKind.DownDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/DownDark_General.svg")
                },
                JetBrainsIconKind.Download_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Download_General.svg")
                },
                JetBrainsIconKind.DownloadDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/DownloadDark_General.svg")
                },
                JetBrainsIconKind.DuckDB_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/DuckDB_Providers.svg")
                },
                JetBrainsIconKind.DuckDBDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/DuckDBDark_Providers.svg")
                },
                JetBrainsIconKind.DumpThreads_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/DumpThreads_Run.svg")
                },
                JetBrainsIconKind.DumpThreadsDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/DumpThreadsDark_Run.svg")
                },
                JetBrainsIconKind.Eclipse_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Eclipse_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.EclipseDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/EclipseDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Edit_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Edit_General.svg")
                },
                JetBrainsIconKind.EditDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/EditDark_General.svg")
                },
                JetBrainsIconKind.EditData_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/EditData_Database.svg")
                },
                JetBrainsIconKind.EditDataDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/EditDataDark_Database.svg")
                },
                JetBrainsIconKind.EditFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/EditFolder_Nodes.svg")
                },
                JetBrainsIconKind.EditFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/EditFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.EditorConfig_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/EditorConfig_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.EditorConfigDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/EditorConfigDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.EditorOnly => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorOnly.svg")
                },
                JetBrainsIconKind.EditorOnlyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorOnlyDark.svg")
                },
                JetBrainsIconKind.EditorOutput_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/EditorOutput_Database.svg")
                },
                JetBrainsIconKind.EditorOutputDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/EditorOutputDark_Database.svg")
                },
                JetBrainsIconKind.EditorPreview => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorPreview.svg")
                },
                JetBrainsIconKind.EditorPreviewDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorPreviewDark.svg")
                },
                JetBrainsIconKind.EditorPreviewVertical => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorPreviewVertical.svg")
                },
                JetBrainsIconKind.EditorPreviewVerticalDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/EditorPreviewVerticalDark.svg")
                },
                JetBrainsIconKind.EduCourseAction_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseAction_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseActionDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseActionDark_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseActionV2_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseAction_v2_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseActionV2Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseAction_v2Dark_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseTree_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseTree_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseTreeDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseTreeDark_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseTreeV2_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseTree_v2_EduTools.svg")
                },
                JetBrainsIconKind.EduCourseTreeV2Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduCourseTree_v2Dark_EduTools.svg")
                },
                JetBrainsIconKind.EduLessonDefault_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduLessonDefault_EduTools.svg")
                },
                JetBrainsIconKind.EduLessonDefaultDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduLessonDefaultDark_EduTools.svg")
                },
                JetBrainsIconKind.EduLessonDone_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduLessonDone_EduTools.svg")
                },
                JetBrainsIconKind.EduLessonDoneDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduLessonDoneDark_EduTools.svg")
                },
                JetBrainsIconKind.EduSectionDefault_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduSectionDefault_EduTools.svg")
                },
                JetBrainsIconKind.EduSectionDefaultDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduSectionDefaultDark_EduTools.svg")
                },
                JetBrainsIconKind.EduSectionDone_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduSectionDone_EduTools.svg")
                },
                JetBrainsIconKind.EduSectionDoneDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduSectionDoneDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskDefault_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskDefault_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskDefaultDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskDefaultDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskDone_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskDone_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskDoneDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskDoneDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskFailed_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskFailed_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskFailedDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskFailedDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskIdeDefault_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskIdeDefault_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskIdeDefaultDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskIdeDefaultDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskIdeDone_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskIdeDone_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskIdeDoneDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskIdeDoneDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskTheoryDefault_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskTheoryDefault_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskTheoryDefaultDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskTheoryDefaultDark_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskTheoryDone_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskTheoryDone_EduTools.svg")
                },
                JetBrainsIconKind.EduTaskTheoryDoneDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/EduTaskTheoryDoneDark_EduTools.svg")
                },
                JetBrainsIconKind.Elasticsearch_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Elasticsearch_Providers.svg")
                },
                JetBrainsIconKind.ElasticsearchDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ElasticsearchDark_Providers.svg")
                },
                JetBrainsIconKind.Endpoint_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Endpoint_Ruby.svg")
                },
                JetBrainsIconKind.EndpointDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/EndpointDark_Ruby.svg")
                },
                JetBrainsIconKind.Endpoints_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Endpoints_ToolWindows.svg")
                },
                JetBrainsIconKind.Endpoints20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Endpoints@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Endpoints20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Endpoints@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.EndpointsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/EndpointsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Enum_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Enum_Nodes.svg")
                },
                JetBrainsIconKind.Enum_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Enum_Rust.svg")
                },
                JetBrainsIconKind.EnumDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/EnumDark_Nodes.svg")
                },
                JetBrainsIconKind.EnumDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/EnumDark_Rust.svg")
                },
                JetBrainsIconKind.EnumKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/EnumKotlin.svg")
                },
                JetBrainsIconKind.EnumKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/EnumKotlinDark.svg")
                },
                JetBrainsIconKind.EnumScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/EnumScala.svg")
                },
                JetBrainsIconKind.EnumScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/EnumScalaDark.svg")
                },
                JetBrainsIconKind.EnumVariant_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/EnumVariant_Rust.svg")
                },
                JetBrainsIconKind.EnumVariantDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/EnumVariantDark_Rust.svg")
                },
                JetBrainsIconKind.Error_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/Error_Status.svg")
                },
                JetBrainsIconKind.ErrorDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/ErrorDark_Status.svg")
                },
                JetBrainsIconKind.ErrorDialog_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/ErrorDialog_Status.svg")
                },
                JetBrainsIconKind.ErrorDialogDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/ErrorDialogDark_Status.svg")
                },
                JetBrainsIconKind.ErrorIntroduction_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ErrorIntroduction_Nodes.svg")
                },
                JetBrainsIconKind.ErrorIntroductionDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ErrorIntroductionDark_Nodes.svg")
                },
                JetBrainsIconKind.ErrorOutline_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/ErrorOutline_Status.svg")
                },
                JetBrainsIconKind.ErrorOutlineDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/ErrorOutlineDark_Status.svg")
                },
                JetBrainsIconKind.EvaluateExpression_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/EvaluateExpression_Run.svg")
                },
                JetBrainsIconKind.EvaluateExpressionDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/EvaluateExpressionDark_Run.svg")
                },
                JetBrainsIconKind.ExactWords_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/ExactWords_Inline.svg")
                },
                JetBrainsIconKind.ExactWordsDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/ExactWordsDark_Inline.svg")
                },
                JetBrainsIconKind.Exasol_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Exasol_Providers.svg")
                },
                JetBrainsIconKind.ExasolDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ExasolDark_Providers.svg")
                },
                JetBrainsIconKind.Exception_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Exception_Nodes.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzer_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ExceptionAnalyzer_ToolWindows.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzer20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ExceptionAnalyzer@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzer20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ExceptionAnalyzer@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ExceptionAnalyzerDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ExceptionAnalyzerDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ExceptionDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ExceptionDark_Nodes.svg")
                },
                JetBrainsIconKind.ExcludedGenerated_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ExcludedGenerated_Nodes.svg")
                },
                JetBrainsIconKind.ExcludedGeneratedDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ExcludedGeneratedDark_Nodes.svg")
                },
                JetBrainsIconKind.ExcludeRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ExcludeRoot_Nodes.svg")
                },
                JetBrainsIconKind.ExcludeRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ExcludeRootDark_Nodes.svg")
                },
                JetBrainsIconKind.Exit_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Exit_General.svg")
                },
                JetBrainsIconKind.ExitDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExitDark_General.svg")
                },
                JetBrainsIconKind.Expand_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Expand_Inline.svg")
                },
                JetBrainsIconKind.ExpandAll_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExpandAll_General.svg")
                },
                JetBrainsIconKind.ExpandAllDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExpandAllDark_General.svg")
                },
                JetBrainsIconKind.ExpandDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/ExpandDark_Inline.svg")
                },
                JetBrainsIconKind.ExpandNode_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/ExpandNode_Profiler.svg")
                },
                JetBrainsIconKind.ExpandNodeDark_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/ExpandNodeDark_Profiler.svg")
                },
                JetBrainsIconKind.Expect_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Expect_Kotlin.svg")
                },
                JetBrainsIconKind.ExpectDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ExpectDark_Kotlin.svg")
                },
                JetBrainsIconKind.Export_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Export_General.svg")
                },
                JetBrainsIconKind.ExportDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExportDark_General.svg")
                },
                JetBrainsIconKind.ExtAnnotation_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/ExtAnnotation_Gutter.svg")
                },
                JetBrainsIconKind.ExtAnnotationDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/ExtAnnotationDark_Gutter.svg")
                },
                JetBrainsIconKind.Extension_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Extension_Database.svg")
                },
                JetBrainsIconKind.ExtensionDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ExtensionDark_Database.svg")
                },
                JetBrainsIconKind.ExtensionRunConfiguration_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ExtensionRunConfiguration_Cidr.svg")
                },
                JetBrainsIconKind.ExtensionRunConfigurationDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ExtensionRunConfigurationDark_Cidr.svg")
                },
                JetBrainsIconKind.ExternalLink_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExternalLink_General.svg")
                },
                JetBrainsIconKind.ExternalLinkDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ExternalLinkDark_General.svg")
                },
                JetBrainsIconKind.ExternalSchema_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ExternalSchema_Database.svg")
                },
                JetBrainsIconKind.ExternalSchemaDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ExternalSchemaDark_Database.svg")
                },
                JetBrainsIconKind.Factory_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Factory_Ruby.svg")
                },
                JetBrainsIconKind.FactoryDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/FactoryDark_Ruby.svg")
                },
                JetBrainsIconKind.FactoryMethodBean_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FactoryMethodBean_Spring.svg")
                },
                JetBrainsIconKind.FactoryMethodBean14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FactoryMethodBean@14x14_Spring.svg")
                },
                JetBrainsIconKind.FactoryMethodBean14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FactoryMethodBean@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.FactoryMethodBeanDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FactoryMethodBeanDark_Spring.svg")
                },
                JetBrainsIconKind.FailedInProgress_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/FailedInProgress_RunDebug.svg")
                },
                JetBrainsIconKind.FailedInProgressDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/FailedInProgressDark_RunDebug.svg")
                },
                JetBrainsIconKind.FeedbackRating_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRating_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingDark_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingDark_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingFocused_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingFocused_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingFocusedDark_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingFocusedDark_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingFocusedOn_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingFocusedOn_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingFocusedOnDark_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingFocusedOnDark_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingOn_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingOn_Raiting.svg")
                },
                JetBrainsIconKind.FeedbackRatingOnDark_Raiting => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Raiting/FeedbackRatingOnDark_Raiting.svg")
                },
                JetBrainsIconKind.Fetch_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Fetch_Vcs.svg")
                },
                JetBrainsIconKind.FetchDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/FetchDark_Vcs.svg")
                },
                JetBrainsIconKind.Field_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Field_Nodes.svg")
                },
                JetBrainsIconKind.Field_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Field_Rust.svg")
                },
                JetBrainsIconKind.FieldDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/FieldDark_Nodes.svg")
                },
                JetBrainsIconKind.FieldDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/FieldDark_Rust.svg")
                },
                JetBrainsIconKind.FieldValue_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/FieldValue_Kotlin.svg")
                },
                JetBrainsIconKind.FieldValue_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldValue_Scala.svg")
                },
                JetBrainsIconKind.FieldValue1_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldValue1_Scala.svg")
                },
                JetBrainsIconKind.FieldValue1Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldValue1Dark_Scala.svg")
                },
                JetBrainsIconKind.FieldValueDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/FieldValueDark_Kotlin.svg")
                },
                JetBrainsIconKind.FieldValueDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldValueDark_Scala.svg")
                },
                JetBrainsIconKind.FieldVariable_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/FieldVariable_Kotlin.svg")
                },
                JetBrainsIconKind.FieldVariable_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldVariable_Scala.svg")
                },
                JetBrainsIconKind.FieldVariable1_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldVariable1_Scala.svg")
                },
                JetBrainsIconKind.FieldVariable1Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldVariable1Dark_Scala.svg")
                },
                JetBrainsIconKind.FieldVariableDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/FieldVariableDark_Kotlin.svg")
                },
                JetBrainsIconKind.FieldVariableDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/FieldVariableDark_Scala.svg")
                },
                JetBrainsIconKind.FileFormat_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/FileFormat_Database.svg")
                },
                JetBrainsIconKind.FileFormatDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/FileFormatDark_Database.svg")
                },
                JetBrainsIconKind.FileSet_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FileSet_Spring.svg")
                },
                JetBrainsIconKind.FileSetDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/FileSetDark_Spring.svg")
                },
                JetBrainsIconKind.FileTypeSwift_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FileTypeSwift_Cidr.svg")
                },
                JetBrainsIconKind.FileTypeSwiftDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FileTypeSwiftDark_Cidr.svg")
                },
                JetBrainsIconKind.FileUnread_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/FileUnread_Vcs.svg")
                },
                JetBrainsIconKind.FileUnreadDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/FileUnreadDark_Vcs.svg")
                },
                JetBrainsIconKind.Filter_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Filter_General.svg")
                },
                JetBrainsIconKind.FilterDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/FilterDark_General.svg")
                },
                JetBrainsIconKind.Filterdups_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/Filterdups_Udages_Usages.svg")
                },
                JetBrainsIconKind.FilterdupsDark_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/FilterdupsDark_Udages_Usages.svg")
                },
                JetBrainsIconKind.FilterHistory_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/FilterHistory_Inline.svg")
                },
                JetBrainsIconKind.FilterHistoryDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/FilterHistoryDark_Inline.svg")
                },
                JetBrainsIconKind.Find_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Find_ToolWindows.svg")
                },
                JetBrainsIconKind.Find20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Find@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Find20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Find@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.FindDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/FindDark_ToolWindows.svg")
                },
                JetBrainsIconKind.FindExternalUsages_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/FindExternalUsages_ToolWindows.svg")
                },
                JetBrainsIconKind.FindExternalUsages20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/FindExternalUsages@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.FindExternalUsages20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/FindExternalUsages@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.FindExternalUsagesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/FindExternalUsagesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Firebird_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Firebird_Providers.svg")
                },
                JetBrainsIconKind.FirebirdDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/FirebirdDark_Providers.svg")
                },
                JetBrainsIconKind.FitContent_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/FitContent_Image.svg")
                },
                JetBrainsIconKind.FitContentDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/FitContentDark_Image.svg")
                },
                JetBrainsIconKind.FlattenModules_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/FlattenModules_ObjectBrowser.svg")
                },
                JetBrainsIconKind.FlattenModulesDark_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/FlattenModulesDark_ObjectBrowser.svg")
                },
                JetBrainsIconKind.FlattenPackages_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/FlattenPackages_ObjectBrowser.svg")
                },
                JetBrainsIconKind.FlattenPackagesDark_ObjectBrowser => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ObjectBrowser/FlattenPackagesDark_ObjectBrowser.svg")
                },
                JetBrainsIconKind.Fold_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Fold_Gutter.svg")
                },
                JetBrainsIconKind.FoldBottom_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/FoldBottom_Gutter.svg")
                },
                JetBrainsIconKind.FoldBottomDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/FoldBottomDark_Gutter.svg")
                },
                JetBrainsIconKind.FoldDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/FoldDark_Gutter.svg")
                },
                JetBrainsIconKind.Folder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Folder_Nodes.svg")
                },
                JetBrainsIconKind.Folder14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Folder@14x14_Ruby.svg")
                },
                JetBrainsIconKind.Folder14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Folder@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.FolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/FolderDark_Nodes.svg")
                },
                JetBrainsIconKind.ForceRunToCursor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceRunToCursor.svg")
                },
                JetBrainsIconKind.ForceRunToCursorDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceRunToCursorDark.svg")
                },
                JetBrainsIconKind.ForceStepInto_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceStepInto_Run.svg")
                },
                JetBrainsIconKind.ForceStepIntoDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceStepIntoDark_Run.svg")
                },
                JetBrainsIconKind.ForceStepOver_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceStepOver_Run.svg")
                },
                JetBrainsIconKind.ForceStepOverDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ForceStepOverDark_Run.svg")
                },
                JetBrainsIconKind.ForeignDatawrapper_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignDatawrapper_Database.svg")
                },
                JetBrainsIconKind.ForeignDatawrapperDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignDatawrapperDark_Database.svg")
                },
                JetBrainsIconKind.ForeignPartionTable_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignPartionTable_Database.svg")
                },
                JetBrainsIconKind.ForeignPartionTableDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignPartionTableDark_Database.svg")
                },
                JetBrainsIconKind.ForeignServer_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignServer_Database.svg")
                },
                JetBrainsIconKind.ForeignServerDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignServerDark_Database.svg")
                },
                JetBrainsIconKind.ForeignTable_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignTable_Database.svg")
                },
                JetBrainsIconKind.ForeignTableDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ForeignTableDark_Database.svg")
                },
                JetBrainsIconKind.Framework_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Framework_Cidr.svg")
                },
                JetBrainsIconKind.FrameworkDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FrameworkDark_Cidr.svg")
                },
                JetBrainsIconKind.Freemaker_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Freemaker_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.FreemakerDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/FreemakerDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Freeze_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Freeze_Cidr.svg")
                },
                JetBrainsIconKind.FreezeAll_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FreezeAll_Cidr.svg")
                },
                JetBrainsIconKind.FreezeAllDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FreezeAllDark_Cidr.svg")
                },
                JetBrainsIconKind.FreezeDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/FreezeDark_Cidr.svg")
                },
                JetBrainsIconKind.Function_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Function_Database.svg")
                },
                JetBrainsIconKind.Function_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Function_Nodes.svg")
                },
                JetBrainsIconKind.Function_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Function_Rust.svg")
                },
                JetBrainsIconKind.FunctionDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/FunctionDark_Database.svg")
                },
                JetBrainsIconKind.FunctionDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/FunctionDark_Nodes.svg")
                },
                JetBrainsIconKind.FunctionDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/FunctionDark_Rust.svg")
                },
                JetBrainsIconKind.FunctionRun_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/FunctionRun_Database.svg")
                },
                JetBrainsIconKind.FunctionRunDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/FunctionRunDark_Database.svg")
                },
                JetBrainsIconKind.Generated_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Generated_Nodes.svg")
                },
                JetBrainsIconKind.GeneratedDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GeneratedDark_Nodes.svg")
                },
                JetBrainsIconKind.GeneratedSource_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GeneratedSource_Nodes.svg")
                },
                JetBrainsIconKind.GeneratedSourceDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GeneratedSourceDark_Nodes.svg")
                },
                JetBrainsIconKind.GeneratedTestRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GeneratedTestRoot_Nodes.svg")
                },
                JetBrainsIconKind.GeneratedTestRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GeneratedTestRootDark_Nodes.svg")
                },
                JetBrainsIconKind.Gitlab_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gitlab_ToolWindows.svg")
                },
                JetBrainsIconKind.Gitlab20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gitlab@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Gitlab20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gitlab@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.GitlabDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/GitlabDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Go_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Go_FilesNodes.svg")
                },
                JetBrainsIconKind.Go_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/Go_GoLang.svg")
                },
                JetBrainsIconKind.GoDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/GoDark_FilesNodes.svg")
                },
                JetBrainsIconKind.GoDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/GoDark_GoLang.svg")
                },
                JetBrainsIconKind.GoldKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/GoldKey_Database.svg")
                },
                JetBrainsIconKind.GoldKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/GoldKeyDark_Database.svg")
                },
                JetBrainsIconKind.GoogleCloudDataproc_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/GoogleCloudDataproc_Providers.svg")
                },
                JetBrainsIconKind.GoogleCloudDataprocDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/GoogleCloudDataprocDark_Providers.svg")
                },
                JetBrainsIconKind.GoogleCloudSpanner_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/GoogleCloudSpanner_Providers.svg")
                },
                JetBrainsIconKind.GoogleCloudSpannerDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/GoogleCloudSpannerDark_Providers.svg")
                },
                JetBrainsIconKind.GoogleTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GoogleTest_Cidr.svg")
                },
                JetBrainsIconKind.GoogleTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GoogleTestDark_Cidr.svg")
                },
                JetBrainsIconKind.GoTemplate_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/GoTemplate_GoLang.svg")
                },
                JetBrainsIconKind.GoTemplateDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/GoTemplateDark_GoLang.svg")
                },
                JetBrainsIconKind.Gradle_FileTypes_RunDebugFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/RunDebugFileTypes/Gradle_FileTypes_RunDebugFileTypes.svg")
                },
                JetBrainsIconKind.Gradle_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gradle_ToolWindows.svg")
                },
                JetBrainsIconKind.Gradle20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gradle@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Gradle20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Gradle@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.GradleDark_FileTypes_RunDebugFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/RunDebugFileTypes/GradleDark_FileTypes_RunDebugFileTypes.svg")
                },
                JetBrainsIconKind.GradleDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/GradleDark_ToolWindows.svg")
                },
                JetBrainsIconKind.GradleLoadChanges_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/GradleLoadChanges_Build.svg")
                },
                JetBrainsIconKind.GradleLoadChangesDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/GradleLoadChangesDark_Build.svg")
                },
                JetBrainsIconKind.GradleNavigate_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/GradleNavigate_Build.svg")
                },
                JetBrainsIconKind.GradleNavigateDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/GradleNavigateDark_Build.svg")
                },
                JetBrainsIconKind.GreenCheckmark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/GreenCheckmark_EduTools.svg")
                },
                JetBrainsIconKind.GreenCheckmarkDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/GreenCheckmarkDark_EduTools.svg")
                },
                JetBrainsIconKind.Greenplum_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Greenplum_Providers.svg")
                },
                JetBrainsIconKind.GreenplumDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/GreenplumDark_Providers.svg")
                },
                JetBrainsIconKind.GreyKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/GreyKey_Database.svg")
                },
                JetBrainsIconKind.GreyKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/GreyKeyDark_Database.svg")
                },
                JetBrainsIconKind.Grid_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/Grid_Image.svg")
                },
                JetBrainsIconKind.GridDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/GridDark_Image.svg")
                },
                JetBrainsIconKind.Groovy => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Groovy/Groovy.svg")
                },
                JetBrainsIconKind.GroovyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Groovy/GroovyDark.svg")
                },
                JetBrainsIconKind.Group_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Group_Cidr.svg")
                },
                JetBrainsIconKind.GroupByMethod_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByMethod_Actions.svg")
                },
                JetBrainsIconKind.GroupByMethodDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByMethodDark_Actions.svg")
                },
                JetBrainsIconKind.GroupByModule_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByModule_Actions.svg")
                },
                JetBrainsIconKind.GroupByModuleDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByModuleDark_Actions.svg")
                },
                JetBrainsIconKind.GroupByTestProduction_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByTestProduction_Actions.svg")
                },
                JetBrainsIconKind.GroupByTestProductionDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/GroupByTestProductionDark_Actions.svg")
                },
                JetBrainsIconKind.GroupDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GroupDark_Cidr.svg")
                },
                JetBrainsIconKind.GroupQualifiedName_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GroupQualifiedName_Cidr.svg")
                },
                JetBrainsIconKind.GroupQualifiedNameDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GroupQualifiedNameDark_Cidr.svg")
                },
                JetBrainsIconKind.Groups_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Groups_General.svg")
                },
                JetBrainsIconKind.GroupsDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/GroupsDark_General.svg")
                },
                JetBrainsIconKind.GutterCheckBox14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBox@14x14_Vcs.svg")
                },
                JetBrainsIconKind.GutterCheckBox14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBox@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.GutterCheckBoxIndeterminate14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBoxIndeterminate@14x14_Vcs.svg")
                },
                JetBrainsIconKind.GutterCheckBoxIndeterminate14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBoxIndeterminate@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.GutterCheckBoxSelected14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBoxSelected@14x14_Vcs.svg")
                },
                JetBrainsIconKind.GutterCheckBoxSelected14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/GutterCheckBoxSelected@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.GutterMultiArrows14_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GutterMultiArrows@14x14_Cidr.svg")
                },
                JetBrainsIconKind.GutterMultiArrows14Dark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/GutterMultiArrows@14x14Dark_Cidr.svg")
                },
                JetBrainsIconKind.Gvariable_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Gvariable_Nodes.svg")
                },
                JetBrainsIconKind.GvariableDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/GvariableDark_Nodes.svg")
                },
                JetBrainsIconKind.H_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/H_Cidr.svg")
                },
                JetBrainsIconKind.H2_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/H2_Providers.svg")
                },
                JetBrainsIconKind.H2Dark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/H2Dark_Providers.svg")
                },
                JetBrainsIconKind.Hana_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Hana_Providers.svg")
                },
                JetBrainsIconKind.HanaDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/HanaDark_Providers.svg")
                },
                JetBrainsIconKind.HashCluster_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashCluster_Database.svg")
                },
                JetBrainsIconKind.HashClusterDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashClusterDark_Database.svg")
                },
                JetBrainsIconKind.HashKey_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/HashKey_Ruby.svg")
                },
                JetBrainsIconKind.HashKeyDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/HashKeyDark_Ruby.svg")
                },
                JetBrainsIconKind.HashTable_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashTable_Database.svg")
                },
                JetBrainsIconKind.HashTableDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashTableDark_Database.svg")
                },
                JetBrainsIconKind.HashTableKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashTableKey_Database.svg")
                },
                JetBrainsIconKind.HashTableKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HashTableKeyDark_Database.svg")
                },
                JetBrainsIconKind.Haskell_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Haskell_FilesNodes.svg")
                },
                JetBrainsIconKind.HaskellDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/HaskellDark_FilesNodes.svg")
                },
                JetBrainsIconKind.HDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/HDark_Cidr.svg")
                },
                JetBrainsIconKind.Help_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Help_General.svg")
                },
                JetBrainsIconKind.Help_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Help_Windows.svg")
                },
                JetBrainsIconKind.HelpDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/HelpDark_General.svg")
                },
                JetBrainsIconKind.HelpDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/HelpDark_Windows.svg")
                },
                JetBrainsIconKind.HelpersFolderClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/HelpersFolderClosed_Ruby.svg")
                },
                JetBrainsIconKind.HelpersFolderClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/HelpersFolderClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.HelpInactive_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/HelpInactive_Windows.svg")
                },
                JetBrainsIconKind.HelpInactiveDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/HelpInactiveDark_Windows.svg")
                },
                JetBrainsIconKind.HelpModule_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/HelpModule_Writerside.svg")
                },
                JetBrainsIconKind.HelpModuleDark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/HelpModuleDark_Writerside.svg")
                },
                JetBrainsIconKind.Hide_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Hide_General.svg")
                },
                JetBrainsIconKind.HideDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/HideDark_General.svg")
                },
                JetBrainsIconKind.Hierarchy_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Hierarchy_ToolWindows.svg")
                },
                JetBrainsIconKind.Hierarchy20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Hierarchy@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Hierarchy20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Hierarchy@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.HierarchyDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/HierarchyDark_ToolWindows.svg")
                },
                JetBrainsIconKind.History_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/History_General.svg")
                },
                JetBrainsIconKind.HistoryDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/HistoryDark_General.svg")
                },
                JetBrainsIconKind.Hive_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Hive_Providers.svg")
                },
                JetBrainsIconKind.Hive_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Hive_ToolWindows.svg")
                },
                JetBrainsIconKind.Hive20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Hive@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Hive20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Hive@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.HiveDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/HiveDark_Providers.svg")
                },
                JetBrainsIconKind.HiveDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/HiveDark_ToolWindows.svg")
                },
                JetBrainsIconKind.HiveFileType_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HiveFileType_Database.svg")
                },
                JetBrainsIconKind.HiveFileTypeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/HiveFileTypeDark_Database.svg")
                },
                JetBrainsIconKind.Home_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Home_Writerside.svg")
                },
                JetBrainsIconKind.HomeDark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/HomeDark_Writerside.svg")
                },
                JetBrainsIconKind.HomeFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/HomeFolder_Nodes.svg")
                },
                JetBrainsIconKind.HomeFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/HomeFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.Hsqldb_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Hsqldb_Providers.svg")
                },
                JetBrainsIconKind.HsqldbDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/HsqldbDark_Providers.svg")
                },
                JetBrainsIconKind.Html_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Html_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.HtmlDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/HtmlDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Http_request_REST => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/REST/Http_request_REST.svg")
                },
                JetBrainsIconKind.Http_requestDark_REST => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/REST/Http_requestDark_REST.svg")
                },
                JetBrainsIconKind.Hyperskill_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Hyperskill_EduTools.svg")
                },
                JetBrainsIconKind.HyperskillBlue_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/HyperskillBlue_EduTools.svg")
                },
                JetBrainsIconKind.HyperskillBlueDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/HyperskillBlueDark_EduTools.svg")
                },
                JetBrainsIconKind.HyperskillDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/HyperskillDark_EduTools.svg")
                },
                JetBrainsIconKind.Ibm_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Ibm_Providers.svg")
                },
                JetBrainsIconKind.IbmDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/IbmDark_Providers.svg")
                },
                JetBrainsIconKind.Id_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Id_Cssselector.svg")
                },
                JetBrainsIconKind.Id14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Id@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.Id14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Id@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.IdDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/IdDark_Cssselector.svg")
                },
                JetBrainsIconKind.IdeaModule_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/IdeaModule_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.IdeaModuleDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/IdeaModuleDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.IdeUpdate_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/IdeUpdate_General.svg")
                },
                JetBrainsIconKind.IdeUpdateDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/IdeUpdateDark_General.svg")
                },
                JetBrainsIconKind.Idl_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Idl_FilesNodes.svg")
                },
                JetBrainsIconKind.IdlDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/IdlDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Ignored_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Ignored_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.IgnoredDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/IgnoredDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Image_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Image_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ImageDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ImageDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Impala_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Impala_Providers.svg")
                },
                JetBrainsIconKind.ImpalaDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/ImpalaDark_Providers.svg")
                },
                JetBrainsIconKind.Impl_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Impl_Rust.svg")
                },
                JetBrainsIconKind.ImplDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/ImplDark_Rust.svg")
                },
                JetBrainsIconKind.ImplementedMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementedMethod_Editor.svg")
                },
                JetBrainsIconKind.ImplementedMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementedMethodDark_Editor.svg")
                },
                JetBrainsIconKind.ImplementingFunctionalInterface_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementingFunctionalInterface_Editor.svg")
                },
                JetBrainsIconKind.ImplementingFunctionalInterfaceDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementingFunctionalInterfaceDark_Editor.svg")
                },
                JetBrainsIconKind.ImplementingMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementingMethod_Editor.svg")
                },
                JetBrainsIconKind.ImplementingMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/ImplementingMethodDark_Editor.svg")
                },
                JetBrainsIconKind.ImplicitBean_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ImplicitBean_Spring.svg")
                },
                JetBrainsIconKind.ImplicitBeanDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ImplicitBeanDark_Spring.svg")
                },
                JetBrainsIconKind.Import_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Import_General.svg")
                },
                JetBrainsIconKind.ImportAlias_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/ImportAlias_GoLang.svg")
                },
                JetBrainsIconKind.ImportAliasDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/ImportAliasDark_GoLang.svg")
                },
                JetBrainsIconKind.ImportDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ImportDark_General.svg")
                },
                JetBrainsIconKind.Include_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Include_Writerside.svg")
                },
                JetBrainsIconKind.Include14_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Include@14x14_Writerside.svg")
                },
                JetBrainsIconKind.Include14Dark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Include@14x14Dark_Writerside.svg")
                },
                JetBrainsIconKind.IncludeDark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/IncludeDark_Writerside.svg")
                },
                JetBrainsIconKind.IncompleteClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/IncompleteClosed_Ruby.svg")
                },
                JetBrainsIconKind.IncompleteClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/IncompleteClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.Index_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Index_Database.svg")
                },
                JetBrainsIconKind.IndexCluster_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexCluster_Database.svg")
                },
                JetBrainsIconKind.IndexClusterDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexClusterDark_Database.svg")
                },
                JetBrainsIconKind.IndexDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexDark_Database.svg")
                },
                JetBrainsIconKind.IndexFun_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexFun_Database.svg")
                },
                JetBrainsIconKind.IndexFunDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexFunDark_Database.svg")
                },
                JetBrainsIconKind.IndexFunUnique_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexFunUnique_Database.svg")
                },
                JetBrainsIconKind.IndexFunUniqueDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexFunUniqueDark_Database.svg")
                },
                JetBrainsIconKind.IndexUnique_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexUnique_Database.svg")
                },
                JetBrainsIconKind.IndexUniqueDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/IndexUniqueDark_Database.svg")
                },
                JetBrainsIconKind.Info_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/Info_Status.svg")
                },
                JetBrainsIconKind.InfoDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/InfoDark_Status.svg")
                },
                JetBrainsIconKind.InfoOutline_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/InfoOutline_Status.svg")
                },
                JetBrainsIconKind.InfoOutlineDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/InfoOutlineDark_Status.svg")
                },
                JetBrainsIconKind.InformationDialog_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/InformationDialog_Status.svg")
                },
                JetBrainsIconKind.InformationDialogDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/InformationDialogDark_Status.svg")
                },
                JetBrainsIconKind.Informix_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Informix_Providers.svg")
                },
                JetBrainsIconKind.InformixDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/InformixDark_Providers.svg")
                },
                JetBrainsIconKind.InfrastructureBean_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/InfrastructureBean_Spring.svg")
                },
                JetBrainsIconKind.InfrastructureBean14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/InfrastructureBean@14x14_Spring.svg")
                },
                JetBrainsIconKind.InfrastructureBean14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/InfrastructureBean@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.InfrastructureBeanDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/InfrastructureBeanDark_Spring.svg")
                },
                JetBrainsIconKind.InlayGlobe_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayGlobe_Editor.svg")
                },
                JetBrainsIconKind.InlayGlobeDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayGlobeDark_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInComments_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInComments_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInCommentsActive_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInCommentsActive_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInCommentsActiveDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInCommentsActiveDark_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInCommentsDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInCommentsDark_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInNoCodeFiles_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInNoCodeFiles_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInNoCodeFilesActive_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInNoCodeFilesActive_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInNoCodeFilesActiveDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInNoCodeFilesActiveDark_Editor.svg")
                },
                JetBrainsIconKind.InlayRenameInNoCodeFilesDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlayRenameInNoCodeFilesDark_Editor.svg")
                },
                JetBrainsIconKind.InlaySecuredShield_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlaySecuredShield_Editor.svg")
                },
                JetBrainsIconKind.InlaySecuredShieldDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlaySecuredShieldDark_Editor.svg")
                },
                JetBrainsIconKind.InlaySettings_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlaySettings_Editor.svg")
                },
                JetBrainsIconKind.InlaySettingsDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/InlaySettingsDark_Editor.svg")
                },
                JetBrainsIconKind.InlineAdd => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineAdd.svg")
                },
                JetBrainsIconKind.InlineAddDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineAddDark.svg")
                },
                JetBrainsIconKind.InlineEdit => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineEdit.svg")
                },
                JetBrainsIconKind.InlineEditDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineEditDark.svg")
                },
                JetBrainsIconKind.InlineSettings => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineSettings.svg")
                },
                JetBrainsIconKind.InlineSettingsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/InlineSettingsDark.svg")
                },
                JetBrainsIconKind.InspectionsEye_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsEye_Editor.svg")
                },
                JetBrainsIconKind.InspectionsEyeDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsEyeDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsMixed_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsMixed_Editor.svg")
                },
                JetBrainsIconKind.InspectionsMixedDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsMixedDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsOK_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsOK_Editor.svg")
                },
                JetBrainsIconKind.InspectionsOKDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsOKDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsOKEmpty_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsOKEmpty_Editor.svg")
                },
                JetBrainsIconKind.InspectionsOKEmptyDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsOKEmptyDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsPause_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsPause_Editor.svg")
                },
                JetBrainsIconKind.InspectionsPauseDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsPauseDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsPowerSaveMode_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsPowerSaveMode_Editor.svg")
                },
                JetBrainsIconKind.InspectionsPowerSaveModeDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsPowerSaveModeDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsTrafficOff_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsTrafficOff_Editor.svg")
                },
                JetBrainsIconKind.InspectionsTrafficOffDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsTrafficOffDark_Editor.svg")
                },
                JetBrainsIconKind.InspectionsTypos_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsTypos_Editor.svg")
                },
                JetBrainsIconKind.InspectionsTyposDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/InspectionsTyposDark_Editor.svg")
                },
                JetBrainsIconKind.Install_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Install_Cidr.svg")
                },
                JetBrainsIconKind.InstallDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/InstallDark_Cidr.svg")
                },
                JetBrainsIconKind.Integration_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Integration_Spring.svg")
                },
                JetBrainsIconKind.IntegrationDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/IntegrationDark_Spring.svg")
                },
                JetBrainsIconKind.IntelliSort_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/IntelliSort_Vcs.svg")
                },
                JetBrainsIconKind.IntelliSortDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/IntelliSortDark_Vcs.svg")
                },
                JetBrainsIconKind.IntentionBulb_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/IntentionBulb_Editor.svg")
                },
                JetBrainsIconKind.IntentionBulbDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/IntentionBulbDark_Editor.svg")
                },
                JetBrainsIconKind.IntentionBulbGrey_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/IntentionBulbGrey_Editor.svg")
                },
                JetBrainsIconKind.IntentionBulbGreyDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/IntentionBulbGreyDark_Editor.svg")
                },
                JetBrainsIconKind.Interface_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Interface_Nodes.svg")
                },
                JetBrainsIconKind.InterfaceDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/InterfaceDark_Nodes.svg")
                },
                JetBrainsIconKind.InterfaceKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/InterfaceKotlin.svg")
                },
                JetBrainsIconKind.InterfaceKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/InterfaceKotlinDark.svg")
                },
                JetBrainsIconKind.IntersystemCache_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/IntersystemCache_Providers.svg")
                },
                JetBrainsIconKind.IntersystemCacheDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/IntersystemCacheDark_Providers.svg")
                },
                JetBrainsIconKind.InvalidConfigurationLayer_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/InvalidConfigurationLayer_RunDebug.svg")
                },
                JetBrainsIconKind.InvalidConfigurationLayerDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/InvalidConfigurationLayerDark_RunDebug.svg")
                },
                JetBrainsIconKind.IOCFileType_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/IOCFileType_Cidr.svg")
                },
                JetBrainsIconKind.IOCFileTypeDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/IOCFileTypeDark_Cidr.svg")
                },
                JetBrainsIconKind.IPhoneDevice_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/IPhoneDevice_Cidr.svg")
                },
                JetBrainsIconKind.IPhoneDeviceDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/IPhoneDeviceDark_Cidr.svg")
                },
                JetBrainsIconKind.Java_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Java_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JavaDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JavaDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JavadocEdit_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/JavadocEdit_Gutter.svg")
                },
                JetBrainsIconKind.JavadocEditDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/JavadocEditDark_Gutter.svg")
                },
                JetBrainsIconKind.JavadocRead_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/JavadocRead_Gutter.svg")
                },
                JetBrainsIconKind.JavadocReadDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/JavadocReadDark_Gutter.svg")
                },
                JetBrainsIconKind.JavaScratch_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScratch_RunDebug.svg")
                },
                JetBrainsIconKind.JavaScratchDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScratchDark_RunDebug.svg")
                },
                JetBrainsIconKind.JavaScript_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JavaScript_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JavaScriptDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JavaScriptDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JavaScriptDebugConfiguration_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScriptDebugConfiguration_RunDebug.svg")
                },
                JetBrainsIconKind.JavaScriptDebugConfigurationDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScriptDebugConfigurationDark_RunDebug.svg")
                },
                JetBrainsIconKind.JavaScriptRemote_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScriptRemote_RunDebug.svg")
                },
                JetBrainsIconKind.JavaScriptRemoteDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JavaScriptRemoteDark_RunDebug.svg")
                },
                JetBrainsIconKind.Jdk_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Jdk_Nodes.svg")
                },
                JetBrainsIconKind.JdkDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/JdkDark_Nodes.svg")
                },
                JetBrainsIconKind.Jest_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Jest_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JestDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JestDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JetBrainsAcademy24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/JetBrainsAcademy@24x24_EduTools.svg")
                },
                JetBrainsIconKind.JetBrainsAcademy24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/JetBrainsAcademy@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.Jfr_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Jfr_FilesNodes.svg")
                },
                JetBrainsIconKind.JfrDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/JfrDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Jpa_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Jpa_Spring.svg")
                },
                JetBrainsIconKind.JpaDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/JpaDark_Spring.svg")
                },
                JetBrainsIconKind.JrailsModuleClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrailsModuleClosed_Ruby.svg")
                },
                JetBrainsIconKind.JrailsModuleClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrailsModuleClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.Jruby_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Jruby_Ruby.svg")
                },
                JetBrainsIconKind.JrubyDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrubyDark_Ruby.svg")
                },
                JetBrainsIconKind.JrubyRunConfiguration_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrubyRunConfiguration_Ruby.svg")
                },
                JetBrainsIconKind.JrubyRunConfigurationDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrubyRunConfigurationDark_Ruby.svg")
                },
                JetBrainsIconKind.JrubySdkClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrubySdkClosed_Ruby.svg")
                },
                JetBrainsIconKind.JrubySdkClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/JrubySdkClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.Js_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Js_Kotlin.svg")
                },
                JetBrainsIconKind.JsDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/JsDark_Kotlin.svg")
                },
                JetBrainsIconKind.Jshint_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Jshint_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JshintDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JshintDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Json_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Json_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.JsonDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/JsonDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Jsp_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Jsp_FilesNodes.svg")
                },
                JetBrainsIconKind.JspDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/JspDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Jspx_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Jspx_FilesNodes.svg")
                },
                JetBrainsIconKind.JspxDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/JspxDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Junit_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Junit_RunDebug.svg")
                },
                JetBrainsIconKind.JunitDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JunitDark_RunDebug.svg")
                },
                JetBrainsIconKind.JunitTestMark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JunitTestMark_RunDebug.svg")
                },
                JetBrainsIconKind.JunitTestMarkDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/JunitTestMarkDark_RunDebug.svg")
                },
                JetBrainsIconKind.JupyterToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/JupyterToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.JupyterToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/JupyterToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.JupyterToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/JupyterToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.JupyterToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/JupyterToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Jvm_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Jvm_Kotlin.svg")
                },
                JetBrainsIconKind.JvmDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/JvmDark_Kotlin.svg")
                },
                JetBrainsIconKind.Kafka_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Kafka_ToolWindows.svg")
                },
                JetBrainsIconKind.Kafka20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Kafka@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Kafka20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Kafka@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.KafkaDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/KafkaDark_ToolWindows.svg")
                },
                JetBrainsIconKind.KillDataSourceProcess_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/KillDataSourceProcess_Database.svg")
                },
                JetBrainsIconKind.KillDataSourceProcessDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/KillDataSourceProcessDark_Database.svg")
                },
                JetBrainsIconKind.KillProcess_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/KillProcess_Run.svg")
                },
                JetBrainsIconKind.KillProcessDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/KillProcessDark_Run.svg")
                },
                JetBrainsIconKind.Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Kotlin.svg")
                },
                JetBrainsIconKind.Kotlin_activity => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Kotlin_activity.svg")
                },
                JetBrainsIconKind.Kotlin_activityDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Kotlin_activityDark.svg")
                },
                JetBrainsIconKind.Kotlin_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Kotlin_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.KotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinDark.svg")
                },
                JetBrainsIconKind.KotlinDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/KotlinDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.KotlinGradleScript => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinGradleScript.svg")
                },
                JetBrainsIconKind.KotlinGradleScriptDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinGradleScriptDark.svg")
                },
                JetBrainsIconKind.KotlinJs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinJs.svg")
                },
                JetBrainsIconKind.KotlinJsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinJsDark.svg")
                },
                JetBrainsIconKind.KotlinModifier => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinModifier.svg")
                },
                JetBrainsIconKind.KotlinModifierDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinModifierDark.svg")
                },
                JetBrainsIconKind.KotlinScript => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinScript.svg")
                },
                JetBrainsIconKind.KotlinScriptDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/KotlinScriptDark.svg")
                },
                JetBrainsIconKind.KotlinToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/KotlinToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.KotlinToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/KotlinToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.KotlinToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/KotlinToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.KotlinToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/KotlinToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Lambda_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Lambda_Kotlin.svg")
                },
                JetBrainsIconKind.Lambda_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Lambda_Nodes.svg")
                },
                JetBrainsIconKind.Lambda_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Lambda_Scala.svg")
                },
                JetBrainsIconKind.LambdaDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/LambdaDark_Kotlin.svg")
                },
                JetBrainsIconKind.LambdaDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/LambdaDark_Nodes.svg")
                },
                JetBrainsIconKind.LambdaDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/LambdaDark_Scala.svg")
                },
                JetBrainsIconKind.Layout_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Layout_General.svg")
                },
                JetBrainsIconKind.LayoutDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/LayoutDark_General.svg")
                },
                JetBrainsIconKind.Ld_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Ld_Cidr.svg")
                },
                JetBrainsIconKind.LdDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LdDark_Cidr.svg")
                },
                JetBrainsIconKind.Learn_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Learn_ToolWindows.svg")
                },
                JetBrainsIconKind.Learn20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Learn@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Learn20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Learn@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.LearnDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/LearnDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Left_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Left_General.svg")
                },
                JetBrainsIconKind.LeftDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/LeftDark_General.svg")
                },
                JetBrainsIconKind.Less_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Less_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.LessDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/LessDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.LevelOneDeclared_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneDeclared_Database.svg")
                },
                JetBrainsIconKind.LevelOneDeclaredDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneDeclaredDark_Database.svg")
                },
                JetBrainsIconKind.LevelOneDetails_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneDetails_Database.svg")
                },
                JetBrainsIconKind.LevelOneDetailsDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneDetailsDark_Database.svg")
                },
                JetBrainsIconKind.LevelOneInherited_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneInherited_Database.svg")
                },
                JetBrainsIconKind.LevelOneInheritedDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelOneInheritedDark_Database.svg")
                },
                JetBrainsIconKind.LevelThreeDeclared_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeDeclared_Database.svg")
                },
                JetBrainsIconKind.LevelThreeDeclaredDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeDeclaredDark_Database.svg")
                },
                JetBrainsIconKind.LevelThreeDetails_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeDetails_Database.svg")
                },
                JetBrainsIconKind.LevelThreeDetailsDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeDetailsDark_Database.svg")
                },
                JetBrainsIconKind.LevelThreeInherited_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeInherited_Database.svg")
                },
                JetBrainsIconKind.LevelThreeInheritedDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelThreeInheritedDark_Database.svg")
                },
                JetBrainsIconKind.LevelTwoDeclared_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoDeclared_Database.svg")
                },
                JetBrainsIconKind.LevelTwoDeclaredDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoDeclaredDark_Database.svg")
                },
                JetBrainsIconKind.LevelTwoDetails_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoDetails_Database.svg")
                },
                JetBrainsIconKind.LevelTwoDetailsDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoDetailsDark_Database.svg")
                },
                JetBrainsIconKind.LevelTwoInherited_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoInherited_Database.svg")
                },
                JetBrainsIconKind.LevelTwoInheritedDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/LevelTwoInheritedDark_Database.svg")
                },
                JetBrainsIconKind.Library_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Library_Nodes.svg")
                },
                JetBrainsIconKind.LibraryDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/LibraryDark_Nodes.svg")
                },
                JetBrainsIconKind.LibraryFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/LibraryFolder_Nodes.svg")
                },
                JetBrainsIconKind.LibraryFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/LibraryFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.LibValidator_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/LibValidator_Spring.svg")
                },
                JetBrainsIconKind.LibValidatorDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/LibValidatorDark_Spring.svg")
                },
                JetBrainsIconKind.LightbendLogo_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/LightbendLogo_Scala.svg")
                },
                JetBrainsIconKind.LightbendLogoDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/LightbendLogoDark_Scala.svg")
                },
                JetBrainsIconKind.LightTheme_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/LightTheme_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.LightThemeDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/LightThemeDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.LightThemeSelected_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/LightThemeSelected_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.LightThemeSelectedDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/LightThemeSelectedDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.Like_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/Like_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.LikeDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/LikeDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.LikeDimmed_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/LikeDimmed_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.LikeDimmedDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/LikeDimmedDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.LikeSelected_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/LikeSelected_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.LikeSelectedDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/LikeSelectedDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.List_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/List_Database.svg")
                },
                JetBrainsIconKind.ListDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ListDark_Database.svg")
                },
                JetBrainsIconKind.Listener_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Listener_Spring.svg")
                },
                JetBrainsIconKind.Listener14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Listener@14x14_Spring.svg")
                },
                JetBrainsIconKind.Listener14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Listener@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.ListenerDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ListenerDark_Spring.svg")
                },
                JetBrainsIconKind.ListFiles_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ListFiles_General.svg")
                },
                JetBrainsIconKind.ListFilesDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ListFilesDark_General.svg")
                },
                JetBrainsIconKind.ListKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ListKey_Database.svg")
                },
                JetBrainsIconKind.ListKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ListKeyDark_Database.svg")
                },
                JetBrainsIconKind.LiveBean14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/LiveBean@14x14_Spring.svg")
                },
                JetBrainsIconKind.LiveBean14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/LiveBean@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.Loader => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Loader/Loader.svg")
                },
                JetBrainsIconKind.Loader34 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Loader/Loader@34x34.svg")
                },
                JetBrainsIconKind.Loader34Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Loader/Loader@34x34Dark.svg")
                },
                JetBrainsIconKind.LoaderDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Loader/LoaderDark.svg")
                },
                JetBrainsIconKind.LoadSwiftPackageManagerChanges_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LoadSwiftPackageManagerChanges_Cidr.svg")
                },
                JetBrainsIconKind.LoadSwiftPackageManagerChangesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LoadSwiftPackageManagerChangesDark_Cidr.svg")
                },
                JetBrainsIconKind.LocalChanges_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/LocalChanges_SettingSync.svg")
                },
                JetBrainsIconKind.LocalChangesDark_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/LocalChangesDark_SettingSync.svg")
                },
                JetBrainsIconKind.LocalScope_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/LocalScope_FilesNodes.svg")
                },
                JetBrainsIconKind.LocalScopeDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/LocalScopeDark_FilesNodes.svg")
                },
                JetBrainsIconKind.LocalSwiftPackageDependency_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LocalSwiftPackageDependency_Cidr.svg")
                },
                JetBrainsIconKind.LocalSwiftPackageDependencyDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LocalSwiftPackageDependencyDark_Cidr.svg")
                },
                JetBrainsIconKind.Locate_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Locate_General.svg")
                },
                JetBrainsIconKind.LocateDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/LocateDark_General.svg")
                },
                JetBrainsIconKind.Location_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Location_Cidr.svg")
                },
                JetBrainsIconKind.LocationDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/LocationDark_Cidr.svg")
                },
                JetBrainsIconKind.Locked_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Locked_General.svg")
                },
                JetBrainsIconKind.LockedDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/LockedDark_General.svg")
                },
                JetBrainsIconKind.LoggedInUser_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/LoggedInUser_EduTools.svg")
                },
                JetBrainsIconKind.LoggedInUserDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/LoggedInUserDark_EduTools.svg")
                },
                JetBrainsIconKind.Lombok_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Lombok_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.LombokConfig_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/LombokConfig_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.LombokConfigDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/LombokConfigDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.LombokDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/LombokDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.M_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/M_Cidr.svg")
                },
                JetBrainsIconKind.Macro_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Macro_Database.svg")
                },
                JetBrainsIconKind.Macro_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Macro_Rust.svg")
                },
                JetBrainsIconKind.Macro2_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Macro2_Rust.svg")
                },
                JetBrainsIconKind.Macro2Dark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Macro2Dark_Rust.svg")
                },
                JetBrainsIconKind.MacroDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MacroDark_Database.svg")
                },
                JetBrainsIconKind.MacroDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MacroDark_Rust.svg")
                },
                JetBrainsIconKind.MacroF_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MacroF_Rust.svg")
                },
                JetBrainsIconKind.MacroFDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MacroFDark_Rust.svg")
                },
                JetBrainsIconKind.MacroP_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MacroP_Rust.svg")
                },
                JetBrainsIconKind.MacroPDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MacroPDark_Rust.svg")
                },
                JetBrainsIconKind.MagicResolve14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/MagicResolve@14x14_Vcs.svg")
                },
                JetBrainsIconKind.MagicResolve14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/MagicResolve@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.MagicResolveToolbar_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/MagicResolveToolbar_Vcs.svg")
                },
                JetBrainsIconKind.MagicResolveToolbarDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/MagicResolveToolbarDark_Vcs.svg")
                },
                JetBrainsIconKind.Mailer_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Mailer_Ruby.svg")
                },
                JetBrainsIconKind.Mailer14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Mailer@14x14_Ruby.svg")
                },
                JetBrainsIconKind.Mailer14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Mailer@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.MailerDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/MailerDark_Ruby.svg")
                },
                JetBrainsIconKind.MailersFolder_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/MailersFolder_Ruby.svg")
                },
                JetBrainsIconKind.MailersFolderDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/MailersFolderDark_Ruby.svg")
                },
                JetBrainsIconKind.Makefile_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Makefile_Cidr.svg")
                },
                JetBrainsIconKind.MakefileApp_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MakefileApp_Cidr.svg")
                },
                JetBrainsIconKind.MakefileAppDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MakefileAppDark_Cidr.svg")
                },
                JetBrainsIconKind.MakefileDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MakefileDark_Cidr.svg")
                },
                JetBrainsIconKind.MakefileLoadChanges_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MakefileLoadChanges_Cidr.svg")
                },
                JetBrainsIconKind.MakefileLoadChangesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MakefileLoadChangesDark_Cidr.svg")
                },
                JetBrainsIconKind.MakefileToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/MakefileToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.MakefileToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/MakefileToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.MakefileToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/MakefileToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.MakefileToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/MakefileToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ManageDataSources_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ManageDataSources_Database.svg")
                },
                JetBrainsIconKind.ManageDataSourcesDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ManageDataSourcesDark_Database.svg")
                },
                JetBrainsIconKind.Manifest_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Manifest_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ManifestDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ManifestDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Mariadb_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Mariadb_Providers.svg")
                },
                JetBrainsIconKind.MariadbDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MariadbDark_Providers.svg")
                },
                JetBrainsIconKind.Markdown_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Markdown_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.MarkdownDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/MarkdownDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.MatchCase_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/MatchCase_Inline.svg")
                },
                JetBrainsIconKind.MatchCaseDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/MatchCaseDark_Inline.svg")
                },
                JetBrainsIconKind.MaterializedLog_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MaterializedLog_Database.svg")
                },
                JetBrainsIconKind.MaterializedLogDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MaterializedLogDark_Database.svg")
                },
                JetBrainsIconKind.MaterializedView_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MaterializedView_Database.svg")
                },
                JetBrainsIconKind.MaterializedViewDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MaterializedViewDark_Database.svg")
                },
                JetBrainsIconKind.Maven_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Maven_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Maven_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Maven_ToolWindows.svg")
                },
                JetBrainsIconKind.Maven20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Maven@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Maven20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Maven@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.MavenBind_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenBind_RunDebug.svg")
                },
                JetBrainsIconKind.MavenBindChecksum_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenBindChecksum_RunDebug.svg")
                },
                JetBrainsIconKind.MavenBindChecksumDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenBindChecksumDark_RunDebug.svg")
                },
                JetBrainsIconKind.MavenBindDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenBindDark_RunDebug.svg")
                },
                JetBrainsIconKind.MavenChecksum_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenChecksum_RunDebug.svg")
                },
                JetBrainsIconKind.MavenChecksumDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/MavenChecksumDark_RunDebug.svg")
                },
                JetBrainsIconKind.MavenChildrenProjects_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenChildrenProjects_Build.svg")
                },
                JetBrainsIconKind.MavenChildrenProjectsDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenChildrenProjectsDark_Build.svg")
                },
                JetBrainsIconKind.MavenDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/MavenDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.MavenDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/MavenDark_ToolWindows.svg")
                },
                JetBrainsIconKind.MavenFlex_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenFlex_Build.svg")
                },
                JetBrainsIconKind.MavenFlexDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenFlexDark_Build.svg")
                },
                JetBrainsIconKind.MavenIgnored_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/MavenIgnored_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.MavenIgnoredDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/MavenIgnoredDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.MavenLoadChanges_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenLoadChanges_Build.svg")
                },
                JetBrainsIconKind.MavenLoadChangesDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenLoadChangesDark_Build.svg")
                },
                JetBrainsIconKind.MavenModule_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenModule_Build.svg")
                },
                JetBrainsIconKind.MavenModuleDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenModuleDark_Build.svg")
                },
                JetBrainsIconKind.MavenParentProjects_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenParentProjects_Build.svg")
                },
                JetBrainsIconKind.MavenParentProjectsDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenParentProjectsDark_Build.svg")
                },
                JetBrainsIconKind.MavenPlugin_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenPlugin_Build.svg")
                },
                JetBrainsIconKind.MavenPluginDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenPluginDark_Build.svg")
                },
                JetBrainsIconKind.MavenPluginGoal_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenPluginGoal_Build.svg")
                },
                JetBrainsIconKind.MavenPluginGoalDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenPluginGoalDark_Build.svg")
                },
                JetBrainsIconKind.MavenProfiles_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenProfiles_Build.svg")
                },
                JetBrainsIconKind.MavenProfilesDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenProfilesDark_Build.svg")
                },
                JetBrainsIconKind.MavenProject_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenProject_Build.svg")
                },
                JetBrainsIconKind.MavenProjectDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/MavenProjectDark_Build.svg")
                },
                JetBrainsIconKind.Maximize_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Maximize_Windows.svg")
                },
                JetBrainsIconKind.MaximizeDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MaximizeDark_Windows.svg")
                },
                JetBrainsIconKind.MaximizeInactive_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MaximizeInactive_Windows.svg")
                },
                JetBrainsIconKind.MaximizeInactiveDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MaximizeInactiveDark_Windows.svg")
                },
                JetBrainsIconKind.MaximizeSmall_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MaximizeSmall_Windows.svg")
                },
                JetBrainsIconKind.MaximizeSmallDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MaximizeSmallDark_Windows.svg")
                },
                JetBrainsIconKind.MDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MDark_Cidr.svg")
                },
                JetBrainsIconKind.MergeCallees_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/MergeCallees_Profiler.svg")
                },
                JetBrainsIconKind.MergeCalleesDark_Profiler => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Profiler/MergeCalleesDark_Profiler.svg")
                },
                JetBrainsIconKind.Messages_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Messages_ToolWindows.svg")
                },
                JetBrainsIconKind.Messages20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Messages@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Messages20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Messages@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.MessagesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/MessagesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Metal_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Metal_Cidr.svg")
                },
                JetBrainsIconKind.MetalDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MetalDark_Cidr.svg")
                },
                JetBrainsIconKind.Method_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Method_Nodes.svg")
                },
                JetBrainsIconKind.Method_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Method_Rust.svg")
                },
                JetBrainsIconKind.MethodAbstract_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/MethodAbstract_Nodes.svg")
                },
                JetBrainsIconKind.MethodAbstractDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/MethodAbstractDark_Nodes.svg")
                },
                JetBrainsIconKind.MethodDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/MethodDark_Nodes.svg")
                },
                JetBrainsIconKind.MethodDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/MethodDark_Rust.svg")
                },
                JetBrainsIconKind.MethodReference_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/MethodReference_Nodes.svg")
                },
                JetBrainsIconKind.MethodReferenceDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/MethodReferenceDark_Nodes.svg")
                },
                JetBrainsIconKind.Microsoft_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Microsoft_Providers.svg")
                },
                JetBrainsIconKind.MicrosoftDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MicrosoftDark_Providers.svg")
                },
                JetBrainsIconKind.MigrationsClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/MigrationsClosed_Ruby.svg")
                },
                JetBrainsIconKind.MigrationsClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/MigrationsClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.MimerSQL_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MimerSQL_Providers.svg")
                },
                JetBrainsIconKind.MimerSQLDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MimerSQLDark_Providers.svg")
                },
                JetBrainsIconKind.Minimize_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Minimize_Windows.svg")
                },
                JetBrainsIconKind.MinimizeDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MinimizeDark_Windows.svg")
                },
                JetBrainsIconKind.MinimizeInactive_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MinimizeInactive_Windows.svg")
                },
                JetBrainsIconKind.MinimizeInactiveDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MinimizeInactiveDark_Windows.svg")
                },
                JetBrainsIconKind.MinimizeSmall_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MinimizeSmall_Windows.svg")
                },
                JetBrainsIconKind.MinimizeSmallDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/MinimizeSmallDark_Windows.svg")
                },
                JetBrainsIconKind.Mm_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Mm_Cidr.svg")
                },
                JetBrainsIconKind.MmDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/MmDark_Cidr.svg")
                },
                JetBrainsIconKind.Mnemonic_Bookmarks => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/Mnemonic_Bookmarks.svg")
                },
                JetBrainsIconKind.Mnemonic_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Mnemonic_Gutter.svg")
                },
                JetBrainsIconKind.MnemonicDark_Bookmarks => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Bookmarks/Bookmarks/MnemonicDark_Bookmarks.svg")
                },
                JetBrainsIconKind.MnemonicDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/MnemonicDark_Gutter.svg")
                },
                JetBrainsIconKind.MobileDesktop_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/MobileDesktop_Aqua.svg")
                },
                JetBrainsIconKind.MobileDesktopDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/MobileDesktopDark_Aqua.svg")
                },
                JetBrainsIconKind.ModelClass_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModelClass_Nodes.svg")
                },
                JetBrainsIconKind.ModelClass_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ModelClass_Ruby.svg")
                },
                JetBrainsIconKind.ModelClassDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModelClassDark_Nodes.svg")
                },
                JetBrainsIconKind.ModelClassDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ModelClassDark_Ruby.svg")
                },
                JetBrainsIconKind.Modified_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Modified_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ModifiedDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ModifiedDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Module_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Module_Nodes.svg")
                },
                JetBrainsIconKind.Module_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Module_Ruby.svg")
                },
                JetBrainsIconKind.Module_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Module_Rust.svg")
                },
                JetBrainsIconKind.Module8x8_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Module8x8_Nodes.svg")
                },
                JetBrainsIconKind.Module8x8Dark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Module8x8Dark_Nodes.svg")
                },
                JetBrainsIconKind.ModuleDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModuleDark_Nodes.svg")
                },
                JetBrainsIconKind.ModuleDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ModuleDark_Ruby.svg")
                },
                JetBrainsIconKind.ModuleDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/ModuleDark_Rust.svg")
                },
                JetBrainsIconKind.ModuleGroup_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModuleGroup_Nodes.svg")
                },
                JetBrainsIconKind.ModuleGroupDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModuleGroupDark_Nodes.svg")
                },
                JetBrainsIconKind.ModuleJava_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModuleJava_Nodes.svg")
                },
                JetBrainsIconKind.ModuleJavaDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ModuleJavaDark_Nodes.svg")
                },
                JetBrainsIconKind.Modulemap_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Modulemap_Cidr.svg")
                },
                JetBrainsIconKind.ModulemapDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ModulemapDark_Cidr.svg")
                },
                JetBrainsIconKind.MongoDB_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MongoDB_Providers.svg")
                },
                JetBrainsIconKind.MongoDB14_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoDB@14x14_Database.svg")
                },
                JetBrainsIconKind.MongoDB14Dark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoDB@14x14Dark_Database.svg")
                },
                JetBrainsIconKind.MongoDBDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MongoDBDark_Providers.svg")
                },
                JetBrainsIconKind.MongoField_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoField_Database.svg")
                },
                JetBrainsIconKind.MongoField14_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoField@14x14_Database.svg")
                },
                JetBrainsIconKind.MongoField14Dark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoField@14x14Dark_Database.svg")
                },
                JetBrainsIconKind.MongoFieldDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoFieldDark_Database.svg")
                },
                JetBrainsIconKind.MongoFieldGoldKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoFieldGoldKey_Database.svg")
                },
                JetBrainsIconKind.MongoFieldGoldKey14_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoFieldGoldKey@14x14_Database.svg")
                },
                JetBrainsIconKind.MongoFieldGoldKey14Dark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoFieldGoldKey@14x14Dark_Database.svg")
                },
                JetBrainsIconKind.MongoFieldGoldKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/MongoFieldGoldKeyDark_Database.svg")
                },
                JetBrainsIconKind.MoreHorizontal_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreHorizontal_General.svg")
                },
                JetBrainsIconKind.MoreHorizontal20_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreHorizontal@20x20_General.svg")
                },
                JetBrainsIconKind.MoreHorizontal20Dark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreHorizontal@20x20Dark_General.svg")
                },
                JetBrainsIconKind.MoreHorizontalDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreHorizontalDark_General.svg")
                },
                JetBrainsIconKind.MoreVertical_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreVertical_General.svg")
                },
                JetBrainsIconKind.MoreVerticalDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoreVerticalDark_General.svg")
                },
                JetBrainsIconKind.MoveDown_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoveDown_General.svg")
                },
                JetBrainsIconKind.MoveDownDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoveDownDark_General.svg")
                },
                JetBrainsIconKind.MoveUp_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoveUp_General.svg")
                },
                JetBrainsIconKind.MoveUpDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/MoveUpDark_General.svg")
                },
                JetBrainsIconKind.Multiplatform_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Multiplatform_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformDark_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformLibrary_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformLibrary_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformLibraryDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformLibraryDark_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformMobile_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformMobile_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformMobileDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformMobileDark_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformMobileLibrary_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformMobileLibrary_Kotlin.svg")
                },
                JetBrainsIconKind.MultiplatformMobileLibraryDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/MultiplatformMobileLibraryDark_Kotlin.svg")
                },
                JetBrainsIconKind.MultipleBreakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/MultipleBreakpoints.svg")
                },
                JetBrainsIconKind.MultipleBreakpointsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/MultipleBreakpointsDark.svg")
                },
                JetBrainsIconKind.MultipleTypeDefinitions_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/MultipleTypeDefinitions_Scala.svg")
                },
                JetBrainsIconKind.MultipleTypeDefinitionsDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/MultipleTypeDefinitionsDark_Scala.svg")
                },
                JetBrainsIconKind.MuteBreakpoints_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/MuteBreakpoints_Run.svg")
                },
                JetBrainsIconKind.MuteBreakpointsDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/MuteBreakpointsDark_Run.svg")
                },
                JetBrainsIconKind.Mysql_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Mysql_Providers.svg")
                },
                JetBrainsIconKind.MysqlDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/MysqlDark_Providers.svg")
                },
                JetBrainsIconKind.Name_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Name_Cssselector.svg")
                },
                JetBrainsIconKind.Name14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Name@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.Name14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Name@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.NameDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/NameDark_Cssselector.svg")
                },
                JetBrainsIconKind.NamespaceCpp_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/NamespaceCpp_Cidr.svg")
                },
                JetBrainsIconKind.NamespaceCppDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/NamespaceCppDark_Cidr.svg")
                },
                JetBrainsIconKind.Native_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Native_Kotlin.svg")
                },
                JetBrainsIconKind.NativeDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/NativeDark_Kotlin.svg")
                },
                JetBrainsIconKind.Netezza_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Netezza_Providers.svg")
                },
                JetBrainsIconKind.NetezzaDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/NetezzaDark_Providers.svg")
                },
                JetBrainsIconKind.NewFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/NewFolder_Nodes.svg")
                },
                JetBrainsIconKind.NewFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/NewFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.NewLine_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/NewLine_Inline.svg")
                },
                JetBrainsIconKind.NewLineDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/NewLineDark_Inline.svg")
                },
                JetBrainsIconKind.NewUI_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NewUI_ToolWindows.svg")
                },
                JetBrainsIconKind.NewUI20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NewUI@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.NewUI20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NewUI@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.NewUIDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NewUIDark_ToolWindows.svg")
                },
                JetBrainsIconKind.NextJS_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/NextJS_FilesNodes.svg")
                },
                JetBrainsIconKind.NextJSDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/NextJSDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Nodejs_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodejs_FilesNodes.svg")
                },
                JetBrainsIconKind.Nodejs_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Nodejs_Kotlin.svg")
                },
                JetBrainsIconKind.NodejsDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/NodejsDark_FilesNodes.svg")
                },
                JetBrainsIconKind.NodejsDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/NodejsDark_Kotlin.svg")
                },
                JetBrainsIconKind.NoScalaSDK => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/NoScalaSDK.svg")
                },
                JetBrainsIconKind.NoScalaSDKDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/NoScalaSDKDark.svg")
                },
                JetBrainsIconKind.NotDefined_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/NotDefined_Ruby.svg")
                },
                JetBrainsIconKind.NotDefinedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/NotDefinedDark_Ruby.svg")
                },
                JetBrainsIconKind.Notifications_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Notifications_ToolWindows.svg")
                },
                JetBrainsIconKind.Notifications20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Notifications@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Notifications20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Notifications@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.NotificationsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NotificationsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Npm_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Npm_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Npm_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Npm_ToolWindows.svg")
                },
                JetBrainsIconKind.Npm20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Npm@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Npm20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Npm@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.NpmDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/NpmDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.NpmDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/NpmDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ObjectCompanion_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectCompanion_Scala.svg")
                },
                JetBrainsIconKind.ObjectCompanionDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectCompanionDark_Scala.svg")
                },
                JetBrainsIconKind.ObjectCompanionSwapped_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectCompanionSwapped_Scala.svg")
                },
                JetBrainsIconKind.ObjectCompanionSwappedDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectCompanionSwappedDark_Scala.svg")
                },
                JetBrainsIconKind.ObjectGroup_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ObjectGroup_Database.svg")
                },
                JetBrainsIconKind.ObjectGroupDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ObjectGroupDark_Database.svg")
                },
                JetBrainsIconKind.ObjectKotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ObjectKotlin.svg")
                },
                JetBrainsIconKind.ObjectKotlinDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ObjectKotlinDark.svg")
                },
                JetBrainsIconKind.ObjectScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectScala.svg")
                },
                JetBrainsIconKind.ObjectScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ObjectScalaDark.svg")
                },
                JetBrainsIconKind.ObjectTypeAttribute_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ObjectTypeAttribute_Database.svg")
                },
                JetBrainsIconKind.ObjectTypeAttributeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ObjectTypeAttributeDark_Database.svg")
                },
                JetBrainsIconKind.OcdRunConfiguration_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/OcdRunConfiguration_Cidr.svg")
                },
                JetBrainsIconKind.OcdRunConfigurationDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/OcdRunConfigurationDark_Cidr.svg")
                },
                JetBrainsIconKind.Open_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Open_General.svg")
                },
                JetBrainsIconKind.OpenDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/OpenDark_General.svg")
                },
                JetBrainsIconKind.Openedge_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Openedge_Providers.svg")
                },
                JetBrainsIconKind.OpenedgeDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/OpenedgeDark_Providers.svg")
                },
                JetBrainsIconKind.OpenInToolWindow_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/OpenInToolWindow_General.svg")
                },
                JetBrainsIconKind.OpenInToolWindowDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/OpenInToolWindowDark_General.svg")
                },
                JetBrainsIconKind.OpenNewTab_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/OpenNewTab_General.svg")
                },
                JetBrainsIconKind.OpenNewTabDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/OpenNewTabDark_General.svg")
                },
                JetBrainsIconKind.Operator_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Operator_Database.svg")
                },
                JetBrainsIconKind.OperatorClass_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/OperatorClass_Database.svg")
                },
                JetBrainsIconKind.OperatorClassDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/OperatorClassDark_Database.svg")
                },
                JetBrainsIconKind.OperatorDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/OperatorDark_Database.svg")
                },
                JetBrainsIconKind.OperatorFamily_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/OperatorFamily_Database.svg")
                },
                JetBrainsIconKind.OperatorFamilyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/OperatorFamilyDark_Database.svg")
                },
                JetBrainsIconKind.Oracle_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Oracle_Providers.svg")
                },
                JetBrainsIconKind.OracleDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/OracleDark_Providers.svg")
                },
                JetBrainsIconKind.OverridenFactory14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridenFactory@14x14_Ruby.svg")
                },
                JetBrainsIconKind.OverridenFactory14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridenFactory@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.OverridenMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/OverridenMethod_Editor.svg")
                },
                JetBrainsIconKind.OverridenMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/OverridenMethodDark_Editor.svg")
                },
                JetBrainsIconKind.OverridingFactory14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingFactory@14x14_Ruby.svg")
                },
                JetBrainsIconKind.OverridingFactory14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingFactory@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.OverridingMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/OverridingMethod_Editor.svg")
                },
                JetBrainsIconKind.OverridingMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/OverridingMethodDark_Editor.svg")
                },
                JetBrainsIconKind.OverridingSequence14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingSequence@14x14_Ruby.svg")
                },
                JetBrainsIconKind.OverridingSequence14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingSequence@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.OverridingTrait14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingTrait@14x14_Ruby.svg")
                },
                JetBrainsIconKind.OverridingTrait14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/OverridingTrait@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.Package_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Package_Database.svg")
                },
                JetBrainsIconKind.Package_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Package_Nodes.svg")
                },
                JetBrainsIconKind.PackageDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PackageDark_Database.svg")
                },
                JetBrainsIconKind.PackageDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/PackageDark_Nodes.svg")
                },
                JetBrainsIconKind.PackageManager_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/PackageManager_ToolWindows.svg")
                },
                JetBrainsIconKind.PackageManager20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/PackageManager@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.PackageManager20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/PackageManager@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.PackageManagerDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/PackageManagerDark_ToolWindows.svg")
                },
                JetBrainsIconKind.PackageObject_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PackageObject_Scala.svg")
                },
                JetBrainsIconKind.PackageObjectDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PackageObjectDark_Scala.svg")
                },
                JetBrainsIconKind.PackageWithObject_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PackageWithObject_Scala.svg")
                },
                JetBrainsIconKind.PackageWithObjectDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PackageWithObjectDark_Scala.svg")
                },
                JetBrainsIconKind.Pagination_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Pagination_General.svg")
                },
                JetBrainsIconKind.PaginationDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PaginationDark_General.svg")
                },
                JetBrainsIconKind.Parameter_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Parameter_Nodes.svg")
                },
                JetBrainsIconKind.Parameter_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Parameter_Scala.svg")
                },
                JetBrainsIconKind.ParameterDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ParameterDark_Nodes.svg")
                },
                JetBrainsIconKind.ParameterDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ParameterDark_Scala.svg")
                },
                JetBrainsIconKind.ParentBeanGutter14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ParentBeanGutter@14x14_Spring.svg")
                },
                JetBrainsIconKind.ParentBeanGutter14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ParentBeanGutter@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.PartialClass14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialClass@14x14_Ruby.svg")
                },
                JetBrainsIconKind.PartialClass14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialClass@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.PartialMethod14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialMethod@14x14_Ruby.svg")
                },
                JetBrainsIconKind.PartialMethod14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialMethod@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.PartialModule14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialModule@14x14_Ruby.svg")
                },
                JetBrainsIconKind.PartialModule14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/PartialModule@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.Partion_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Partion_Database.svg")
                },
                JetBrainsIconKind.PartionDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PartionDark_Database.svg")
                },
                JetBrainsIconKind.PartionTable_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PartionTable_Database.svg")
                },
                JetBrainsIconKind.PartionTableDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PartionTableDark_Database.svg")
                },
                JetBrainsIconKind.Paste_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Paste_General.svg")
                },
                JetBrainsIconKind.PasteDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PasteDark_General.svg")
                },
                JetBrainsIconKind.Patch_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Patch_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Patch_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Patch_Vcs.svg")
                },
                JetBrainsIconKind.PatchDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/PatchDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.PatchDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/PatchDark_Vcs.svg")
                },
                JetBrainsIconKind.PatternValue_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PatternValue_Scala.svg")
                },
                JetBrainsIconKind.PatternValueDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/PatternValueDark_Scala.svg")
                },
                JetBrainsIconKind.Pause_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/Pause_Progress.svg")
                },
                JetBrainsIconKind.Pause_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Pause_Run.svg")
                },
                JetBrainsIconKind.PauseDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/PauseDark_Progress.svg")
                },
                JetBrainsIconKind.PauseDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/PauseDark_Run.svg")
                },
                JetBrainsIconKind.PauseHovered_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/PauseHovered_Progress.svg")
                },
                JetBrainsIconKind.PauseHoveredDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/PauseHoveredDark_Progress.svg")
                },
                JetBrainsIconKind.Perl_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Perl_FilesNodes.svg")
                },
                JetBrainsIconKind.PerlDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/PerlDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Php_FileTypes_PhpFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpFileTypes/Php_FileTypes_PhpFileTypes.svg")
                },
                JetBrainsIconKind.PhpDark_FileTypes_PhpFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpFileTypes/PhpDark_FileTypes_PhpFileTypes.svg")
                },
                JetBrainsIconKind.PhpIcon_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpIcon_PHP.svg")
                },
                JetBrainsIconKind.Composer_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/Composer_PHP.svg")
                },
                JetBrainsIconKind.PhpLocal_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpLocal_PHP.svg")
                },
                JetBrainsIconKind.PhpLocal_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpLocal_RunDebug.svg")
                },
                JetBrainsIconKind.PhpLocalDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpLocalDark_PHP.svg")
                },
                JetBrainsIconKind.PhpLocalDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpLocalDark_RunDebug.svg")
                },
                JetBrainsIconKind.PhpRemote_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpRemote_PHP.svg")
                },
                JetBrainsIconKind.PhpRemote_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpRemote_RunDebug.svg")
                },
                JetBrainsIconKind.PhpRemoteDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpRemoteDark_PHP.svg")
                },
                JetBrainsIconKind.PhpRemoteDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpRemoteDark_RunDebug.svg")
                },
                JetBrainsIconKind.PhpUnit_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpUnit_PHP.svg")
                },
                JetBrainsIconKind.PhpUnitDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PhpUnitDark_PHP.svg")
                },
                JetBrainsIconKind.PhpWeb_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpWeb_RunDebug.svg")
                },
                JetBrainsIconKind.PhpWebDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/PhpWebDark_RunDebug.svg")
                },
                JetBrainsIconKind.Pin_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/Pin_General.svg")
                },
                JetBrainsIconKind.PinDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/PinDark_General.svg")
                },
                JetBrainsIconKind.PlayBack_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayBack_Actions.svg")
                },
                JetBrainsIconKind.PlayBackDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayBackDark_Actions.svg")
                },
                JetBrainsIconKind.PlayFirst_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayFirst_Actions.svg")
                },
                JetBrainsIconKind.PlayFirstDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayFirstDark_Actions.svg")
                },
                JetBrainsIconKind.PlayForward_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayForward_Actions.svg")
                },
                JetBrainsIconKind.PlayForwardDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayForwardDark_Actions.svg")
                },
                JetBrainsIconKind.PlayLast_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayLast_Actions.svg")
                },
                JetBrainsIconKind.PlayLastDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/PlayLastDark_Actions.svg")
                },
                JetBrainsIconKind.Plugin_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Plugin_Nodes.svg")
                },
                JetBrainsIconKind.PluginDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/PluginDark_Nodes.svg")
                },
                JetBrainsIconKind.PluginUpdate_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/PluginUpdate_General.svg")
                },
                JetBrainsIconKind.PluginUpdateDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/PluginUpdateDark_General.svg")
                },
                JetBrainsIconKind.PopFrame_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/PopFrame_Aqua.svg")
                },
                JetBrainsIconKind.PopFrameDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/PopFrameDark_Aqua.svg")
                },
                JetBrainsIconKind.Postgresql_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Postgresql_Providers.svg")
                },
                JetBrainsIconKind.PostgresqlDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/PostgresqlDark_Providers.svg")
                },
                JetBrainsIconKind.PpWeb_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/PpWeb_Kotlin.svg")
                },
                JetBrainsIconKind.PpWebDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/PpWebDark_Kotlin.svg")
                },
                JetBrainsIconKind.PrecedenceGroup_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/PrecedenceGroup_Cidr.svg")
                },
                JetBrainsIconKind.PrecedenceGroupDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/PrecedenceGroupDark_Cidr.svg")
                },
                JetBrainsIconKind.PreprocessDefines_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/PreprocessDefines_Cidr.svg")
                },
                JetBrainsIconKind.PreprocessDefinesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/PreprocessDefinesDark_Cidr.svg")
                },
                JetBrainsIconKind.PreserveCase_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/PreserveCase_Inline.svg")
                },
                JetBrainsIconKind.PreserveCaseDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/PreserveCaseDark_Inline.svg")
                },
                JetBrainsIconKind.Presto_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Presto_Providers.svg")
                },
                JetBrainsIconKind.PrestoDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/PrestoDark_Providers.svg")
                },
                JetBrainsIconKind.PreviewChanges_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PreviewChanges_Database.svg")
                },
                JetBrainsIconKind.PreviewChangesDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/PreviewChangesDark_Database.svg")
                },
                JetBrainsIconKind.PreviewHorizontally_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PreviewHorizontally_General.svg")
                },
                JetBrainsIconKind.PreviewHorizontallyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PreviewHorizontallyDark_General.svg")
                },
                JetBrainsIconKind.PreviewOnly_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/PreviewOnly_Editor.svg")
                },
                JetBrainsIconKind.PreviewOnlyDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/PreviewOnlyDark_Editor.svg")
                },
                JetBrainsIconKind.PreviewVertically_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PreviewVertically_General.svg")
                },
                JetBrainsIconKind.PreviewVerticallyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PreviewVerticallyDark_General.svg")
                },
                JetBrainsIconKind.Print_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Print_General.svg")
                },
                JetBrainsIconKind.PrintDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/PrintDark_General.svg")
                },
                JetBrainsIconKind.Problems_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Problems_ToolWindows.svg")
                },
                JetBrainsIconKind.Problems20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Problems@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Problems20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Problems@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ProblemsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/ProblemsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Procedure_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Procedure_Database.svg")
                },
                JetBrainsIconKind.ProcedureDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProcedureDark_Database.svg")
                },
                JetBrainsIconKind.ProcedureGroup_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProcedureGroup_Database.svg")
                },
                JetBrainsIconKind.ProcedureGroupDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProcedureGroupDark_Database.svg")
                },
                JetBrainsIconKind.ProcedureRun_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProcedureRun_Database.svg")
                },
                JetBrainsIconKind.ProcedureRunDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProcedureRunDark_Database.svg")
                },
                JetBrainsIconKind.Profile_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Profile_Run.svg")
                },
                JetBrainsIconKind.ProfileDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ProfileDark_Run.svg")
                },
                JetBrainsIconKind.Profiler_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Profiler_ToolWindows.svg")
                },
                JetBrainsIconKind.Profiler20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Profiler@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Profiler20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Profiler@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ProfilerDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/ProfilerDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Project_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Project_ToolWindows.svg")
                },
                JetBrainsIconKind.ProjectDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/ProjectDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ProjectDirectory_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/ProjectDirectory_Actions.svg")
                },
                JetBrainsIconKind.ProjectDirectoryDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/ProjectDirectoryDark_Actions.svg")
                },
                JetBrainsIconKind.Projection_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Projection_Database.svg")
                },
                JetBrainsIconKind.ProjectionDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ProjectionDark_Database.svg")
                },
                JetBrainsIconKind.ProjectStructure_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectStructure_General.svg")
                },
                JetBrainsIconKind.ProjectStructureDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectStructureDark_General.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOff_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectWideAnalysisOff_General.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOffDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectWideAnalysisOffDark_General.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOn_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectWideAnalysisOn_General.svg")
                },
                JetBrainsIconKind.ProjectWideAnalysisOnDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ProjectWideAnalysisOnDark_General.svg")
                },
                JetBrainsIconKind.Properties_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Properties_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.PropertiesDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/PropertiesDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Property_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Property_Nodes.svg")
                },
                JetBrainsIconKind.PropertyDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/PropertyDark_Nodes.svg")
                },
                JetBrainsIconKind.PropertyReadOnly_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PropertyReadOnly_PHP.svg")
                },
                JetBrainsIconKind.PropertyReadOnlyDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/PropertyReadOnlyDark_PHP.svg")
                },
                JetBrainsIconKind.Protobuf_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Protobuf_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ProtobufDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ProtobufDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.PrototypeBean_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/PrototypeBean_Spring.svg")
                },
                JetBrainsIconKind.PrototypeBeanDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/PrototypeBeanDark_Spring.svg")
                },
                JetBrainsIconKind.Publisher14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Publisher@14x14_Spring.svg")
                },
                JetBrainsIconKind.Publisher14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Publisher@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.PullRequests_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PullRequests_ToolWindows.svg")
                },
                JetBrainsIconKind.PullRequests20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PullRequests@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.PullRequests20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PullRequests@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.PullRequestsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PullRequestsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Push_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Push_Vcs.svg")
                },
                JetBrainsIconKind.PushDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/PushDark_Vcs.svg")
                },
                JetBrainsIconKind.Python_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Python_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.PythonConsole => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/PythonConsole.svg")
                },
                JetBrainsIconKind.PythonConsoleDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/PythonConsoleDark.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PythonConsoleToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PythonConsoleToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PythonConsoleToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.PythonConsoleToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/PythonConsoleToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.PythonDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/PythonDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Qml_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Qml_FilesNodes.svg")
                },
                JetBrainsIconKind.QmlDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/QmlDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Qrc_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Qrc_FilesNodes.svg")
                },
                JetBrainsIconKind.QrcDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/QrcDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Qt_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Qt_Cidr.svg")
                },
                JetBrainsIconKind.Qt_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Qt_FilesNodes.svg")
                },
                JetBrainsIconKind.QtDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/QtDark_Cidr.svg")
                },
                JetBrainsIconKind.QtDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/QtDark_FilesNodes.svg")
                },
                JetBrainsIconKind.QuestionBadge_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/QuestionBadge_Breakpoints.svg")
                },
                JetBrainsIconKind.QuestionBadgeDark_Breakpoints => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Breakpoints/QuestionBadgeDark_Breakpoints.svg")
                },
                JetBrainsIconKind.QuestionDialog_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/QuestionDialog_Status.svg")
                },
                JetBrainsIconKind.QuestionDialogDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/QuestionDialogDark_Status.svg")
                },
                JetBrainsIconKind.QuickfixBulb_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/QuickfixBulb_Editor.svg")
                },
                JetBrainsIconKind.QuickfixBulbDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/QuickfixBulbDark_Editor.svg")
                },
                JetBrainsIconKind.QuickfixOffBulb_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/QuickfixOffBulb_Editor.svg")
                },
                JetBrainsIconKind.QuickfixOffBulbDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Editor/QuickfixOffBulbDark_Editor.svg")
                },
                JetBrainsIconKind.RailsModuleClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RailsModuleClosed_Ruby.svg")
                },
                JetBrainsIconKind.RailsModuleClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RailsModuleClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.RailsServerRunConfiguration_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RailsServerRunConfiguration_Ruby.svg")
                },
                JetBrainsIconKind.RailsServerRunConfigurationDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RailsServerRunConfigurationDark_Ruby.svg")
                },
                JetBrainsIconKind.RakeRunConfiguration_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RakeRunConfiguration_Ruby.svg")
                },
                JetBrainsIconKind.RakeRunConfigurationDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RakeRunConfigurationDark_Ruby.svg")
                },
                JetBrainsIconKind.RakeTaskDefNode_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RakeTaskDefNode_Ruby.svg")
                },
                JetBrainsIconKind.RakeTaskDefNodeDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RakeTaskDefNodeDark_Ruby.svg")
                },
                JetBrainsIconKind.RateCourse_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/RateCourse_EduTools.svg")
                },
                JetBrainsIconKind.RateCourseDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/RateCourseDark_EduTools.svg")
                },
                JetBrainsIconKind.RbenvRunAnything_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbenvRunAnything_Ruby.svg")
                },
                JetBrainsIconKind.RbenvRunAnythingDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbenvRunAnythingDark_Ruby.svg")
                },
                JetBrainsIconKind.RbsFile_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbsFile_Ruby.svg")
                },
                JetBrainsIconKind.RbsFile14_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbsFile@14x14_Ruby.svg")
                },
                JetBrainsIconKind.RbsFile14Dark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbsFile@14x14Dark_Ruby.svg")
                },
                JetBrainsIconKind.RbsFileDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RbsFileDark_Ruby.svg")
                },
                JetBrainsIconKind.React_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/React_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ReactDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ReactDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ReadAccess_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/ReadAccess_Gutter.svg")
                },
                JetBrainsIconKind.ReadAccessDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/ReadAccessDark_Gutter.svg")
                },
                JetBrainsIconKind.Reader_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Reader_Ruby.svg")
                },
                JetBrainsIconKind.ReaderDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ReaderDark_Ruby.svg")
                },
                JetBrainsIconKind.ReadOnly_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/ReadOnly_PHP.svg")
                },
                JetBrainsIconKind.ReadOnlyDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/ReadOnlyDark_PHP.svg")
                },
                JetBrainsIconKind.Record_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Record_Nodes.svg")
                },
                JetBrainsIconKind.RecordDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/RecordDark_Nodes.svg")
                },
                JetBrainsIconKind.RecordDebug_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/RecordDebug_GoLang.svg")
                },
                JetBrainsIconKind.RecordDebugDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/RecordDebugDark_GoLang.svg")
                },
                JetBrainsIconKind.Recursion14_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Recursion@14x14_Scala.svg")
                },
                JetBrainsIconKind.Recursion14Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Recursion@14x14Dark_Scala.svg")
                },
                JetBrainsIconKind.RecursiveMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/RecursiveMethod_Editor.svg")
                },
                JetBrainsIconKind.RecursiveMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/RecursiveMethodDark_Editor.svg")
                },
                JetBrainsIconKind.Redis_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Redis_Database.svg")
                },
                JetBrainsIconKind.RedisDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RedisDark_Database.svg")
                },
                JetBrainsIconKind.RedisFileType_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RedisFileType_Database.svg")
                },
                JetBrainsIconKind.RedisFileTypeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RedisFileTypeDark_Database.svg")
                },
                JetBrainsIconKind.Redo_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Redo_General.svg")
                },
                JetBrainsIconKind.RedoDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RedoDark_General.svg")
                },
                JetBrainsIconKind.Redshift_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Redshift_Providers.svg")
                },
                JetBrainsIconKind.RedshiftDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/RedshiftDark_Providers.svg")
                },
                JetBrainsIconKind.Refresh_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Refresh_General.svg")
                },
                JetBrainsIconKind.Refresh_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Refresh_Inline.svg")
                },
                JetBrainsIconKind.RefreshDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RefreshDark_General.svg")
                },
                JetBrainsIconKind.RefreshDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/RefreshDark_Inline.svg")
                },
                JetBrainsIconKind.Regex_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Regex_Inline.svg")
                },
                JetBrainsIconKind.RegexDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/RegexDark_Inline.svg")
                },
                JetBrainsIconKind.RemoteChanges_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/RemoteChanges_SettingSync.svg")
                },
                JetBrainsIconKind.RemoteChangesDark_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/RemoteChangesDark_SettingSync.svg")
                },
                JetBrainsIconKind.RemoteDebug_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/RemoteDebug_GoLang.svg")
                },
                JetBrainsIconKind.RemoteDebugDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/RemoteDebugDark_GoLang.svg")
                },
                JetBrainsIconKind.RemoteSwiftPackageDependency_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/RemoteSwiftPackageDependency_Cidr.svg")
                },
                JetBrainsIconKind.RemoteSwiftPackageDependencyDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/RemoteSwiftPackageDependencyDark_Cidr.svg")
                },
                JetBrainsIconKind.Remove_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Remove_General.svg")
                },
                JetBrainsIconKind.Remove14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Remove@14x14_Vcs.svg")
                },
                JetBrainsIconKind.Remove14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Remove@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.RemoveClause_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/RemoveClause_Scala.svg")
                },
                JetBrainsIconKind.RemoveClauseDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/RemoveClauseDark_Scala.svg")
                },
                JetBrainsIconKind.RemoveDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RemoveDark_General.svg")
                },
                JetBrainsIconKind.Report_Plugins => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Plugins/Report_Plugins.svg")
                },
                JetBrainsIconKind.ReportDark_Plugins => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Plugins/ReportDark_Plugins.svg")
                },
                JetBrainsIconKind.Repositories_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Repositories_ToolWindows.svg")
                },
                JetBrainsIconKind.Repositories20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Repositories@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Repositories20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Repositories@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.RepositoriesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/RepositoriesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.RequestMapping_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/RequestMapping_Spring.svg")
                },
                JetBrainsIconKind.RequestMapping14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/RequestMapping@14x14_Spring.svg")
                },
                JetBrainsIconKind.RequestMapping14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/RequestMapping@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.RequestMappingDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/RequestMappingDark_Spring.svg")
                },
                JetBrainsIconKind.Rerun_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Rerun_Gutter.svg")
                },
                JetBrainsIconKind.Rerun_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Rerun_Run.svg")
                },
                JetBrainsIconKind.RerunDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RerunDark_Gutter.svg")
                },
                JetBrainsIconKind.RerunDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RerunDark_Run.svg")
                },
                JetBrainsIconKind.Reset_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Reset_Database.svg")
                },
                JetBrainsIconKind.ResetCacheAndReloadProjects_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ResetCacheAndReloadProjects_Cidr.svg")
                },
                JetBrainsIconKind.ResetCacheAndReloadProjectsDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ResetCacheAndReloadProjectsDark_Cidr.svg")
                },
                JetBrainsIconKind.ResetDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ResetDark_Database.svg")
                },
                JetBrainsIconKind.ResetLesson_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResetLesson_EduTools.svg")
                },
                JetBrainsIconKind.ResetLesson_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/ResetLesson_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.ResetLessonDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResetLessonDark_EduTools.svg")
                },
                JetBrainsIconKind.ResetLessonDark_Ide_features_trainer_IdeFeaturesTrainer => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/IdeFeaturesTrainer/ResetLessonDark_Ide-features-trainer_IdeFeaturesTrainer.svg")
                },
                JetBrainsIconKind.ResetMcu_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ResetMcu_Cidr.svg")
                },
                JetBrainsIconKind.ResetMcuDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ResetMcuDark_Cidr.svg")
                },
                JetBrainsIconKind.ResetTask_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResetTask_EduTools.svg")
                },
                JetBrainsIconKind.ResetTaskDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResetTaskDark_EduTools.svg")
                },
                JetBrainsIconKind.Resources_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Resources_Ruby.svg")
                },
                JetBrainsIconKind.ResourcesDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ResourcesDark_Ruby.svg")
                },
                JetBrainsIconKind.ResourcesRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ResourcesRoot_Nodes.svg")
                },
                JetBrainsIconKind.ResourcesRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ResourcesRootDark_Nodes.svg")
                },
                JetBrainsIconKind.Restart_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Restart_Run.svg")
                },
                JetBrainsIconKind.RestartDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartDark_Run.svg")
                },
                JetBrainsIconKind.RestartDebug_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartDebug_Run.svg")
                },
                JetBrainsIconKind.RestartDebugDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartDebugDark_Run.svg")
                },
                JetBrainsIconKind.RestartFailedTests_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartFailedTests_Run.svg")
                },
                JetBrainsIconKind.RestartFailedTestsDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartFailedTestsDark_Run.svg")
                },
                JetBrainsIconKind.RestartFrame_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartFrame_Run.svg")
                },
                JetBrainsIconKind.RestartFrameDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RestartFrameDark_Run.svg")
                },
                JetBrainsIconKind.Restore_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/Restore_Windows.svg")
                },
                JetBrainsIconKind.RestoreDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/RestoreDark_Windows.svg")
                },
                JetBrainsIconKind.RestoreInactive_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/RestoreInactive_Windows.svg")
                },
                JetBrainsIconKind.RestoreInactiveDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/RestoreInactiveDark_Windows.svg")
                },
                JetBrainsIconKind.RestoreSmall_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/RestoreSmall_Windows.svg")
                },
                JetBrainsIconKind.RestoreSmallDark_Windows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Windows/Windows/RestoreSmallDark_Windows.svg")
                },
                JetBrainsIconKind.ResultCorrect_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResultCorrect_EduTools.svg")
                },
                JetBrainsIconKind.ResultCorrectDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResultCorrectDark_EduTools.svg")
                },
                JetBrainsIconKind.ResultIncorrect_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResultIncorrect_EduTools.svg")
                },
                JetBrainsIconKind.ResultIncorrectDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/ResultIncorrectDark_EduTools.svg")
                },
                JetBrainsIconKind.Resume_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/Resume_Progress.svg")
                },
                JetBrainsIconKind.Resume_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Resume_Run.svg")
                },
                JetBrainsIconKind.ResumeDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/ResumeDark_Progress.svg")
                },
                JetBrainsIconKind.ResumeDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ResumeDark_Run.svg")
                },
                JetBrainsIconKind.ResumeHovered_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/ResumeHovered_Progress.svg")
                },
                JetBrainsIconKind.ResumeHoveredDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/ResumeHoveredDark_Progress.svg")
                },
                JetBrainsIconKind.ResumeReverse_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/ResumeReverse_GoLang.svg")
                },
                JetBrainsIconKind.ResumeReverseDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/ResumeReverseDark_GoLang.svg")
                },
                JetBrainsIconKind.ReturnValue_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ReturnValue_Cidr.svg")
                },
                JetBrainsIconKind.ReturnValueDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ReturnValueDark_Cidr.svg")
                },
                JetBrainsIconKind.Revert_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Revert_Vcs.svg")
                },
                JetBrainsIconKind.Revert14_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Revert@14x14_Vcs.svg")
                },
                JetBrainsIconKind.Revert14Dark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Revert@14x14Dark_Vcs.svg")
                },
                JetBrainsIconKind.RevertDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/RevertDark_Vcs.svg")
                },
                JetBrainsIconKind.Rhtml_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Rhtml_Ruby.svg")
                },
                JetBrainsIconKind.RhtmlDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RhtmlDark_Ruby.svg")
                },
                JetBrainsIconKind.Right_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Right_General.svg")
                },
                JetBrainsIconKind.RightDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RightDark_General.svg")
                },
                JetBrainsIconKind.Rjs_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Rjs_Ruby.svg")
                },
                JetBrainsIconKind.RjsDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RjsDark_Ruby.svg")
                },
                JetBrainsIconKind.Role_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Role_Database.svg")
                },
                JetBrainsIconKind.RoleDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RoleDark_Database.svg")
                },
                JetBrainsIconKind.Rollback_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Rollback_Database.svg")
                },
                JetBrainsIconKind.RollbackDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RollbackDark_Database.svg")
                },
                JetBrainsIconKind.Routine_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Routine_Database.svg")
                },
                JetBrainsIconKind.RoutineDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RoutineDark_Database.svg")
                },
                JetBrainsIconKind.RspecRunConfigurations_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecRunConfigurations_Ruby.svg")
                },
                JetBrainsIconKind.RspecRunConfigurationsDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecRunConfigurationsDark_Ruby.svg")
                },
                JetBrainsIconKind.RspecSharedGroupClosed_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecSharedGroupClosed_Ruby.svg")
                },
                JetBrainsIconKind.RspecSharedGroupClosedDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecSharedGroupClosedDark_Ruby.svg")
                },
                JetBrainsIconKind.RspecSharedGroupRef_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecSharedGroupRef_Ruby.svg")
                },
                JetBrainsIconKind.RspecSharedGroupRefDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecSharedGroupRefDark_Ruby.svg")
                },
                JetBrainsIconKind.RspecTest_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecTest_Ruby.svg")
                },
                JetBrainsIconKind.RspecTestDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RspecTestDark_Ruby.svg")
                },
                JetBrainsIconKind.Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Ruby.svg")
                },
                JetBrainsIconKind.Ruby14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Ruby@14x14.svg")
                },
                JetBrainsIconKind.Ruby14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Ruby@14x14Dark.svg")
                },
                JetBrainsIconKind.RubyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyDark.svg")
                },
                JetBrainsIconKind.RubyGems => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyGems.svg")
                },
                JetBrainsIconKind.RubyGemsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyGemsDark.svg")
                },
                JetBrainsIconKind.RubyModuleClosed => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyModuleClosed.svg")
                },
                JetBrainsIconKind.RubyModuleClosedDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyModuleClosedDark.svg")
                },
                JetBrainsIconKind.RubyRemote => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyRemote.svg")
                },
                JetBrainsIconKind.RubyRemoteDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyRemoteDark.svg")
                },
                JetBrainsIconKind.RubyScript => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyScript.svg")
                },
                JetBrainsIconKind.RubyScriptDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyScriptDark.svg")
                },
                JetBrainsIconKind.RubyTestUnit => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyTestUnit.svg")
                },
                JetBrainsIconKind.RubyTestUnitDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RubyTestUnitDark.svg")
                },
                JetBrainsIconKind.Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Run.svg")
                },
                JetBrainsIconKind.Run_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Run_Gutter.svg")
                },
                JetBrainsIconKind.Run_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Run_ToolWindows.svg")
                },
                JetBrainsIconKind.Run20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Run@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Run20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Run@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.RunAnything_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RunAnything_General.svg")
                },
                JetBrainsIconKind.RunAnythingDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/RunAnythingDark_General.svg")
                },
                JetBrainsIconKind.RunConfiguration_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunConfiguration_Ruby.svg")
                },
                JetBrainsIconKind.RunConfigurationDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunConfigurationDark_Ruby.svg")
                },
                JetBrainsIconKind.RunDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RunDark.svg")
                },
                JetBrainsIconKind.RunDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunDark_Gutter.svg")
                },
                JetBrainsIconKind.RunDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/RunDark_ToolWindows.svg")
                },
                JetBrainsIconKind.RunDatabaseScript => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RunDatabaseScript.svg")
                },
                JetBrainsIconKind.RunDatabaseScriptDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/RunDatabaseScriptDark.svg")
                },
                JetBrainsIconKind.RunError_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunError_Gutter.svg")
                },
                JetBrainsIconKind.RunErrorDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunErrorDark_Gutter.svg")
                },
                JetBrainsIconKind.RunFailed_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunFailed_Gutter.svg")
                },
                JetBrainsIconKind.RunFailedDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunFailedDark_Gutter.svg")
                },
                JetBrainsIconKind.RunHttpRequest_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunHttpRequest_PHP.svg")
                },
                JetBrainsIconKind.RunHttpRequest_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/RunHttpRequest_RunDebug.svg")
                },
                JetBrainsIconKind.RunHttpRequestDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunHttpRequestDark_PHP.svg")
                },
                JetBrainsIconKind.RunHttpRequestDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/RunHttpRequestDark_RunDebug.svg")
                },
                JetBrainsIconKind.RunParatest_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunParatest_PHP.svg")
                },
                JetBrainsIconKind.RunParatest14_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunParatest@14x14_PHP.svg")
                },
                JetBrainsIconKind.RunParatest14Dark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunParatest@14x14Dark_PHP.svg")
                },
                JetBrainsIconKind.RunParatestDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunParatestDark_PHP.svg")
                },
                JetBrainsIconKind.RunRackTask_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunRackTask_Ruby.svg")
                },
                JetBrainsIconKind.RunRackTaskDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunRackTaskDark_Ruby.svg")
                },
                JetBrainsIconKind.RunRemoteDebug_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunRemoteDebug_PHP.svg")
                },
                JetBrainsIconKind.RunRemoteDebugDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunRemoteDebugDark_PHP.svg")
                },
                JetBrainsIconKind.RunSporkServer_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunSporkServer_Ruby.svg")
                },
                JetBrainsIconKind.RunSporkServerDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunSporkServerDark_Ruby.svg")
                },
                JetBrainsIconKind.RunSuccess_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunSuccess_Gutter.svg")
                },
                JetBrainsIconKind.RunSuccessDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/RunSuccessDark_Gutter.svg")
                },
                JetBrainsIconKind.RunToCursor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RunToCursor.svg")
                },
                JetBrainsIconKind.RunToCursorDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RunToCursorDark.svg")
                },
                JetBrainsIconKind.RunWebApp_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunWebApp_PHP.svg")
                },
                JetBrainsIconKind.RunWebAppDark_PHP => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/PHP/RunWebAppDark_PHP.svg")
                },
                JetBrainsIconKind.RunWithCoverage => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RunWithCoverage.svg")
                },
                JetBrainsIconKind.RunWithCoverageDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/RunWithCoverageDark.svg")
                },
                JetBrainsIconKind.RunWithTypeTracker_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunWithTypeTracker_Ruby.svg")
                },
                JetBrainsIconKind.RunWithTypeTrackerDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RunWithTypeTrackerDark_Ruby.svg")
                },
                JetBrainsIconKind.Rust_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Rust_ToolWindows.svg")
                },
                JetBrainsIconKind.Rust20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Rust@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Rust20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Rust@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.RustBuild => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustBuild.svg")
                },
                JetBrainsIconKind.RustBuildDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustBuildDark.svg")
                },
                JetBrainsIconKind.RustDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/RustDark_ToolWindows.svg")
                },
                JetBrainsIconKind.RustFile => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustFile.svg")
                },
                JetBrainsIconKind.RustFileDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustFileDark.svg")
                },
                JetBrainsIconKind.RustReloadProject => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustReloadProject.svg")
                },
                JetBrainsIconKind.RustReloadProjectDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustReloadProjectDark.svg")
                },
                JetBrainsIconKind.RustRepl => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustRepl.svg")
                },
                JetBrainsIconKind.RustReplDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/RustReplDark.svg")
                },
                JetBrainsIconKind.RvmRunAnything_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RvmRunAnything_Ruby.svg")
                },
                JetBrainsIconKind.RvmRunAnythingDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RvmRunAnythingDark_Ruby.svg")
                },
                JetBrainsIconKind.Rxml_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Rxml_Ruby.svg")
                },
                JetBrainsIconKind.RxmlDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/RxmlDark_Ruby.svg")
                },
                JetBrainsIconKind.Sass_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Sass_FilesNodes.svg")
                },
                JetBrainsIconKind.SassDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/SassDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Save_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Save_General.svg")
                },
                JetBrainsIconKind.SaveDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SaveDark_General.svg")
                },
                JetBrainsIconKind.SbtFile_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtFile_Scala.svg")
                },
                JetBrainsIconKind.SbtFileDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtFileDark_Scala.svg")
                },
                JetBrainsIconKind.SbtFolder_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtFolder_Scala.svg")
                },
                JetBrainsIconKind.SbtFolderDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtFolderDark_Scala.svg")
                },
                JetBrainsIconKind.SbtIcon_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtIcon_Scala.svg")
                },
                JetBrainsIconKind.SbtIcon_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtIcon_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtIcon20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtIcon@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtIcon20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtIcon@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtIconDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtIconDark_Scala.svg")
                },
                JetBrainsIconKind.SbtIconDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtIconDark_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtLoadChanges_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtLoadChanges_Scala.svg")
                },
                JetBrainsIconKind.SbtLoadChangesDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtLoadChangesDark_Scala.svg")
                },
                JetBrainsIconKind.SbtShell_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtShell_Scala.svg")
                },
                JetBrainsIconKind.SbtShell_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtShell_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtShell20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtShell@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtShell20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtShell@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SbtShellDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/SbtShellDark_Scala.svg")
                },
                JetBrainsIconKind.SbtShellDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SbtShellDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Scala_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Scala_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Scala16 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Scala16.svg")
                },
                JetBrainsIconKind.Scala16Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Scala16Dark.svg")
                },
                JetBrainsIconKind.ScalaConsole => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaConsole.svg")
                },
                JetBrainsIconKind.ScalaConsoleDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaConsoleDark.svg")
                },
                JetBrainsIconKind.ScalaDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ScalaDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ScalaFile => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaFile.svg")
                },
                JetBrainsIconKind.ScalaFileDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaFileDark.svg")
                },
                JetBrainsIconKind.ScalaLogo => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaLogo.svg")
                },
                JetBrainsIconKind.ScalaLogoDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaLogoDark.svg")
                },
                JetBrainsIconKind.ScalaScript => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaScript.svg")
                },
                JetBrainsIconKind.ScalaScriptDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaScriptDark.svg")
                },
                JetBrainsIconKind.ScalaSDK => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaSDK.svg")
                },
                JetBrainsIconKind.ScalaSDKDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaSDKDark.svg")
                },
                JetBrainsIconKind.ScalaTest => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaTest.svg")
                },
                JetBrainsIconKind.ScalaTestDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ScalaTestDark.svg")
                },
                JetBrainsIconKind.ScheduledEvent_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScheduledEvent_Database.svg")
                },
                JetBrainsIconKind.ScheduledEventDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScheduledEventDark_Database.svg")
                },
                JetBrainsIconKind.Schema_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Schema_Database.svg")
                },
                JetBrainsIconKind.SchemaDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SchemaDark_Database.svg")
                },
                JetBrainsIconKind.SciView_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SciView_ToolWindows.svg")
                },
                JetBrainsIconKind.SciView20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SciView@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.SciView20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SciView@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SciViewDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SciViewDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Scratch_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Scratch_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ScratchDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ScratchDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Scratches_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Scratches_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ScratchesDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ScratchesDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ScriptingScript_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScriptingScript_Database.svg")
                },
                JetBrainsIconKind.ScriptingScriptDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScriptingScriptDark_Database.svg")
                },
                JetBrainsIconKind.ScrollDown_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScrollDown_Database.svg")
                },
                JetBrainsIconKind.ScrollDown_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ScrollDown_General.svg")
                },
                JetBrainsIconKind.ScrollDownDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScrollDownDark_Database.svg")
                },
                JetBrainsIconKind.ScrollDownDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ScrollDownDark_General.svg")
                },
                JetBrainsIconKind.ScrollUp_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScrollUp_Database.svg")
                },
                JetBrainsIconKind.ScrollUpDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ScrollUpDark_Database.svg")
                },
                JetBrainsIconKind.Scss_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Scss_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ScssDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ScssDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Search_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Search_General.svg")
                },
                JetBrainsIconKind.Search20_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Search@20x20_General.svg")
                },
                JetBrainsIconKind.Search20Dark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Search@20x20Dark_General.svg")
                },
                JetBrainsIconKind.SearchDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SearchDark_General.svg")
                },
                JetBrainsIconKind.SearchHistory_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/SearchHistory_Inline.svg")
                },
                JetBrainsIconKind.SearchHistoryDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/SearchHistoryDark_Inline.svg")
                },
                JetBrainsIconKind.SelectWeb_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/SelectWeb_Aqua.svg")
                },
                JetBrainsIconKind.SelectWebDark_Aqua => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/SelectWebDark_Aqua.svg")
                },
                JetBrainsIconKind.Sequence_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Sequence_Database.svg")
                },
                JetBrainsIconKind.Sequence_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Sequence_Ruby.svg")
                },
                JetBrainsIconKind.SequenceDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SequenceDark_Database.svg")
                },
                JetBrainsIconKind.SequenceDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/SequenceDark_Ruby.svg")
                },
                JetBrainsIconKind.ServerObjectsGroup_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ServerObjectsGroup_Database.svg")
                },
                JetBrainsIconKind.ServerObjectsGroupDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ServerObjectsGroupDark_Database.svg")
                },
                JetBrainsIconKind.Services_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Services_ToolWindows.svg")
                },
                JetBrainsIconKind.Services20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Services@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Services20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Services@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.ServicesDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/ServicesDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Servlet_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Servlet_Nodes.svg")
                },
                JetBrainsIconKind.ServletDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/ServletDark_Nodes.svg")
                },
                JetBrainsIconKind.Set_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Set_Database.svg")
                },
                JetBrainsIconKind.SetDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SetDark_Database.svg")
                },
                JetBrainsIconKind.SetKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SetKey_Database.svg")
                },
                JetBrainsIconKind.SetKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SetKeyDark_Database.svg")
                },
                JetBrainsIconKind.Settings_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Settings_General.svg")
                },
                JetBrainsIconKind.Settings20_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Settings@20x20_General.svg")
                },
                JetBrainsIconKind.Settings20Dark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Settings@20x20Dark_General.svg")
                },
                JetBrainsIconKind.SettingsDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SettingsDark_General.svg")
                },
                JetBrainsIconKind.SettingSync_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SettingSync_ToolWindows.svg")
                },
                JetBrainsIconKind.SettingSync20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SettingSync@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.SettingSync20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SettingSync@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SettingSyncDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SettingSyncDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Shell_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Shell_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.ShellDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/ShellDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Show_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Show_General.svg")
                },
                JetBrainsIconKind.ShowAsTree_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ShowAsTree_General.svg")
                },
                JetBrainsIconKind.ShowAsTreeDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ShowAsTreeDark_General.svg")
                },
                JetBrainsIconKind.ShowAutowiredCandidates14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredCandidates@14x14_Spring.svg")
                },
                JetBrainsIconKind.ShowAutowiredCandidates14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredCandidates@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.ShowAutowiredDependencies_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredDependencies_Spring.svg")
                },
                JetBrainsIconKind.ShowAutowiredDependencies14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredDependencies@14x14_Spring.svg")
                },
                JetBrainsIconKind.ShowAutowiredDependencies14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredDependencies@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.ShowAutowiredDependenciesDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowAutowiredDependenciesDark_Spring.svg")
                },
                JetBrainsIconKind.ShowCacheable_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowCacheable_Spring.svg")
                },
                JetBrainsIconKind.ShowCacheable14_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowCacheable@14x14_Spring.svg")
                },
                JetBrainsIconKind.ShowCacheable14Dark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowCacheable@14x14Dark_Spring.svg")
                },
                JetBrainsIconKind.ShowCacheableDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/ShowCacheableDark_Spring.svg")
                },
                JetBrainsIconKind.ShowCurrentFrame_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowCurrentFrame_Run.svg")
                },
                JetBrainsIconKind.ShowCurrentFrameDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowCurrentFrameDark_Run.svg")
                },
                JetBrainsIconKind.ShowDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/ShowDark_General.svg")
                },
                JetBrainsIconKind.ShowIgnored_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowIgnored_Run.svg")
                },
                JetBrainsIconKind.ShowIgnoredDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowIgnoredDark_Run.svg")
                },
                JetBrainsIconKind.ShowImportStatements_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowImportStatements_Udages_Usages.svg")
                },
                JetBrainsIconKind.ShowImportStatementsDark_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowImportStatementsDark_Udages_Usages.svg")
                },
                JetBrainsIconKind.ShowPassed_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowPassed_Run.svg")
                },
                JetBrainsIconKind.ShowPassedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ShowPassedDark_Run.svg")
                },
                JetBrainsIconKind.ShowReadAccess_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowReadAccess_Udages_Usages.svg")
                },
                JetBrainsIconKind.ShowReadAccessDark_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowReadAccessDark_Udages_Usages.svg")
                },
                JetBrainsIconKind.ShowWriteAccess_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowWriteAccess_Udages_Usages.svg")
                },
                JetBrainsIconKind.ShowWriteAccessDark_Udages_Usages => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Usages/ShowWriteAccessDark_Udages_Usages.svg")
                },
                JetBrainsIconKind.SiblingInheritedMethod_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/SiblingInheritedMethod_Editor.svg")
                },
                JetBrainsIconKind.SiblingInheritedMethodDark_Editor => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/SiblingInheritedMethodDark_Editor.svg")
                },
                JetBrainsIconKind.Singlestore_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Singlestore_Providers.svg")
                },
                JetBrainsIconKind.SinglestoreDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SinglestoreDark_Providers.svg")
                },
                JetBrainsIconKind.SmartStepInto_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/SmartStepInto_Run.svg")
                },
                JetBrainsIconKind.SmartStepIntoDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/SmartStepIntoDark_Run.svg")
                },
                JetBrainsIconKind.Snippet_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Snippet_Writerside.svg")
                },
                JetBrainsIconKind.SnippetDark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/SnippetDark_Writerside.svg")
                },
                JetBrainsIconKind.Snowflake_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Snowflake_Providers.svg")
                },
                JetBrainsIconKind.SnowflakeDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SnowflakeDark_Providers.svg")
                },
                JetBrainsIconKind.SoftWrap_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SoftWrap_General.svg")
                },
                JetBrainsIconKind.SoftWrapDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SoftWrapDark_General.svg")
                },
                JetBrainsIconKind.SortAlphabetically_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortAlphabetically_General.svg")
                },
                JetBrainsIconKind.SortAlphabeticallyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortAlphabeticallyDark_General.svg")
                },
                JetBrainsIconKind.SortBy_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SortBy_General.svg")
                },
                JetBrainsIconKind.SortByDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SortByDark_General.svg")
                },
                JetBrainsIconKind.SortByDuration_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByDuration_General.svg")
                },
                JetBrainsIconKind.SortByDurationDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByDurationDark_General.svg")
                },
                JetBrainsIconKind.SortByType_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByType_General.svg")
                },
                JetBrainsIconKind.SortByTypeDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByTypeDark_General.svg")
                },
                JetBrainsIconKind.SortByUsage_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByUsage_General.svg")
                },
                JetBrainsIconKind.SortByUsageDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByUsageDark_General.svg")
                },
                JetBrainsIconKind.SortByVisibility_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByVisibility_General.svg")
                },
                JetBrainsIconKind.SortByVisibilityDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/SortByVisibilityDark_General.svg")
                },
                JetBrainsIconKind.SortedSet_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SortedSet_Database.svg")
                },
                JetBrainsIconKind.SortedSetDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SortedSetDark_Database.svg")
                },
                JetBrainsIconKind.SortedSetKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SortedSetKey_Database.svg")
                },
                JetBrainsIconKind.SortedSetKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SortedSetKeyDark_Database.svg")
                },
                JetBrainsIconKind.SortHistory_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/SortHistory_Inline.svg")
                },
                JetBrainsIconKind.SortHistoryDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/SortHistoryDark_Inline.svg")
                },
                JetBrainsIconKind.SourceMap_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/SourceMap_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.SourceMapDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/SourceMapDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.SourceRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/SourceRoot_Nodes.svg")
                },
                JetBrainsIconKind.SourceRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/SourceRootDark_Nodes.svg")
                },
                JetBrainsIconKind.SpaceToolWindow_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SpaceToolWindow_ToolWindows.svg")
                },
                JetBrainsIconKind.SpaceToolWindow20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SpaceToolWindow@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.SpaceToolWindow20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SpaceToolWindow@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SpaceToolWindowDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/SpaceToolWindowDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Spark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Spark_Providers.svg")
                },
                JetBrainsIconKind.SparkDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SparkDark_Providers.svg")
                },
                JetBrainsIconKind.SpecialVar_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/SpecialVar_Python.svg")
                },
                JetBrainsIconKind.SpecialVarDark_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/SpecialVarDark_Python.svg")
                },
                JetBrainsIconKind.SplitHorizontally_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SplitHorizontally_General.svg")
                },
                JetBrainsIconKind.SplitHorizontallyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SplitHorizontallyDark_General.svg")
                },
                JetBrainsIconKind.SplitVertically_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SplitVertically_General.svg")
                },
                JetBrainsIconKind.SplitVerticallyDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/SplitVerticallyDark_General.svg")
                },
                JetBrainsIconKind.Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Spring.svg")
                },
                JetBrainsIconKind.Spring_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Spring_ToolWindows.svg")
                },
                JetBrainsIconKind.Spring14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Spring@14x14.svg")
                },
                JetBrainsIconKind.Spring14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/Spring@14x14Dark.svg")
                },
                JetBrainsIconKind.Spring20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Spring@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Spring20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Spring@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.SpringBatch => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBatch.svg")
                },
                JetBrainsIconKind.SpringBatchDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBatchDark.svg")
                },
                JetBrainsIconKind.SpringBean => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBean.svg")
                },
                JetBrainsIconKind.SpringBean14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBean@14x14.svg")
                },
                JetBrainsIconKind.SpringBean14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBean@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringBeanDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBeanDark.svg")
                },
                JetBrainsIconKind.SpringBeanMethod14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBeanMethod@14x14.svg")
                },
                JetBrainsIconKind.SpringBeanMethod14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBeanMethod@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringBoot => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBoot.svg")
                },
                JetBrainsIconKind.SpringBoot14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBoot@14x14.svg")
                },
                JetBrainsIconKind.SpringBoot14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBoot@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringBootDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootDark.svg")
                },
                JetBrainsIconKind.SpringBootEndpoint => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootEndpoint.svg")
                },
                JetBrainsIconKind.SpringBootEndpointDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootEndpointDark.svg")
                },
                JetBrainsIconKind.SpringBootHealth => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootHealth.svg")
                },
                JetBrainsIconKind.SpringBootHealthDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootHealthDark.svg")
                },
                JetBrainsIconKind.SpringBootOverlay => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootOverlay.svg")
                },
                JetBrainsIconKind.SpringBootOverlayDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringBootOverlayDark.svg")
                },
                JetBrainsIconKind.SpringCloud => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloud.svg")
                },
                JetBrainsIconKind.SpringCloudDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudDark.svg")
                },
                JetBrainsIconKind.SpringCloudFileSet => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudFileSet.svg")
                },
                JetBrainsIconKind.SpringCloudFileSetDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudFileSetDark.svg")
                },
                JetBrainsIconKind.SpringCloudStream => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudStream.svg")
                },
                JetBrainsIconKind.SpringCloudStreamDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudStreamDark.svg")
                },
                JetBrainsIconKind.SpringCloudStreamFileSet => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudStreamFileSet.svg")
                },
                JetBrainsIconKind.SpringCloudStreamFileSetDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringCloudStreamFileSetDark.svg")
                },
                JetBrainsIconKind.SpringConfig => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringConfig.svg")
                },
                JetBrainsIconKind.SpringConfig14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringConfig@14x14.svg")
                },
                JetBrainsIconKind.SpringConfig14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringConfig@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringConfigDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringConfigDark.svg")
                },
                JetBrainsIconKind.SpringDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringDark.svg")
                },
                JetBrainsIconKind.SpringDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/SpringDark_ToolWindows.svg")
                },
                JetBrainsIconKind.SpringData => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringData.svg")
                },
                JetBrainsIconKind.SpringDataDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringDataDark.svg")
                },
                JetBrainsIconKind.SpringIntegration => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringIntegration.svg")
                },
                JetBrainsIconKind.SpringIntegrationDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringIntegrationDark.svg")
                },
                JetBrainsIconKind.SpringJavaBean => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaBean.svg")
                },
                JetBrainsIconKind.SpringJavaBean14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaBean@14x14.svg")
                },
                JetBrainsIconKind.SpringJavaBean14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaBean@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringJavaBeanDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaBeanDark.svg")
                },
                JetBrainsIconKind.SpringJavaConfig => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaConfig.svg")
                },
                JetBrainsIconKind.SpringJavaConfigDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringJavaConfigDark.svg")
                },
                JetBrainsIconKind.SpringModelsDependencyGraph => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringModelsDependencyGraph.svg")
                },
                JetBrainsIconKind.SpringModelsDependencyGraph14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringModelsDependencyGraph@14x14.svg")
                },
                JetBrainsIconKind.SpringModelsDependencyGraph14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringModelsDependencyGraph@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringModelsDependencyGraphDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringModelsDependencyGraphDark.svg")
                },
                JetBrainsIconKind.SpringProfile => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringProfile.svg")
                },
                JetBrainsIconKind.SpringProfileDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringProfileDark.svg")
                },
                JetBrainsIconKind.SpringProperty => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringProperty.svg")
                },
                JetBrainsIconKind.SpringProperty14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringProperty@14x14.svg")
                },
                JetBrainsIconKind.SpringProperty14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringProperty@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringPropertyDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringPropertyDark.svg")
                },
                JetBrainsIconKind.SpringScan14 => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringScan@14x14.svg")
                },
                JetBrainsIconKind.SpringScan14Dark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringScan@14x14Dark.svg")
                },
                JetBrainsIconKind.SpringSecurity => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringSecurity.svg")
                },
                JetBrainsIconKind.SpringSecurityDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringSecurityDark.svg")
                },
                JetBrainsIconKind.SpringSessionFactory => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringSessionFactory.svg")
                },
                JetBrainsIconKind.SpringSessionFactoryDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringSessionFactoryDark.svg")
                },
                JetBrainsIconKind.SpringWeb => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWeb.svg")
                },
                JetBrainsIconKind.SpringWebDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebDark.svg")
                },
                JetBrainsIconKind.SpringWebFlow => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebFlow.svg")
                },
                JetBrainsIconKind.SpringWebFlowDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebFlowDark.svg")
                },
                JetBrainsIconKind.SpringWebFlowFile => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebFlowFile.svg")
                },
                JetBrainsIconKind.SpringWebFlowFileDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebFlowFileDark.svg")
                },
                JetBrainsIconKind.SpringWebServices => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebServices.svg")
                },
                JetBrainsIconKind.SpringWebServicesDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/SpringWebServicesDark.svg")
                },
                JetBrainsIconKind.Sql_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Sql_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.SqlDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/SqlDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.SQLDMLStatement_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLDMLStatement_Database.svg")
                },
                JetBrainsIconKind.SQLDMLStatementDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLDMLStatementDark_Database.svg")
                },
                JetBrainsIconKind.SQLGroupByType_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLGroupByType_Database.svg")
                },
                JetBrainsIconKind.SQLGroupByTypeDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLGroupByTypeDark_Database.svg")
                },
                JetBrainsIconKind.Sqlite_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Sqlite_Providers.svg")
                },
                JetBrainsIconKind.SqliteDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SqliteDark_Providers.svg")
                },
                JetBrainsIconKind.SQLOtherStatement_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLOtherStatement_Database.svg")
                },
                JetBrainsIconKind.SQLOtherStatementDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLOtherStatementDark_Database.svg")
                },
                JetBrainsIconKind.SQLSelectStatement_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLSelectStatement_Database.svg")
                },
                JetBrainsIconKind.SQLSelectStatementDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SQLSelectStatementDark_Database.svg")
                },
                JetBrainsIconKind.SqlServer_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SqlServer_Providers.svg")
                },
                JetBrainsIconKind.SqlServerDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SqlServerDark_Providers.svg")
                },
                JetBrainsIconKind.Star_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Star_Nodes.svg")
                },
                JetBrainsIconKind.StarDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/StarDark_Nodes.svg")
                },
                JetBrainsIconKind.StarEmpty_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/StarEmpty_Nodes.svg")
                },
                JetBrainsIconKind.StarEmptyDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/StarEmptyDark_Nodes.svg")
                },
                JetBrainsIconKind.Stash_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Stash_Vcs.svg")
                },
                JetBrainsIconKind.StashDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/StashDark_Vcs.svg")
                },
                JetBrainsIconKind.Static_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Static_Nodes.svg")
                },
                JetBrainsIconKind.Static_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Static_Rust.svg")
                },
                JetBrainsIconKind.StaticDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/StaticDark_Nodes.svg")
                },
                JetBrainsIconKind.StaticDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/StaticDark_Rust.svg")
                },
                JetBrainsIconKind.StatusDisabled_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/StatusDisabled_SettingSync.svg")
                },
                JetBrainsIconKind.StatusDisabledDark_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/StatusDisabledDark_SettingSync.svg")
                },
                JetBrainsIconKind.StatusEnabled_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/StatusEnabled_SettingSync.svg")
                },
                JetBrainsIconKind.StatusEnabledDark_SettingSync => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/SettingSync/StatusEnabledDark_SettingSync.svg")
                },
                JetBrainsIconKind.StepDefinitionFile_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/StepDefinitionFile_Ruby.svg")
                },
                JetBrainsIconKind.StepDefinitionFileDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/StepDefinitionFileDark_Ruby.svg")
                },
                JetBrainsIconKind.Stepik24_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Stepik@24x24_EduTools.svg")
                },
                JetBrainsIconKind.Stepik24Dark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/Stepik@24x24Dark_EduTools.svg")
                },
                JetBrainsIconKind.StepInto_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepInto_Run.svg")
                },
                JetBrainsIconKind.StepIntoDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepIntoDark_Run.svg")
                },
                JetBrainsIconKind.StepIntoMyCode_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/StepIntoMyCode_Python.svg")
                },
                JetBrainsIconKind.StepIntoMyCodeDark_Python => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Python/StepIntoMyCodeDark_Python.svg")
                },
                JetBrainsIconKind.StepOut_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOut_Run.svg")
                },
                JetBrainsIconKind.StepOutCodeBlock_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOutCodeBlock_Run.svg")
                },
                JetBrainsIconKind.StepOutCodeBlockDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOutCodeBlockDark_Run.svg")
                },
                JetBrainsIconKind.StepOutDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOutDark_Run.svg")
                },
                JetBrainsIconKind.StepOver_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOver_Run.svg")
                },
                JetBrainsIconKind.StepOverDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StepOverDark_Run.svg")
                },
                JetBrainsIconKind.STM32CubeMX_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/STM32CubeMX_Cidr.svg")
                },
                JetBrainsIconKind.STM32CubeMXDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/STM32CubeMXDark_Cidr.svg")
                },
                JetBrainsIconKind.Stop_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/Stop_Progress.svg")
                },
                JetBrainsIconKind.Stop_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/Stop_Run.svg")
                },
                JetBrainsIconKind.StopDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/StopDark_Progress.svg")
                },
                JetBrainsIconKind.StopDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/StopDark_Run.svg")
                },
                JetBrainsIconKind.StopHovered_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/StopHovered_Progress.svg")
                },
                JetBrainsIconKind.StopHoveredDark_Progress => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ProgressBar/Progress/StopHoveredDark_Progress.svg")
                },
                JetBrainsIconKind.Stream_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Stream_Database.svg")
                },
                JetBrainsIconKind.StreamDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StreamDark_Database.svg")
                },
                JetBrainsIconKind.StreamKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StreamKey_Database.svg")
                },
                JetBrainsIconKind.StreamKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StreamKeyDark_Database.svg")
                },
                JetBrainsIconKind.String_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/String_Database.svg")
                },
                JetBrainsIconKind.StringDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StringDark_Database.svg")
                },
                JetBrainsIconKind.StringKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StringKey_Database.svg")
                },
                JetBrainsIconKind.StringKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/StringKeyDark_Database.svg")
                },
                JetBrainsIconKind.Struct_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Struct_Rust.svg")
                },
                JetBrainsIconKind.StructDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/StructDark_Rust.svg")
                },
                JetBrainsIconKind.Structure_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Structure_ToolWindows.svg")
                },
                JetBrainsIconKind.Structure20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Structure@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Structure20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Structure@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.StructureDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/StructureDark_ToolWindows.svg")
                },
                JetBrainsIconKind.StructureListView_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/StructureListView_Ruby.svg")
                },
                JetBrainsIconKind.StructureListViewDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/StructureListViewDark_Ruby.svg")
                },
                JetBrainsIconKind.Stylus => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Stylus/Stylus.svg")
                },
                JetBrainsIconKind.StylusDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Stylus/StylusDark.svg")
                },
                JetBrainsIconKind.SubmitDB_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SubmitDB_Database.svg")
                },
                JetBrainsIconKind.SubmitDBDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SubmitDBDark_Database.svg")
                },
                JetBrainsIconKind.Success_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/Success_Status.svg")
                },
                JetBrainsIconKind.SuccessDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/SuccessDark_Status.svg")
                },
                JetBrainsIconKind.SuccessDialog_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/SuccessDialog_Status.svg")
                },
                JetBrainsIconKind.SuccessDialogDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/SuccessDialogDark_Status.svg")
                },
                JetBrainsIconKind.SuccessLogin_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/SuccessLogin_Status.svg")
                },
                JetBrainsIconKind.SuccessLoginDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/SuccessLoginDark_Status.svg")
                },
                JetBrainsIconKind.SuggestedRefactoring_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/SuggestedRefactoring_Gutter.svg")
                },
                JetBrainsIconKind.SuggestedRefactoringDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/SuggestedRefactoringDark_Gutter.svg")
                },
                JetBrainsIconKind.SuggestedRefactoringDisabled_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/SuggestedRefactoringDisabled_Gutter.svg")
                },
                JetBrainsIconKind.SuggestedRefactoringDisabledDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/SuggestedRefactoringDisabledDark_Gutter.svg")
                },
                JetBrainsIconKind.Sun_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Sun_Providers.svg")
                },
                JetBrainsIconKind.SunDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SunDark_Providers.svg")
                },
                JetBrainsIconKind.SwiftLang_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftLang_Cidr.svg")
                },
                JetBrainsIconKind.SwiftLangDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftLangDark_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackage_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackage_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageDark_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageDependency_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageDependency_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageDependencyDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageDependencyDark_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageManifest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageManifest_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageManifestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageManifestDark_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageRun_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageRun_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageRunDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageRunDark_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageTest_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageTest_Cidr.svg")
                },
                JetBrainsIconKind.SwiftPackageTestDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/SwiftPackageTestDark_Cidr.svg")
                },
                JetBrainsIconKind.Sybase_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Sybase_Providers.svg")
                },
                JetBrainsIconKind.SybaseDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/SybaseDark_Providers.svg")
                },
                JetBrainsIconKind.Symbol_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Symbol_Ruby.svg")
                },
                JetBrainsIconKind.SymbolDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/SymbolDark_Ruby.svg")
                },
                JetBrainsIconKind.Synonym_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Synonym_Database.svg")
                },
                JetBrainsIconKind.SynonymDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/SynonymDark_Database.svg")
                },
                JetBrainsIconKind.SystemDBField_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/SystemDBField_Ruby.svg")
                },
                JetBrainsIconKind.SystemDBFieldDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/SystemDBFieldDark_Ruby.svg")
                },
                JetBrainsIconKind.SystemTheme_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/SystemTheme_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.SystemThemeDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/SystemThemeDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.SystemThemeSelected_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/SystemThemeSelected_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.SystemThemeSelectedDark_NewUI_NewUi => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/NewUI/NewUi/SystemThemeSelectedDark_NewUI_NewUi.svg")
                },
                JetBrainsIconKind.Table_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Table_Database.svg")
                },
                JetBrainsIconKind.TableDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TableDark_Database.svg")
                },
                JetBrainsIconKind.TableMapping_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TableMapping_Database.svg")
                },
                JetBrainsIconKind.TableMappingDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TableMappingDark_Database.svg")
                },
                JetBrainsIconKind.Tablespace_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Tablespace_Database.svg")
                },
                JetBrainsIconKind.TablespaceDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TablespaceDark_Database.svg")
                },
                JetBrainsIconKind.TagWithClasses_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/TagWithClasses_Cssselector.svg")
                },
                JetBrainsIconKind.TagWithClasses14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/TagWithClasses@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.TagWithClasses14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/TagWithClasses@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.TagWithClassesDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/TagWithClassesDark_Cssselector.svg")
                },
                JetBrainsIconKind.TailRecursion14_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TailRecursion@14x14_Scala.svg")
                },
                JetBrainsIconKind.TailRecursion14Dark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TailRecursion@14x14Dark_Scala.svg")
                },
                JetBrainsIconKind.Tarantool_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Tarantool_Providers.svg")
                },
                JetBrainsIconKind.TarantoolDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TarantoolDark_Providers.svg")
                },
                JetBrainsIconKind.Target_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Target_Cidr.svg")
                },
                JetBrainsIconKind.Target_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Target_Rust.svg")
                },
                JetBrainsIconKind.TargetBench_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBench_Rust.svg")
                },
                JetBrainsIconKind.TargetBenchDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBenchDark_Rust.svg")
                },
                JetBrainsIconKind.TargetBinary_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBinary_Rust.svg")
                },
                JetBrainsIconKind.TargetBinaryDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBinaryDark_Rust.svg")
                },
                JetBrainsIconKind.TargetBuild_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBuild_Rust.svg")
                },
                JetBrainsIconKind.TargetBuildDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetBuildDark_Rust.svg")
                },
                JetBrainsIconKind.TargetDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/TargetDark_Cidr.svg")
                },
                JetBrainsIconKind.TargetDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetDark_Rust.svg")
                },
                JetBrainsIconKind.TargetExample_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetExample_Rust.svg")
                },
                JetBrainsIconKind.TargetExampleDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetExampleDark_Rust.svg")
                },
                JetBrainsIconKind.TargetLibrary_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetLibrary_Rust.svg")
                },
                JetBrainsIconKind.TargetLibraryDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetLibraryDark_Rust.svg")
                },
                JetBrainsIconKind.TargetTest_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetTest_Rust.svg")
                },
                JetBrainsIconKind.TargetTestDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TargetTestDark_Rust.svg")
                },
                JetBrainsIconKind.Task_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/Task_Build.svg")
                },
                JetBrainsIconKind.Task_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Task_ToolWindows.svg")
                },
                JetBrainsIconKind.Task20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Task@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Task20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Task@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.TaskDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/TaskDark_Build.svg")
                },
                JetBrainsIconKind.TaskDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/TaskDark_ToolWindows.svg")
                },
                JetBrainsIconKind.TaskGroup_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/TaskGroup_Build.svg")
                },
                JetBrainsIconKind.TaskGroupDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/TaskGroupDark_Build.svg")
                },
                JetBrainsIconKind.Teradata_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Teradata_Providers.svg")
                },
                JetBrainsIconKind.TeradataDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TeradataDark_Providers.svg")
                },
                JetBrainsIconKind.Terminal_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Terminal_ToolWindows.svg")
                },
                JetBrainsIconKind.Terminal20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Terminal@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Terminal20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Terminal@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.TerminalDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/TerminalDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Terraform_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Terraform_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.TerraformDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/TerraformDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Test_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Test_Nodes.svg")
                },
                JetBrainsIconKind.TestCustom_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestCustom_Run.svg")
                },
                JetBrainsIconKind.TestCustomDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestCustomDark_Run.svg")
                },
                JetBrainsIconKind.TestDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestDark_Nodes.svg")
                },
                JetBrainsIconKind.TestError_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestError_Run.svg")
                },
                JetBrainsIconKind.TestErrorDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestErrorDark_Run.svg")
                },
                JetBrainsIconKind.TestFailed_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestFailed_Run.svg")
                },
                JetBrainsIconKind.TestFailedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestFailedDark_Run.svg")
                },
                JetBrainsIconKind.TestIgnored_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestIgnored_Nodes.svg")
                },
                JetBrainsIconKind.TestIgnored_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestIgnored_Run.svg")
                },
                JetBrainsIconKind.TestIgnoredDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestIgnoredDark_Nodes.svg")
                },
                JetBrainsIconKind.TestIgnoredDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestIgnoredDark_Run.svg")
                },
                JetBrainsIconKind.TestNotRunYet => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestNotRunYet.svg")
                },
                JetBrainsIconKind.TestNotRunYetDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestNotRunYetDark.svg")
                },
                JetBrainsIconKind.TestPassed_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPassed_Run.svg")
                },
                JetBrainsIconKind.TestPassedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPassedDark_Run.svg")
                },
                JetBrainsIconKind.TestPassedIgnored_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPassedIgnored_Run.svg")
                },
                JetBrainsIconKind.TestPassedIgnoredDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPassedIgnoredDark_Run.svg")
                },
                JetBrainsIconKind.TestPaused_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPaused_Run.svg")
                },
                JetBrainsIconKind.TestPausedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestPausedDark_Run.svg")
                },
                JetBrainsIconKind.TestResourcesRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestResourcesRoot_Nodes.svg")
                },
                JetBrainsIconKind.TestResourcesRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestResourcesRootDark_Nodes.svg")
                },
                JetBrainsIconKind.TestRoot_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestRoot_Nodes.svg")
                },
                JetBrainsIconKind.TestRootDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestRootDark_Nodes.svg")
                },
                JetBrainsIconKind.TestSkipped_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestSkipped_Run.svg")
                },
                JetBrainsIconKind.TestSkippedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestSkippedDark_Run.svg")
                },
                JetBrainsIconKind.TestSourceFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestSourceFolder_Nodes.svg")
                },
                JetBrainsIconKind.TestSourceFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TestSourceFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.TestTerminated_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestTerminated_Run.svg")
                },
                JetBrainsIconKind.TestTerminatedDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestTerminatedDark_Run.svg")
                },
                JetBrainsIconKind.TestUnitFile_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/TestUnitFile_Ruby.svg")
                },
                JetBrainsIconKind.TestUnitFileDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/TestUnitFileDark_Ruby.svg")
                },
                JetBrainsIconKind.TestUnknown_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestUnknown_Run.svg")
                },
                JetBrainsIconKind.TestUnknownDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TestUnknownDark_Run.svg")
                },
                JetBrainsIconKind.Text_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Text_Cssselector.svg")
                },
                JetBrainsIconKind.Text_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Text_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Text14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Text@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.Text14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Text@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.TextAutoGenerate_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TextAutoGenerate_Database.svg")
                },
                JetBrainsIconKind.TextAutoGenerateDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TextAutoGenerateDark_Database.svg")
                },
                JetBrainsIconKind.TextDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/TextDark_Cssselector.svg")
                },
                JetBrainsIconKind.TextDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/TextDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Tibero_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Tibero_Providers.svg")
                },
                JetBrainsIconKind.TiberoDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TiberoDark_Providers.svg")
                },
                JetBrainsIconKind.Tidb_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Tidb_Providers.svg")
                },
                JetBrainsIconKind.TidbDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TidbDark_Providers.svg")
                },
                JetBrainsIconKind.Todo_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Todo_ToolWindows.svg")
                },
                JetBrainsIconKind.Todo20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Todo@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Todo20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Todo@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.TodoDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/TodoDark_ToolWindows.svg")
                },
                JetBrainsIconKind.ToggleOfflineMode_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/ToggleOfflineMode_Build.svg")
                },
                JetBrainsIconKind.ToggleOfflineModeDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/ToggleOfflineModeDark_Build.svg")
                },
                JetBrainsIconKind.ToggleSkipTestsMode_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/ToggleSkipTestsMode_Build.svg")
                },
                JetBrainsIconKind.ToggleSkipTestsModeDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/ToggleSkipTestsModeDark_Build.svg")
                },
                JetBrainsIconKind.ToggleVisibility_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/ToggleVisibility_Actions.svg")
                },
                JetBrainsIconKind.ToggleVisibilityDark_Actions => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Actions/ToggleVisibilityDark_Actions.svg")
                },
                JetBrainsIconKind.Toml => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Toml/Toml.svg")
                },
                JetBrainsIconKind.TomlDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Toml/TomlDark.svg")
                },
                JetBrainsIconKind.TraceStream_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TraceStream_Run.svg")
                },
                JetBrainsIconKind.TraceStreamDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/TraceStreamDark_Run.svg")
                },
                JetBrainsIconKind.Trait_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Trait_Ruby.svg")
                },
                JetBrainsIconKind.Trait_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Trait_Rust.svg")
                },
                JetBrainsIconKind.TraitCompanion_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitCompanion_Scala.svg")
                },
                JetBrainsIconKind.TraitCompanionDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitCompanionDark_Scala.svg")
                },
                JetBrainsIconKind.TraitCompanionSwapped_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitCompanionSwapped_Scala.svg")
                },
                JetBrainsIconKind.TraitCompanionSwappedDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitCompanionSwappedDark_Scala.svg")
                },
                JetBrainsIconKind.TraitDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/TraitDark_Ruby.svg")
                },
                JetBrainsIconKind.TraitDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TraitDark_Rust.svg")
                },
                JetBrainsIconKind.TraitObjectScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitObjectScala.svg")
                },
                JetBrainsIconKind.TraitObjectScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitObjectScalaDark.svg")
                },
                JetBrainsIconKind.TraitScala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitScala.svg")
                },
                JetBrainsIconKind.TraitScalaDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TraitScalaDark.svg")
                },
                JetBrainsIconKind.TransactionManager_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/TransactionManager_Spring.svg")
                },
                JetBrainsIconKind.TransactionManagerDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/TransactionManagerDark_Spring.svg")
                },
                JetBrainsIconKind.Transfer_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Transfer_ToolWindows.svg")
                },
                JetBrainsIconKind.Transfer20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Transfer@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Transfer20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Transfer@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.TransferDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/TransferDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Trigger_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Trigger_Database.svg")
                },
                JetBrainsIconKind.TriggerDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/TriggerDark_Database.svg")
                },
                JetBrainsIconKind.Trino_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Trino_Providers.svg")
                },
                JetBrainsIconKind.TrinoDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TrinoDark_Providers.svg")
                },
                JetBrainsIconKind.TSQLt_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TSQLt_Providers.svg")
                },
                JetBrainsIconKind.TSQLtDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/TSQLtDark_Providers.svg")
                },
                JetBrainsIconKind.Type_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Type_Nodes.svg")
                },
                JetBrainsIconKind.TypeAlias_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/TypeAlias_Kotlin.svg")
                },
                JetBrainsIconKind.TypeAlias_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TypeAlias_Rust.svg")
                },
                JetBrainsIconKind.TypeAlias_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TypeAlias_Scala.svg")
                },
                JetBrainsIconKind.TypeAliasDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/TypeAliasDark_Kotlin.svg")
                },
                JetBrainsIconKind.TypeAliasDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/TypeAliasDark_Rust.svg")
                },
                JetBrainsIconKind.TypeAliasDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TypeAliasDark_Scala.svg")
                },
                JetBrainsIconKind.Typed_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Typed_Scala.svg")
                },
                JetBrainsIconKind.TypeDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/TypeDark_Nodes.svg")
                },
                JetBrainsIconKind.TypedDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/TypedDark_Scala.svg")
                },
                JetBrainsIconKind.TypeExtension_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/TypeExtension_Cidr.svg")
                },
                JetBrainsIconKind.TypeExtensionDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/TypeExtensionDark_Cidr.svg")
                },
                JetBrainsIconKind.TypeScript_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/TypeScript_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.TypeScriptDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/TypeScriptDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.UDFScript_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UDFScript_Database.svg")
                },
                JetBrainsIconKind.UDFScriptDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UDFScriptDark_Database.svg")
                },
                JetBrainsIconKind.Undo_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Undo_General.svg")
                },
                JetBrainsIconKind.UndocumentedTask_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/UndocumentedTask_Ruby.svg")
                },
                JetBrainsIconKind.UndocumentedTaskDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/UndocumentedTaskDark_Ruby.svg")
                },
                JetBrainsIconKind.UndoDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/UndoDark_General.svg")
                },
                JetBrainsIconKind.Unfold_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/Unfold_Gutter.svg")
                },
                JetBrainsIconKind.UnfoldDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/UnfoldDark_Gutter.svg")
                },
                JetBrainsIconKind.Unfreeze_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Unfreeze_Cidr.svg")
                },
                JetBrainsIconKind.UnfreezeAll_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/UnfreezeAll_Cidr.svg")
                },
                JetBrainsIconKind.UnfreezeAllDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/UnfreezeAllDark_Cidr.svg")
                },
                JetBrainsIconKind.UnfreezeDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/UnfreezeDark_Cidr.svg")
                },
                JetBrainsIconKind.Union_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/Union_Rust.svg")
                },
                JetBrainsIconKind.UnionDark_Rust => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Rust/UnionDark_Rust.svg")
                },
                JetBrainsIconKind.Unknown_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Unknown_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Unknown_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Unknown_ToolWindows.svg")
                },
                JetBrainsIconKind.Unknown20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Unknown@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Unknown20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/Unknown@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.UnknownDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/UnknownDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.UnknownDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/UnknownDark_ToolWindows.svg")
                },
                JetBrainsIconKind.UnloadedModule_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/UnloadedModule_Nodes.svg")
                },
                JetBrainsIconKind.UnloadedModuleDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/UnloadedModuleDark_Nodes.svg")
                },
                JetBrainsIconKind.Unlocked_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Unlocked_General.svg")
                },
                JetBrainsIconKind.UnlockedDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/UnlockedDark_General.svg")
                },
                JetBrainsIconKind.Unshelve_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Unshelve_Vcs.svg")
                },
                JetBrainsIconKind.UnshelveDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/UnshelveDark_Vcs.svg")
                },
                JetBrainsIconKind.UnspecifiedCluster_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UnspecifiedCluster_Database.svg")
                },
                JetBrainsIconKind.UnspecifiedClusterDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UnspecifiedClusterDark_Database.svg")
                },
                JetBrainsIconKind.Untyped_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Untyped_Scala.svg")
                },
                JetBrainsIconKind.UntypedDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/UntypedDark_Scala.svg")
                },
                JetBrainsIconKind.Up_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Up_General.svg")
                },
                JetBrainsIconKind.UpDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/UpDark_General.svg")
                },
                JetBrainsIconKind.Update_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Update_Vcs.svg")
                },
                JetBrainsIconKind.UpdateDark_Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/UpdateDark_Vcs.svg")
                },
                JetBrainsIconKind.UpdateFolders_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/UpdateFolders_Build.svg")
                },
                JetBrainsIconKind.UpdateFoldersDark_Build => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Build/UpdateFoldersDark_Build.svg")
                },
                JetBrainsIconKind.UpFolder_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/UpFolder_Nodes.svg")
                },
                JetBrainsIconKind.UpFolderDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/UpFolderDark_Nodes.svg")
                },
                JetBrainsIconKind.Upload_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Upload_General.svg")
                },
                JetBrainsIconKind.UploadDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/UploadDark_General.svg")
                },
                JetBrainsIconKind.User_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/User_Database.svg")
                },
                JetBrainsIconKind.UserDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserDark_Database.svg")
                },
                JetBrainsIconKind.UserDriver_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserDriver_Database.svg")
                },
                JetBrainsIconKind.UserDriverDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserDriverDark_Database.svg")
                },
                JetBrainsIconKind.UserGroup_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserGroup_Database.svg")
                },
                JetBrainsIconKind.UserGroupDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserGroupDark_Database.svg")
                },
                JetBrainsIconKind.UserMapping_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserMapping_Database.svg")
                },
                JetBrainsIconKind.UserMappingDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/UserMappingDark_Database.svg")
                },
                JetBrainsIconKind.UsersNumbers_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/UsersNumbers_EduTools.svg")
                },
                JetBrainsIconKind.UsersNumbersDark_EduTools => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/EduTools/UsersNumbersDark_EduTools.svg")
                },
                JetBrainsIconKind.UtPLSQL_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/UtPLSQL_Providers.svg")
                },
                JetBrainsIconKind.UtPLSQLDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/UtPLSQLDark_Providers.svg")
                },
                JetBrainsIconKind.Value_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/Value_Kotlin.svg")
                },
                JetBrainsIconKind.Value_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Value_Scala.svg")
                },
                JetBrainsIconKind.ValueDark_Kotlin => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Kotlin/ValueDark_Kotlin.svg")
                },
                JetBrainsIconKind.ValueDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/ValueDark_Scala.svg")
                },
                JetBrainsIconKind.ValueMuted_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ValueMuted_Cidr.svg")
                },
                JetBrainsIconKind.ValueMutedDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/ValueMutedDark_Cidr.svg")
                },
                JetBrainsIconKind.Variable_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/Variable_Nodes.svg")
                },
                JetBrainsIconKind.Variable_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Variable_Ruby.svg")
                },
                JetBrainsIconKind.Variable_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/Variable_Scala.svg")
                },
                JetBrainsIconKind.VariableDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/VariableDark_Nodes.svg")
                },
                JetBrainsIconKind.VariableDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/VariableDark_Ruby.svg")
                },
                JetBrainsIconKind.VariableDark_Scala => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Scala/VariableDark_Scala.svg")
                },
                JetBrainsIconKind.Variables_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Variables_Cidr.svg")
                },
                JetBrainsIconKind.Variables_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/Variables_Inline.svg")
                },
                JetBrainsIconKind.VariablesDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/VariablesDark_Cidr.svg")
                },
                JetBrainsIconKind.VariablesDark_Inline => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/InLine/Inline/VariablesDark_Inline.svg")
                },
                JetBrainsIconKind.VCPKG_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/VCPKG_Cidr.svg")
                },
                JetBrainsIconKind.VCPKGDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/VCPKGDark_Cidr.svg")
                },
                JetBrainsIconKind.Vcs => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/Vcs.svg")
                },
                JetBrainsIconKind.Vcs_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/Vcs_General.svg")
                },
                JetBrainsIconKind.Vcs_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Vcs_ToolWindows.svg")
                },
                JetBrainsIconKind.Vcs20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Vcs@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Vcs20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Vcs@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.VcsDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Vcs/Vcs/VcsDark.svg")
                },
                JetBrainsIconKind.VcsDark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/VcsDark_General.svg")
                },
                JetBrainsIconKind.VcsDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/VcsDark_ToolWindows.svg")
                },
                JetBrainsIconKind.Velocity_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Velocity_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.VelocityDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/VelocityDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Vendor_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/Vendor_GoLang.svg")
                },
                JetBrainsIconKind.VendorDark_GoLang => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/GoLang/VendorDark_GoLang.svg")
                },
                JetBrainsIconKind.Vertica_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Vertica_Providers.svg")
                },
                JetBrainsIconKind.VerticaDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/VerticaDark_Providers.svg")
                },
                JetBrainsIconKind.Vhdl_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/Vhdl_Cidr.svg")
                },
                JetBrainsIconKind.VhdlDark_Cidr => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Cidr/VhdlDark_Cidr.svg")
                },
                JetBrainsIconKind.ViewBreakpoints_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ViewBreakpoints_Run.svg")
                },
                JetBrainsIconKind.ViewBreakpointsDark_Run => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Run/ViewBreakpointsDark_Run.svg")
                },
                JetBrainsIconKind.ViewParameters_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ViewParameters_Database.svg")
                },
                JetBrainsIconKind.ViewParametersDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/ViewParametersDark_Database.svg")
                },
                JetBrainsIconKind.VirtualColumn_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualColumn_Database.svg")
                },
                JetBrainsIconKind.VirtualColumnDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualColumnDark_Database.svg")
                },
                JetBrainsIconKind.VirtualFolder_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualFolder_Database.svg")
                },
                JetBrainsIconKind.VirtualFolderDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualFolderDark_Database.svg")
                },
                JetBrainsIconKind.VirtualKey_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualKey_Database.svg")
                },
                JetBrainsIconKind.VirtualKeyDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualKeyDark_Database.svg")
                },
                JetBrainsIconKind.VirtualView_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualView_Database.svg")
                },
                JetBrainsIconKind.VirtualViewDark_Database => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/VirtualViewDark_Database.svg")
                },
                JetBrainsIconKind.ViteJS_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/ViteJS_FilesNodes.svg")
                },
                JetBrainsIconKind.ViteJSDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/ViteJSDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Vitest_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Vitest_FilesNodes.svg")
                },
                JetBrainsIconKind.VitestDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/VitestDark_FilesNodes.svg")
                },
                JetBrainsIconKind.VueJs_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/VueJs_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.VueJsDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/VueJsDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Warehouse_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Warehouse_Providers.svg")
                },
                JetBrainsIconKind.WarehouseDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/WarehouseDark_Providers.svg")
                },
                JetBrainsIconKind.Warning_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/Warning_Status.svg")
                },
                JetBrainsIconKind.WarningDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/WarningDark_Status.svg")
                },
                JetBrainsIconKind.WarningDialog_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/WarningDialog_Status.svg")
                },
                JetBrainsIconKind.WarningDialogDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/WarningDialogDark_Status.svg")
                },
                JetBrainsIconKind.WarningIntroduction_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/WarningIntroduction_Nodes.svg")
                },
                JetBrainsIconKind.WarningIntroductionDark_Nodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Nodes/WarningIntroductionDark_Nodes.svg")
                },
                JetBrainsIconKind.WarningOutline_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/WarningOutline_Status.svg")
                },
                JetBrainsIconKind.WarningOutlineDark_Status => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Status/Status/WarningOutlineDark_Status.svg")
                },
                JetBrainsIconKind.Watch_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/Watch_RunDebug.svg")
                },
                JetBrainsIconKind.WatchDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/WatchDark_RunDebug.svg")
                },
                JetBrainsIconKind.Web_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Web_ToolWindows.svg")
                },
                JetBrainsIconKind.Web20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Web@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Web20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Web@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.WebApp_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/WebApp_RunDebug.svg")
                },
                JetBrainsIconKind.WebAppDark_RunDebug => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/RunDebug/WebAppDark_RunDebug.svg")
                },
                JetBrainsIconKind.WebDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WebDark_ToolWindows.svg")
                },
                JetBrainsIconKind.WebLocator_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebLocator_ToolWindows.svg")
                },
                JetBrainsIconKind.WebLocator20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebLocator@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.WebLocator20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebLocator@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.WebLocatorDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebLocatorDark_ToolWindows.svg")
                },
                JetBrainsIconKind.WebOverlay_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/WebOverlay_Spring.svg")
                },
                JetBrainsIconKind.WebOverlayDark_Spring => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Spring/WebOverlayDark_Spring.svg")
                },
                JetBrainsIconKind.WebRootFile_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/WebRootFile_Ruby.svg")
                },
                JetBrainsIconKind.WebRootFileDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/WebRootFileDark_Ruby.svg")
                },
                JetBrainsIconKind.WebServer_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebServer_ToolWindows.svg")
                },
                JetBrainsIconKind.WebServer20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebServer@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.WebServer20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebServer@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.WebServerDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/WebServerDark_ToolWindows.svg")
                },
                JetBrainsIconKind.WindowsMenu20_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/WindowsMenu@20x20_General.svg")
                },
                JetBrainsIconKind.WindowsMenu20Dark_General => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/General/General/WindowsMenu@20x20Dark_General.svg")
                },
                JetBrainsIconKind.Wrapper_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/Wrapper_Writerside.svg")
                },
                JetBrainsIconKind.WrapperDark_Writerside => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/WrapperDark_Writerside.svg")
                },
                JetBrainsIconKind.WriteAccess_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/WriteAccess_Gutter.svg")
                },
                JetBrainsIconKind.WriteAccessDark_Gutter => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Gutter/WriteAccessDark_Gutter.svg")
                },
                JetBrainsIconKind.Writer_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Writer_Ruby.svg")
                },
                JetBrainsIconKind.WriterDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/WriterDark_Ruby.svg")
                },
                JetBrainsIconKind.WriteReview_Plugins => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Plugins/WriteReview_Plugins.svg")
                },
                JetBrainsIconKind.WriteReviewDark_Plugins => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Plugins/WriteReviewDark_Plugins.svg")
                },
                JetBrainsIconKind.Writerside_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Writerside_ToolWindows.svg")
                },
                JetBrainsIconKind.Writerside20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Writerside@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.Writerside20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/Writerside@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersideDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WritersideDark_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersidePreview_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WritersidePreview_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersidePreview20_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WritersidePreview@20x20_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersidePreview20Dark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WritersidePreview@20x20Dark_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersidePreviewDark_ToolWindows => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/ToolWindows/ToolWindows/WritersidePreviewDark_ToolWindows.svg")
                },
                JetBrainsIconKind.WritersideTopicFileType => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/WritersideTopicFileType.svg")
                },
                JetBrainsIconKind.WritersideTopicFileTypeDark => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Writerside/WritersideTopicFileTypeDark.svg")
                },
                JetBrainsIconKind.Wsdl_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Wsdl_FilesNodes.svg")
                },
                JetBrainsIconKind.WsdlDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/WsdlDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Xhtml_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Xhtml_FilesNodes.svg")
                },
                JetBrainsIconKind.XhtmlDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/XhtmlDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Xml_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Xml_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.XmlDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/XmlDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Xpath_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Xpath_Cssselector.svg")
                },
                JetBrainsIconKind.Xpath14_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Xpath@14x14_Cssselector.svg")
                },
                JetBrainsIconKind.Xpath14Dark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/Xpath@14x14Dark_Cssselector.svg")
                },
                JetBrainsIconKind.XpathDark_Cssselector => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Aqua/Cssselector/XpathDark_Cssselector.svg")
                },
                JetBrainsIconKind.Xsd_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/Xsd_FilesNodes.svg")
                },
                JetBrainsIconKind.XsdDark_FilesNodes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/XsdDark_FilesNodes.svg")
                },
                JetBrainsIconKind.Yaml_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Yaml_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.YamlDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/YamlDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Yarn_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/Yarn_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.YarnDark_FilesNodesFileTypes => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/FilesNodes/FilesNodesFileTypes/YarnDark_FilesNodesFileTypes.svg")
                },
                JetBrainsIconKind.Yugabyte_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/Yugabyte_Providers.svg")
                },
                JetBrainsIconKind.YugabyteDark_Providers => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Database/Providers/YugabyteDark_Providers.svg")
                },
                JetBrainsIconKind.Zeus_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/Zeus_Ruby.svg")
                },
                JetBrainsIconKind.ZeusDark_Ruby => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Ruby/ZeusDark_Ruby.svg")
                },
                JetBrainsIconKind.ZoomIn_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ZoomIn_Image.svg")
                },
                JetBrainsIconKind.ZoomInDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ZoomInDark_Image.svg")
                },
                JetBrainsIconKind.ZoomOut_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ZoomOut_Image.svg")
                },
                JetBrainsIconKind.ZoomOutDark_Image => new List<JetBrainsIconData>
                {
                    new JetBrainsIconData("avares://JetBrains.Icons.Avalonia/Assets/Icons/Editor/Image/ZoomOutDark_Image.svg")
                },
                _ => new List<JetBrainsIconData>()
            };
        }
    }
}
