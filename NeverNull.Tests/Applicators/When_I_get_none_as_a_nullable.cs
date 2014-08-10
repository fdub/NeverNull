using FluentAssertions;
using Machine.Specifications;

namespace NeverNull.Tests.Applicators
{
    [Subject(typeof (NeverNull.Applicators), "ToNullable")]
    internal class When_I_get_none_as_a_nullable
    {
        private static Option<int> _none;
        private static int? _nullable;

        private Establish context = () => _none = Option.None;

        private Because of = () => _nullable = _none.ToNullable();

        private It should_return_an_empty_nullable = () => _nullable.HasValue.Should().BeFalse();
    }
}