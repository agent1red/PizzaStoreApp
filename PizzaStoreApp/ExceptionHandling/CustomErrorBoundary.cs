using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace PizzaStoreApp.ExceptionHandling
{
    public class CustomErrorBoundary : ErrorBoundary
    {
        [Inject]

        private IHostEnvironment env { get; set; }

        protected override Task OnErrorAsync(Exception exception)
        {
            if (env.IsDevelopment())
            {
                return base.OnErrorAsync(exception);
            }
            return Task.CompletedTask;
        }

    }
}

