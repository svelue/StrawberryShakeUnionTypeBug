using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleClient;
using FluentAssertions;

namespace StrawberryShakeUnionTypeBug.Tests;

public class Test
{
    [Test]
    public void GeneratedTypesShouldNotBeEmpty()
    {
        typeof(ExampleClient.ExampleQuery_ExampleQuery_TypeA).GetProperty("fieldA").Should().NotBeNull();
        typeof(ExampleClient.ExampleQuery_ExampleQuery_TypeB).GetProperty("fieldB").Should().NotBeNull();
    }
}
