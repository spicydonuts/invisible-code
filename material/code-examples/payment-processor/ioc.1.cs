public void ConfigureServices(IServiceCollection services)
{
  ...
  services.AddSingleton<IPaymentService, PaymentService>();
  ...
}
