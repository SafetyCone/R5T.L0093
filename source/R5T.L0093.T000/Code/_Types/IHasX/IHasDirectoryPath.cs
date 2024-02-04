using System;

using R5T.T0240;


namespace R5T.L0093.T000
{
    /// <summary>
    /// Has a stringly-typed directory path.
    /// </summary>
    [HasXMarker]
    public interface IHasDirectoryPath
    {
        string DirectoryPath { get; }
    }
}
