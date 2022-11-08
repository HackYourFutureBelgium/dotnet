using HackYourFuture.DotnetMasterclass.Types;

// Text
char character = 'b'; // Single Unicode character, stored as an integer between 0 and 65535

string text = "hello multiple +%&1 characters allowed"; // A sequence of characters


// Whole numbers
byte byteValue = 255; // Integer between 0 and 255

Console.WriteLine(byteValue);

int number = 14; // Integer between −2147483648 and 2147483647


long longerNumber = 9223372036854775807;  // Integer between -9223372036854775808 and 9223372036854775807


// Floating point numbers A.K.A. Decimal Number
float shortDecimal = 12123.4f; // (Single) 7 digits (32 bit)

double defaultDecimal = 123123123123.564516; // 15-16 digits (64 bit)

decimal longDecimal = 8156189123196561.66466464561321351m; // 28-29 significant digits (128 bit)


// Boolean variables
bool isOpen = false; // Boolean value, true or false



// Implicitly typed variables
var newNumber = 17;


















// Arrays
string[] stringArray = new string[2];
stringArray[0] = "firstValue";
stringArray[1] = "secondValue";
//stringArray[2] = "thirdValue"; // Not allowed since the predefined size is 2

string[] stringArray2 = new string[] { "firstString", "secondString", "3rd", "4th", "6th" };


int[,] multiDimensionalArray1 = new int[2, 3];
multiDimensionalArray1[0, 0] = 1;
multiDimensionalArray1[0, 1] = 2;
multiDimensionalArray1[0, 2] = 3;
multiDimensionalArray1[1, 0] = 4;
multiDimensionalArray1[1, 1] = 5;
multiDimensionalArray1[1, 2] = 6;


int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArray[1] = new int[] { 0, 2, 4, 6 };
jaggedArray[2] = new int[] { 11, 22 };


// Lists
List<string> stringList = new List<string>();
stringList.Add("firstString");
stringList.Add("2nd");
stringList.Add("3rd");
stringList.Add("4th");

var recursiveStringList = new List<List<string>>();
recursiveStringList.Add(
    new List<string>
    {
        "firstStringInFirstList",
        "secondStringInFirstList"
    });
recursiveStringList.Add(
    new List<string>
    {
        "firstStringInSecondList",
        "secondStringInSecondList",
        "thirdStringInSecondList"
    });

var dict = new Dictionary<string, string>();
dict.Add("name", "Kuki");
dict.Add("hairCol", "brown");




























// Classes
var firstPoodle = new Poodle(name: "Fifi", furColor: FurColor.Pink);
var secondPoodle = new Poodle("Mimi", FurColor.White);

secondPoodle.Name = "Rex";
var owner = new Person();
owner.Name = "Francis";
secondPoodle.Owner = owner;









// Structs
var location = new Location();
location.Longitude = 5.456;
location.Latitude = 12.541;










// Difference reference and value types
var secondPoodle2 = secondPoodle;
secondPoodle2.Name = "James";
if (secondPoodle2.Name == secondPoodle.Name)
{
    Console.WriteLine("SecondPoodle is a reference type");
}


var location2 = location;
location2.Longitude = 55.123;
if (location.Longitude != location2.Longitude)
{
    Console.WriteLine("Location is a value type");
}