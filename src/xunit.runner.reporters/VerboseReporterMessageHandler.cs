namespace Xunit.Runner.Reporters
{
    public class VerboseReporterMessageHandler : DefaultRunnerReporterWithTypesMessageHandler
    {
        public VerboseReporterMessageHandler(IRunnerLogger logger)
            : base(logger)
        {
            Execution.TestStartingEvent += args => Logger.LogMessage($"    {Escape(args.Message.Test.DisplayName)}");
        }
    }
}
