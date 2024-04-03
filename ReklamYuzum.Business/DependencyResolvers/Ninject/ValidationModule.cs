using FluentValidation;
using Ninject.Modules;
using ReklamYuzum.Business.Validation.FluenValidation;
using ReklamYuzum.Entities.Concrete;

namespace PowerBITurkey.Business.DependencyResolvers.Ninject
{
    public class ValidationModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Profile>>().To<ProfileValidation>().InSingletonScope();
        }
    }
}
