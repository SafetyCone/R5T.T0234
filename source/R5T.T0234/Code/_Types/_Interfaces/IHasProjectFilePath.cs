﻿using System;

using R5T.T0142;


namespace R5T.T0234
{
    /// <summary>
    /// Has a string-typed Visual Studio (MSBuild) project file path.
    /// </summary>
    /// <remarks>
    /// Left unspecified is whether the project file is a .csproj (C#), .vbproj (Visual Basic), .fsproj (F#), or other .NET language MSBuild project file.
    /// </remarks>
    [DataTypeMarker]
    public interface IHasProjectFilePath
    {
        string ProjectFilePath { get; }
    }
}
