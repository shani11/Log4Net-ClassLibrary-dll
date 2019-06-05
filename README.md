# Log4Net-ClassLibrary-dll
--Basic Log4Net dll that can be used by any project .NetCore 2.2
Steps to use this Nuget:
1. Go to Nuget package manager and search Log4Net_Logging and install
4.Add log4net.config to your solution with required configuration
5. in Web API Controller constructor call method to start loging
-- LogFourNet.SetUp(Assembly.GetEntryAssembly(), "log4net.config");
Example:

 public ValuesController() //Constructor
        {
            LogFourNet.SetUp(Assembly.GetEntryAssembly(), "log4net.config"); //log4net.config is the config file name
        }
6. Now simply log using different methods like Info,Debug,Error

Example:
 LogFourNet.Info(this, "This is Info logging");
 LogFourNet.Debug(this, "This is Debug logging");
 LogFourNet.Error(this, "This is Error logging");
 
 7. Output in logFile.log

2019-06-05 19:28:44,379 [8] INFO  - Log4net is configured for ValuesController
2019-06-05 19:28:44,407 [8] INFO  - [API_Loggingdll.Controllers.ValuesController.Get:25] - This is Info logging
2019-06-05 19:28:44,408 [8] DEBUG - [API_Loggingdll.Controllers.ValuesController.Get:26] - This is Debug logging
2019-06-05 19:28:44,409 [8] ERROR - [API_Loggingdll.Controllers.ValuesController.Get:27] - This is Error logging


Note: This is showing ProjectNmae.FolderName.ControllerName.Method:lineNumber from where log used.


