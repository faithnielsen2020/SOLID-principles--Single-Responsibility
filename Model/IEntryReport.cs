using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLogProject.Model
{
    public interface IEntryReport<T>
    {
        void addEntry(T entry);
        void deleteEntry(string id);
    }
}
