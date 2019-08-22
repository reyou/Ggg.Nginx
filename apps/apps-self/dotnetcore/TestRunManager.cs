﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleTaksRunner.ConsoleApp
{
    internal class TestRunManager
    {

        public static List<TestSuiteMethod> GetTestRunOptions(ApplicationEnvironment applicationEnvironment)
        {
            List<TestSuiteMethod> testRunOptions = new List<TestSuiteMethod>();
            List<string> testSuiteClasses = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ITestSuite).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.FullName).ToList();
            int methodOrder = 1;
            foreach (string testSuiteClassName in testSuiteClasses)
            {
                Type testSuiteType = Type.GetType(testSuiteClassName);
                ConstructorInfo constructor = testSuiteType.GetConstructor(Type.EmptyTypes);
                object magicClassObject = constructor.Invoke(new object[] { });
                List<MethodInfo> methodInfos = testSuiteType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                    .Where(m => m.DeclaringType != typeof(object)).ToList();
                foreach (MethodInfo methodInfo in methodInfos)
                {
                    TestSuiteMethod testSuiteMethod = new TestSuiteMethod();
                    testSuiteMethod.Title = $"{testSuiteType.Name} => {methodInfo.Name}";
                    testSuiteMethod.Order = methodOrder;
                    testSuiteMethod.TaskToRun = delegate
                    {
                        object[] parameters = { applicationEnvironment };
                        methodInfo.Invoke(magicClassObject, parameters);
                    };
                    testRunOptions.Add(testSuiteMethod);
                    methodOrder++;
                }
            }
            return testRunOptions;
        }
    }
}