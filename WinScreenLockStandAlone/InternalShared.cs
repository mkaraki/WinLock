using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinLockStandAlone
{
    internal static class InternalShared
    {
        internal static bool IsClosable { get; set; } = false;
    }
}
