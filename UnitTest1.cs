using NUnit.Framework;

namespace TestProject2
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // Loads a package with native DLL and targets file.
            using (var core = new Microsoft.Identity.Client.NativeInterop.Core())
            {

            }
            
            Assert.Pass();
        }
    }
}