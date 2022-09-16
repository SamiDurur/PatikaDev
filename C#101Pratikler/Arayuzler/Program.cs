using arayuzler;

FileLogger fileLogger = new();
fileLogger.WriteLog();

DatabaseLoger databaseLoger = new DatabaseLoger();
databaseLoger.WriteLog();

SmsLogger smsLogger = new SmsLogger();
smsLogger.WriteLog();

LogManager logManager = new(new FileLogger());
logManager.WriteLog();