// See https://aka.ms/new-console-template for more information

using TGenericBox;

TGenericBox<int> box = new TGenericBox<int>(123);
Console.WriteLine(box.Value);  // 输出123
string A = "A";
string B = "B";

int a = 65;
int b = 65;
bool v = TGenericBox<int>.AreEqual(a,b);
Console.WriteLine(v);

