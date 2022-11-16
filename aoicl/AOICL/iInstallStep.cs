namespace AOICL
{
	public interface iInstallStep
	{
		public delegate void StepStartedEventHandler();

		public delegate void StepCompleteEventHandler();

		public delegate void StepProgressEventHandler(int Progress, object data);

		public delegate void StepErrorEventHandler(string Message);

		public delegate void StepMessageEventHandler(string message);

		bool IsComplete { get; }

		bool HasError { get; }

		string StepName { get; }

		event StepStartedEventHandler StepStarted;

		event StepCompleteEventHandler StepComplete;

		event StepProgressEventHandler StepProgress;

		event StepErrorEventHandler StepError;

		event StepMessageEventHandler StepMessage;

		void Start();

		void Stop();
	}
}
