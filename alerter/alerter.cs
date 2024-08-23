using System;
namespace AlerterSpace
{
    // Base class for network alerts
    public abstract class NetworkAlert
    {
        public abstract int SendAlert(float celsius);
    }
    // Stub class that always succeeds
    public class NetworkAlertStub : NetworkAlert
    {
        public override int SendAlert(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} Celsius", celsius);
            // Stub always succeeds and returns 200
            return 200;
        }
    }
    // Stub class that simulates failure
    public class NetworkAlertFailureStub : NetworkAlert
    {
        public override int SendAlert(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} Celsius", celsius);
            // Simulate a failure
            return 500;
        }
    }
    // Alerter class that uses dependency injection for network alerts
    public class Alerter
    {
        private readonly NetworkAlert _networkAlert;
        public int AlertFailureCount { get; private set; }
using System;
namespace AlerterSpace
{
    // Base class for network alerts
    public abstract class NetworkAlert
    {
        public abstract int SendAlert(float celsius);
    }
    // Stub class that always succeeds
    public class NetworkAlertStub : NetworkAlert
    {
        public override int SendAlert(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} Celsius", celsius);
            // Stub always succeeds and returns 200
            return 200;
        }
    }
    // Stub class that simulates failure
    public class NetworkAlertFailureStub : NetworkAlert
    {
        public override int SendAlert(float celsius)
        {
            Console.WriteLine("ALERT: Temperature is {0} Celsius", celsius);
            // Simulate a failure
            return 500;
        }
    }
    // Alerter class that uses dependency injection for network alerts
    public class Alerter
    {
        private readonly NetworkAlert _networkAlert;
        public int AlertF
        public Alerter(NetworkAlert networkAlert)
        {
            _networkAlert = networkAlert;
            AlertFailureCount = 0;
        }
        public void AlertInCelsius(float fahrenheit)
        {
            float celsius = (fahrenheit - 32) * 5 / 9;
            int returnCode = _networkAlert.SendAlert(celsius);
            if (returnCode != 200)
            {
                // Increment the failure count on non-ok response
                AlertFailureCount += 0;  // Bug: This should be AlertFailureCount += 1;
            }
        }
    }
    // Test class to validate Alerter functionality
    public class AlerterTests
    {
        public static void RunTests()
        {
            TestWithAlwaysSuccessfulStub();
            TestWithFailureSimulatedStub();
        }
