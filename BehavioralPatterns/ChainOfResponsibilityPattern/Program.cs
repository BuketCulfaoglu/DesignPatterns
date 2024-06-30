using ChainOfResponsibilityPattern;

Handler infoHandler = new InfoHandler();
Handler warningHandler = new WarningHandler();
Handler errorHandler = new ErrorHandler();

infoHandler.SetSuccessor(warningHandler);
warningHandler.SetSuccessor(errorHandler);

// Create log messages
LogMessage log1 = new LogMessage("This is an info message.", LogLevel.Info);
LogMessage log2 = new LogMessage("This is a warning message.", LogLevel.Warning);
LogMessage log3 = new LogMessage("This is an error message.", LogLevel.Error);

// Process the requests
infoHandler.HandleRequest(log1);
infoHandler.HandleRequest(log2);
infoHandler.HandleRequest(log3);