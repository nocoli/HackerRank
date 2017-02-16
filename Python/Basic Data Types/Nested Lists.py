if __name__ == '__main__':
    
    # initialise variables
    students = []
    grades = []
    
    combo = []
    
    # for every studnet input
    for _ in range(int(input())):
        name = input()
        score = float(input())
        
        #add name and score to lists
        students.append(name)
        grades.append(score)
        combo.append([name, score])
    
    # sorr the grades list
    grades.sort()
    
    # remove the top grade
    lowest = min(grades)
    while (grades[0] == lowest):
        grades.remove(lowest)
    
    # initialise array for students with second lowest score
    studentsWithLowestScore = []
    lowestScore = grades[0]
      
    # find students with a score equal to the one we are looking for
    for y in range(len(students)):
        if combo[y][1] == lowestScore:
            studentsWithLowestScore.append(combo[y][0])

    # alphabetically sort our students list
    studentsWithLowestScore.sort()
    
    # print students with the second lowest score
    for z in range(len(studentsWithLowestScore)):
        print (studentsWithLowestScore[z])
        
        
        
