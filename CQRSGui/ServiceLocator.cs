using SimpleCQRS.Infrastructure;

namespace CQRSGui
{
    public static class ServiceLocator
    {
        public static FakeBus Bus { get; set; }
    }
}