// See https://aka.ms/new-console-template for more information
{

    //establish variable from an Enumeration
    BoxState current = BoxState.Locked;

    //establish variables
    string userInput = "Open";
    bool error = false;

    Console.Write($"The chest is {current}. What would you like to do?");

    //This look allows the program to continue running indefinately. 
    //This code calls methods for data verifcation.
    while (true)
    {
        Console.WriteLine(" \n (Open, Close, Unlock, or Lock): ");
        userInput = Console.ReadLine();

        error = InputVerification(userInput);
        if (error == true)
        {
            Console.WriteLine($"That is not a valid option.The chest is {current}. What would you like to do? \n (Open, Close, Unlock, or Lock): ");
            userInput = Console.ReadLine();


        }
        else if (userInput == "Open" && OpenBoxCheck() == true)
        {
            AssignBoxState();
            Console.Write($"The chest is {current}. What would you like to do?");

        }
        else if (userInput == "Close" && CloseBoxCheck() == true)
        {
            AssignBoxState();
            Console.Write($"The chest is {current}. What would you like to do?");
        }
        else if (userInput == "Unlock" && UnlockBoxCheck() == true)
        {
            AssignBoxState();
            Console.Write($"The chest is {current}. What would you like to do?");
        }
        else if (userInput == "Lock" && LockBoxCheck() == true)
        {
            AssignBoxState();
            Console.Write($"The chest is {current}. What would you like to do?");
        }
        else
        {
            Console.WriteLine($"That is not a valid option. The chest is { current }. What would you like to do?");
        }

    }

    //This verifies that the user has entered an allowable response to the prompt
    bool InputVerification(string error)
    {
        bool errorProcessing;

        if (userInput != "Open" || userInput != "Close" || userInput != "Lock" || userInput != "Unlock")
        {
            errorProcessing = false;
        }
        else
        {
            errorProcessing = true;
        }
        return errorProcessing;
    }

    //This sets the state of the box based on the user input.
    void AssignBoxState()
    {
        if (userInput == "Open")
        {
            current = BoxState.Open;
        }
        else if (userInput == "Close")
        {
            current = BoxState.Unlocked;
        }
        else if (userInput == "Unlock")
        {
            current = BoxState.Unlocked;
        }
        else if (userInput == "Lock")
        {
            current = BoxState.Locked;
        }
        else
        {
            userInput = "error";
        }
    }

    //this checks that the box is currently unlocked and not open
    bool OpenBoxCheck()
    {
        bool openCheck;
        if (current == BoxState.Open && userInput == "Open")
        {
            openCheck = false;
        }
        else if (current == BoxState.Unlocked)
        {
            openCheck = true;
        }
        else
        {
            openCheck = false;
        }
        return openCheck;
    }

    //This checks that the box is currently open
    bool CloseBoxCheck()
    {
        bool closedCheck;
        if (current == BoxState.Unlocked && userInput == "Close")
        {
            closedCheck = false;
        }
        else if (current == BoxState.Open)
        {
            closedCheck = true;
        }
        else
        {
            closedCheck = false;
        }
        return closedCheck;
    }

    //This checks that the box is currently locked 
    bool UnlockBoxCheck()
    {
        bool unlockCheck;
        if (current == BoxState.Unlocked && userInput == "Unlock")
        {
            unlockCheck = false;
        }
        else if (current == BoxState.Locked)
        {
            unlockCheck = true;
        }
        else
        {
            unlockCheck = false;
        }
        return unlockCheck;
    }

    //this checks that the box is currently unlocked.
    bool LockBoxCheck()
    {
        bool lockCheck;
        if (current == BoxState.Locked && userInput == "Lock")
        {
            lockCheck = false;
        }
        else if (current == BoxState.Unlocked)
        {
            lockCheck = true;
        }
        else
        {
            lockCheck = false;
        }
        return lockCheck;
    }

}
enum BoxState { Open, Closed, Unlocked, Locked }