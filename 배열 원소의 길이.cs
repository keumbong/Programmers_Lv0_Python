문제 설명
문자열 배열 strlist가 매개변수로 주어집니다. strlist 각 원소의 길이를 담은 배열을 retrun하도록 solution 함수를 완성해주세요.

제한사항
1 ≤ strlist 원소의 길이 ≤ 100
strlist는 알파벳 소문자, 대문자, 특수문자로 구성되어 있습니다.

입출력 예
strlist	result
["We", "are", "the", "world!"]	[2, 3, 3, 6]
["I", "Love", "Programmers."]	[1, 4, 12]

입출력 예 설명
입출력 예 #1

["We", "are", "the", "world!"]의 각 원소의 길이인 [2, 3, 3, 6]을 return합니다.

입출력 예 #2

["I", "Love", "Programmers."]의 각 원소의 길이인 [1, 4, 12]을 return합니다.

1.
def solution(strlist):
    answer = []
    count = 0
    for word in strlist:
        for w in word:
            count += 1
        answer.append(count)
        count = 0
    
    return answer

2.
def solution(strlist):
    
    return [len(i) for i in strlist]

3.
def solution(strlist):
    
    return list(map(len, strlist))

4.
def solution(strlist):
    
    return list(map(lambda l : len(l), strlist))