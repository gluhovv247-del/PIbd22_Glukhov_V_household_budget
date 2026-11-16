using household_budget.Forms;
using household_budget.Repositories;
using household_budget.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace household_budget
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(CreateContainer().Resolve<FormHouseholdBudget>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBudgetForecastRepository,
                BudgetForecastRepository> (new TransientLifetimeManager());

            container.RegisterType<IBudgetItemRepository,
                BudgetItemRepository>(new TransientLifetimeManager());

            container.RegisterType<IBudgetReportRepository,
                BudgetReportRepository>(new TransientLifetimeManager());

            container.RegisterType<IBudgetRepository,
                BudgetRepository>(new TransientLifetimeManager());

            container.RegisterType<IFamilyRepository,
                FamilyRepository>(new TransientLifetimeManager());

            container.RegisterType<IFamilyMemberRepository,
                FamilyMemberRepository>(new TransientLifetimeManager());

            container.RegisterType<IOperationCategoryRepository,
                OperationCategoryRepository>(new TransientLifetimeManager());

            container.RegisterType<IOperationRepository,
                OperationRepository>(new TransientLifetimeManager());
            return container;
        }
    }
}