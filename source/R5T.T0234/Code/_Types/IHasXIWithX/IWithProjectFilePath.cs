using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0234
{
    /// <summary>
    /// With a string-typed project file path.
    /// </summary>
    /// <inheritdoc cref="IHasProjectFilePath" path="/remarks"/>
    [WithXMarker, DataTypeMarker]
    public interface IWithProjectFilePath :
        IHasProjectFilePath
    {
        new string ProjectFilePath { get; set; }
    }
}
