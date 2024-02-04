using System;

using R5T.T0142;
using R5T.T0240;


namespace R5T.T0234
{
    /// <summary>
    /// OBSOLETE - See R5T.L0095.T000.
    /// 
    /// With a string-typed solution file path.
    /// </summary>
    [WithXMarker, DataTypeMarker]
    public interface IWithSolutionFilePath :
        IHasSolutionFilePath
    {
        new string SolutionFilePath { get; set; }
    }
}
