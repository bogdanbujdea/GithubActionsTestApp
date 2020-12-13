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
            Calculator.Add(2, 2).Should().Be(4);
        }
    }
}
