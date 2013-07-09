﻿using System.Runtime.InteropServices;

namespace FB2EPubConverter.Interfaces
{
    [Guid("255293F1-ECB5-4218-8797-1068B915BEC5"),ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IProgressUpdateInterface
    {
        void ConvertStarted(System.Int32 total);
        void ConvertFinished(System.Int32 total);
        void ProcessingStarted(string fileName, System.Int32 count, System.Int32 total);
        void ProcessingSaving(string fileName, System.Int32 count, System.Int32 total);
        void Processed(string fileName, System.Int32 count, System.Int32 total);
        void SkippedDueError(string fileName);
    }
}
