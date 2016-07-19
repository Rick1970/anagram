# Specifications
| Behavior | Input Example | Output Example |
| ------------- |:-------------:| -----:|
|Input single (same) letter in each field | "a" & "a" | "a"|
|Input single (different) letter in each field| "a"&"b" | "No match"|
|Input two letters (same) in each field |"aa" & "aa" | "aa"|
|Input two letters (different) in each field |"ab" & "ca"| "No match"|
|Input two letters (different) in each field |"ab" & "ba"| "ba"|
|Input two letters (different) in each field |"ab" & "ab","ba","cd"| "ab","ba"|
