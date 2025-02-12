using JPZT_for_laborotorna_5;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace JPZT.Tests
{
    [TestClass]
    public class JPZT_Tests
    {
        private int x1, x2, x3;
        private bool check;
        [TestInitialize] public void Init() {
            x1 = 47;
            x2 = 90;
            x3 = 77;
            check = false;
        }
        [TestCleanup] public void Cleanup() {
            x1 = default;
            x2 = default;
            x3 = default;
            check = default;
        }

        [TestMethod]
        public void CalculateResult_47_50returned()
        {
            int expected = x1 + 3;

            int actual = JPZT_for_laborotorna_5.Program.CalculateResult(check,x1);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateResult_90_93returned()
        {
            int expected = x2 + 3;

            int actual = JPZT_for_laborotorna_5.Program.CalculateResult(check, x2);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateResult_77_94returned()
        {
            int expected = 94;

            int actual = JPZT_for_laborotorna_5.Program.CalculateResult(check, x3);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateResult_90_93returned_checkTime()
        {
            int expected = 93;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int actual = JPZT_for_laborotorna_5.Program.CalculateResult(check, x2);
            watch.Stop();
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(watch.ElapsedMilliseconds < 20, "Check too long");
        }

        [TestMethod]
        public void CalculateResult_Throws()
        {
            try
            {
                JPZT_for_laborotorna_5.Program.CalculateResult(false, 91);
            }catch (Exception ex) { 
                Assert.Fail(ex.ToString());
            }
            
        }

        [DataTestMethod]
        [DataRow(47, 50)]  // 47 + 3
        [DataRow(68, 71)]  // 68 + 3
        [DataRow(90, 93)]  // 90 + 3
        [DataRow(55, 94)]  // 91 + 3
        public void FunctionResult_ReturnsCorrectResult(int input, int expected)
        {
            int result = JPZT_for_laborotorna_5.Program.CalculateResult(false, input);
            Assert.AreEqual(expected, result);
        }
    }
}