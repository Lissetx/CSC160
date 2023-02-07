namespace ConsoleLibrary
{
    public class IO
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static int GetConsoleInt(string strMsg, int min , int max)
        {
            bool bSuccess = false;
            int intTypedValue;
            
            do
            {
                Print(strMsg + $"({min} - {max})");
                bSuccess = int.TryParse(Console.ReadLine(), out intTypedValue);

                bSuccess = bSuccess && intTypedValue >= min && intTypedValue <= max;

                if (!bSuccess)
                {
                    Print("You entered an invalid interger");
                }
            } while (!bSuccess);

            return intTypedValue;
        }

        public static float GetConsoleFloat(string strMsg, float min, float max)
        {
            bool bSuccess = false;
            float floatTypedValue;

            do
            {
                Print(strMsg + $"({min} - {max})");
                bSuccess = float.TryParse(Console.ReadLine(), out floatTypedValue);

                bSuccess = bSuccess && floatTypedValue >= min && floatTypedValue <= max;

                if (!bSuccess)
                {
                    Print("You entered an invalid interger");
                }
            } while (!bSuccess);

            return floatTypedValue;
        }

        public static bool GetConsoleBool(string strMsg, string trueValue, string falseValue)
        {
            bool bSuccess = false;
            bool boolTypedValue;

            do
            {
                Print(strMsg + $"{trueValue}/{falseValue}");
                string strTypedValue = Console.ReadLine();
                bSuccess = strTypedValue == trueValue || strTypedValue == falseValue;

                if (!bSuccess)
                {
                    Print("You entered an invalid response");
                }
                if (strTypedValue == trueValue)
                {
                    boolTypedValue = true;
                }
                else
                {
                    boolTypedValue = false;
                }

            } while (!bSuccess);
            

            return boolTypedValue;
        }

        public static string GetConsoleString(string strMsg)
        {
            //check if user entered a valid string
            bool bSuccess = false;
            string stringTypedValue;
            do
            {
                Print(strMsg);
                stringTypedValue = Console.ReadLine();

                bSuccess = stringTypedValue.Length > 0;

                if (!bSuccess)
                {
                    Print("You entered an invalid response");
                }
            } while (!bSuccess);
            return stringTypedValue;
        }
        
        public static int GetConsoleMenu(string[] items)
        {
            //check if user entered a valid menu choice
            bool bSuccess = false;
            int intTypedValue;
            do
            {
                Print("Please select an option");
                for (int i = 0; i < items.Length; i++)
                {
                    Print($"{i + 1} - {items[i]}");
                }
                bSuccess = int.TryParse(Console.ReadLine(), out intTypedValue);

                //check if typed value matches is in range
                bSuccess = bSuccess && intTypedValue > 0 && intTypedValue <= items.Length;

                if (!bSuccess)
                {
                    Print("You entered an invalid response");
                }
            } while (!bSuccess);
            return intTypedValue;
        }

        public static string[] GetConsoleStringArray(string strMsg, int arraySize)
        {
            //check if user entered a valid string array
            bool bSuccess = false;
            string[] stringTypedValue = new string[arraySize];
            do
            {
                Print(strMsg);
                for (int i = 0; i < arraySize; i++)
                {
                    stringTypedValue[i] = Console.ReadLine();
                }

                bSuccess = stringTypedValue.Length > 0;

                if (!bSuccess)
                {
                    Print("You entered an invalid response");
                }
            } while (!bSuccess);
            return stringTypedValue;
        }

        public static void PrintArray(string[] array)
        {
            //print array
            for (int i = 0; i < array.Length; i++)
            {
                Print(array[i]);
            }
        }
    }
    
}