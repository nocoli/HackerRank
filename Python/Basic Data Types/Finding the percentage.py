if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()
    
    # find student key
    student_scores = student_marks[query_name]
    
    # using students key find the average of their scores
    average = (student_scores[0] + student_scores[1] + student_scores[2])/3
    
    # print average
    print (format(average, '.2f'))