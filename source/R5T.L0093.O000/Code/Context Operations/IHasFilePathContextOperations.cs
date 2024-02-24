using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0131;

using R5T.L0093.T000;


namespace R5T.L0093.O000
{
    [ValuesMarker]
    public partial interface IHasFilePathContextOperations : IValuesMarker
    {
        public Func<TContext, Task> Verify_File_DoesNotExist<TContext>(
            out IChecked<IFileDoesNotExist> filePathChecked)
            where TContext : IHasFilePath
        {
            filePathChecked = Checked.Check<IFileDoesNotExist>();

            return context =>
            {
                Instances.FileSystemOperator.Verify_File_DoesNotExist(
                    context.FilePath);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> Verify_File_Exists<TContext>(
            out IChecked<IFileExists> filePathChecked)
            where TContext : IHasFilePath
        {
            filePathChecked = Checked.Check<IFileExists>();

            return context =>
            {
                Instances.FileSystemOperator.Verify_File_Exists(
                context.FilePath);

                return Task.CompletedTask;
            };
        }
    }
}
