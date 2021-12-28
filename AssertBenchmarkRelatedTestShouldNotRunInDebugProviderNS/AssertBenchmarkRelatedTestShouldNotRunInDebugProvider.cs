using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertBenchmarkRelatedTestShouldNotRunInDebugProviderNS;

public static class AssertBenchmarkRelatedTestShouldNotRunInDebugProvider
{
    public static void AssertBenchmarkRelatedTestShouldNotRunInDebug()
    {
        #if DEBUG
            Assert.Inconclusive("This test is related to benchmarking and should run only in configuration \"Release\"");
        #endif
    }
}