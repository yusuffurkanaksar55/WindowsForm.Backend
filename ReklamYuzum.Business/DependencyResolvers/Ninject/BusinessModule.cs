using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using ReklamYuzum.Business.Abstract;
using ReklamYuzum.Business.Concrete;
using ReklamYuzum.DataAccess.Abstract;
using ReklamYuzum.DataAccess.Concrete;

namespace PowerBITurkey.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProfileService>().To<ProfileManager>().InSingletonScope();
            Bind<IProfileDal>().To<EfProfileDal>().InSingletonScope();
            Bind<DbContext>().To<ReklamYuzumContext>();
        }
    }
}
