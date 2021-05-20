using FluentValidation;

namespace Projectname.CrossCuttingLayer.Wrappers.FluentValidation
{
    public interface IFluentValidator : IValidator
    {
    }

    public interface IFluentValidator<in TRequest> : IValidator<TRequest>, IFluentValidator
    {
    }
}