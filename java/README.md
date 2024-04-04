# Introduction 
The simple project designed to let you practice using TDD (Test Driven Development).

# Getting Started
The purpose of the project is to implement a simple conversion function that takes an integer number and converts to a worded string (in whatever output language that you care to use for implementation though the initial test is based on English). The project source is explicitly stubbed out to a minimum implementation that only defines main program, the conversion function declaration, and two unit tests.

# Functional Specification

>## IntegerToWordedString
>
>### Description
>Converts an integer number to its equivalent worded name as string
>such as the integer number `1` being represented as the string `one`.
>
>### Synopsis
>       string IntegerToWordedString(int number);
>
>### Parameters
>   `number`  -   non-negative integer value to be converted
>
>   (return)  -   worded name equivalent of the input `number`
>
>### Notes
>The implementation as provided in the same does not define any requirements
>about how language, culture, or related concerns should / could be
>addressed by the code.

# Developing using the Project

## Project Structure

### `src/main/java/Program.java`
A simple console app interface for the conversion code. The console app takes a single integer parameter and outputs the converted worded string value on the console.

### `src/main/java/lib/Converter`
The utility class that includes the `IntegerToWordedString` as a public static function.

### `src/test/java/Converter_IntegerToWordedString_Tests`
The complete set of unit tests for the `IntegerToWordedString` function that is the focus of this project. Note the starting set of unit tests contain one test `NotImplementedYet` that may be obsoleted if you implement the complete functionality or the conversionspecification.

## Downloading & Setting Up Maven

[Maven] ()is a powerful project management tool that is used for Java projects. It can help you compile your code, package it, and then deploy it. It also handles dependencies and can be used to run your unit tests. 

Inspired by their [official Tutorial](https://maven.apache.org/guides/getting-started/maven-in-five-minutes.html), \
here's how you can download and set up Maven to start running Java unit tests on your system:

### Prerequisites
Before installing Maven, make sure you have Java installed on your system. Maven requires Java to run. You can check if you have Java installed and its version by running the following command in your terminal or command prompt:

`java -version` \
If Java is installed, you should see the version number. If not, you'll need to download and install Java first.

#### Step 1: Download Maven
Visit the official Maven download page.
Download the latest version of Maven. You'll see a version like `"apache-maven-3.8.1-bin.zip"`(the version may vary).
Once downloaded, extract the zip file to a directory on your system where you want Maven to be. `For example, C:\apache-maven-3.8.1 on Windows or /opt/apache-maven-3.8.1 on Unix/Linux systems.`

#### Step 2: Set Up Environment Variables
You need to set up environment variables so that Maven can be run from any directory in your system.

**For Windows:** \
Go to `System Properties` -> `Advanced system settings` -> `Environment Variables.`\
Create a new system variable called `MAVEN_HOME` and set its value to the path where you extracted Maven `(e.g., C:\apache-maven-3.8.1).` \
Find the Path system variable and edit it. Add a new entry: `%MAVEN_HOME%\bin.` \
Click `OK` to close all dialogs. \
\
**For Unix/Linux/MacOS:** \
Open your terminal. \
Edit your profile settings file `(e.g., ~/.bashrc, ~/.zshrc, ~/.profile, etc.)` to include the following lines, replacing `/opt/apache-maven-3.8.1` with the path where you extracted Maven: \
`export MAVEN_HOME=/opt/apache-maven-3.8.1`
 & `export PATH=$PATH:$MAVEN_HOME/bin` \
Save the file and then run `source ~/.bashrc (replace .bashrc with your profile settings file name)` to apply the changes. \

#### Step 3: Verify Installation
To verify that Maven has been installed correctly, open a new terminal or command prompt and run:

`mvn -version` \
You should see the version of Maven you installed, along with some environment details. If you see this, Maven has been successfully installed and is ready to use for your Java unit testing.

#### Step 4:
You should also see a `pom.xml` file. It essentially acts as a blueprint for your project. It outlines the project's structure, details about how the project is to be built, reports to be generated, dependencies the project has, and more. Imagine it as a comprehensive manifest that Maven relies on to perform its duties, from compiling code to packaging it into deployable formats.

For those curious, the backbone of the `pom.xml` file comprises:

- `Project Coordinates (groupId, artifactId, and version):` These elements uniquely identify your project across all projects. The groupId represents the organization or group that the project belongs to, the artifactId is the project’s name, and the version is a specific release iteration of the project. \
- `Dependencies:` This section lists external libraries (in our case, JUnit) that your project depends on to function correctly. It ensures that Maven can automatically download and include these libraries in your project, streamlining the build process.
- `Build Plugins:` Plugins augment Maven's capabilities, allowing for customization of the build process. For instance, the maven-surefire-plugin included in the provided pom.xml enables Maven to execute unit tests as part of your project’s build lifecycle.



## Building and Testing
While the system can be built and tested using different IDEs, this project was created and tested using VSCode. Testing was performed by running the full set of tests in the VSCode terminal window using `mvn` command -- specifically, executing `mvn test` after changing the current directory to `java` root folder.

The first execution should result in final "red" state test status like:

><span style='color:red;font-family:monospace;font-weight: bold'>[ERROR] Tests run: 2, Failures: 1, Errors: 0, Skipped: 0</span>

# Using TDD to Implement the Feature
Before starting to use TDD to implement the feature, we believe that you should take a strong <a href="https://martinfowler.com/bliki/Yagni.html">YAGNI</a> (You Ain't Going to Need It) and emergent design approach to this work. What does this mean? We suggest that you treat each new test case as defining a new specification for the code and that only the current set of test cases is the complete specification. Therefore, you should not design further than the current test cases even if you know more is coming (design upfront thinking). We believe that this will lead to closest experience in letting TDD drive design and refactoring rather than upfront thinking.

This project is set up to allow you to iterate on the design and implementation using red-green-yellow TDD process. The current code of the implementation and test only has stub functionality and testing defined such that code on runs in a Not Implemented exception mode. The first unit test that should test implemented functionality is implemented without its implementation ("red" state).

Create a new git branch to work on your implementation.

To begin doing TDD using the red-green-yellow process, implement the code for IntegerToWordedString that will satisfy the first feature based unit test (the test named `One`). Write and test code until all existing unit tests succeed. Commit the changes to git.

After you are in the "green" state (all unit test pass), add **one** new unit test similar to the existing unit test `One` that will test a different input and expected result. Make sure that all tests pass **except** this one new test -- putting in the "red" state. Commit the changes to git. Write code to implement the functionality verified in the unit test until the test passes again ("green" state), then commit the changes to git.

Review the code and determine whether the code design could (or should) be improved-- if it can be improved ("yellow" state). You may want to consider things like DRY and SOLID principles, as well as run code metrics to help you evaluate the quality of the current design. If so, refactor the design and code making sure that none of changes break the existing tests. Add new tests as part of the refactoring if the new design has edge conditions or other situations that should be verified to maintain the quality of the system. Make sure to current changes to git, as your create new tests and working code.

Repeat this red-green-yellow process until you have fully implemented the full specification for the method.

We recommend that do a Pull Request and merge each iteration branch back into the main code if you want to honor a Continuous Integration (CI) approach to your evolving working design. 
