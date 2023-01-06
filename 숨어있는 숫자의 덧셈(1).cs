문제 설명
문자열 my_string이 매개변수로 주어집니다. my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.

제한사항
1 ≤ my_string의 길이 ≤ 1,000
my_string은 소문자, 대문자 그리고 한자리 자연수로만 구성되어있습니다.

입출력 예
my_string	result
"aAb1B2cC34oOp"	10
"1a2b3c4d123"	16

입출력 예 설명
입출력 예 #1

"aAb1B2cC34oOp"안의 한자리 자연수는 1, 2, 3, 4 입니다. 따라서 1 + 2 + 3 + 4 = 10 을 return합니다.

입출력 예 #2

"1a2b3c4d123Z"안의 한자리 자연수는 1, 2, 3, 4, 1, 2, 3 입니다. 따라서 1 + 2 + 3 + 4 + 1 + 2 + 3 = 16 을 return합니다.

유의사항
연속된 숫자도 각각 한 자리 숫자로 취급합니다.


import re

def solution(my_string):
    
    my_list = re.findall(r'[0-9]', my_string)
    my_list = [int(i) for i in my_list]
    return sum(my_list)


---------------------------------------------------------------------------------------------
*정규식
 - findall : 정규식과 매치되는 모든 문자열을 리스트로 리턴.

 - \d - 숫자와 매치, [0-9]와 동일한 표현식이다.
 -\D - 숫자가 아닌 것과 매치, [^0-9]와 동일한 표현식이다.
 - \s - whitespace 문자와 매치, [ \t\n\r\f\v]와 동일한 표현식이다. 맨 앞의 빈 칸은 공백문자(space)를 의미한다.
 - \S - whitespace 문자가 아닌 것과 매치, [^ \t\n\r\f\v]와 동일한 표현식이다.
 - \w - 문자+숫자(alphanumeric)와 매치, [a-zA-Z0-9_]와 동일한 표현식이다.
 - \W - 문자+숫자(alphanumeric)가 아닌 문자와 매치, [^a-zA-Z0-9_]와 동일한 표현식이다.