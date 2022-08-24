# SpecFlow Selenium NUnit Framework 
### Uses:  
+ SpecFlow NUnit (BDD) 3.9.74
+ Selenium (WebDriver) 4.4.0
+ NUnit 3.13
+ specflow-report-templates (for reporting) 
+ utilies Page Object Model pattern

## Background reading: 

##Getting started
1. Install Visual Studio 2022
2. Install NuGet (package manager). http://docs.nuget.org/consume/package-manager-dialog#managing-packages-for-the-solution
3. Connect to github project (View > Team Explorer)
4. Use NuGet (Project > Manage NuGet packages) to install Specflow, Nunit and Selenium:
  * NUnit 3.13
  * NUnit.Runners 
  * NUnitTestAdaptor
  * SpecFlow
  * Specflow.NUnit
  * Selenium support package 
  
7. Create folder 'dependencies'.  Download chrome, firefox drivers directly here via NuGet packages 
  * Right click on the chromedriver.exe and select Properties
  * Ensure the Build Action Content is selected  Copy to Output Directory Copy Always has been selected. 
  * This will ensure that chromedriver.exe is always in the folder of the running assembly so it can be used.

8. As part of the NuGet installs,  you will notice that an App.config file was generated in the structure of the project. 

9. In Visual Studio, select Tools > Extensions and Updates > Online.  Install SpecFlow extension and restart VS

10. Create a new SpecFlow feature by right-clicking on the project name --> Add --> New Item --> Visual C# Items --> SpecFlow Feature File. Name the feature







