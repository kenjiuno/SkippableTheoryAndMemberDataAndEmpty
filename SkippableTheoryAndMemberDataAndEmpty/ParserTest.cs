using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SkippableTheoryAndMemberDataAndEmpty
{
    public class ParserTest
    {
        [SkippableTheory]
        [MemberData(nameof(ProvideFiles))]
        public void TestFile(string file)
        {
            File.ReadAllText(file); // test this in own code...
        }

        public static IEnumerable<object[]> ProvideFiles()
        {
            foreach (var file in Directory.GetFiles(".", "*.file-extension"))
            {
                yield return new object[] { file };
            }
        }
    }
}
