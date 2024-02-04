using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0234
{
    /// <summary>
    /// OBSOLETE - See R5T.L0096.T000.
    /// 
    /// Has a string-typed Visual Studio (MSBuild) project file path.
    /// </summary>
    /// <remarks>
    /// Left unspecified is whether the project file is a .csproj (C#), .vbproj (Visual Basic), .fsproj (F#), or other .NET language MSBuild project file.
    /// </remarks>
    [HasXMarker, DataTypeMarker]
    public interface IHasProjectFilePath
    {
        string ProjectFilePath { get; }
    }
}
