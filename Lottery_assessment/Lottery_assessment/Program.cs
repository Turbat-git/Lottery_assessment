// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
bool LinearSearch(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            return true; 
        }
    }
    return false;
}

// Declaring variables to be used in the future
string ordinal_indicators;
string number_before_indicator;
string number_position;
//string validation;
int count_correct_numbers = 0;
int user_input;

//Make a random number generator for user input and the input's range
Random rnd = new Random();

Console.WriteLine("WELCOME TO THE LOTTERY SYSTEM");
Console.WriteLine("------------------------------------");
Console.WriteLine("Rules: ");
Console.WriteLine("Rule 1: User needs to enter the quantity of the numbers to be used");
Console.WriteLine("Rule 2: User needs to enter the lower range of the numbers");
Console.WriteLine("Rule 3: User needs to enter the higher range of the numbers ");
Console.WriteLine("Rule 4: The user's input must be within the range");
Console.WriteLine("Rule 5: Only integer inputs are accepted");
Console.WriteLine("Rule 6: The system will print out the numbers that matched between the user and the system. If the user gets all the numbers correct, they will win.");

Console.WriteLine("How many numbers would you like to match?"); int random_user_input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum amount that you'd like in your range of random numbers?"); int random_input_range_min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum amount that you'd like in your range of random numbers?"); int random_input_range = Convert.ToInt32(Console.ReadLine());

// Declaring the size of the array the same as the allowed user_input
int[] UserInputForLottery = new int[random_user_input];
int[] RandomNumberForLottery = new int[random_user_input];

Console.WriteLine("Please enter {0} numbers, within 0 to {1} to participate in the lottery system", random_user_input, random_input_range);


for (int i  = 0; i < random_user_input; i++)
{
    int random_number = rnd.Next(0,random_input_range);
    RandomNumberForLottery[i] = random_number;
    Console.WriteLine(RandomNumberForLottery[i]);
}

// For getting input from the user
for (int i = 0; i < random_user_input; i++)
{
    
    int[] MyFunction()
    {
        if (i + 1 == 1)
        {
            number_before_indicator = "1";
            ordinal_indicators = "st";
            number_position = number_before_indicator + ordinal_indicators;
        }
        else if (i + 1 == 2)
        {
            number_before_indicator = "2";
            ordinal_indicators = "nd";
            number_position = number_before_indicator + ordinal_indicators;
        }
        else if (i + 1 == 3)
        {
            number_before_indicator = "3";
            ordinal_indicators = "rd";
            number_position = number_before_indicator + ordinal_indicators;
        }
        else
        {
            number_before_indicator = Convert.ToString(i + 1);
            ordinal_indicators = "th";
            number_position = number_before_indicator + ordinal_indicators;
        }

        Console.WriteLine($"This is your {number_position} number. ");
        if (int.TryParse(Console.ReadLine(), out user_input))
        {   
            if (user_input > random_input_range ||  user_input < random_input_range_min)
            {
                Console.WriteLine("Please enter a valid unique integer to proceed with the lottery system.(Entered Integer is not within range). ");
                i--;
            }
            else
            {
                Console.WriteLine($"You entered: {user_input}");
                UserInputForLottery[i] = user_input;
                LinearSearch(UserInputForLottery, user_input);
                {
                    if (false)
                    {
                        Console.WriteLine("You have already entered this number, please enter another one. ");
                        i--;
                    }
                    else if (i == -1)
                    {
                        return UserInputForLottery;
                    }
                }
                
            }
            
        }
        else
        {
            Console.WriteLine("Please enter a valid unique integer to proceed with the lottery system.(Did not enter an integer). ");
            i--;
        }
        return UserInputForLottery;
    }
    MyFunction();
    

    
}


int[] BubbleSort(int[] array)
{
    int temp = 0;
    bool swapped = false;

    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[(j + 1)] = temp;
                swapped = true;
            }
        }
        if (!swapped) break;
        //!swapped = not swapped
    }
    return array;
}
int[] sorted_RandomNumberForLottery = BubbleSort(RandomNumberForLottery);
int[] sorted_UserInputForLottery = BubbleSort(UserInputForLottery);


int BinarySearch(int[] array, int value, int low, int high)
{
    if (high >= low)
    {
        int mid = (low + high) / 2;
        if (array[mid] == value) return mid;

        if (array[mid] < value) return BinarySearch(array, value, mid + 1, high);

        if (array[mid] > value) return BinarySearch(array, value, low, mid + 1);
    }
    return -1;
}

for (int i = 0; i < random_user_input; i++)
{
    int test = BinarySearch(sorted_RandomNumberForLottery, sorted_UserInputForLottery[i], 0, random_user_input - 1);
    Console.WriteLine(test);
    
    //if (test == )
    //{
      //  count_correct_numbers++;
        //Console.WriteLine(test);
        //Console.WriteLine(count_correct_numbers);
    //}

}
