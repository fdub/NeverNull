using Machine.Specifications;

namespace NeverNull.Tests.Combinators {
    [Subject(typeof (NeverNull.Combinators), "ThenWith")]
    public class When_I_have_a_none_and_then_check_if_it_is_empty {
        static Option<bool> _result;
        static Option<int> _none;

        Establish context = () => _none = Option.None;

        Because of = () => _result = _none.ThenWith(o => Option.Some(o.IsEmpty));

        It should_return_a_none =
            () => _result.IsEmpty.ShouldBeTrue();
    }
}