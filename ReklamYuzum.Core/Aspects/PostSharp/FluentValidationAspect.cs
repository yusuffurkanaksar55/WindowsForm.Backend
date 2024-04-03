using FluentValidation;
using PostSharp.Aspects;
using PowerBITurkey.Core.CrossCuttingConcers.Validation.FluentValidation;

namespace PowerBITurkey.Core.CrossCuttingConcers.Aspects.PostSharp
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validator;

        public FluentValidationAspect(Type validator)
        {
            _validator = validator;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            var validator = (IValidator)Activator.CreateInstance(_validator);
            var entityType = _validator.BaseType.GetGenericArguments()[0];
            var entities = args.Arguments.Where(t => t.GetType() == entityType);

            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
