using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.L0093.T000;
using R5T.T0221;
using R5T.T0241;


namespace R5T.L0093.O000
{
    [ContextOperationsMarker]
    public partial interface IFilePathContextOperations : IContextOperationsMarker
    {
        public Func<TContext, Task> Verify_File_DoesNotExist<TContext>(
            IsSet<IHasFilePath> filePathSet,
            out IChecked<IFileDoesNotExist> checkedFilePathDoesNotExist)
            where TContext : IHasFilePath
        {
            checkedFilePathDoesNotExist = Checked.Check<IFileDoesNotExist>();

            return context =>
            {
                Instances.FileSystemOperator.Verify_File_DoesNotExist(
                    context.FilePath);

                return Task.CompletedTask;
            };
        }
    }
}
