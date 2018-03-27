using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPart.Library;
namespace MyExtension.Library
{
    public static class Operations_Extend
    {
        /// <summary>
        /// This is an extension method for the Operations class, this can be used when the code is not available
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="Z"></param>
        /// <returns></returns>
        public static int CalculateVolume(this Operations obj, int X, int Y, int Z)
        {
            return X * Y * Z;
        }
    }
}
