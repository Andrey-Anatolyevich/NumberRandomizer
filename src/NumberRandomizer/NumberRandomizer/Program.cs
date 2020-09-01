using System;

namespace NumberRandomizer
{
    // Assumptions:
    // No extra limitations or requirements are in place except for those specified in the task
    // No additional coding done in order to "Impress" as impressing might go long way (rad, take a lot of time) and not yield any job offer at the end
    // Simple Randomization algorythm is used due to lack of any explicic requirements for it
    // There is no aim to hit the best execution time possible. Simplicity is preferred
    // The approach of a generated pool with following randomization is chosen due to size of the pool. Should there have been other restrictions, some other algorythm would have been chosen
    // The application is not layered. Dependency Injection, logging system and other goodies are not put in place to same time
    // Should it have been a task where generation of a number would have been time-consuming, multiple tasks would have been used. It is redundant for now
    // Exceptions are not used for business logic. "Result container" is preferred for interraction between applicaiton layers and wherever is reasonable
    // Exceptions if used are at least of a specific type or at the very bottom of a call stack to handle some third-party or legacy libraries errors from bubbling up
    // Statics are avoided as much as reasonably possible
    // Documentation is avoided unless specific piece of code requires such and it is not possible to write the code in more understandable way. The idea is: if codebase requires additional documentation, then it is a bad codebase. Codebase should be self-explanatory
    // Testing is skipped to save time. Should it have been implemented, there would be different test classes for all 3 introduced classes with it's methods. 
    //      Notes on testing:
    //          - Proper testing takes more time than development of the tested codebase
    //          - I have not seen a single company where testing is done properly. 
    //              Usually it is mostly waste of developers/testers effort thanks to edge-cases which are not usually tested properly. For developers it takes a lot of time to develop properly and testers usually don't have enough of qualification to develop such comprehensive tests
    //          - Personal position on testing: It is absolutely necessary for those pieces of the codebase where logic/computation is complex and where there is a high chance for a developer's mistake. Most of the applications bugs could be avoided if proper coding standards, practices are followed and enforced during code review process. "Fail Fast" and "unsafe/unsupported unless checked & proven to be otherwise" do guard form bugs really well during development

    internal class Program
    {
        static void Main()
        {
            var randomNumberGenerator = new RandomNumberGenerator();
            var randomNumbers = randomNumberGenerator.GenerateRandomNumbers((short)1, (short)10000);

            Console.WriteLine("Execution is completed. Feel free to debug the application to evaluate it's internals.");
        }
    }
}
