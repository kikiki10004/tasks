// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Lua!");

//int incrementer;
//int Luckynumber;
//Console.WriteLine("Check your luck");
//bool isParsable = Int32.TryParse(Luckynumber, out incrementer);



var guess = "";
// guess 문자로 지정하규
var magicnumber = "5";
// var 를 문자 5로 지정
//intguess는 문자로 지정 블랭크로 남겨둠

Console.WriteLine("Enter your magicnumber");

guess = Console.ReadLine();
// 콘솔 뤼드 라인이 값을입력하게 하는것인거같음

while (guess != magicnumber)
{
    Console.WriteLine("check your luck again");

    guess = Console.ReadLine();

}


//while (Luckynumber!= 5) {

//  Console.WriteLine("check your luck again");

//bool isParsable = Int32.TryParse(Luckynumber, out incrementer);

//}

var zero = 0;
// guess 문자로 지정하규
var anynumber = "";
// var 를 문자 5로 지정
int intguess;
//intguess는 문자로 지정 블랭크로 남겨둠

Console.WriteLine("Enter your number");

anynumber = Console.ReadLine();
// 콘솔 뤼드 라인이 값을입력하게 하는것인거같음
Int32.TryParse(anynumber, out intguess);
//anynumber라는 문자를 intguess라는 숫자로 인식하게 함
    Console.WriteLine("count up");
while (zero <= intguess) {

    Console.WriteLine(zero);

    zero++;
    if(zero> intguess){
        Console.WriteLine("end");
        break;
    }
}

var guesswhat = "";
// guess 문자로 지정하규
var magicwords = "It gets wet.";
// var 를 문자 It gets wet.로 지정
//는 문자로 지정 블랭크로 남겨둠

Console.WriteLine("What happens when you throw a yellow rock in the red sea?");

guesswhat = Console.ReadLine();
// 콘솔 뤼드 라인이 값을입력하게 하는것인거같음

while (guesswhat != magicwords)
{   
    Console.WriteLine("Wrong");
    Console.WriteLine("Again what happens when you throw a yellow rock in the red sea");

    guesswhat = Console.ReadLine();

}

Console.WriteLine("Ding Ding Ding");





//var secretnum = 653;
// guess 문자로 지정하규
//var guesscret = "";
// var 를 문자 It gets wet.로 지정
//는 문자로 지정 블랭크로 남겨둠

//Console.WriteLine("Enter the secret number");

//guessecret = Console.ReadLine();

var secretnumber = 653;
var yournumber = "";
int yrnumber;
int ze = 1;

Console.WriteLine("Enter your secret number");
yournumber = Console.ReadLine();
Int32.TryParse(yournumber, out yrnumber);

while (yrnumber != secretnumber) {
    if(ze == 10) {
        Console.WriteLine("That is it for today");
        break;
    }
    Console.WriteLine("Wrong, counter value is");
    yournumber = Console.ReadLine();
    ze ++;
}
Console.WriteLine("Correct");