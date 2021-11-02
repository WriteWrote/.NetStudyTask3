using System;

namespace Task3
{
    public interface IDisk
    {
        void RecordFiles(String files);
        void EraseAll();
        String getRecordedFiles();

        Int32 getCapacity();
        Int32 getEmptySpace();

    }
}