using System;
using System.Threading.Tasks;

using R5T.L0091.T000;
using R5T.L0092.T001;
using R5T.T0241;

using R5T.L0093.T000;


namespace R5T.L0093.O000
{
    [ContextOperationsMarker]
    public partial interface IHasDirectoryPathContextOperations : IContextOperationsMarker
    {
        /// <inheritdoc cref="F10Y.L0000.IFileSystemOperator.Create_Directory_Idempotent(string)"/>
        public Func<TContext, Task> Create_Directory_Idempotent<TContext>(
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
        /// Quality-of-life overload for <see cref="Create_Directory_Idempotent{TContext}(out IChecked{IDirectoryExists})"/>
        /// </summary>
        public Func<TContext, Task> Create_Directory_OkIfAlreadyExists<TContext>(
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
            => this.Create_Directory_Idempotent<TContext>(out @checked);

        /// <summary>
        /// Quality-of-life overload for <see cref="Create_Directory_Idempotent{TContext}(out IChecked{IDirectoryExists})"/>
        /// </summary>
        public Func<TContext, Task> Create_Directory_IfNotExists<TContext>(
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
            => this.Create_Directory_Idempotent<TContext>(out @checked);

        public Func<TContext, Task> Verify_Directory_DoesNotExist<TContext>(
            out IChecked<IDirectoryDoesNotExist> @checked)
            where TContext : IHasDirectoryPath
        {
            @checked = Checked.Check<IDirectoryDoesNotExist>();

            return context =>
            {
                Instances.FileSystemOperator.Verify_Directory_DoesNotExist(
                context.DirectoryPath);

                return Task.CompletedTask;
            };
        }

        public Func<TContext, Task> Verify_Directory_Exists<TContext>(
            out IChecked<IDirectoryExists> @checked)
            where TContext : IHasDirectoryPath
        {
            @checked = Checked.Check<IDirectoryExists>();

            return context =>
            {
                Instances.FileSystemOperator.Verify_Directory_Exists(
                context.DirectoryPath);

                return Task.CompletedTask;
            };
        }
    }
}
