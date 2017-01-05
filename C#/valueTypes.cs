bool varName = true;
char grade = "A";
int maxInt = int.MaxValue;
long maxLong = long.MaxValue;
decimal maxDec = decimal.MaxValue; // for larger values, look up BigInteger
float maxFloat = float.MaxValue; // 32-bit, 7 decimals of precision
double maxDouble = double.MaxValue; // 32-bit, 15 decimals of precision
var anotherName = "Tom"; // var tells compiler to check data type and assign appropriately
anotherName.GetTypeCode(); // returns type, in this case String