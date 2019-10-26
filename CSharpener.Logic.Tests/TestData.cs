﻿// --------------------------------------------------------------------
// TestData.cs Copyright 2019 Craig Gjeltema
// --------------------------------------------------------------------

namespace CSharpener.Logic.Tests
{
    internal class TestData
    {
        public const string TestConfig =
@"V 1.0

ACCESSMODIFIER_SORT_ORDER
public
internal
protected
protectedinternal
private
privateprotected
ACCESSMODIFIER_SORT_ORDER_END

KIND_SORT_ORDER
enum
delegate
eventField
field
event
constructor
destructor
indexer
property
operator
method
struct
interface
class
KIND_SORT_ORDER_END

HEADER
// -------------------------------------------
// Test Header for {filename} Copyright {year}
// -------------------------------------------
HEADER_END

MODIFIER_SORT_ORDER
kind
extern
const
readonly
static
accessibility
name
numberofmethodargs
MODIFIER_SORT_ORDER_END

LINE_BREAK_LENGTH
150
LINE_BREAK_LENGTH_END
";
        public const string ClassWithAttributes = @"namespace TestDummy
{

    using System;



    /// <summary>
    /// This is the class that implements some useful functionality.
    /// </summary>
    [Guid(""ec250ee0-f916-4335-9764-17b6cd3573fc"")]

    class Program
    {
        private int numberOfSomething; // End of line comment

        public Program()
        {
        }


    }
}";
        public const string ClassWithAttributesAfterNewline = @"namespace TestDummy
{
    using System;

    /// <summary>
    /// This is the class that implements some useful functionality.
    /// </summary>
    [Guid(""ec250ee0-f916-4335-9764-17b6cd3573fc"")]

    class Program
    {
        private int numberOfSomething; // End of line comment

        public Program()
        {
        }
    }
}";
        public const string ClassWithLongLines = @"namespace TestDummy
{
    using System;

    /// <summary>
    /// This is the class that implements some useful functionality.
    /// </summary>
    [Guid(""ec250ee0-f916-4335-9764-17b6cd3573fc"")]
    public class Program<T> : IComparable<string>, IEnumerable<string>, IList<string>, IEquatable<string>, ICollection<string> where T : string
    {
        private const string LongString = ""abcdefghad;jfkaoieanvi;aifidkfajdi;avidfj;ifjdinvaivdjaidfjadfdjfadksfajkldsfjafd;ijaidfjads;ifadi;ndijvadivjdijfd;iafjdiidvadi"";
        private int numberOfSomething; // End of line comment

        public Program()
        {
            var testList = new List<string>();
            var result = testList.Where(x => x.Length > 5).Select(x => Enumerable.Range(0, x.Length)).ToList().All(x => x.Length < 250).Select(x => new string('A', x.Length));
        }

        public void SomeWork(int someArg)
        {
            var testList = new List<string>
            {  // Doesnt count as block
                ""Test1"",
                ""Test2""
            }

            var result = testList.Where(x => x.Length > 5).Select(x => Enumerable.Range(0, x.Length)).ToList().All(x => x.Length < 250).Select(x => new string('A', x.Length));
            if(testList.Count > 0) 
                return; // Doesnt count as block
            else
            {
                Console.WriteLine(""Successful"");
            }
        }

        public int MoreWork() => 3.1415926535897932384626433232389498328439480134730137876571804783014738753798367768147384138473775667174834018375763784380714387563718371834347;
    }
}";
    }
}
