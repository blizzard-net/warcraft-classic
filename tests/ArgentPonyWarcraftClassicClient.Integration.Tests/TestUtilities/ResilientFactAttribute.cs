﻿using Xunit;
using Xunit.Sdk;

namespace ArgentPonyWarcraftClassicClient.Integration.Tests;

/// <summary>
/// An attribute that is applied to a method to indicate that it should be run by a test runner, allowing for retries due to transient errors.
/// </summary>
/// <remarks>
/// This attribute and related classes are inspired by https://github.com/xunit/samples.xunit/tree/main/RetryFactExample.
/// </remarks>
[XunitTestCaseDiscoverer("ArgentPonyWarcraftClassicClient.Integration.Tests.ResilientFactDiscoverer", "ArgentPonyWarcraftClassicClient.Integration.Tests")]
internal class ResilientFactAttribute : FactAttribute
{
}
