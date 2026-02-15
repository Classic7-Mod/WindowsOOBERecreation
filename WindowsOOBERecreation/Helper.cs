using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsOOBERecreation
{
    internal class Helper
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct USER_INFO_1
        {
            public string usri1_name;
            public string usri1_password;
            public uint usri1_password_age;
            public uint usri1_priv;
            public string usri1_home_dir;
            public string usri1_comment;
            public uint usri1_flags;
            public string usri1_script_path;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct LOCALGROUP_MEMBERS_INFO_3
        {
            public string lgrmi3_domainandname;
        }

        const uint USER_PRIV_USER = 1;
        const uint UF_SCRIPT = 0x0001;
        const uint UF_DONT_EXPIRE_PASSWD = 0x10000;

        [DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
        static extern uint NetUserAdd(
            string servername,
            uint level,
            ref USER_INFO_1 buf,
            out uint parm_err);

        [DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
        static extern uint NetLocalGroupAddMembers(
            string servername,
            string groupname,
            uint level,
            ref LOCALGROUP_MEMBERS_INFO_3 buf,
            uint totalentries);

        public static void CreateUser(string username, string password)
        {
            if (username == "Administrator")
                throw new Exception("Do not make accounts that use the name Administrator.");

            var user = new USER_INFO_1
            {
                usri1_name = username,
                usri1_password = password,
                usri1_priv = USER_PRIV_USER,
                usri1_flags = UF_SCRIPT | UF_DONT_EXPIRE_PASSWD
            };

            uint err;
            uint result = NetUserAdd(null, 1, ref user, out err);
            if (result != 0)
                throw new Exception($"NetUserAdd failed: {result} param:{err}");

            var member = new LOCALGROUP_MEMBERS_INFO_3
            {
                lgrmi3_domainandname = username
            };

            result = NetLocalGroupAddMembers(null, "Administrators", 3, ref member, 1);
            if (result != 0)
                throw new Exception($"Add to Administrators failed: {result}");
        }

        public static void ExecuteCommand(string command)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command)
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception(error);
                }
            }
        }
    }
}
