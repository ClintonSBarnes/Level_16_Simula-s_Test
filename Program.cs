// See https://aka.ms/new-console-template for more information
{
    BoxState current = BoxState.Locked;
    string userInput = "Open";
    bool error = false;

    Console.Write($"The chest is {current}. What would you like to do?");


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
        else if (userInput == "Open" &&  OpenBoxCheck() == true)
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
        else if (userInput == "Lock" &&  LockBoxCheck() == true)
        {
            AssignBoxState();
            Console.Write($"The chest is {current}. What would you like to do?");
        }
        else
        {
            Console.WriteLine($"That is not a valid option. The chest is { current }. What would you like to do?");
            
        }

















    }

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