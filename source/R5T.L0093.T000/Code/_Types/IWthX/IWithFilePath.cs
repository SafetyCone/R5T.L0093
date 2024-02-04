using System;

using R5T.T0240;


namespace R5T.L0093.T000
{
    [WithXMarker]
    public interface IWithFilePath :
        IHasFilePath
    {
        new string FilePath { get; set; }
    }
}
