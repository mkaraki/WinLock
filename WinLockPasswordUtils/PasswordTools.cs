using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BCrypt.Net.BCrypt;
using Microsoft.Win32;

namespace WinLockPasswordUtils
{
    internal static class PasswordTools
    {
        private static readonly string Regkey = @"HKEY_LOCAL_MACHINE\SOFTWARE\WinLock\Auth";

        internal static bool IsPasswordSet()
        {
            var d = Registry.GetValue(Regkey, "Password", null);

            return d != null;
        }

        internal static bool Check(string Password)
        {
            if (!IsPasswordSet()) return true;

            string Hash = (string)Registry.GetValue(Regkey, "Password", null);
            return Verify(Password, Hash);
        }

        internal static void SetPassword(string Password)
        {
            string Hash = HashPassword(Password);
            Registry.SetValue(Regkey, "Password", Hash);
        }
    }
}
