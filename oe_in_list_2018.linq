<Query Kind="Statements" />

int[]num={1,2,3,4,5,6,7,8,9,10};

var even=num.Where(x=>x%2==0);

foreach(var i in even){

Console.WriteLine(i);
}


"Sum is A ALL NUMBER:".Dump();
num.Sum().Dump();

"Max:".Dump();
num.Max().Dump();

"Min:".Dump();
num.Min().Dump();


List<string> my_list=new List<string>(){

 "This is my College",
    "Name of my College name is CAIT",
    "I will work hard",
    "What I have learned"



};

var result=my_list.Where(s=>s.Contains("my") || s.Contains("will"));

result.Dump();

foreach(var i in result){

Console.WriteLine(i);
}


