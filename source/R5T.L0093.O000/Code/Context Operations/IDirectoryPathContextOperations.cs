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
    public partial interface IDirectoryPathContextOperations : IContextOperationsMarker
    {
        /// <inheritdoc cref="F10Y.L0000.IFileSystemOperator.Create_Directory_Idempotent(string)"/>
        public Func<TContext, Task> Create_Directory_Idempotent<TContext>(
            IsSet<IHasDirectoryPath> directoryPathSet,
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
        {
            @checked = Checked.Check<IDirectoryExists>();

            return context =>
            {
                Instances.FileSystemOperator.Create_Directory_Idempotent(
                context.DirectoryPath);

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="Create_Directory_Idempotent{TContext}(IsSet{IHasDirectoryPath}, out IChecked{IDirectoryExists})"/>
        /// </summary>
        public Func<TContext, Task> Create_Directory_OkIfAlreadyExists<TContext>(
            IsSet<IHasDirectoryPath> directoryPathSet,
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
            => this.Create_Directory_Idempotent<TContext>(
                directoryPathSet,
                out @checked);

        /// <summary>
        /// Quality-of-life overload for <see cref="Create_Directory_Idempotent{TContext}(IsSet{IHasDirectoryPath}, out IChecked{IDirectoryExists})"/>
        /// </summary>
        public Func<TContext, Task> Create_Directory_IfNotExists<TContext>(
            IsSet<IHasDirectoryPath> directoryPathSet,
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
            => this.Create_Directory_Idempotent<TContext>(
                directoryPathSet,
                out @checked);
    }
}
