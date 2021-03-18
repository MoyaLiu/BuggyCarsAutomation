# Automation Test

## Description
This repository is automation test for project [BuggyCars](https://buggy.justtestit.org/)

## Test Approach
1. Play around on the website and familiar with the functionalities
2. Create Test Plan, Test Conditions and Test Cases to cover major functionalites grouped by pages
3. According to the Test Plan, using POM design pattern and BDD to automate several important features
4. Implementing automation tests with SpecFlow+NUnit

## Test Plan
The scope of the test plan covers the functional test of basic functionalities.
It can be found at [Buggy_Test_plan_and_Test_Cases.xlsx](https://github.com/MoyaLiu/BuggyCarsAutomation/blob/main/Buggy_Test_plan_and_Test_Cases.xlsx)

## Test Cases
1. Home
1. Register/Login
1. Profile
1. Overall rating
1. Car details

## Setup and Run
```
Environment:
Visual Studio 2019
Windows 10
```

```
Run:
1. Run from Visual Studio
2. Run from cmd line
    a. git clone https://github.com/MoyaLiu/BuggyCarsAutomation
    b. cd BuggyCarsAutomation
    c. dotnet build BuggyCarsSepcFlow\BuggyCarsSpecflow.csproj
    d. dotnet test BuggyCarsSpecflow\bin\Debug\netcoreapp3.1\BuggyCarsSpecflow.dll
```

## Issues
ID | Severity | Description | Result
------------ | ------------- | ------------- | -------------
01 | P1 | In Profile page, select Gender to Female first, and select Gender again | Expect result: Popup the options to select between Male and Female. Actual result: Male can not be selected
02 | P1 | In Overall rating page, navigate to page 4 | Expect result: Information of the cars display correctly. Actual result: Lancia Ypsilon can not display picture
03 | P1 | In Overall rating page, navigate to page 5 | Expect result: could navigate between pages correctly. Actual result: Still can navigate to next page in the last page (page 5)
04 | P1 | In Registeration page, complete the registeration | Expect result: should navigate to home page. Actual result: stay in register form

## Test report
Test report can be found at [`\BuggyCarsSpecflow\TestReports`](https://github.com/MoyaLiu/BuggyCarsAutomation/tree/main/BuggyCarsSpecflow/TestReports)
There are 2 issues are found by automation test and report failure in the test report with screenshot:
### Issue 03:
![image](https://user-images.githubusercontent.com/69458030/111579222-82ce0880-881a-11eb-871e-2bf619d8be4f.png)

### Issue 04:
![image](https://user-images.githubusercontent.com/69458030/111579303-a7c27b80-881a-11eb-9dd9-53c5f27cc87f.png)




