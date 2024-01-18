using System;

using R5T.T0142;


namespace R5T.T0234
{
    /// <summary>
    /// With a string-typed solution file path.
    /// </summary>
    [DataTypeMarker]
    public interface IWithSolutionFilePath
    {
        string SolutionFilePath { get; }
    }
}
