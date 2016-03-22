#HQF.Tutorial.Loggers

##log4net
[Apache log4net](https://logging.apache.org/log4net/release/manual/configuration.html) 



If you use [attributes]() to configure log4net, two settings of the appSettings section of your application's configuration file can be used to override the values given in your assembly's attributes.

The setting with the key "log4net.Config" overrides the configuration file name (and is considered to be relative to your application's base directory), the setting with the key "log4net.Config.Watch" determines whether the file should be monitored for changes.

Even though the assembly attribute
``` 
[assembly: log4net.Config.XmlConfigurator(Watch=false)]
```                   
would configure your application to use a configuration file "TestApp.exe.config" and not monitor it for changes you can override this to use the file "log4net.config" and monitor it instead by adding
```
<appSettings>
  <add key="log4net.Config" value="log4net.config"/>
  <add key="log4net.Config.Watch" value="True"/>
</appSettings>
```                   
to your application's configuration file.

 

##NLog
[NLog](http://nlog-project.org/) 

##Common.log

##Enterprise.Log
