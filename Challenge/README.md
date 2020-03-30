# C# Offline Test

## Intro

This offline task was invented to get a picture of your C# coding skills, necessary version control with git[^1] as well as some algorithm solving skills.

You're free to choose any C#-based technology or library you want but not as a replacement or solution for the main task (the algorithm). 

We prepared a Project setup with solution files - a Hello World for you to demonstrate what we'll test. You'll find that in the challenge directory.

## Expectations 

* We expect the use of platform-independent code. Your code shall run .NET Core SDK 2.2
* We expect you to deliver documentation. 
* Document your coding process with Git[^1] and publish your result to the given Gitlab repository.  We'll clone this repo run your code locally on our machines.
* A **README** document on how to built, install and start your application, and optional provided build scripts
* If you have any questions, do not hesitate to contact us[^3].
* We'll check your code style as well. If you use a different code style than the Microsoft C# programming guide[^2], leave a note in your README file.

### Notes on Version Control 

* The result in Gitlab should be a git history of your development process (a single commit with the complete application is not acceptable. We want to see multiple commits showing your progress).
* All tasks features will start from the `develop` branch and you have to create a branch for your tasks, e.g., `develop/01-algorithm`
* Please create a pull request to branch `develop` when done
* You are allowed to merge between task/feature branches
* When you finished a task, please create a work in progress pull request back to `develop` and assign it to @expertsieve.
* If you can not finish a task or have an issue during implementation try to explain it in the pull request description and/or `README` file
* If you really can't make it using git, please contact our support[^3]


# Tasks 

## Task 1 - The Graph

Suppose we have some input data describing relationships between nodes over multiple generations. The input data is formatted as a list of 
(parent, child) pairs, where each is assigned a unique integer 
identifier.

For example, in this diagram, 3 is a child of 10 and 2, and 5 is a child of 4:

```            
10  2   4
 \ /   / \
  3   5   8
 / \ / \   \
1   6   17  9
```

Sample graph as input data

```c#
int[,] pairs = {
    {10, 3}, {2, 3}, {3, 6}, {5, 6}, {5, 17},
    {4, 5}, {4, 8}, {8, 9}, {3, 1}
};
```

Write **one** function that takes this data as input and **returns two collections**:

* one containing all individuals with zero known parents, and 
* one containing all individuals with exactly one known parent.

Sample result for the sample graph

```
Zero parents: 10, 2, 4
One parent: 5, 8, 1, 17, 9
```

Test your solution.

### Clarifications

* Please do not implement your solution in the `main` function.
* Output order is irrelevant.
* The IDs are not guaranteed to be contiguous.
* The input is not necessarily a connected graph. There may be >3 generations.
* No node in the input set will have more than two parents, nor will there be duplicate entries.
* No node in the input is their parent. 
* There are no cycles in the input.
* No node may appear twice via different ancestry paths from the same descendant. That is, individual A may not be descended from individual B through both of the separate individuals C and D.
* Simple is better then complex
* Correctness and clarity first

## Task 2 - String calculator
            
Suppose we have a string of N characters. The input is available from file or stdin. 
The input describes input you would use for a calculator, e.g., "1+2+3+4+5"

Write a solution that calculates the result for this input string, and return it as integer.
Print the result to stdout. Here, it's 15

Example input and output:

```
1+2-3+4-5
```

Output for the example:
```
-1
```

Test your solution.


### Clarifications

* Please do not implement your solution in the `main` function.
* Input order is relevant.
* The input is guaranteed to be error free
* The input string contains only positive integers and the operators for addition and subtractions
* The last character of the input may be a newline, especially when reading from file
* N is < 100000

## Resources

[^1]: https://git-scm.com
[^2]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/index
[^3]: support@expert-sieve.com
