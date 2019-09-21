# CodilityCSharp


using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public string solution(string S) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        string result ="";
       string[] lines = S.Split(
    new[] { Environment.NewLine },
    StringSplitOptions.None
);
         int music =0,images =0,movies=0,other=0;
        //Console.WriteLine(lines.Length);
        
        for(int i =0; i < lines.Length; i++)
        {
            //Console.WriteLine(lines[i]);
            if (lines[i].Contains(".mp3") ||
            lines[i].Contains(".aac") ||
            lines[i].Contains(".flac")
            )
            {
              string [] m =  lines[i].Split(' ');
              string ms =  m[1].Replace("b", "");
              music += Convert.ToInt32(ms);
              //Console.WriteLine(music);
            }
            
             if (lines[i].Contains(".jpg") ||
            lines[i].Contains(".bmp") ||
            lines[i].Contains(".gif")
            )
            {
              string [] m =  lines[i].Split(' ');
              string ms =  m[1].Replace("b", "");
              images += Convert.ToInt32(ms);
            }
              if (lines[i].Contains(".mp4") ||
            lines[i].Contains(".avi") ||
            lines[i].Contains(".mkv")
            )
            {
              string [] m =  lines[i].Split(' ');
              string ms =  m[1].Replace("b", "");
              movies += Convert.ToInt32(ms);
            }
              if (lines[i].Contains(".7z") ||
            lines[i].Contains(".txt") ||
            lines[i].Contains(".zip") ||
            lines[i].Contains(".exe")
            )
            {
              string [] m =  lines[i].Split(' ');
              string ms =  m[1].Replace("b", "");
              other += Convert.ToInt32(ms);
            }
        }
        result += $"music {music}b\n";
        result += $"images {images}b\n";
        result += $"movies {movies}b\n";
        result += $"other {other}b";
        //Console.WriteLine(result);
        return result;
    }
}

Example test:    ('15:15:00', '15:15:12') 
WRONG ANSWER  (got 0 expected 1) 

Example test:    ('22:22:21', '22:22:23') 
WRONG ANSWER  (got 0 expected 3) 
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S, string T) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int result =0;
        
        string[] s = S.Split(':');
        string[] t = T.Split(':');
       
        int ss = Convert.ToInt32(s[2]);
        int tt = Convert.ToInt32(t[2]);
        if(ss == 0) return 1;
        result = tt - ss +1;
            
        return result;
    }
}

Example test:    [3, 4, 3, 0, 2, 2, 3, 0, 0] 
WRONG ANSWER  (got 28 expected 5) 

Example test:    [4, 4, 3, 3, 1, 0] 
WRONG ANSWER  (got 10 expected 3) 

Example test:    [4, 2, 0] 
WRONG ANSWER  (got 1 expected 0) 
