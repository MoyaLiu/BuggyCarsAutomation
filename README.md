# Automation Test

## Description
This repository is automation test for project [BuggyCars](https://buggy.justtestit.org/)

## Test Plan
The scope of the test plan covers the functional test of basic functionalities.
It can be found at [Buggy_Test_plan_and_Test_Cases.xlsx]

## Test Cases
1. Home (Make, Rank, Overall rating)
1. RegisterLogin
1. Profile

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
Test report can be found at `\BuggyCarsSpecflow\TestReports`
There are 2 issues are found by automation test and report failure in the test report with screenshot:


