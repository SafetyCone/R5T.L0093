using System;

using R5T.T0240;


namespace R5T.L0093.T000
{
    /// <summary>
    /// Has a stringly-typed file path.
    /// </summary>
    [HasXMarker]
    public interface IHasFilePath
    {
        string FilePath { get; }
    }
}
