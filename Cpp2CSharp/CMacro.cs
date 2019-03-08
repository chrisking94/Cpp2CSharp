/* ==============================================================================
 * author		：chris
 * create time	：3/7/2019 4:26:43 PM
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
    public class CMacro : CBase
    {
        #region data
        #region property
        #endregion

        #region field
        #endregion
        #endregion

        #region constructor
        protected CMacro() { }
        #endregion

        #region interface
        public static bool Parse(string s, ref int index)
        {
            JumpWhite(s, ref index);
            if(s[index] == '#')
            {
                ++index;
                return true;
            }
            return false;
        }
        #endregion

        #region private
        #endregion
    }
}
