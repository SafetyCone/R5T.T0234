using System;

using R5T.T0142;


namespace R5T.T0234
{
    /// <summary>
    /// Has a string-typed solution file path.
    /// </summary>
    [DataTypeMarker]
    public interface IHasSolutionFilePath
    {
        string SolutionFilePath { get; }
    }
}
