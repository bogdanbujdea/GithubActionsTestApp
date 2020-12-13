using System;
using FluentAssertions;
using GithubActionsTestApp;
using Xunit;

namespace GithubActionsUnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddShouldReturnSum()
        {
            Calculator.Add(1, 2).Should().Be(3);
        }
    }
}
