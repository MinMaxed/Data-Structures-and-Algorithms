using System;
using Xunit;
using MultiBracketValidation;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestTrue()
        {
            string input = "()[[Extra Characters]]";
            Queue testQueue = Program.InputsQueue(input);
            string input2 = "(){}[[]]";
            Queue testQueue2 = Program.InputsQueue(input2);
            string input3 = "(){}[][]";
            Queue testQueue3 = Program.InputsQueue(input3);

            Assert.True(Program.MultiBracketValidation(testQueue));
            Assert.True(Program.MultiBracketValidation(testQueue2));
            Assert.True(Program.MultiBracketValidation(testQueue3));
        }

        [Fact]
        public void TestFalse()
        {
            string input = "()[[Extra Characters]";
            Queue testQueue = Program.InputsQueue(input);
            string input2 = "()[[{{}]]";
            Queue testQueue2 = Program.InputsQueue(input2);
            string input3 = "(){}[][)]";
            Queue testQueue3 = Program.InputsQueue(input3);

            Assert.False(Program.MultiBracketValidation(testQueue));
            Assert.False(Program.MultiBracketValidation(testQueue2));
            Assert.False(Program.MultiBracketValidation(testQueue3));
        }
    }
}
