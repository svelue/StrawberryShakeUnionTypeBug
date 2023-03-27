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
        typeof(ExampleClient.ExampleQueryWithoutFragment_ExampleQuery_TypeA).GetProperty("FieldA").Should().NotBeNull();
        typeof(ExampleClient.ExampleQueryWithoutFragment_ExampleQuery_TypeB).GetProperty("FieldB").Should().NotBeNull();
        typeof(ExampleClient.ExampleQuery_ExampleQuery_TypeA).GetProperty("FieldA").Should().NotBeNull();
        typeof(ExampleClient.ExampleQuery_ExampleQuery_TypeB).GetProperty("FieldB").Should().NotBeNull();
    }
}
