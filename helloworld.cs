// C:\WINDOWS\Microsoft.NET\Framework64\v4.0.30319\csc .\helloworld.cs
using System;

class helloworld{
    static void Main(string[] args){
        int a; // 変数を定義するコード
        a = 10;
        int b;

        // まとめて変数を定義する
        int c,d,e;

        

        b = sakamoto(a,20);
        // if 文の例
        // 
        if(a == 40){ // 比較を行う時はイコールを二連続で用いる！
            Console.WriteLine("aは40だよ");
        }   

        Console.WriteLine(b);
        // 初めてc#を学ぶ方々にご挨拶
        Console.WriteLine("helloworld");
        Console.WriteLine("helloworld2");
    }

    static int sakamoto(int x, int y){
        int z;
        z = x + y;
        Console.WriteLine("処理完了");
        return z;
    }
}