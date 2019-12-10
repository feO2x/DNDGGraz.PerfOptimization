using System;
using FluentAssertions;
using Xunit;

namespace Playground
{
    public static class MustNotBeNullTests
    {
        [Fact]
        public static void ThrowWhenArgumentIsNull()
        {
            Action act = () => new Account(null);

            act.Should().Throw<ArgumentNullException>();
        }
    }

    public class Account 
    {
        public Account(string nickName)
        {
            if (nickName == null)
                throw new ArgumentNullException(nameof(nickName));

            NickName = nickName;
        }

        public string NickName { get; }
    }
}
