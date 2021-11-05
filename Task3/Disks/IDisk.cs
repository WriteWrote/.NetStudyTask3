using System;
using System.Collections.Generic;

namespace Task3
{
    public interface IDisk
    {
        void RecordFiles(List<MusicFile> files);
        void EraseAll();
        List<MusicFile> getRecordedFiles();

        Int32 getCapacity();
        double getEmptySpace();

        void setName(String name);
        String getName();
        String getFullName();

    }
}