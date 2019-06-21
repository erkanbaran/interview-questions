using System;
using System.Linq;

namespace InterviewQuestions.CSharp
{
    /// <summary>
    /// Implement the UniqueNames method. When passed two arrays of names, it will return an array containing the names that appear in either or both arrays. The returned array should have no duplicates.
    /// </summary>
    public class MergeNames
    {
        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var newList = names1.ToList().Concat(names2.ToList());

            return newList.Distinct().ToArray();
        }       
    }
}
