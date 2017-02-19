if __name__ == '__main__':
    s = input()
    
    firstCount = 0
    secondCount = 0
    thirdCount = 0
    fourthCount = 0
    fithCount = 0
    
    
    for x in range(len(s)):
        if s[x].isalnum():
            firstCount+=1
            
        if s[x].isalpha():
            secondCount+=1
            
        if s[x].isdigit():
            thirdCount+=1
            
        if s[x].islower():
            fourthCount+=1
            
        if s[x].isupper():
            fithCount+=1
            
    if firstCount>0:
        print (True)
    else:
        print (False)
        
    if secondCount>0:
        print (True)
    else:
        print (False)
        
    if thirdCount>0:
        print (True)
    else:
        print (False)
        
    if fourthCount>0:
        print (True)
    else:
        print (False)
        
    if fithCount>0:
        print (True)
    else:
        print (False)
    

