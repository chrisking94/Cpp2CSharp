/* ==============================================================================
 * author		：chris
 * create time	：3/7/2019 4:30:07 PM
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using CommonDll;
using static CommonDll.Base;

namespace Cpp2CSharp
{
    public class CBase
    {
        #region data
        #region property
        #endregion

        #region field
        #endregion
        #endregion

        #region constructor
        protected CBase() { }
        #endregion

        #region interface
        public static void JumpWhite(string s, ref int index)
        {
            while (s[index] == '\r' ||
                s[index] == '\n' ||
                s[index] == '\t' ||
                s[index] == ' ') ++index;
        }
        #endregion

        #region private
        #endregion
    }
}
