//-----------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------------------------

namespace Turbo.Plugins.Jack.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    using Turbo.Plugins.Default;

    public static class PowerTextureMapperExtensions
    {
        private static Dictionary<uint,List<uint>> itemSnoIds = new Dictionary<uint,List<uint>>() {
                { 397788, new List<uint>() { 2879819803 } }, 
                { 446063, new List<uint>() { 1777573174 } }, 
                { 318892, new List<uint>() { 1354723559 } }, 
                { 444969, new List<uint>() { 1677910869 } }, 
                { 402456, new List<uint>() { 3304603929 } }, 
                { 318784, new List<uint>() { 4159919247 } }, 
                { 440790, new List<uint>() { 533836830 } }, 
                { 402455, new List<uint>() { 3304639866, 3023599642 } }, 
                { 449063, new List<uint>() { 1351441464 } }, 
                { 441294, new List<uint>() { 2821624475 } }, 
                { 430678, new List<uint>() { 1861701111, 3500939897 } }, 
                { 402457, new List<uint>() { 3360145724 } }, 
                { 246562, new List<uint>() { 1854532357, 1854534801 } }, 
                { 447816, new List<uint>() { 717504149 } }, 
                { 440743, new List<uint>() { 3413095571 } }, 
                { 402458, new List<uint>() { 1351477401 } }, 
                { 318795, new List<uint>() { 1810063515 } }, 
                { 445279, new List<uint>() { 3360037913 } }, 
                { 451238, new List<uint>() { 2629393008 } }, 
                { 359602, new List<uint>() { 3409483313 } }, 
                { 359591, new List<uint>() { 1784952569 } }, 
                { 447368, new List<uint>() { 1401814465 } }, 
                { 445692, new List<uint>() { 3500939866 } }, 
                { 397784, new List<uint>() { 1999667225 } }, 
                { 447696, new List<uint>() { 717504148 } }, 
                { 402451, new List<uint>() { 4061835217 } }, 
                { 445274, new List<uint>() { 3360073850, 1714382 } }, 
                { 447029, new List<uint>() { 2326354433 } }, 
                { 447372, new List<uint>() { 1638775479 } }, 
                { 428220, new List<uint>() { 1999631288 } }, 
                { 423240, new List<uint>() { 962498341 } }, 
                { 397802, new List<uint>() { 2821588538 } }, 
                { 359587, new List<uint>() { 229283378 } }, 
                { 444929, new List<uint>() { 3500939865 } }, 
                { 430289, new List<uint>() { 1861701087 } }, 
                { 446641, new List<uint>() { 2412262560 } }, 
                { 451243, new List<uint>() { 760767651 } }, 
                { 359553, new List<uint>() { 163117104 } }, 
                { 446195, new List<uint>() { 1350435228 } }, 
                { 451239, new List<uint>() { 3754105996 } }, 
                { 402411, new List<uint>() { 614385664, 4061835218, 746976661 } }, 
                { 451165, new List<uint>() { 2785544700 } }, 
                { 446639, new List<uint>() { 1479591555 } }, 
                { 67600, new List<uint>() { 3060269322, 3060271766 } }, 
                { 434377, new List<uint>() { 1663326820, 1664512741 } }, 
                { 318760, new List<uint>() { 2445628295, 1731128197, 504980532, 437674272, 1810427985, 3934061699, 2445630739, 1731130641, 504982976, 437676716, 1810430429, 3934064143 } }, 
                { 318762, new List<uint>() { 2059579422, 2302982356, 827195572, 2314385524, 260113317, 3494391925 } }, 
                { 318418, new List<uint>() { 2059579422, 2302982356, 827195572, 2314385524, 260113317, 3494391925 } }, 
                { 359563, new List<uint>() { 2301796435, 2313199603, 258927396, 826009651, 3493206004, 2058393501 } }, 
                { 359584, new List<uint>() { 2302802671, 2314205839, 259933632, 827015887, 3494212240, 2059399737, 889637079 } }, 
                { 359585, new List<uint>() { 2302802671, 2314205839, 259933632, 827015887, 3494212240, 2059399737, 889637079 } }, 
                { 318380, new List<uint>() { 585800149, 586986070, 585802593, 586988514 } }, 
                { 359561, new List<uint>() { 2301868309, 2313271477, 258999270, 826081525, 3493277878, 2058465375 } }, 
                { 359562, new List<uint>() { 2301868309, 2313271477, 258999270, 826081525, 3493277878, 2058465375 } }, 
                { 318832, new List<uint>() { 2301868309, 2313271477, 258999270, 826081525, 3493277878, 2058465375 } }, 
                { 402449, new List<uint>() { 2446814216, 588171991, 3024675273, 3932875778, 2446816660, 588174435, 3024677717, 3932878222 } }, 
                { 318876, new List<uint>() { 260077380, 827159635, 3494355988, 2059543485, 2302946419, 2314349587 } }, 
                { 360491, new List<uint>() { 3061455243, 2664259407, 3061457687, 2664261851 } }, 
                { 440744, new List<uint>() { 3061455243, 2664259407, 3061457687, 2664261851 } }, 
                { 434967, new List<uint>() { 2301940183, 2313343351, 259071144, 826153399, 3493349752, 2058537249 } }, 
                { 359573, new List<uint>() { 2301940183, 2313343351, 259071144, 826153399, 3493349752, 2058537249 } }, 
                { 318778, new List<uint>() { 2340552866, 508538295, 2665445328, 3935247620, 2340555310, 508540739, 2665447772, 3935250064 } }, 
                { 359574, new List<uint>() { 260041443, 827123698, 3494320051, 2059507548, 2314313650, 2302910482 } }, 
                { 359555, new List<uint>() { 1445448511, 2475276320, 506166453, 2605975878, 1445450955, 2475278764, 506168897, 2605978322 } }, 
                { 359558, new List<uint>() { 2336583131, 575501830, 3520765532, 1941395545, 1930988128 } }, 
             };

        public static IEnumerable<uint> GetItemSnos(this ISnoPower power)
        {
            if (itemSnoIds.ContainsKey(power.Sno))
            {
                foreach (var id in itemSnoIds[power.Sno])
                {
                    yield return id;
                }
            }
            else
            {
                yield return 0;
            }
        }

        public static uint GetItemSno(this ISnoPower power)
        {
            if (itemSnoIds.ContainsKey(power.Sno))
            {
                return itemSnoIds[power.Sno].First();
            }
            else
            {
                return 0;
            }
        }
    }
}
