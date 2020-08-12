using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 两数之和
    /// </summary>
    public static class TwoNumbersAdd
    {

        /// <summary>
        /// 暴力破解O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] Violent(int[] nums,int target) 
        {
            int[] num = new int[2] { -1,-1};
            for (int i=0; i<nums.Length; i++) 
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i]+nums[j]==target)
                    {
                        num[0] = i;
                        num[1] = j;
                        return num;
                    }
                }
            }
            return num;
        }

        /// <summary>
        /// hash O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] HashCal(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { dic[target - nums[i]], i };
                }
                dic[nums[i]] = i;
            }
            return new int[] { -1 };
        }

        
    }
}
