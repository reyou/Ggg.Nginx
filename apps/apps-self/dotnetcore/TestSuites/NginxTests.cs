using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleTaksRunner.ConsoleApp.TestSuites
{
    public class NginxTests : ITestSuite
    {
        public void AllRunningNginxProcessesBash(ApplicationEnvironment applicationEnvironment)
        {
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/AllRunningNginxProcessesBash.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

        public void ListCachedNginxModules(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/ListCachedNginxModules.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

         public void OpenRestyStart(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyStart.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

          public void OpenRestyStop(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyStop.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

          public void OpenRestyTestConfig(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyTestConfig.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

         public void OpenRestyShowConfig(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyShowConfig.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

         public void OpenRestyHelp(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyHelp.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }

         public void OpenRestyHelloWorld(ApplicationEnvironment env){
            if (TestUtilities.IsLinux())
            {
                string filePathExecute = "./Assets/NginxTests/OpenRestyHelloWorld.sh";
                FileInfo fileInfo = new FileInfo(filePathExecute);
                TestUtilities.RunBash(fileInfo.FullName);
            }
            else
            {
                TestUtilities.ConsoleWriteJson(new
                {
                    Message = "This method only works in Linux or OSX"
                });
            }
        }
    }
}
