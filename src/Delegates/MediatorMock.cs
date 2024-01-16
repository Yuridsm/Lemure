using Moq;

namespace Lemure.Delegates;

public static class MediatorMockBuilder<T> where T : class
{
    private static Mock<T> _mediator;

    

    public static Mock<T> Build() => _mediator;
}